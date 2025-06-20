using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TTSBroswer
{
    public partial class Form1 : Form
    {
        private Form1 mainForm;
        private SettingsForm settingsForm;
        public bool isdark;


        public Form1()
        {
            InitializeComponent();
            this.Icon = new Icon("213457898.ico"); // Ensure this file exists in output dir

            this.Load += Form1_Load;

            mainForm = this;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                await webView21.EnsureCoreWebView2Async();
            }
            catch (Exception ex)
            {
                MessageBox.Show("WebView2 initialization failed: " + ex.Message, "Error");
                return;
            }

            webView21.CoreWebView2.DocumentTitleChanged += (s, ev) =>
            {
                this.Text = webView21.CoreWebView2.DocumentTitle;
            };

            webView21.Source = new Uri("https://www.google.com/");
            webView21.Location = new Point(0, 35);
            webView21.Size = new Size(this.Width, this.Height - 35);
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            homeButtion.Click += (s, ev) =>
            {
                webView21.Source = new Uri("https://www.google.com/");
            };

            ForwardButtion.Click += (s, ev) =>
            {
                if (webView21.CanGoForward)
                    webView21.GoForward();
            };

            downloadsButton.Click += (s, ev) =>
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
                System.Diagnostics.Process.Start("explorer.exe", path);
            };

            searchBox.KeyDown += (s, ev) =>
            {
                if (ev.KeyCode == Keys.Enter)
                {
                    ev.SuppressKeyPress = true;
                    string raw = searchBox.Text.Trim();
                    string finalUrl;

                    if (raw.StartsWith("http://") || raw.StartsWith("https://"))
                        finalUrl = raw;
                    else if (raw.Contains("."))
                        finalUrl = "https://" + raw;
                    else
                        finalUrl = $"https://www.google.com/search?q={Uri.EscapeDataString(raw)}";

                    try
                    {
                        webView21.Source = new Uri(finalUrl);
                    }
                    catch (UriFormatException)
                    {
                        MessageBox.Show("That doesn't seem like a valid address or search term.", "Signal Error");
                    }
                }
            };

            SettingsButtion.Click += (s, ev) =>
            {
                SettingsForm settingsForm = new SettingsForm(this);
                settingsForm.ShowDialog(this);
            };
        }

        public void ApplyDarkMode(bool enabled)
        {
            var bg = enabled ? Color.FromArgb(30, 30, 30) : SystemColors.Control;
            var fg = enabled ? Color.White : SystemColors.ControlText;

            this.BackColor = bg;
            ApplyThemeToControls(this.Controls, bg, fg);
            godarkmode();
        }
        private void ApplyThemeToControls(Control.ControlCollection controls, Color bg, Color fg)
        {
            foreach (Control ctrl in controls)
            {
                ctrl.BackColor = bg;
                ctrl.ForeColor = fg;

                if (ctrl.HasChildren)
                    ApplyThemeToControls(ctrl.Controls, bg, fg);
            }
        }
        public void godarkmode()
        {
            if (isdark && settingsForm != null)
            {
                settingsForm.darkmodecheckBox.ForeColor = Color.Black;
            }
            else if (settingsForm != null)
            {
                settingsForm.darkmodecheckBox.ForeColor = Color.White;
            }
        }
    }
}