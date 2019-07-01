using System;
using System.Linq;

namespace HmWrk3_Text2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To do homework 3, place the file for processing text.txt on the desktop");
            Console.WriteLine("Press 1 to write the text into sentences");
            Console.WriteLine("Press 2 to write the text into words");
            Console.WriteLine("Press 3 to write the text into punctuation");
            Console.WriteLine("Press 4 to write words in alphabetical order with the number of uses");
            Console.WriteLine("Press 5 to write the longest sentence by the number of characters");
            Console.WriteLine("Press 6 to write the shortest sentence by the number of characters");
            Console.WriteLine("Press 7  to write a list of used letters descending from the number of their use");


            ReadWriter rw = new ReadWriter();

            string con = "Y";
            for (; con == "Y" || con == "y";)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                    { rw.WriteSentence(); Console.WriteLine("Text was splited on sentence and record in file SplitTextSentence.txt on the desktop"); }
                        break;
                    case "2":
                    { rw.WriteWord(); Console.WriteLine("Text was splited on words and record in file SplitTextWord.txt on the desktop"); }
                        break;
                    case "3":
                    { rw.WritePunctMarks(); Console.WriteLine("Text was splited on punctuation marks and record in file SplitPunctMarks.txt on the desktop"); }
                        break;
                    case "4":
                    { rw.WriteWordsOrderByAlphabet(); Console.WriteLine("Text was splited on words and order by alphabet and record in file TextWordOrderByAlphabet.txt on the desktop"); }
                        break;
                    case "5":
                    { rw.WriteLongestSentence(); Console.WriteLine("Longest Sentence record in file LongestSentence.txt on the desktop"); }
                        break;
                    case "6":
                    { rw.WriteShortestSentence(); Console.WriteLine("Shortest Sentence record in file LongestSentence.txt on the desktop"); }
                        break;
                    case "7":
                    { rw.WriteMostСommonLetter(); Console.WriteLine("Text was splited on Letter order by count and record in file MostСommonLetter.txt on the desktop"); }
                        break;
                }
            Console.WriteLine("Will you continue?-Y/N");
            con = Console.ReadLine();
            }

        }
    }
}
