using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HmWrk3_Text2
{
    class WordsOrderByAlphabet
    {
        Word wd=new Word();
        public int count;
        public IEnumerable<string> WordOrderByAlphabet()
        {
            var WordOrderByAlphabet =wd.GetWords().Where(i => !i.Contains(" ")).
                OrderBy(i => i).GroupBy(g => g).Select(x => $"Word:{x.Key}  Count:{x.Count()}");
            count = WordOrderByAlphabet.Count();
            return WordOrderByAlphabet;
        }
    }
}
