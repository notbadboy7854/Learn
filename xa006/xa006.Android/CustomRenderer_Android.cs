
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using xa006;
using xa006.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(CustomView), typeof(CustomRenderer_Android))]
namespace xa006.Droid
{
    public class CustomRenderer_Android : ViewRenderer<CustomView, Android.Widget.DatePicker>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CustomView> e)
        {
            base.OnElementChanged(e);

            var datePicker = new Android.Widget.DatePicker(Forms.Context);

            SetNativeControl(datePicker);
        }
    }
}
