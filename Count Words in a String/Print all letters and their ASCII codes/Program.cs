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
            
            
            for (int i = 0; i < 127; i++)
            {
                char charnum = (char)i;
                string value = $"[{i}] = {charnum}";
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
