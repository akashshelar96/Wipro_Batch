﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Wipro_Batch
{
    class C
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                for(int j=1;j<=10;j++)
                {
                    if (i == 1 || i == 10 || j == 1)
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
