using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace HmWrk3_Text2
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dirInfo = new DirectoryInfo("c:/Users/User/Desktop/Source");
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            DirectoryInfo dirInfo1 = new DirectoryInfo("c:/Users/User/Desktop/Result");
            if (!dirInfo1.Exists)
            {
                dirInfo1.Create();
            }
            
            Console.WriteLine("To do homework 3, put the file for processing text.txt on c:/Users/User/Desktop/Source/");
            Console.WriteLine("Press 1 to write the text into sentences");
            Console.WriteLine("Press 2 to write the text into words");
            Console.WriteLine("Press 3 to write the text into punctuation");
            Console.WriteLine("Press 4 to write words in alphabetical order with the number of uses");
            Console.WriteLine("Press 5 to write the longest sentence by the number of characters");
            Console.WriteLine("Press 6 to write the shortest sentence by the number of characters");
            Console.WriteLine("Press 7  to write a list of used letters descending from the number of their use");
            Console.WriteLine();
            Console.WriteLine("New file  *.txt you can put in a folder c:/Users/User/Desktop/Source/");


            Watcher wr = new Watcher();
            wr.Run();
            ReadWriter.sourceFilePath = @"c:/Users/User/Desktop/Source/text.txt";
            //ReadWriter ReadWriter = new ReadWriter();
            //ReadWriter.sourceFilePath = @"c:/Users/User/Desktop/Source/text.txt";

            string con = "Y";
            for (; con == "Y" || con == "y";)
            {
               
                    
                switch (Console.ReadLine())
                {
                    case "1":
                    { ReadWriter.sourceFilePath = @"c:/Users/User/Desktop/Source/text.txt";
                        Thread thread1 = new Thread(ReadWriter.WriteSentence);
                     thread1.Start();

                    }
                        break;
                    case "2":
                    { ReadWriter.sourceFilePath = @"c:/Users/User/Desktop/Source/text.txt";
                        Thread thread2 = new Thread(ReadWriter.WriteWord);
                        thread2.Start();

                    }
                        break;
                    case "3":
                    {
                        ReadWriter.sourceFilePath = @"c:/Users/User/Desktop/Source/text.txt";
                        Thread thread3 = new Thread(ReadWriter.WritePunctMarks);
                        thread3.Start();
                        
                    }
                        break;
                    case "4":
                    { ReadWriter.sourceFilePath = @"c:/Users/User/Desktop/Source/text.txt";
                        Thread thread4 = new Thread(ReadWriter.WriteWordsOrderByAlphabet);
                        thread4.Start();
                        Console.WriteLine("Wait until the end of the process, otherwise you may get an exception...");
                    }
                        break;
                    case "5":
                    { ReadWriter.sourceFilePath = @"c:/Users/User/Desktop/Source/text.txt";
                        Thread thread5 = new Thread(ReadWriter.WriteLongestSentence);
                        thread5.Start();
                    }
                        break;
                    case "6":
                    { ReadWriter.sourceFilePath = @"c:/Users/User/Desktop/Source/text.txt";
                        Thread thread6 = new Thread(ReadWriter.WriteShortestSentence);
                        thread6.Start();

                    }
                        break;
                    case "7":
                    { ReadWriter.sourceFilePath = @"c:/Users/User/Desktop/Source/text.txt";
                        Thread thread7 = new Thread(ReadWriter.WriteMostСommonLetter);
                        thread7.Start();
                    }
                        break;
                    default:
                        Console.WriteLine("incorrect number");
                        break;

                }
                Console.WriteLine("Will you continue?-Y/N");
                con = Console.ReadLine();
                while (con != "Y" & con != "y" & con != "N" & con != "n")
                {
                    Console.WriteLine("Input Y or N");
                    con = Console.ReadLine();
                }
                wr.con = con;

            }

        }
    }
}
