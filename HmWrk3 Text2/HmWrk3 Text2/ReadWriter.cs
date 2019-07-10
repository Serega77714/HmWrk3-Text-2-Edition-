using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace HmWrk3_Text2
{
    
    public static class ReadWriter
    {
        
        public static string sourceFilePath;
        static string pattern1 = @"[\(\)\[\]\<\>\*_']";
        static string  pattern2 = "[\"]";
        
        public static string ReadAndCleanText()
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

        public static void WriteSentence()
        {
            Sentence sn=new Sentence();
            using (StreamWriter sw = new StreamWriter("c:/Users/User/Desktop/Result/SplitTextSentence.txt")) //text was splited on Sentence and record in file SplitTextSentence.txt
            {
                foreach (var i in sn.GetSentence())
                {
                    i.Trim();
                    sw.WriteLine(i);
                }
            }
            Console.WriteLine("Text was splited on sentence and record in file SplitTextSentence.txt on the desktop in folder 'Result'");
        }

        public static void WriteLongestSentence()
        {
            Sentence sn = new Sentence();
            using (StreamWriter sw = new StreamWriter("c:/Users/User/Desktop/Result/LongestSentence.txt"))//Longest Sentence record in file LongestSentence.txt
            {
                sw.WriteLine(sn.GetLongestSentence());
            }
            Console.WriteLine("Longest Sentence record in file LongestSentence.txt on the desktop in folder 'Result'");
        }

        public static void WriteShortestSentence()
        {
            Sentence sn = new Sentence();
            using (StreamWriter sw = new StreamWriter("c:/Users/User/Desktop/Result/ShortestSentence.txt"))//Shortest Sentence record in file LongestSentence.txt
            {
                sw.WriteLine(sn.GetShortestSentence());
            }
            Console.WriteLine("Shortest Sentence record in file LongestSentence.txt on the desktop in folder 'Result'");
        }
        


        public static void WriteWord()
        {
            Word wd = new Word();
            using (StreamWriter sw = new StreamWriter("c:/Users/User/Desktop/Result/SplitTextWord.txt"))//text was splited on words and record in file SplitTextWord.txt
            {
                foreach (var i in wd.GetWords())
                {
                    i.Trim();
                    //if (String.IsNullOReadWriterhiteSpace(i) == false)
                        sw.WriteLine(i);
                }
            }
            Console.WriteLine("Text was splited on words and record in file SplitTextWord.txt on the desktop in folder 'Result'");
        }

        public static void WritePunctMarks()
        {
            PunctMarks pm = new PunctMarks();
            using (StreamWriter sw = new StreamWriter("c:/Users/User/Desktop/Result/SplitPunctMarks.txt")) //text was splited on punctuation marks and record in file SplitPunctMarks.txt
            {
                foreach (var i in pm.GetPunctMarks())
                {
                    
                        sw.WriteLine(i);
                }
            }
            Console.WriteLine("Text was splited on punctuation marks and record in file SplitPunctMarks.txt on the desktop in folder 'Result'");
        }

        public static void WriteWordsOrderByAlphabet()
        {
            WordsOrderByAlphabet wAl = new WordsOrderByAlphabet();
            using (StreamWriter sw = new StreamWriter("c:/Users/User/Desktop/Result/TextWordOrderByAlphabet.txt", true)) //text was splited on words and order by alphabet and record in file TextWordOrderByAlphabet.txt
            {
                foreach (var i in wAl.WordOrderByAlphabet())
                {
                    sw.WriteLine(i);
                }
                
            }

            if (ReadWriter.sourceFilePath == @"c:/Users/User/Desktop/Source/text.txt")
            {
                Console.WriteLine("Text was splited on words and order by alphabet and record in file TextWordOrderByAlphabet.txt on the desktop in folder 'Result'");
            }
            
            using (StreamWriter sw = new StreamWriter("c:/Users/User/Desktop/Result/HistoryChanges.txt", true)) //History Changes record in file HistoryChanges.txt
            {
                DirectoryInfo dinf = new DirectoryInfo("c:/Users/User/Desktop/Result/TextWordOrderByAlphabet.txt");

                sw.WriteLine("Number of new words:");
                sw.WriteLine(wAl.count);
                sw.WriteLine("Record at:");
                sw.WriteLine(dinf.LastWriteTime);
                sw.WriteLine();
                Console.WriteLine("History сhanges of file TextWordOrderByAlphabet.txt was write to file c:/Users/User/Desktop/Result/HistoryChanges.txt");
            }

        }
        
        public static void WriteMostСommonLetter()
        {
            Letters lt = new Letters();
            using (StreamWriter sw = new StreamWriter("c:/Users/User/Desktop/Result/MostСommonLetter.txt")) //text was splited on Letter order by count and record in file MostСommonLetter.txt
            {
                foreach (var i in lt.GetMostСommonLetter())
                {
                    sw.WriteLine(i);
                }
            }
            Console.WriteLine("Text was splited on Letter order by count and record in file MostСommonLetter.txt on the desktop in folder 'Result'");
        }

       

    }
}
