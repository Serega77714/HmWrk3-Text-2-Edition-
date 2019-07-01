using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HmWrk3_Text2
{
    class Word
    {
        string pattern4 = @"(\b[^\s\n]*\b)";
        string pattern6 = @"([^A-Za-z\s])";
       public string CleanedTextOnlyWords1=null;
        public string[] GetWords()
        {
            ReadWriter rw = new ReadWriter();
            var CleanedTextOnlyWords = Regex.Replace(rw.ReadAndCleanText(), pattern6, "");
            string[] SplitTextWord = new Regex(pattern4).Split(CleanedTextOnlyWords);
            CleanedTextOnlyWords1 = CleanedTextOnlyWords;
            return SplitTextWord;
            
        }
    }
}
