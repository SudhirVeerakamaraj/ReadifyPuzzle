using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Readify.PuzzleTest.Controllers
{
    public class TokenController : ApiController
    {
        public IHttpActionResult Get() {
            return Ok("9c394929-4cec-43e0-9fa5-df4d47bd1397");
        }
    }
}
