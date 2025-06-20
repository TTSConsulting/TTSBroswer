using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;

namespace TTSBroswer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            webView21 = new WebView2();
            homeButtion = new Button();
            ForwardButtion = new Button();
            backwardButtion = new Button();
            searchBox = new TextBox();
            downloadsButton = new Button();
            SettingsButtion = new Button();
            AboutButtion = new Button();
            DuckDuckGobuttion = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(0, 37);
            webView21.Name = "webView21";
            webView21.Size = new Size(1927, 920);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // homeButtion
            // 
            homeButtion.Location = new Point(0, 5);
            homeButtion.Name = "homeButtion";
            homeButtion.Size = new Size(64, 29);
            homeButtion.TabIndex = 1;
            homeButtion.Text = "Home";
            homeButtion.UseVisualStyleBackColor = true;
            // 
            // ForwardButtion
            // 
            ForwardButtion.Location = new Point(185, 5);
            ForwardButtion.Name = "ForwardButtion";
            ForwardButtion.Size = new Size(74, 29);
            ForwardButtion.TabIndex = 2;
            ForwardButtion.Text = "→";
            ForwardButtion.UseVisualStyleBackColor = true;
            // 
            // backwardButtion
            // 
            backwardButtion.Location = new Point(85, 5);
            backwardButtion.Name = "backwardButtion";
            backwardButtion.Size = new Size(94, 29);
            backwardButtion.TabIndex = 3;
            backwardButtion.Text = "←";
            backwardButtion.UseVisualStyleBackColor = true;
            backwardButtion.Click += BackwardButton_Click;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(265, 7);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(868, 27);
            searchBox.TabIndex = 4;
            // 
            // downloadsButton
            // 
            downloadsButton.Location = new Point(1436, 6);
            downloadsButton.Name = "downloadsButton";
            downloadsButton.Size = new Size(94, 29);
            downloadsButton.TabIndex = 5;
            downloadsButton.Text = "Downloads";
            downloadsButton.UseVisualStyleBackColor = true;
            // 
            // SettingsButtion
            // 
            SettingsButtion.Location = new Point(1536, 5);
            SettingsButtion.Name = "SettingsButtion";
            SettingsButtion.Size = new Size(198, 29);
            SettingsButtion.TabIndex = 6;
            SettingsButtion.Text = "Settings";
            SettingsButtion.UseVisualStyleBackColor = true;
            // 
            // AboutButtion
            // 
            AboutButtion.Location = new Point(1320, 6);
            AboutButtion.Name = "AboutButtion";
            AboutButtion.Size = new Size(94, 29);
            AboutButtion.TabIndex = 7;
            AboutButtion.Text = "About";
            AboutButtion.UseVisualStyleBackColor = true;
            // 
            // DuckDuckGobuttion
            // 
            DuckDuckGobuttion.Location = new Point(1139, 5);
            DuckDuckGobuttion.Name = "DuckDuckGobuttion";
            DuckDuckGobuttion.Size = new Size(175, 29);
            DuckDuckGobuttion.TabIndex = 8;
            DuckDuckGobuttion.Text = "Search In DuckDuckGo";
            DuckDuckGobuttion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 957);
            Controls.Add(DuckDuckGobuttion);
            Controls.Add(AboutButtion);
            Controls.Add(SettingsButtion);
            Controls.Add(downloadsButton);
            Controls.Add(searchBox);
            Controls.Add(backwardButtion);
            Controls.Add(ForwardButtion);
            Controls.Add(homeButtion);
            Controls.Add(webView21);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "New Tab";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BackwardButton_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoBack)
            {
                webView21.GoBack();
            }
        }

        #endregion

        private WebView2 webView21;
        private Button homeButtion;
        private Button ForwardButtion;
        private Button backwardButtion;
        private TextBox searchBox;
        private Button downloadsButton;
        private Button SettingsButtion;
        private Button AboutButtion;
        private Button DuckDuckGobuttion;
    }
}
