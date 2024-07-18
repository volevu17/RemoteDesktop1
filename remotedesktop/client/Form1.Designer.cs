namespace client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtIP = new TextBox();
            txtPort = new TextBox();
            btnConnect = new Button();
            btnShare = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 105);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 4;
            label1.Text = "IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 211);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 5;
            label2.Text = "Port";
            // 
            // txtIP
            // 
            txtIP.Location = new Point(272, 128);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(162, 27);
            txtIP.TabIndex = 2;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(272, 234);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(162, 27);
            txtPort.TabIndex = 3;
            txtPort.Text = "80";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(224, 325);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(94, 83);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnShare
            // 
            btnShare.Location = new Point(498, 325);
            btnShare.Name = "btnShare";
            btnShare.Size = new Size(94, 83);
            btnShare.TabIndex = 1;
            btnShare.Text = "Share screen";
            btnShare.UseVisualStyleBackColor = true;
            btnShare.Click += btnShare_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShare);
            Controls.Add(btnConnect);
            Controls.Add(txtPort);
            Controls.Add(txtIP);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Client";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtIP;
        private TextBox txtPort;
        private Button btnConnect;
        private Button btnShare;
        private System.Windows.Forms.Timer timer1;
    }
}