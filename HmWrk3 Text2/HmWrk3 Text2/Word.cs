using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HmWrk3_Text2
{
    class Word
    {
        string pattern4 = @"(\b[^\s\n]*\b)";
        string pattern6 = @"[^A-Za-z\s]*|\n*";
        public string CleanedTextOnlyWords1 = null;
        public string[] GetWords()
        {
            //ReadWriter ReadWriter = new ReadWriter();
            var CleanedTextOnlyWords = Regex.Replace(ReadWriter.ReadAndCleanText(), pattern6, String.Empty);
            string[] SplitTextWord = new Regex(pattern4).Split(CleanedTextOnlyWords);
            CleanedTextOnlyWords1 = CleanedTextOnlyWords;
            return SplitTextWord;


        }
    }
}
