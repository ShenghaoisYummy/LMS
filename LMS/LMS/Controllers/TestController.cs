using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LMS.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        [Route("api/test")]
        public IHttpActionResult Test()
        {
            using (LMSEntities context = new LMSEntities())
            {
                var students = context.Students.ToList();
                return Ok(students);
            }
        }
    }
}
