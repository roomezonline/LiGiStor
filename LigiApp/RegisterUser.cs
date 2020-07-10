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

namespace LigiApp
{
    [Activity(Label = "RegisterUser", MainLauncher = true)]
    public class RegisterUser : Activity
    {
        private EditText txtmobile;
        private EditText txtname;
        private EditText txtpassword;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.registeruser);
            // Create your application here

            txtmobile = FindViewById<EditText>(Resource.Id.txtMobile);
            txtname = FindViewById<EditText>(Resource.Id.txtName);
            txtpassword = FindViewById<EditText>(Resource.Id.txtPassword);

            


        }
    }
}