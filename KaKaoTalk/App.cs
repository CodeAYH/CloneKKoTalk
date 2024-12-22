using KaKao.Forms.UI.Views;
using System.Windows;

namespace Kakao
{
    class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            KakaoWindow window = new();

            window.Show();
        }
    }
}
