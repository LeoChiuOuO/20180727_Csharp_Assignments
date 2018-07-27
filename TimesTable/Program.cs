using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesTable
{
    class Program
    {
        // 作業2: 九九乘法表
        static void Main(string[] args)
        {
            // solution1
            int a = 1;
            while (a <= 9)
            {
                int b = 1;
                while (b <= 9)
                {
                    int c = a * b;
                    Console.Write("  " + a + "*" + b + "=");
                    if (c < 10)
                    {
                        Console.Write(" " + c);
                    }
                    else
                    {
                        Console.Write(c);
                    }
                    b++;
                }
                a++;
                Console.WriteLine();
            }

            // solution2
            int i = 1;
            while (i <= 9)
            {
                int j = 1;
                while (j <= 9)
                {
                    Console.Write($"{i}*{j}={i*j}\t"); // 意同: i + "*" + j + "=" + (i + j)
                    j++;
                }
                i++;
                Console.WriteLine();
            }
        }
    }
}
