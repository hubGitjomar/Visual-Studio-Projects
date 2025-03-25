using AppsTest.MVVM.Views;

namespace AppsTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPageView();
        }
    }
}
