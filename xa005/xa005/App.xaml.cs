using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xa005
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            switch(Device.RuntimePlatform)
            {
                case Device.iOS: MainPage = new CPage_iOS(); break;
                case Device.Android: MainPage = new CPage_Android(); break;

                //case TargetIdiom.Desktop: MainPage = new CPage

            }
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
