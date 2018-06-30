using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplicationJsondata.APIController
{
    public class JsondataWebAPIController : ApiController
    {
        // GET: api/JsondataWebAPI
        public IEnumerable<string> Get()
        {
           // var data = st
            return new string[] { "value1", "value2" };
        }

        // GET: api/JsondataWebAPI/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/JsondataWebAPI
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/JsondataWebAPI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/JsondataWebAPI/5
        public void Delete(int id)
        {
            
        }
    }
}
