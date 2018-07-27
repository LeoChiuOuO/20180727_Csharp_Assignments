using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum1to100     
{
    class Program
    {
        // 作業1: 從1到100共100個整數的總和
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 0;
            while (i <= 100)
            {
                sum += i;   // 意同 sum = sum + i;
                i++;
            }
            Console.WriteLine(sum);
        }
    }
}
