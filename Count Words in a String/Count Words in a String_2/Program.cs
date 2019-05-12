using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;
using Count_Words_in_a_String_2;

namespace Count_Words_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                string line = default;
                Console.WriteLine("Choose: FILE = 1(D:1.txt); Console Input = 2; Exit = Any Other Number", Color.Green);
                string Choose = Console.ReadLine();
                int Choose1 = Convert.ToInt32(Choose);

                if (Choose1 == 1)
                {
                    line = File.ReadAllText(@"D:\\3.txt");
                }
                else if (Choose1 == 2)
                {
                    Console.WriteLine("Enter string");
                    line = Console.ReadLine();
                }
                else
                {
                    break;
                }
                
                line = DelAndCount.SpaceDel(line);
                
                

                Console.WriteLine(line);
                Console.WriteLine("Word Count = " + DelAndCount.WordCount(line), Color.Red);

                int count = WordsCounter.WordSeparator(line).Length;
                Console.WriteLine("Word Count 2 = " + count, Color.Yellow);
                Console.WriteLine("Statistics of the words", Color.Blue);
                WordsCounter.WordStatPrint(line);
                //int len = WordsCounter.WordLength(count, WordsCounter.WordSeparator(line));
                //Console.WriteLine(len);
            }

           

        }
    }
}
