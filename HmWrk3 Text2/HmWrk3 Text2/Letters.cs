using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HmWrk3_Text2
{
    class Letters
    {
        string pattern7 = @"([A-Za-z])";
        public IEnumerable<string> GetMostСommonLetter()
        {
            Word wr = new Word();
            wr.GetWords();
            string[] SplitTextLetter = new Regex(pattern7).Split(wr.CleanedTextOnlyWords1); //text split  on Letters

            var MostСommonLetter = SplitTextLetter.GroupBy(g => g).OrderByDescending(i => i.Count())
                .Select(x => $"Letter:{x.Key}  Count:{x.Count()}");//Letter order by count/
            return MostСommonLetter;
        }
     }
}
