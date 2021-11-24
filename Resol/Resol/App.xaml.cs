using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Resol
{
    public partial class App : Application
    {
        public static string url;
        public App()
        {

            InitializeComponent();
            //MainPage = new MainPage();
            url = "https://uthprograweb2.000webhostapp.com/webservice/";
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
