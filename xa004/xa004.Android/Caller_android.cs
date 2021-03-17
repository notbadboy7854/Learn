using System;
using xa004.Droid;
using Xamarin.Forms;

[assembly:Dependency(typeof(Caller_android))]

namespace xa004.Droid
{
    public class Caller_android : IDialer
    {
        public bool dial(string strPhoneNumber)
        {
            System.Diagnostics.Debug.WriteLine("안드로이드 전화");
            return true;
        }
    }
}
