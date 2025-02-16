using System;
using System.Linq;
using System.Windows.Forms;
using Titanium.Web.Proxy;
using Titanium.Web.Proxy.EventArguments;
using Titanium.Web.Proxy.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ProxyApp
{
    public partial class Form1 : Form
    {
        private readonly ProxyServer proxyServer;
        private readonly ExplicitProxyEndPoint endPoint;

        // List to store duplicate requests for checking
        private readonly List<string> loggedRequests = new List<string>();

        public Form1()
        {
            InitializeComponent();
            proxyServer = new ProxyServer();
            endPoint = new ExplicitProxyEndPoint(System.Net.IPAddress.Any, 7889, true);

            // Register event handler
            proxyServer.BeforeRequest += OnRequest;
            proxyServer.BeforeResponse += OnResponse;

            proxyServer.AddEndPoint(endPoint);
            proxyServer.Start();
        }

        private async Task OnRequest(object sender, SessionEventArgs e)
        {
            string url = e.HttpClient.Request.Url;

            // Store request so it appears even if duplicated
            lock (loggedRequests)
            {
                loggedRequests.Add(url);
            }

            await Task.CompletedTask;
        }

        private async Task OnResponse(object sender, SessionEventArgs e)
        {
            string url = e.HttpClient.Request.Url;
            int statusCode = e.HttpClient.Response.StatusCode;

            // Format: "200 OK - https://example.com"
            string logEntry = $"{statusCode} - {url}";

            // Ensure UI updates are thread-safe
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


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            proxyServer.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
