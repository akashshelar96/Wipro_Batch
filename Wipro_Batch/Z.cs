using System;
using System.Collections.Generic;
using System.Text;

namespace Wipro_Batch
{
    class Z
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    if (i == 1 || i == 10 || j>=1 && j<=10 || i+j==10)
                    if(((i==0 || i==6) || j>=0 || j<=6) || i+j==6)

                    //if(((i == 0 or i==10)and j>=0 and j<=6)or i+j==6):

                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
            Console.ReadLine();

        }
    }
}
