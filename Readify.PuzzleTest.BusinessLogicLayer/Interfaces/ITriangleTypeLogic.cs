namespace Readify.PuzzleTest.BusinessLogicLayer.Interfaces
{
    public interface ITriangleTypeLogic
    {
        /// <summary>
        /// Sets the triangle type for given sides of a triangle
        /// </summary>
        /// <param name="sideA">first side of triangle</param>
        /// <param name="sideB">second side of triangle</param>
        /// <param name="sideC">thrid side of triangle</param>
        string GetTriangleType(int sideA, int sideB, int sideC);
    }
}