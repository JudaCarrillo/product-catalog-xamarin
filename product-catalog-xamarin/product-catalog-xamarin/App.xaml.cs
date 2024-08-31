using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace product_catalog_xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.Transparent,
                BackgroundColor = Color.FromHex("#1e1e1e"),
            };
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
