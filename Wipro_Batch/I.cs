﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Wipro_Batch
{
    class I
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=10;i++)
            {
                for(int j=1;j<=10;j++)
                {
                    if (i == 1 || i == 10 || j == 5)
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
