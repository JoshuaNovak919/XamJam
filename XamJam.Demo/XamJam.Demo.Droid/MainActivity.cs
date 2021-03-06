﻿using Android.App;
using Android.Content.PM;
using Android.Opengl;
using Android.OS;
using FFImageLoading.Forms.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamSvg.XamForms.Droid;

namespace XamJam.Demo.Droid
{
    [Activity(Label = "GestureSample", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
            CachedImageRenderer.Init();
            SvgImageRenderer.InitializeForms();
            Forms.Init(this, bundle);
            MR.Gestures.Android.Settings.LicenseKey = "ALZ9-BPVU-XQ35-CEBG-5ZRR-URJQ-ED5U-TSY8-6THP-3GVU-JW8Z-RZGE-CQW6";
            LoadApplication(new App());
        }
    }
}

