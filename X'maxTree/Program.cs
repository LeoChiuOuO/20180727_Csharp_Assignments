using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_maxTree
{
    class Program
    {
        // 作業3: 聖誕樹
        static void Main(string[] args)
        {
            // Solution1
            int a = 0;
            while (a++ < 5)
            {
                int b = 0;
                while (b++ < 5 - a)
                {
                    Console.Write(" ");
                }
                int c = 0;
                while (c++ < 2 * a - 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Solution2
            int i = 0;
            while (i++ < 5)
            {
                int j = 6;
                while (j-- >= i + 1)
                {
                    Console.Write(" ");
                }
                int k = 0;
                while (k++ <= j * 2)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
