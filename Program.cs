using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problem6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            for (int i = 1; i <=n; i++)
            {
                for (int j = i; j <=n; j++)
                {
                    Console.Write("*");

                }

                Console.WriteLine();
            }
        Console.ReadLine();
            
        }

        
    }
}
