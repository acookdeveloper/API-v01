using API_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_01.Controllers
{
    //[Authorize] get this later
    public class ValuesController : ApiController
    {
        //Get all values from the database in the table from the model created > User_AuthController.cs
        private API01Entities db = new API01Entities();

        // GET api/values
        public IEnumerable<User_Auth> Get()
        {
            //get database connection here


            return db.User_Auth.ToList();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
