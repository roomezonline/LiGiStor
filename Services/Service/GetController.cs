using System;
using System.Collections.Generic;
 using System.Linq;
 using System.Net;
 using System.Net.Http;
using System.Web.Http;
using LiGiStor.Model;

namespace Services.Service
{
    

    public class GetController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get_User_List()
        {
            var db = new BUSINESS();
            return Json(db.BGet_User_List());

        }
    }
}
