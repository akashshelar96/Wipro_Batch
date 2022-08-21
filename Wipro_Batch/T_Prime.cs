using System;
using System.Collections.Generic;
using System.Text;

namespace Wipro_Batch
{
    class T_Prime
    {

        static void printtwinprime(int n)
        {
            bool[] prime = new bool[n + 1];

            for (int i = 0; i < n + 1; i++)
                prime[i] = true;

            for (int p = 2; p * p <= n; p++)
            {
               
                if (prime[p] == true)
                {

                   
                    for (int i = p * 2; i <= n; i += p)
                        prime[i] = false;
                }
            }
                for (int i = 2; i <= n - 2; i++)
            {
                if (prime[i] == true && prime[i + 2] == true)
                    Console.Write(" (" + i + ", " + (i + 2) + ")");
            }
        }

        public static void Main()
        {
            
            int n = 500;           
            printtwinprime(n);
        }
    }
}
