using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using NUnit.Framework;
using Readify.PuzzleTest.BusinessLogicLayer.Interfaces;
using Readify.PuzzleTest.Controllers;
using Readify.PuzzleTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.Http.Results;
namespace Readify.PuzzleTest.Tests.PuzzleTest.API
{
    [TestClass]
    public class TriangleTypeControllerTest
    {
        private ITriangleTypeLogic _triangleTypeLogicMock;
        private TriangleTypeController _triangleTypeController;
        [OneTimeSetUp]
        public void OneTimeSetUp() {
            _triangleTypeLogicMock = Substitute.For<ITriangleTypeLogic>();
            _triangleTypeController = new TriangleTypeController(_triangleTypeLogicMock);
        }
        [TestCase]
        public void TestSuccessTriangleType() {
            #region Arrange
            var inputA = "1";
            var inputB = "2";
            var inputC = "1";
            var expectedType = "test";
            _triangleTypeLogicMock.GetTriangleType(1,1,1).ReturnsForAnyArgs(expectedType);
            #endregion

            #region Act
            var actionResult = _triangleTypeController.Get(inputA,inputB,inputC);
            var response = actionResult as OkNegotiatedContentResult<string>;
            #endregion

            #region Assert
            NUnit.Framework.Assert.AreEqual(expectedType, response.Content);
            #endregion

        }
        [TestCase]
        public void TestFailureTriangleType()
        {
            #region Arrange
            var inputA = "1";
            var inputB = "asdasdsad";
            var inputC = "1";
            var expectedType = "The request is invalid.";
            _triangleTypeLogicMock.GetTriangleType(1, 1, 1).ReturnsForAnyArgs(expectedType);
            #endregion

            #region Act
            var actionResult = _triangleTypeController.Get(inputA, inputB, inputC);
            var response = actionResult as NegotiatedContentResult<Error>;
            #endregion

            #region Assert
            _triangleTypeLogicMock.DidNotReceive();
            NUnit.Framework.Assert.AreEqual(expectedType, response.Content.message);
            #endregion

        }

    }
}
