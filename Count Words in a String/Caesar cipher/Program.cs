using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter mode (Encrypt = 1/Decrypt = 0)");
            int mode = default;
            string m = Console.ReadLine();
            mode = Convert.ToInt32(m);
            Console.WriteLine("Enter key");
            int key = default;
            string k = Console.ReadLine();
            key = Convert.ToInt32(k);
           

            Console.WriteLine("Enter line");
            string line = Console.ReadLine();
            char[] test = Caesar.Encrypt(mode, key, line);
            for (int i = 0; i < test.Length; i++)
            {
                Console.Write(test[i]);
            }
            Console.ReadLine();
        }
    }
}
