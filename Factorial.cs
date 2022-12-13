using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Factorial
    {

       public  int n = 10;
       public  int m = 20;

        public int Num(int n)
        {
           int result = 1;
            for (int i = 1; i < n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
