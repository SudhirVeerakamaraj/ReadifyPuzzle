using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readify.PuzzleTest.BusinessLogicLayer.Interfaces
{
    public interface IReverseWordsLogic
    {
        /// <summary>
        /// Reverses everyword of the sentence
        /// </summary>
        /// <param name="sentenceToReverse">Input sentence which need to be reversed</param>
        /// <returns>Reversed sentence</returns>
        string ReverseWords(string sentenceToReverse);
    }
}
