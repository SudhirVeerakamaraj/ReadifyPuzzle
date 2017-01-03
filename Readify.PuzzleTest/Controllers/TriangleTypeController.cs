using Readify.PuzzleTest.BusinessLogicLayer.Implementations;
using Readify.PuzzleTest.BusinessLogicLayer.Interfaces;
using System.Web.Http;
using System;
using Readify.PuzzleTest.Models;

using System.Net;

namespace Readify.PuzzleTest.Controllers
{
    public class TriangleTypeController : ApiController
    {
        private readonly ITriangleTypeLogic _TriangleTypeLogic;

        public TriangleTypeController(ITriangleTypeLogic triangleTypeLogic)
        {
            _TriangleTypeLogic = triangleTypeLogic;
        }
       
        // GET api/<controller>
        public IHttpActionResult Get(string a, string b, string c)
        {
             try
            {
                var sideA = Convert.ToInt32(a);
                var sideB = Convert.ToInt32(b);
                var sideC = Convert.ToInt32(c);
                return Ok(_TriangleTypeLogic.GetTriangleType(sideA, sideB, sideC));
            }
            catch (Exception)
            {
                var error = new Error() { message = "The request is invalid." };
                return Content(HttpStatusCode.BadRequest, error);
            }
        }

           }
}