using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("old/api/values")]
    public class OldController : ApiController
    {
        [Route("")]
        [HttpGet]
        public HttpResponseMessage Get(CancellationToken cancellationToken)
        {
            FooModel data = new FooModel
            {
                MyProperty = "bar"
            };

            HttpResponseMessage message = this.Request.CreateResponse(HttpStatusCode.OK, data);
            return message;
        }
    }
}

