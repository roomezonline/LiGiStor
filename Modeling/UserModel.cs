using System;
using System.Collections.Generic;
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
        public int Code_Meli { get; set; }
        public string Ip { get; set; }
        public string Last_seen { get; set; }
        public string State { get; set; }
        public string User_Name { get; set; }


        public static UserModel ToEntity(UserModel userinfo)
        {
            UserModel msg = null/* TODO Change to default(_) if this is not a reference type */;
            msg = userinfo;
            if (msg.Id == null) msg.Id =0;
            if (msg.Ip == null) msg.Ip ="";

            return msg;
        }
    }

  

}
