using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Class10
    {
        static void Main(string[] args)
        {
            Class10 c1 = new Class10();
            Console.WriteLine(c1.Add(10, 20));
            Console.WriteLine(c1.Add(10, 20, 30));
        }
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Add(int a, int b,int c)
        {
            return a + b + c;
        }
    }
}
