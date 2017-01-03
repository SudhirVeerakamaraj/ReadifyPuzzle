using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readify.PuzzleTest.BusinessLogicLayer.Interfaces
{
    public interface IFibonacciLogic
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputN"></param>
        /// <returns></returns>
        long GetNthNumberInFibonacciSeries(int inputN);
    }
}
