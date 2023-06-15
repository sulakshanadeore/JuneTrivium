using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    public class JaggedWithMutliDimensional
    {
        static void Main(string[] args)
        {
            int[][,] multijagged = new int[4][,] 
            { 
            new int[,] { { 1, 2 },{3,4},{5,6 } 
            },
            new int[,] {{ 1, 2 },{3,4},{5,6 }, { 5,7 }

            },
            new int[,] {{ 1, 2 },{3,4}
            },
            new int[,] {{ 1, 2 },{3,4},{5,6 }, { 5,7 },{6,7 },{7,8 } }
            };


            for (int i = 0; i < multijagged.Length; i++)
            {
                int x = 0;
                for (int ele = 0; ele < multijagged[i].GetLength(x); ele++)
                {
                    for (int k = 0; k < multijagged.Rank; k++)
                    {
                        Console.Write(multijagged[i][ele,k] + "\t");
                        Console.WriteLine();
                    }
                  
                   
                }
                  x++;
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
