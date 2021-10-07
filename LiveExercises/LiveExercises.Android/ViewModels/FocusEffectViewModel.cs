using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("MyCompany")]
[assembly: ExportEffect(typeof(LiveExercises.Droid.ViewModels.FocusEffectViewModel), nameof(LiveExercises.Droid.ViewModels.FocusEffectViewModel))]
namespace LiveExercises.Droid.ViewModels
{
    public class FocusEffectViewModel : PlatformEffect
    {
        Android.Graphics.Color _originalBackGroundColor = new Android.Graphics.Color(0, 0, 0, 0);
        Android.Graphics.Color _backgroundColor;
        protected override void OnAttached()
        {
            try
            {
                _backgroundColor = Android.Graphics.Color.LightGreen;
                Control.SetBackgroundColor(_backgroundColor);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", e.Message);
            }
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            try
            {
                if(args.PropertyName == "IsFocused")
                {
                    if(((Android.Graphics.Drawables.ColorDrawable)Control.Background).Color == _backgroundColor)
                    {
                        Control.SetBackgroundColor(_originalBackGroundColor);
                    }
                    else
                    {
                        Control.SetBackgroundColor(_backgroundColor);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", e.Message);
            }
        }
    }
}