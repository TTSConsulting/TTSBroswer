using EasyTabs;

namespace TTSBroswer
{
    public partial class MainWindow : TitleBarTabs
    {
        public MainWindow()
        {
            InitializeComponent();

            // Chrome-style tabs
            TabRenderer = new ChromeTabRenderer(this);

            // Optional: Enables Alt+Tab peek preview
            AeroPeekEnabled = true;

            // Add your first tab (signal default page)
            Tabs.Add(CreateTab());

            // Set which tab to show first
            SelectedTabIndex = 0;
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new Form1()
                {
                    Text = "New Tab"
                }
            };
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Name = "MainWindow";
            this.Text = "TTSBrowser - Signal Console";

            this.ResumeLayout(false);
        }


    }
}