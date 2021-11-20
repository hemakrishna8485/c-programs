using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Class2
    {
        static void Main(string[] args)
        {
            {
                int[,] arr = { { 2, 3 }, { 4, 5 }, { 6, 7 } ,{ 8, 9 } };

                Console.WriteLine(arr[0, 0] );
                Console.WriteLine(arr[0,1]);
                Console.WriteLine(arr[1, 0]);
                Console.WriteLine(arr[1, 1]);
                Console.WriteLine(arr[2, 0]);
                Console.WriteLine(arr[2, 1]);
                Console.WriteLine(arr[3, 0]);
                Console.WriteLine(arr[3, 1]);


            }

        }
    }
}
