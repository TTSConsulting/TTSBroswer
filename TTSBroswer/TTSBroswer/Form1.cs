using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace TTSBroswer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();

            // Sync tab title with page title
            webView21.CoreWebView2.DocumentTitleChanged += (s, ev) =>
            {
                this.Text = webView21.CoreWebView2.DocumentTitle;
            };

            // WebView2 layout
            webView21.Source = new Uri("https://www.google.com/");
            webView21.Location = new Point(0, 35);
            webView21.Size = new Size(this.Width, this.Height - 35);
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Button event hooks
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
        }
    }
}
