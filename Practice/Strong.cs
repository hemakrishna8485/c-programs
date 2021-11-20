using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Strong
    {
        static void Main(string[] args)
        {
            Strong s = new Strong();
            Console.WriteLine(s.IsStrongNumber(141));
        }
        public bool IsStrongNumber(int num)
        {
            int sum = 0;
            int copy = num;
            int digit;
            while (num != 0)
            {

                int fact = 1;
                digit = num % 10;
                fact = Fact(digit);
                sum = sum + fact;
                num /= 10;


            }
            return sum == copy;
        }
        public static int Fact(int digit)
        {
            int fact = 1;
            for (int i = 1; i <= digit; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}