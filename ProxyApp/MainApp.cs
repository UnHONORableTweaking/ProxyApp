using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Titanium.Web.Proxy;
using Titanium.Web.Proxy.EventArguments;
using Titanium.Web.Proxy.Models;
using System.Threading.Tasks;
using Titanium.Web.Proxy.Http;
using Titanium.Web.Proxy.Exceptions;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using Newtonsoft.Json.Linq;

namespace ProxyApp
{
    public partial class MainApp : Form
    {
        private readonly ProxyServer proxyServer;
        private readonly ExplicitProxyEndPoint endPoint;
        private readonly Dictionary<string, string> requestData = new Dictionary<string, string>();

        public MainApp()
        {
            InitializeComponent();
            proxyServer = new ProxyServer();
            proxyServer.CertificateManager.CreateRootCertificate(true);
            proxyServer.CertificateManager.TrustRootCertificate(true);
            proxyServer.EnableHttp2 = true;
            proxyServer.ForwardToUpstreamGateway = true;
            proxyServer.ServerCertificateValidationCallback += OnCertificateValidation;
            proxyServer.BeforeRequest += OnRequest;
            proxyServer.BeforeResponse += OnResponse;
            var explicitEndPoint = new ExplicitProxyEndPoint(IPAddress.Any, 7777, true);
            explicitEndPoint.BeforeTunnelConnectRequest += OnBeforeTunnelConnectRequest;
            proxyServer.AddEndPoint(explicitEndPoint);
            listBoxUrls.SelectedIndexChanged += ListBoxUrls_SelectedIndexChanged;
        }

        // **Handle HTTPS connections properly**
        private async Task OnBeforeTunnelConnectRequest(object sender, TunnelConnectSessionEventArgs e)
        {
            var hostname = e.HttpClient.Request.RequestUri.Host;
            Console.WriteLine($"Tunnel connect request for: {hostname}");

            // Allow decryption for specific domains (customize as needed)
            if (hostname.Contains("hihonorcloud.com"))
            {
                e.DecryptSsl = true; // Decrypt SSL/TLS for this domain
                Console.WriteLine($"Decrypting SSL/TLS for: {hostname}");
            }
            else
            {
                e.DecryptSsl = false; // Do not decrypt SSL/TLS for other domains
                Console.WriteLine($"Not decrypting SSL/TLS for: {hostname}");
            }

            await Task.CompletedTask;
        }

        // **Request Handling**
        private async Task OnRequest(object sender, SessionEventArgs e)
        {
            string requestURL = e.HttpClient.Request.Url;
            requestURL = requestURL.Replace("HTTPS://", "https://");
            requestURL = requestURL.Replace(":443", "");
            Console.WriteLine($"Request to: {requestURL}");
            e.HttpClient.Request.Url = requestURL;

            var requestHeaders = e.HttpClient.Request.Headers;
            string requestBody = await e.GetRequestBodyAsString();

            StringBuilder details = new StringBuilder();
            details.AppendLine($"📤 Request to: {requestURL}");
            details.AppendLine("\n\n🔹 Request Headers:");

            foreach (var header in requestHeaders)
                details.AppendLine($"{header.Name}: {header.Value}");

            if (!string.IsNullOrWhiteSpace(requestBody))
            {
                details.AppendLine("\n\n📝 Request Body:");
                details.AppendLine(requestBody);
            }

            lock (requestData)
            {
                requestData[requestURL] = details.ToString();
            }

            await Task.CompletedTask;
        }
        private async Task OnResponse(object sender, SessionEventArgs e)
        {
            string url = e.HttpClient.Request.Url;
            int statusCode = e.HttpClient.Response.StatusCode;
            Console.WriteLine($"Response from: {url}, Status: {statusCode}");

            var responseHeaders = e.HttpClient.Response.Headers;
            var responseBody = await e.GetResponseBodyAsString();

            StringBuilder details;
            lock (requestData)
            {
                if (!requestData.ContainsKey(url))
                    requestData[url] = "";

                details = new StringBuilder(requestData[url]);
                details.AppendLine($"\n\n✅ Response Status: {statusCode}");
                details.AppendLine("\n\n🔸 Response Headers:");

                foreach (var header in responseHeaders)
                    details.AppendLine($"{header.Name}: {header.Value}");

                if (!string.IsNullOrWhiteSpace(responseBody))
                {
                    details.AppendLine("\n\n📦 Response Body:");
                    details.AppendLine(responseBody);
                }

                requestData[url] = details.ToString();
            }

            string logEntry = $"{statusCode} - {url}";
            if (listBoxUrls.InvokeRequired)
            {
                listBoxUrls.Invoke(new Action(() => listBoxUrls.Items.Add(logEntry)));
            }
            else
            {
                listBoxUrls.Items.Add(logEntry);
            }

            await Task.CompletedTask;
        }

        // **Ensure valid HTTPS certificates**
        private static Task OnCertificateValidation(object sender, CertificateValidationEventArgs e)
        {
            e.IsValid = true;
            return Task.CompletedTask;
        }

        public Task OnCertificateSelection(object sender, CertificateSelectionEventArgs e)
        {
            return Task.CompletedTask;
        }

        private void ListBoxUrls_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUrls.SelectedItem == null) return;

            string selectedLog = listBoxUrls.SelectedItem.ToString();
            string url = selectedLog.Split(new[] { " - " }, StringSplitOptions.None).Last();

            if (requestData.ContainsKey(url))
            {
                txtRequestDetails.Text = requestData[url];
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            proxyServer.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void setupStartButton(object sender, EventArgs e)
        {
            if (proxyServer.ProxyRunning)
            {
                listBoxLogs.Items.Add("Stopping proxy...");
                proxyServer.Stop();
            }
            proxyServer.Start();
            Console.WriteLine("Proxy server started on port 7777...");
            Console.ReadLine();
            listBoxLogs.Items.Add("Proxy server started on port 7777...");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://firmcatcher.thevakhovske.eu.org");
        }
    }
}