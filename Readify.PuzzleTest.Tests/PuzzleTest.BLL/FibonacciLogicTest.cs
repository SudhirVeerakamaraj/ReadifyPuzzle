using NUnit.Framework;
using Readify.PuzzleTest.BusinessLogicLayer.Implementations;
using Readify.PuzzleTest.BusinessLogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readify.PuzzleTest.Tests.PuzzleTest.BLL
{
    [TestFixture]
    class FibonacciLogicTest
    {
        private IFibonacciLogic _fibonacciLogic;
        [OneTimeSetUp]        
        public void OneTimeSetUp() {
            _fibonacciLogic = new FibonacciLogic();
        }
        [TestCase]
        public void TestFibonacciWithValidInput() {
            #region Arrange
            int inputNumber = 10;
            int expected = 55;
            #endregion
            #region Act
            var actual= _fibonacciLogic.GetNthNumberInFibonacciSeries(inputNumber);
            #endregion
            #region Assert
            Assert.AreEqual(expected, actual);
            #endregion
        }
        [TestCase]
        public void TestFibonacciWithNegativeInput()
        {
            #region Arrange
            int inputNumber = -10;
            int expected = -55;
            #endregion
            #region Act
            var actual = _fibonacciLogic.GetNthNumberInFibonacciSeries(inputNumber);
            #endregion
            #region Assert
            Assert.AreEqual(expected, actual);
            #endregion
        }
        [TestCase]
        public void TestFibonacciWithOutOfRangeInput()
        {
            #region Arrange
            int inputNumber = 93;
            
            #endregion
            #region Act & Assert
            Assert.Throws<ApplicationException>(()=> _fibonacciLogic.GetNthNumberInFibonacciSeries(inputNumber));
            #endregion           
        }

    }

}


