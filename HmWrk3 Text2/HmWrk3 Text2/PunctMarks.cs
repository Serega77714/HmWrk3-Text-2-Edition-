using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HmWrk3_Text2
{
    class PunctMarks
    {
        string pattern5 = @"([,.!?:;])";

        public string[] GetPunctMarks()
        {
            //ReadWriter ReadWriter = new ReadWriter();
            string[] SplitPunctMarks = new Regex(pattern5).Split(ReadWriter.ReadAndCleanText());
            return SplitPunctMarks;
        }
    }
}
