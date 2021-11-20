using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Perfect
    {

        static void Main(string[] args)
        {
            Perfect p = new Perfect();
            Console.WriteLine(p.ISPerfectNumber(496));
        }
        public bool ISPerfectNumber(int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            return sum == num;
        }
    }
}