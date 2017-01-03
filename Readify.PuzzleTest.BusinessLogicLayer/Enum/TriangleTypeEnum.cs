namespace Readify.PuzzleTest.BusinessLogicLayer.Enum
{
    public enum TriangleTypeEnum : int
    {
        NonExistentTriangle = -1,
        ScaleneTriangle = 0,
        IsoscelesTriangle = 1,
        EquilateralTriangle = 2
    }

    public static class TriangleTypeEnumString
    {
        public static string ToReadableString(this TriangleTypeEnum triangleTypeEnum)
        {
            switch (triangleTypeEnum)
            {
                case TriangleTypeEnum.NonExistentTriangle:
                    return "Error";

                case TriangleTypeEnum.ScaleneTriangle:
                    return "Scalene";

                case TriangleTypeEnum.IsoscelesTriangle:
                    return "Isosceles";

                case TriangleTypeEnum.EquilateralTriangle:
                    return "Equilateral";

                default:
                    return "Error";
            }
        }
    }
}