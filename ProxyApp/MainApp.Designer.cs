namespace ProxyApp
{
    partial class MainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.listBoxUrls = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bpkgLabel = new System.Windows.Forms.Label();
            this.cpkgLbl = new System.Windows.Forms.Label();
            this.prpkgLbl = new System.Windows.Forms.Label();
            this.baseVerField = new System.Windows.Forms.TextBox();
            this.custVerField = new System.Windows.Forms.TextBox();
            this.preLoadVerField = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.fwVer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.useIndividual = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxLogs = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtRequestDetails = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxUrls
            // 
            this.listBoxUrls.FormattingEnabled = true;
            this.listBoxUrls.Location = new System.Drawing.Point(12, 291);
            this.listBoxUrls.Name = "listBoxUrls";
            this.listBoxUrls.Size = new System.Drawing.Size(260, 147);
            this.listBoxUrls.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Requests:";
            // 
            // bpkgLabel
            // 
            this.bpkgLabel.AutoSize = true;
            this.bpkgLabel.Location = new System.Drawing.Point(11, 98);
            this.bpkgLabel.Name = "bpkgLabel";
            this.bpkgLabel.Size = new System.Drawing.Size(80, 13);
            this.bpkgLabel.TabIndex = 2;
            this.bpkgLabel.Text = "Base Package:";
            // 
            // cpkgLbl
            // 
            this.cpkgLbl.AutoSize = true;
            this.cpkgLbl.Location = new System.Drawing.Point(11, 127);
            this.cpkgLbl.Name = "cpkgLbl";
            this.cpkgLbl.Size = new System.Drawing.Size(77, 13);
            this.cpkgLbl.TabIndex = 3;
            this.cpkgLbl.Text = "Cust Package:";
            // 
            // prpkgLbl
            // 
            this.prpkgLbl.AutoSize = true;
            this.prpkgLbl.Location = new System.Drawing.Point(11, 156);
            this.prpkgLbl.Name = "prpkgLbl";
            this.prpkgLbl.Size = new System.Drawing.Size(92, 13);
            this.prpkgLbl.TabIndex = 4;
            this.prpkgLbl.Text = "Preload Package:";
            // 
            // baseVerField
            // 
            this.baseVerField.Location = new System.Drawing.Point(125, 95);
            this.baseVerField.Name = "baseVerField";
            this.baseVerField.Size = new System.Drawing.Size(210, 20);
            this.baseVerField.TabIndex = 5;
            // 
            // custVerField
            // 
            this.custVerField.Location = new System.Drawing.Point(125, 124);
            this.custVerField.Name = "custVerField";
            this.custVerField.Size = new System.Drawing.Size(210, 20);
            this.custVerField.TabIndex = 6;
            // 
            // preLoadVerField
            // 
            this.preLoadVerField.Location = new System.Drawing.Point(125, 153);
            this.preLoadVerField.Name = "preLoadVerField";
            this.preLoadVerField.Size = new System.Drawing.Size(210, 20);
            this.preLoadVerField.TabIndex = 7;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 188);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(323, 17);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Use alternate authenticaltion (toggle if device is soft-rebranded)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // fwVer
            // 
            this.fwVer.Location = new System.Drawing.Point(15, 37);
            this.fwVer.Name = "fwVer";
            this.fwVer.Size = new System.Drawing.Size(320, 20);
            this.fwVer.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Full FW Version:";
            // 
            // useIndividual
            // 
            this.useIndividual.AutoSize = true;
            this.useIndividual.Location = new System.Drawing.Point(15, 68);
            this.useIndividual.Name = "useIndividual";
            this.useIndividual.Size = new System.Drawing.Size(142, 17);
            this.useIndividual.TabIndex = 18;
            this.useIndividual.Text = "Use individual packages";
            this.useIndividual.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 37);
            this.button1.TabIndex = 19;
            this.button1.Text = "Setup";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.setupStartButton);
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.Location = new System.Drawing.Point(278, 291);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxLogs.Size = new System.Drawing.Size(275, 147);
            this.listBoxLogs.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Proxy logs:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 37);
            this.button2.TabIndex = 22;
            this.button2.Text = "Get HonorSuite";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(286, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 37);
            this.button3.TabIndex = 23;
            this.button3.Text = "FirmCatcher";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(423, 223);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 37);
            this.button4.TabIndex = 24;
            this.button4.Text = "Patch HonorSuite";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(402, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Proxy IP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(402, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "127.0.0.1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "7777";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(402, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 18);
            this.label10.TabIndex = 27;
            this.label10.Text = "Proxy Port:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(452, 194);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "Donate";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtRequestDetails
            // 
            this.txtRequestDetails.Location = new System.Drawing.Point(571, 37);
            this.txtRequestDetails.MaxLength = 256000;
            this.txtRequestDetails.Multiline = true;
            this.txtRequestDetails.Name = "txtRequestDetails";
            this.txtRequestDetails.ReadOnly = true;
            this.txtRequestDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRequestDetails.Size = new System.Drawing.Size(290, 401);
            this.txtRequestDetails.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(568, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Request details (press on request):";
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRequestDetails);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxLogs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.useIndividual);
            this.Controls.Add(this.fwVer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.preLoadVerField);
            this.Controls.Add(this.custVerField);
            this.Controls.Add(this.baseVerField);
            this.Controls.Add(this.prpkgLbl);
            this.Controls.Add(this.cpkgLbl);
            this.Controls.Add(this.bpkgLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxUrls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HnSuite Proxy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUrls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bpkgLabel;
        private System.Windows.Forms.Label cpkgLbl;
        private System.Windows.Forms.Label prpkgLbl;
        private System.Windows.Forms.TextBox baseVerField;
        private System.Windows.Forms.TextBox custVerField;
        private System.Windows.Forms.TextBox preLoadVerField;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox fwVer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox useIndividual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxLogs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtRequestDetails;
        private System.Windows.Forms.Label label2;
    }
}

