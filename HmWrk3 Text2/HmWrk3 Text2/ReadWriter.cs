using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace HmWrk3_Text2
{
    
    public class ReadWriter
    {
        string sourceFilePath = @"c:/Users/User/Desktop/text.txt";
        string pattern1 = @"[\(\)\[\]\<\>\*_']";
        string pattern2 = "[\"]";
        public string ReadAndCleanText()
            {
                string text=null;
                string CleanedText = null;
            try
                {
                    if (File.Exists(sourceFilePath))
                    {
                        
                        using (StreamReader sr = new StreamReader(sourceFilePath))
                        {
                            text = sr.ReadToEnd();
                        }
                        var tx3 = Regex.Replace(text, pattern1, "");
                       CleanedText = Regex.Replace(tx3, pattern2, "");
                    
                    }
                    else Console.WriteLine("Wrong source path");
                }

            catch (Exception)
                {
                        throw;
                }

                return CleanedText;
            }

        public void WriteSentence()
        {
            Sentence sn=new Sentence();
            using (StreamWriter sw = new StreamWriter("c:/Users/User/Desktop/SplitTextSentence.txt")) //text was splited on Sentence and record in file SplitTextSentence.txt
            {
                foreach (var i in sn.GetSentence())
                {
                    i.Trim();
                    sw.WriteLine(i);
                }
            }
        }

        public void WriteLongestSentence()
        {
            Sentence sn = new Sentence();
            using (StreamWriter sw = new StreamWriter("c:/Users/User/Desktop/LongestSentence.txt"))//Longest Sentence record in file LongestSentence.txt
            {
                sw.WriteLine(sn.GetLongestSentence());
            }
        }

        public void WriteShortestSentence()
        {
            Sentence sn = new Sentence();
            using (StreamWriter sw = new StreamWriter("c:/Users/User/Desktop/ShortestSentence.txt"))//Shortest Sentence record in file LongestSentence.txt
            {
                sw.WriteLine(sn.GetShortestSentence());
            }
        }
        


        public void WriteWord()
        {
            Word wd = new Word();
            using (StreamWriter sw = new StreamWriter("c:/Users/User/Desktop/SplitTextWord.txt"))//text was splited on words and record in file SplitTextWord.txt
            {
                foreach (var i in wd.GetWords())
                {
                    i.Trim();
                    if (String.IsNullOrWhiteSpace(i) == false)
                        sw.WriteLine(i);
                }
            }
        }

        public void WritePunctMarks()
        {
            PunctMarks pm = new PunctMarks();
            using (StreamWriter sw = new StreamWriter("c:/Users/User/Desktop/SplitPunctMarks.txt")) //text was splited on punctuation marks and record in file SplitPunctMarks.txt
            {
                foreach (var i in pm.GetPunctMarks())
                {
                    if (String.IsNullOrWhiteSpace(i) == false)
                        sw.WriteLine(i);
                }
            }
        }

        public void WriteWordsOrderByAlphabet()
        {
            WordsOrderByAlphabet wAl = new WordsOrderByAlphabet();
            using (StreamWriter sw = new StreamWriter("c:/Users/User/Desktop/TextWordOrderByAlphabet.txt")) //text was splited on words and order by alphabet and record in file TextWordOrderByAlphabet.txt
            {
                foreach (var i in wAl.WordOrderByAlphabet())
                {
                    i.Replace(@"\W", "");

                    if (String.IsNullOrWhiteSpace(i) == false)
                        sw.WriteLine(i);
                }
            }
        }

        public void WriteMostСommonLetter()
        {
            Letters lt = new Letters();
            using (StreamWriter sw = new StreamWriter("c:/Users/User/Desktop/MostСommonLetter.txt")) //text was splited on Letter order by count and record in file MostСommonLetter.txt
            {
                foreach (var i in lt.GetMostСommonLetter())
                {
                    sw.WriteLine(i);
                }
            }
        }


    }
}
