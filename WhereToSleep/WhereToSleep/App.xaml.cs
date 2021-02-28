using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhereToSleep
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new buttons_sc();
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
