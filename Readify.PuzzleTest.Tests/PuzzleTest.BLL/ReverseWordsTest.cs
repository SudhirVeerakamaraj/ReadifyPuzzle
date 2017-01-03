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
    public class ReverseWordsTest
    {
        private IReverseWordsLogic _reverseWordsLogic;
        [OneTimeSetUp]
        public void OneTimeRun() {
            _reverseWordsLogic = new ReverseWordsLogic();
        }
        [TestCase]
        public void TestReverseWithSingleWord() {
            #region arrange
            string input = "test";
            var expected = input.Reverse();
            #endregion
            #region act
            var actual = _reverseWordsLogic.ReverseWords(input);
            #endregion
            #region assert
            Assert.AreEqual(expected, actual);
            #endregion
        }
        [TestCase]
        public void TestReverseWithSentence()
        {
            #region arrange
            string input = "tests test test test";
            var expected = "stset tset tset tset";
            #endregion
            #region act
            var actual = _reverseWordsLogic.ReverseWords(input);
            #endregion
            #region assert
            Assert.AreEqual(expected, actual);
            #endregion
        }
        [TestCase]
        public void TestReverseWithEmptyString()
        {
            #region arrange
            string input = string.Empty;
            var expected = string.Empty;
            #endregion
            #region act
            var actual = _reverseWordsLogic.ReverseWords(input);
            #endregion
            #region assert
            Assert.AreEqual(expected, actual);
            #endregion
        }
        [TestCase]
        public void TestReverseWithNull() {
            #region arrange
            string input = null;            
            #endregion
            #region act
            var actual = _reverseWordsLogic.ReverseWords(input);
            #endregion
            #region assert
            Assert.IsEmpty(actual);
            #endregion
        }
        
    }
}
