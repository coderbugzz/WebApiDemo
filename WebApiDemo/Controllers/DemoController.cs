using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class DemoController : ApiController
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            // Code to retrieve data from the database or any other source
            var demoData = new string[] { "data 1", "data 2", "data 3" };

            return demoData;
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] string value)
        {
            // Code to save the provided value in the database or any other destination

            return Request.CreateResponse(HttpStatusCode.OK, "Saved: " + value);
        }

        [HttpPut]
        public HttpResponseMessage Put(int id, [FromBody] string value)
        {
            // Code to update the resource with the specified ID using the provided value

            return Request.CreateResponse(HttpStatusCode.OK, "Updated: " + id);
        }

        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            // Code to delete the resource with the specified ID
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted: " + id);
        }
    }
}
