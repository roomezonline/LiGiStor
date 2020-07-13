using LiGiStor.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LiGiStor.core
{
    public class Repositery : LigiInterface
    {
       // string url = "http://192.168.1.124/";
       // string url = "http://192.168.88.5/";
         string url = "http://192.168.88.252/";




        public List<UserModel> Get_user()
        {
            return Task.Run(Get_user_list).Result;
            
        }
        private async Task<List<UserModel>> Get_user_list()
        {
            var client = new HttpClient();
            var result = await client.GetAsync(url + "LigiServices/api/Get/Get_User_List");
            var response = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<UserModel>>(response);
        }

        public List<UserModel> Get_userbyid(string Id)
        {
            throw new NotImplementedException();
        }




        public string registeryuser(UserModel userinfo)
        {
            return Task.Run(() => registeruseronsite(userinfo)).Result;

        }

        private async Task<string> registeruseronsite(UserModel userinfo)
        {
            var client = new HttpClient();
            var jsonstring = JsonConvert.SerializeObject(userinfo);
            var content = new StringContent(jsonstring, Encoding.UTF8, "application/json");
            var result = await client.PostAsync(url + "LigiServices/api/Set/RegisterUser", content);
            var response = await result.Content.ReadAsStringAsync();
            
            return response;
        }

       
       
    }
}
