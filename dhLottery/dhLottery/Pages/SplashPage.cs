using System;
using Xamarin.Forms;

namespace dhLottery
{
    public class SplashPage : ContentPage
    {
        Image splashImage;

        public SplashPage()
        {
            //상단 네비게이션바 제거
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();

            string imgFile = "splash_logo.png";

            //로딩이미지, 가로크기, 세로크기 지정  
            splashImage = new Image { Source = imgFile, WidthRequest = 360, HeightRequest = 680 };

            AbsoluteLayout.SetLayoutFlags(splashImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.FromHex("429de3");
            this.Content = sub;

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            //2초 동안 화면 유지
            await splashImage.ScaleTo(1, 2000);

            //1.5초 동안 0.9배 작아짐
            await splashImage.ScaleTo(0.9, 1500, Easing.Linear);

            //1.5초 동안 150배 커짐
            await splashImage.ScaleTo(150, 1500, Easing.Linear);

            Application.Current.MainPage = new NavigationPage(new MainPage());

        }
    }
}
