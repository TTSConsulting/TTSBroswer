namespace TTSBroswer
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            addressLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(494, 512);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(512, 71);
            label1.Name = "label1";
            label1.Size = new Size(199, 20);
            label1.TabIndex = 2;
            label1.Text = "Version: Release Candidate 4";
            label1.Click += label1_Click;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(635, 91);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(142, 20);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "CURRENT ADDRESS";
            addressLabel.Click += addressLabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(512, 91);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 4;
            label2.Text = "Current Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(512, 111);
            label3.Name = "label3";
            label3.Size = new Size(169, 20);
            label3.TabIndex = 5;
            label3.Text = "Compiled With: .NET 8.0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(512, 131);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 6;
            label4.Text = "NuGet Packages Used:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(528, 151);
            label5.Name = "label5";
            label5.Size = new Size(787, 20);
            label5.TabIndex = 7;
            label5.Text = "Microsoft.Web.Webview2 1.0.3344-prerelease (For Seeing The Web, Uses Microsoft Edge's Web View Under the Hood)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(528, 171);
            label6.Name = "label6";
            label6.Size = new Size(332, 20);
            label6.TabIndex = 8;
            label6.Text = "EasyTabs 2.0.0 (For Google Chrome Tab like Tabs)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(512, 191);
            label7.Name = "label7";
            label7.Size = new Size(218, 20);
            label7.TabIndex = 9;
            label7.Text = "Programing Language Used: C#";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(512, 211);
            label8.Name = "label8";
            label8.Size = new Size(510, 20);
            label8.TabIndex = 10;
            label8.Text = "Visual Studio 2022 Project This Web Broswer Is Built In: Windows Forms App";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 539);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(addressLabel);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AboutForm";
            Text = "About TTSBroswer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label addressLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}