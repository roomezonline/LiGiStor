using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiGiStor.Model;

namespace LiGiStor.core
{
    public class Ligidataservice  
    {

        private LigiInterface actionrepositery ;
        public Ligidataservice()
        {
            actionrepositery = new Repositery();
        }
        public List<UserModel> Get_user()

             

        {
            throw new NotImplementedException();
        }

        public List<UserModel> Get_userbyid(string Id)
        {
            throw new NotImplementedException();
        }

        public string registeryuser(UserModel userinfo)
        {


           


            return actionrepositery.registeryuser(userinfo);
        }

        
    }
}
