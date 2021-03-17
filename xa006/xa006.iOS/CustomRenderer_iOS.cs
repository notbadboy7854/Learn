using System;
using xa006;
using xa006.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomView), typeof(CustomRenderer_iOS))]
namespace xa006.iOS
{
    public class CustomRenderer_iOS : ViewRenderer<CustomView, UIKit.UISlider>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CustomView> e)
        {
            base.OnElementChanged(e);

            var slider = new UIKit.UISlider();

            SetNativeControl(slider);
        }
    }
}
