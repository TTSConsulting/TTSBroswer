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
            webView21.Source = new Uri("https://coolis1362.github.io/wsbsd.org/");
            webView21.Location = new Point(0, 35);
            webView21.Size = new Size(this.Width, this.Height - 35);
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            homeButtion.Click += (sender, e) =>
            {
                webView21.Source = new Uri("https://www.google.com/search?q=");
            };

        }

    }
}
