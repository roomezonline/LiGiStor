using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Java.IO;
using LiGiStor.Model;
using System;
using System.Threading.Tasks;

namespace LigiApp
{
    [Activity(Label = "RegisterUser")]
    public class RegisterUser : Activity
    {
        private EditText txtmobile;
        private EditText txtFirstname;
        private EditText txtLastname;
        private Button btnsave;
        private UserModel userinfo;
        

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

           
             userinfo = new UserModel()
            {
                FirstName = txtFirstname.Text,
                Mobile = txtmobile.Text,
                LastName = txtLastname.Text

            };

            new Register_Task(this,userinfo).Execute();


            //ISharedPreferences sharedPreferences = PreferenceManager.GetDefaultSharedPreferences(this);
            //var editor = sharedPreferences.Edit();
            //editor.PutString("userid", userid);
            //editor.Apply();

            //var dialog = new AlertDialog.Builder(this);
            //dialog.SetTitle(" ای دی برگشتی از وب سرویس پس از تبت نام");
            //dialog.SetMessage(string.Format("{0}", userid));

            //dialog.Show();


        }




        public class Register_Task : AsyncTask<Java.Lang.Void, Java.Lang.Void, string>
        {
            Context mContext;
            private UserModel userinfo;
            private ProgressDialog pDialog;

            public Register_Task(Context context,UserModel muserinfo)
            {
                
                mContext = context;
                userinfo = muserinfo;
                
            }


            protected override void OnPreExecute()
            {
                pDialog = new ProgressDialog(mContext);              
                pDialog.SetMessage("در حال ثبت اطلاعات...");
                pDialog.SetCancelable(false);
                pDialog.Show();
            }

            protected override string RunInBackground(Java.Lang.Void[] @params)
            {
                var dataserivce = new LiGiStor.core.Ligidataservice();
                var userid = dataserivce.registeryuser(UserModel.ToEntity(userinfo));
                          return userid;
            }

            protected override void OnPostExecute(string result)
            {
                base.OnPostExecute(result);
               pDialog.Dismiss();
                Toast.MakeText(mContext, "ثبت نام شما با موفقیت انجام شد " + result , ToastLength.Long).Show();
            }
        }





        //-------------------------------------------------
    }  
}