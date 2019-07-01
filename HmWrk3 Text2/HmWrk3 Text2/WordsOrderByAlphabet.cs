using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HmWrk3_Text2
{
    class WordsOrderByAlphabet
    {
        Word wr=new Word();

        public IEnumerable<string> WordOrderByAlphabet()
        {
            var WordOrderByAlphabet =wr.GetWords().Where(i => !i.Contains(" ")).
                OrderBy(i => i).GroupBy(g => g).Select(x => $"Word:{x.Key}  Count:{x.Count()}");
            return WordOrderByAlphabet;
        }
    }
}
