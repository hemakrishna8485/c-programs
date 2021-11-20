using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Class3
    {
        static void Main(string[] args)
        {
            int[][] array = new int[4][];
            array[0] = new int[2] { 1, 5 };
            array[1] = new int[5] { 1, 3, 4, 5, 6 };
            array[2] = new int[6] { 4, 2, 5, 3, 6, 4 };
            array[3] = new int[6] { 4, 2, 5, 3, 6, 4 };

            for (int i=0;i<array.Length;i++)
                {

                  
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        System.Console.Write(array[i][j] + "\t");
                    }
                    System.Console.WriteLine();
                }
                Console.ReadLine();
            }
            }
        }
    


