﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Words_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                string line = default;
                Console.WriteLine("Choose: FILE = 1(D:1.txt); Console Input = 2; Exit = Any Other Number");
                string Choose = Console.ReadLine();
                int Choose1 = Convert.ToInt32(Choose);

                if (Choose1 == 1)
                {
                    line = File.ReadAllText(@"D:\\1.txt");
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

                int spasecount = line.Split(' ').Length - 1;

                Console.WriteLine(spasecount + 1);
            }



        }
    }
}
