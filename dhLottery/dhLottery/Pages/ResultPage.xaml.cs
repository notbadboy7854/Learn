using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace dhLottery.Pages
{
    public partial class ResultPage : ContentPage
    {
        public ResultPage()
        {
            InitializeComponent();
        }

        private async void btnBack_Clicked(System.Object sender, System.EventArgs e)
        {
            //await Navigation.PopModalAsync();
            await Navigation.PopAsync();
        }
    }
}
