using System;
using System.Collections.Generic;
using System.Text;

namespace Wipro_Batch
{
    class Switchcase
    {
        static void Main(string[] args)
        
         
            {
                Console.WriteLine("Enter a number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a second number");
                int num2 = int.Parse(Console.ReadLine());

                char ch;
                do
                {
                    Console.WriteLine("Enter the choice");
                    Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplicatoin\n4.Division\n");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Addition=" + (num1 + num2));
                            break;
                        case 2:
                            Console.WriteLine("Subtraction=" + (num1 - num2));
                            break;
                        case 3:
                            Console.WriteLine("Multiplication=" + (num1 * num2));
                            break;
                        case 4:
                            Console.WriteLine("Division=" + (num1 / num2));
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;


                    }
                    Console.WriteLine("Do u want to continue......");
                    ch = Convert.ToChar(Console.ReadLine());
                } while (ch == 'Y' || ch == 'y');
            }
        
    }
}
    