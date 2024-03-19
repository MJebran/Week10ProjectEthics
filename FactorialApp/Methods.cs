using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialApp
{
    public class Methods
    {
        public static long CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * CalculateFactorial(n - 1);
        }
    }
}
