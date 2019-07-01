using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HmWrk3_Text2
{
    class Sentence
    {
        string pattern3 = @"([A-Za-z\d\\s]+[^.!?]*[.?!\n])";
        string LongestSentence = null;
        string shortestSentence = null;
        int countSentence = 1;
        private string[] SplitTextSentence = null;

        public string[] GetSentence()
        {
            ReadWriter rw = new ReadWriter();
            string[] SplitTextSentence = new Regex(pattern3).Split(rw.ReadAndCleanText());
            return SplitTextSentence;
        }

        public string GetLongestSentence()
        {
            
            foreach (var i in GetSentence())
            {
                if (i.Length > countSentence)
                    LongestSentence = i;
                countSentence = i.Length;
            }
            return LongestSentence;
        }

        public string GetShortestSentence()
        {
            
            foreach (var i in GetSentence())
            {
                if (i.Length < countSentence)
                    shortestSentence = i;
                countSentence = i.Length;
            }
            return shortestSentence;
        }

    }
}
