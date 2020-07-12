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
using LiGiStor.Model;

namespace LigiApp
{
    [Activity(Label = "RegisterUser", MainLauncher = true)]
    public class RegisterUser : Activity
    {
        private EditText txtmobile;
        private EditText txtname;
        private EditText txtpassword;
        private Button btnsave;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.registeruser);
            // Create your application here

            txtmobile = FindViewById<EditText>(Resource.Id.txt_mobile);
            txtname = FindViewById<EditText>(Resource.Id.txt_name);
            txtpassword = FindViewById<EditText>(Resource.Id.txt_family);
            btnsave = FindViewById<Button>(Resource.Id.btn_register);

            //btnsave.Click += btn_save;

              
            


        }

        //private void btn_save(object sender, EventArgs e)
        //{
        //    var userinfo = new UserModel()
        //    {
        //        FirstName =txtname .Text,
        //        Mobile = txtmobile.Text,
        //        Password  = txtpassword.Text,
        //        User_Name="مجنون",
        //        Type=1,
        //        LastName="samsami",
        //        Last_seen ="225",
        //        Id=3,
        //        State="1",
        //        Code_Meli=123
                
        //                    };

            

        //    var dataserivce = new LiGiStor.core.Ligidataservice ();

        //    var userid = dataserivce.registeryuser(UserModel.ToEntity( userinfo));
        //    //ISharedPreferences sharedPreferences = PreferenceManager.GetDefaultSharedPreferences(this);
        //    //var editor = sharedPreferences.Edit();
        //    //editor.PutString("userid", userid);
        //    //editor.Apply();

        //    var dialog = new AlertDialog.Builder(this);
        //    dialog.SetTitle(" ای دی برگشتی از وب سرویس پس از تبت نام");
        //    dialog.SetMessage(string.Format("{0}", userid));

        //    dialog.Show();


        //}
    }
}