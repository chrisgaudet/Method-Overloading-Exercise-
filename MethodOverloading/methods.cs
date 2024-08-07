using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Methods
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal decx, decimal decy)
        {
            return decx + decy;
        }

        public static string Add(int x, int y, bool withDollars)
        {
            if (withDollars && (x + y) != 1)
            {
                return $"{x + y} dollars";
            }
            else if (withDollars && (x + y) == 1)
            {
                return $"{x + y} dollar";
            }
            else
            {
                return $"{x + y}";
            }

        }
    }
}
