using System;
using System.Collections.Generic;
using System.Text;

namespace Wipro_Batch
{
    class B
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=11;i++)
            {
                for(int j=1;j<=10;j++)
                {
                    if (i == 1 || i == 11||j==1||j==10||i==6)
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
