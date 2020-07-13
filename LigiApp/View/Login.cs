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

namespace LigiApp.View
{
    [Activity(Label = "Login", MainLauncher = true)]
    public class Login : Activity
    {
     private   EditText mobile;
        //private Button btnlogin;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Login);
            mobile = FindViewById<EditText>(Resource.Id.txt_mobile);
            //btnlogin = FindViewById<Button>(Resource.Id.btn_login);
            // Create your application here
            //btnlogin.Click += btnloging_click;



        }

        //private void btnloging_click(object sender, EventArgs e)
        //{
            
        //}
    }
}