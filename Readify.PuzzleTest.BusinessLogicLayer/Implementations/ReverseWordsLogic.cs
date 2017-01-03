using Readify.PuzzleTest.BusinessLogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readify.PuzzleTest.BusinessLogicLayer.Implementations
{
    public class ReverseWordsLogic : IReverseWordsLogic
    {
        public string ReverseWords(string sentenceToReverse)
        {
            if (string.IsNullOrEmpty(sentenceToReverse) == false)
            {
                return string.Join(" ", sentenceToReverse.Split(' ').Select(_ => new String(_.Reverse().ToArray())));
            }
            return string.Empty;
            
        }
    }
}
