using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Class12
    {
        static void Main(string[] args)
        {
            int num = 123;
            int rev = 0;
            while (num > 0) 
            {
                int dig = num % 10;
                rev = rev * 10 + dig;
                num = num /10;
            }
            Console.WriteLine(rev);
        }
    }
}
