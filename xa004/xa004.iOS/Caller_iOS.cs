using System;
using xa004.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(Caller_iOS))]

namespace xa004.iOS
{
    public class Caller_iOS : IDialer
    {
        public bool dial(string strPhoneNumber)
        {
            System.Diagnostics.Debug.WriteLine("iOS 전화");
            return true;
        }
    }
}
