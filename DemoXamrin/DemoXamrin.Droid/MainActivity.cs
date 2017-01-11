using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace DemoXamrin.Droid
{
	[Activity (Label = "DemoXamrin.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
            Button button = FindViewById<Button>(Resource.Id.btn_login);
            TextView tv_sign_up = FindViewById<TextView>(Resource.Id.tv_sign_up);

            tv_sign_up.Click += delegate
            {
                StartActivity(typeof(RegisterActivity));
            };
            button.Click += delegate {
                StartActivity(typeof(RegisterActivity));
            };
            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button> (Resource.Id.myButton);

            //button.Click += delegate {
            //button.Text = string.Format ("{0} clicks!", count++);
            //};
        }
    }
}


