using System.Windows;

namespace Kakao
{
    class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Window window = new();
            window.Show();
        }
    }
}
