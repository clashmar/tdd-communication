using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_communication
{
    public class Kata3
    {
        public static int SumCodes(string input)
        {
            int total = 0;

            foreach (char c in input)
            {
                total += (int)c;
            }

            return total;
        }
    }
}
