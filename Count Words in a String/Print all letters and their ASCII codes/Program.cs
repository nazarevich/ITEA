using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = Colorful.Console;

namespace Print_all_letters_and_their_ASCII_codes
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = default;
            for (int i = 32; i < 127; i++)
            {
                char charnum = (char)i;
                string value = $"[{i}] = {charnum}";
                //Console.WriteLine(value);
                if (i < 100)
                {
                    Console.Write($"[{i}]" + "  = " + charnum + "  ");
                }
                else
                {
                    Console.Write($"[{i}]" + " = " + charnum + "  ");
                }
                counter++;
                if (counter == 4)
                {
                    Console.Write('\n');
                    counter = 0;
                }
            }
            Console.ReadLine();
        }
    }
}