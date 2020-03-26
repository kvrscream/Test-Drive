using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testDrive
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Importante para a navegção funcionar temos de encapsular as views dentro de NAvigationPAge
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
