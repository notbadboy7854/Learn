using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

namespace dhLottery.Droid
{
    [Activity(Label = "dhLottery", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        //public override void OnBackPressed()
        //{
        //    Android.App.AlertDialog.Builder builder = new Android.App.AlertDialog.Builder(this);

        //    builder.SetPositiveButton("확인", (senderAlert, args) => {
        //        Finish();
        //    });

        //    builder.SetNegativeButton("취소", (senderAlert, args) => {
        //        return;
        //    });

        //    Android.App.AlertDialog alterDialog = builder.Create();
        //    alterDialog.SetTitle("알림");
        //    alterDialog.SetMessage("프로그램을 종료 하시겠습니까?");
        //    alterDialog.Show();
        //}
    }
}