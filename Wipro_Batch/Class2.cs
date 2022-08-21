using System;
using System.Collections.Generic;
using System.Text;

namespace Wipro_Batch
{
    class Class2
    {
        static void Main(string[] args)
        {


            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    if (i == 0 || i == 5 || i == 10 || i + j < 2 )

                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();


            }Console.ReadLine();
        }
    }
}



