using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DemoXamrin.Droid
{
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_register);
            Button btn_cancel=FindViewById<Button>(Resource.Id.btn_cancel);

            btn_cancel.Click += delegate
            {
                //StartActivity(typeof(RegisterActivity));
                Finish();
            };            // Create your application here
        }
    }
}