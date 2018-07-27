using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        // 作業5: 求質數
        static void Main(string[] args)
        {
            int fromNumber = 5;
            int toNumber = 300;

            while (fromNumber++ <= toNumber)
            {
                int divisor = 1;
                bool isPrimeFound = true;
                while (divisor++ < fromNumber && isPrimeFound)
                {
                    if (fromNumber % divisor == 0)
                    {
                        isPrimeFound = false;
                    }
                }
                if (isPrimeFound)
                {
                    Console.WriteLine(fromNumber);
                }
            }
        }
    }
}
