using LiGiStor.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Services.Service
{
    public class BUSINESS :ApiController
    {

        string config = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["con_store"].ConnectionString;


        // تکه کد  نمونه برای ارتباط با دیتا اینتری  


        public  List<UserModel> BGet_User_List()
        {
            List<UserModel> result = new List<UserModel>();
            SqlConnection con_AGet_data = new SqlConnection(config);
            con_AGet_data.Open();
             
        //    try
            //{
                SqlCommand cmd = new SqlCommand("SELECT  Id, First_Name  , Last_Name , Mobile  , Password , Type    , Code_Meli  , Ip  , Last_seen , State  , User_Name FROM Tb_User where id=1", con_AGet_data);
                using (System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows == true)
                    {
                        while (reader.Read())
                            result.Add(UserModel.ToEntityFill(reader));
                    }
                }
            //}
          //  catch  
           // {
            //}
            //finally
            //{
                con_AGet_data.Close();
                con_AGet_data.Dispose();
                SqlConnection.ClearPool(con_AGet_data);
            //}

            return result;
        }

//تنتنتننت




        public string BRegisterUser(UserModel userinfo)
        {

           // userinfo = UserModel.ToEntity(userinfo);
            SqlConnection con = new SqlConnection(config);

            SqlCommand cmd = new SqlCommand();
             //IHttpActionResult result = null;

            if ( userinfo.Id  > 0)
            {
                //new SqlCommand("UPDATE  Tb_User    SET Type  = @Type , Code_Meli = @Code_Meli  , Password  = @Password , Ip = @Ip  , Last_seen  = @Last_seen,  State  = @State , First_Name  = @First_Name  , Last_Name  = @Last_Name , Mobile= @Mobile , User_Name= @User_Name  WHERE Id=3", con);
               cmd = new SqlCommand("UPDATE  Tb_User    SET Type  = @Type , Code_Meli = @Code_Meli  , Password  = @Password , Ip = @Ip  , Last_seen  = @Last_seen ,  State  = @State , First_Name  = @First_Name  , Last_Name  = @Last_Name , Mobile = @Mobile , User_Name = @User_Name  WHERE Id = 3", con);
            }
            else
            {
                cmd = new SqlCommand("INSERT INTO  Tb_User     (Type  ,Code_Meli ,Password ,Ip ,Last_seen  ,State  ,First_Name ,Last_Name ,Mobile ,User_Name)  VALUES(@Type  ,@Code_Meli ,@Password ,@Ip ,@Last_seen  ,@State  ,@First_Name ,@Last_Name ,@Mobile ,@User_Name) " + " SELECT CAST(scope_identity() AS int)", con);
            }


            //string ip = userinfo.Ip;
            //if (ip.Length<=0)
            //{
            //    ip = "Null";
            //}
         //   ip = converttostring(ip);
            cmd.Parameters.AddWithValue("@Type",  userinfo.Type);

            cmd.Parameters.AddWithValue("@User_Name", userinfo.User_Name);
            cmd.Parameters.AddWithValue("@Code_Meli",  userinfo.Code_Meli );
            cmd.Parameters.AddWithValue("@Password", userinfo.Password);
            cmd.Parameters.AddWithValue("@Ip",userinfo.Ip);
            cmd.Parameters.AddWithValue("@Last_seen", userinfo.Last_seen );
            cmd.Parameters.AddWithValue("@State", userinfo.State );
            cmd.Parameters.AddWithValue("@First_Name", userinfo.FirstName );
            cmd.Parameters.AddWithValue("@Last_Name", userinfo.LastName );
            cmd.Parameters.AddWithValue("@Mobile", userinfo.Mobile );
            string id;
            try
             {
            con.Open();
 
            if (Convert.ToInt32(userinfo.Id) > 0)
            {
                cmd.ExecuteNonQuery();
                 
                id = "update";

            }
            else
            {
                id = cmd.ExecuteScalar().ToString(); 
            }

           // return Ok("some string");
             }

             catch
             
             {
                id = "Error";
             }

             finally
             {
                con.Close();
                con.Dispose();

                }

                return (id) ;
        }

 



    }
}