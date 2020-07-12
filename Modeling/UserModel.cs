using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiGiStor.Model
{
 public   class UserModel
    {
        public int Id { get;set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }
        public string Code_Meli { get; set; }
        public string Ip { get; set; }
        public string Last_seen { get; set; }
        public string State { get; set; }
        public string User_Name { get; set; }


        public static UserModel ToEntity(UserModel userinfo)
        {
            UserModel msg = null/* TODO Change to default(_) if this is not a reference type */;
            msg = userinfo;
            if (msg.Id < 1) msg.Id =0;
            if (msg.Ip == null) msg.Ip ="Null";
            if (msg.FirstName == null) msg.FirstName = "Null";
            if (msg.LastName == null) msg.LastName = "Null";
            if (msg.Last_seen == null) msg.Last_seen = "Null";
            if (msg.Mobile == null) msg.Mobile = "Null";
            if (msg.Password == null) msg.Password = "Null";
            if (msg.State == null) msg.State = "Null";
            if (msg.User_Name == null) msg.User_Name = "Null";
            if (msg.Type < 1) msg.Type = 0;
            if (msg.Code_Meli == null) msg.Code_Meli = "Null";
            return msg;
        }



        public static UserModel ToEntityFill(SqlDataReader Datareader)
        {
            UserModel msg = new UserModel();
            //    msg = userinfo;

          //  msg.Id = Datareader.GetValues.Id();
            if (msg.Ip == null) msg.Ip = "Null";
            if (msg.FirstName == null) msg.FirstName = "Null";
            if (msg.LastName == null) msg.LastName = "Null";
            if (msg.Last_seen == null) msg.Last_seen = "Null";
            if (msg.Mobile == null) msg.Mobile = "Null";
            if (msg.Password == null) msg.Password = "Null";
            if (msg.State == null) msg.State = "Null";
            if (msg.User_Name == null) msg.User_Name = "Null";
            if (msg.Type < 1) msg.Type = 0;
            if (msg.Code_Meli == null) msg.Code_Meli = "Null";
            return msg;
        }
    }

  

}
