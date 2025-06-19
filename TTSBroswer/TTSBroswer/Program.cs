using EasyTabs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TTSBroswer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var appContext = new TitleBarTabsApplicationContext();
            var mainWindow = new MainWindow(); // Your custom TitleBarTabs form
            appContext.Start(mainWindow);
            Application.Run(appContext);
        }
    }
}
