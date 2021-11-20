using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Class4
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[4];
            Numbers[0] = 1;
            Numbers[1] = 5;
            Numbers[2] = 10;
            Numbers[3] = 15;
            int i = 0;
            while (i < Numbers.Length)
            {
                Console.WriteLine(Numbers[i]);
                i++;
            }
            Console.ReadLine();
        }
    }
}