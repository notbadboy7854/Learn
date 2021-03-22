using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace dhLottery
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void btnResult_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Pages.ResultPage());
        }


        protected override bool OnBackButtonPressed()
        {
             
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("앱을 종료할까요?", "", "아니오", "네");
                if (result == false)
                {
                    //await this.Navigation.PopAsync();
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
            });
            return true;
            //return base.OnBackButtonPressed();

        }

        public async void btnInfo_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Pages.infoPage());
        }
    }
}
