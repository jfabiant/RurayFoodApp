using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RurayFoodApp.Views;

namespace RurayFoodApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("333");
            ((NavigationPage)Application.Current.MainPage).BarTextColor = Color.FromHex("fff");
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
