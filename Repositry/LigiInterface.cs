using LiGiStor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiGiStor.core
{
    interface LigiInterface
    {
        string registeryuser(UserModel userinfo);
        List<UserModel> Get_user();
        List<UserModel> Get_userbyid(string Id);
    }
}
