using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Words_in_a_String_2
{
    public static class DelAndCount
    {
        public static string SpaceDel(string line)
        {
            line = line.Trim();
            while (line.Contains("  "))
            {
                line = line.Replace("  ", " ");
            }
            return line;
        }
    public static int WordCount(string line)
        {
       
            int spacecount = line.Split(' ').Length;
            return spacecount;
        }

    
    }
}
