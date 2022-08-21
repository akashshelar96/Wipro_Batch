using System;
using System.Collections.Generic;
using System.Text;

namespace Wipro_Batch
{
    class V
    {
        static void Main(string[] args)
        {
         
            for (int i= 0; i <= 9;i++)
                {
                for(int j=0; j<=9; j++)
                {
                    if (j + i <= 4 || j - i < -4 || j + i >= 14 || j - i >= 5)

                    {
                        Console.Write("*");
                    }
                    if (i == 0 && j == 5)
                        Console.Write("&");
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
