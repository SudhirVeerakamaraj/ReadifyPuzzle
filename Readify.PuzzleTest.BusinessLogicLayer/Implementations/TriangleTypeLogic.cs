using Readify.PuzzleTest.BusinessLogicLayer.Enum;
using Readify.PuzzleTest.BusinessLogicLayer.Interfaces;

namespace Readify.PuzzleTest.BusinessLogicLayer.Implementations
{
    public class TriangleTypeLogic : ITriangleTypeLogic
    {
        private int _sideA;

        private int _sideB;

        private int _sideC;

        public string GetTriangleType(int sideA, int sideB, int sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;

            var triangleType = TriangleTypeEnum.NonExistentTriangle;
            if (isValidTriangle())
            {
                if (isEquilateralTriangle())
                {
                    triangleType = TriangleTypeEnum.EquilateralTriangle;
                }
                else if (isIsoscelesTriangle())
                {
                    triangleType = TriangleTypeEnum.IsoscelesTriangle;
                }
                else
                {
                    triangleType = TriangleTypeEnum.ScaleneTriangle;
                }
            }
            return triangleType.ToReadableString();
        }

        private bool isValidTriangle()
        {
            if (_sideA < 0 || _sideB < 0 || _sideC < 0)
            {
                return false;
            }
            else if (_sideA + _sideB < _sideC)
            {
                return false;
            }
            else if (_sideB + _sideC < _sideA)
            {
                return false;
            }
            else if (_sideA + _sideC < _sideB)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool isIsoscelesTriangle()
        {
            return (_sideA == _sideB || _sideB == _sideC || _sideC == _sideA);
        }

        private bool isEquilateralTriangle()
        {
            return _sideA == _sideB && _sideB == _sideC;
        }
    }
}