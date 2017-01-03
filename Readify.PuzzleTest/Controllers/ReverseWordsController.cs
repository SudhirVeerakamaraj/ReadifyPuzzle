using Readify.PuzzleTest.BusinessLogicLayer.Implementations;
using Readify.PuzzleTest.BusinessLogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Readify.PuzzleTest.Controllers
{
    public class ReverseWordsController : ApiController
    {
        private readonly IReverseWordsLogic _ReverseWordsLogic;

        public ReverseWordsController(IReverseWordsLogic reverseWordsLogic) {
            _ReverseWordsLogic = reverseWordsLogic;
        }
        public IHttpActionResult Get(string sentence) {
            return Ok(_ReverseWordsLogic.ReverseWords(sentence));
        }
    }
}
