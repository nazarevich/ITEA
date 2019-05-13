using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_cipher
{
    public static class Caesar
    {
        private static char[] Separator(string line)
        {
            int size = line.Length;
            char[] SeparatedLine = new char[size];
            for (int x = 0; x < size; x++)
            {
               SeparatedLine[x] = line [x];
            }
            return SeparatedLine;
        }
        public static char[] Encrypt(int mode, int key, string line)
        {
            if (mode == 0)
            {
                key = -key;
            }

            char[] SeparatedLine = Separator(line);
            int Size = SeparatedLine.Length;
            for (int x = 0; x < Size; x++)
            {
                int NewIndex = SeparatedLine[x] + key;
                if (key > 0)
                {
                    if (NewIndex > 90)
                    {
                        NewIndex = NewIndex - 91 + 65;
                    }
                }
                else if (key < 0)
                {
                    if (NewIndex < 65)
                    {
                        NewIndex = NewIndex + 91 - 65;
                    }
                }
                if  (SeparatedLine[x] >= 65 && SeparatedLine[x] <= 90)
                {
                    SeparatedLine[x] = (char)NewIndex;
                }
                
            }
            return SeparatedLine;
        }
    }
}
