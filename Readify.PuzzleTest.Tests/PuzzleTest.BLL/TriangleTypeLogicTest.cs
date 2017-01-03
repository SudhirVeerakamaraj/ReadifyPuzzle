
using NUnit.Framework;
using Readify.PuzzleTest.BusinessLogicLayer.Enum;
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
    public class TriangleTypeLogicTest
    {
        private ITriangleTypeLogic _triangleTypeLogic;
        [OneTimeSetUp]
        public void OneTimeSetUp() {
            _triangleTypeLogic = new TriangleTypeLogic();
        }

        [TestCase]
        public void TestInvalidTriangle() {

            #region Arrange
            int sideA = 3;
            int sideB = 1;
            int sideC = 1;
            var expected = TriangleTypeEnum.NonExistentTriangle.ToReadableString();
            #endregion
            #region Act
            var actual = _triangleTypeLogic.GetTriangleType(sideA, sideB, sideC);
            #endregion
            #region Assert
            Assert.AreEqual(expected, actual);
            #endregion
        }
        [TestCase]
        public void TestEquilateralTriangle()
        {

            #region Arrange
            int sideA = 2;
            int sideB = 2;
            int sideC = 2;
            var expected = TriangleTypeEnum.EquilateralTriangle.ToReadableString();
            #endregion
            #region Act
            var actual = _triangleTypeLogic.GetTriangleType(sideA, sideB, sideC);
            #endregion
            #region Assert
            Assert.AreEqual(expected, actual);
            #endregion
        }
        [TestCase]
        public void TestIsoscelesTriangle()
        {

            #region Arrange
            int sideA = 2;
            int sideB = 3;
            int sideC = 3;
            var expected = TriangleTypeEnum.IsoscelesTriangle.ToReadableString();
            #endregion
            #region Act
            var actual = _triangleTypeLogic.GetTriangleType(sideA, sideB, sideC);
            #endregion
            #region Assert
            Assert.AreEqual(expected, actual);
            #endregion
        }
        [TestCase]
        public void TestScaleneTriangle()
        {

            #region Arrange
            int sideA = 2;
            int sideB = 4;
            int sideC = 3;
            var expected = TriangleTypeEnum.ScaleneTriangle.ToReadableString();
            #endregion
            #region Act
            var actual = _triangleTypeLogic.GetTriangleType(sideA, sideB, sideC);
            #endregion
            #region Assert
            Assert.AreEqual(expected, actual);
            #endregion
        }

    }
}
