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

        string url = "http://192.168.1.124/";
       // string url = "http://127.0.0.1/";
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
            return Task.Run(() => registeruseronsite(userinfo)).Result;

        }

        private async Task<string> registeruseronsite(UserModel userinfo)
        {
            var client = new HttpClient();
            var jsonstring = JsonConvert.SerializeObject(userinfo);
            var content = new StringContent(jsonstring, Encoding.UTF8, "application/json");
            var result = await client.PostAsync(url + "LigiServices/api/ligi/RegisterUser", content);
            var response = await result.Content.ReadAsStringAsync();
            
            return response;
        }

       
       
    }
}
