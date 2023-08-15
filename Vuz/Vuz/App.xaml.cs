using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vuz
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage()); // Здесь главная страница обернута в NavigationPage
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
