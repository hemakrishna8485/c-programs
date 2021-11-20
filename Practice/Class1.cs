using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Class1
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine(array[0] = 10);
            Console.WriteLine(array[1] = 20);
            Console.WriteLine(array[2] = 30);
            Console.WriteLine(array[3] = 40);
            Console.WriteLine(array[4] = 50);

            foreach(int a in array)
            {
                Console.Write("   s "+a);                                                                                                                                                                                                                                                                                                                                  
            }
        }
    }
}
