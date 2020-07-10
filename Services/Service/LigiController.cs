using LiGiStor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Services.Service
{
    public class LigiController : ApiController
    {


        // private List<UserModel> usrmodel { get; set; }
[HttpGet]
        public IHttpActionResult Iping()
        {
            return Ok(" Welcome your Service Is Run  ");
        }


        [HttpPost]
        public IHttpActionResult RegisterUser(UserModel userinfo)
        {


            return Ok("salam welcome");

        }

    }
}
