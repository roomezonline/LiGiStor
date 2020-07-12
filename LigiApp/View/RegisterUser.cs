using Android.App;
using Android.OS;
using Android.Widget;
using LiGiStor.Model;
using System;

namespace LigiApp
{
    [Activity(Label = "RegisterUser", MainLauncher = true)]
    public class RegisterUser : Activity
    {
        private EditText txtmobile;
        private EditText txtFirstname;
        private EditText txtLastname;
        private Button btnsave;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.registeruser);
            // Create your application here

            txtmobile = FindViewById<EditText>(Resource.Id.txt_mobile);
            txtFirstname = FindViewById<EditText>(Resource.Id.txt_Firstname);
            txtLastname = FindViewById<EditText>(Resource.Id.txt_Lastname);
            btnsave = FindViewById<Button>(Resource.Id.btn_register);

            btnsave.Click += btn_save;





        }

        private void btn_save(object sender, EventArgs e)
        {
            var userinfo = new UserModel()
            {
                FirstName = txtFirstname.Text,
                Mobile = txtmobile.Text,
                LastName = txtLastname.Text


            };



            var dataserivce = new LiGiStor.core.Ligidataservice();

            var userid = dataserivce.registeryuser(UserModel.ToEntity(userinfo));
            //ISharedPreferences sharedPreferences = PreferenceManager.GetDefaultSharedPreferences(this);
            //var editor = sharedPreferences.Edit();
            //editor.PutString("userid", userid);
            //editor.Apply();

            var dialog = new AlertDialog.Builder(this);
            dialog.SetTitle(" ای دی برگشتی از وب سرویس پس از تبت نام");
            dialog.SetMessage(string.Format("{0}", userid));

            dialog.Show();


        }
    }
}