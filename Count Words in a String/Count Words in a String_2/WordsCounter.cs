using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;

namespace Count_Words_in_a_String_2
{
    public static class WordsCounter
    {
        public static string[] WordSeparator(string line)
        {
            String[] Words = line.Split(' ');
            return Words;
        }

      
        private static int[] WordLength(int size, string[] Words)
        {
            int[] WordsStat = new int[size];
            for (int i = 0; i < size; i++)
            {
                WordsStat[i] = Words[i].Length;
            }
            return WordsStat;
        }

        private static int[] SortArray(int[] WordLength)
        {
            int size = WordLength.Length;
            int temp = default;
            for (int x = 0; x < size - 1; x++)
            {
                for (int y = x + 1; y < size; y++)
                {
                    if (WordLength[x] > WordLength[y])
                    {
                        temp = WordLength[x];
                        WordLength[x] = WordLength[y];
                        WordLength[y] = temp;
                    }
                }
                
            }
            return WordLength;
        }

        public static void WordStatPrint(string line)
        {
            string[] SeparateedWords = WordSeparator(line);
            int Size = SeparateedWords.Length;
            int[] WordStat = WordLength(Size, SeparateedWords);
            int[] SortedWordLength = SortArray(WordStat);
           
            
            int counter = 1;
            
            for (int i = 0; i < Size; i++)
            {
                if (i == Size - 1)
                {
                    Console.WriteLine("Words with length " + SortedWordLength[i] + " = " + counter,Color.Blue);
                    counter = 1;
                    break;
                }
                else
                {
                    for (int y = i + 1; y < Size; y++)
                    {
                        if (SortedWordLength[i] == SortedWordLength[y])
                        {
                            counter++;
                        }
                        else
                        {
                            //counter++;
                            Console.WriteLine("Words with length " + SortedWordLength[i] + " = " + counter,Color.Blue);
                            counter = 1;
                            i = y - 1;
                            break;

                        }

                    }
                }
                

                   
               
            }
        }
    }

}
