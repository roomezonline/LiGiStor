using LiGiStor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Services.Service;
using System.Data.SqlClient;

namespace Services.Service
{
    
    public class LigiController : ApiController
    {

        
      // connectionstring config =  System.Web.Configuration.WebConfigurationManager.ConnectionStrings.("con_store");
      
        // private List<UserModel> usrmodel { get; set; }
        [HttpGet]
        public IHttpActionResult Iping()

        {
            

            return Ok(" Welcome your Service Is Run  1111 ");
        }

       

        [HttpPost]
        public IHttpActionResult RegisterUser(UserModel userinfo)
        {
            // using db =new 

            //Services.Service.

            var db = new BUSINESS();
             


            return Ok(db.BRegisterUser(userinfo ));

        }

    }
    
}
