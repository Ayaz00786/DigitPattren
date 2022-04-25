using System;
using System.Collections.Generic;
using System.Text;

namespace DigitPattren
{
    internal class Class1
    {

        public static void pattern1()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
