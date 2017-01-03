using Readify.PuzzleTest.BusinessLogicLayer.Implementations;
using Readify.PuzzleTest.BusinessLogicLayer.Interfaces;
using Readify.PuzzleTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace Readify.PuzzleTest.Controllers
{
    public class FibonacciController : ApiController
    {
        private readonly IFibonacciLogic _FibonacciLogic;

        public FibonacciController(IFibonacciLogic fibonacciLogic)
        {
            _FibonacciLogic = fibonacciLogic;
        }
        public IHttpActionResult Get(string n)
        {
            try
            {
                return Ok(_FibonacciLogic.GetNthNumberInFibonacciSeries(Convert.ToInt32(n)));
            }
            catch (Exception ex)
            {
                if (ex is ApplicationException)
                {
                    return BadRequest();
                }
                else {
                    var error = new Error() { message = "The request is invalid." };
                    return Content(HttpStatusCode.BadRequest, error);                    
                }
                
            }
            
            
        }
    }
}
