using Readify.PuzzleTest.BusinessLogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readify.PuzzleTest.BusinessLogicLayer.Implementations
{
    public class FibonacciLogic:IFibonacciLogic
    {
        private static double sqrt5;
        
        private static double secondConstant;
        private static double thirdConstant;
        public FibonacciLogic() {
            if (sqrt5 == 0)
            {
                sqrt5 = Math.Sqrt(5);
                secondConstant = (1 + sqrt5) / 2;
                thirdConstant = (1 - sqrt5) / 2;
            }
        }
        public long GetNthNumberInFibonacciSeries(int inputN) {
            if (inputN < -92 || inputN > 92) {
                throw new ApplicationException("Should be within the range of -92 to 92");
            }
            return Convert.ToInt64(Math.Round((Math.Pow(secondConstant, inputN) - Math.Pow(thirdConstant, inputN)) / sqrt5));
            
        }
    }
}
