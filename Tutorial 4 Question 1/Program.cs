using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_4_Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number != 0 && 60 % number == 0)
                {
                    Console.WriteLine(number + " is a factor of 60.");
                }
                else
                {
                    Console.WriteLine(number + " is not a factor of 60.");
                }

                Console.ReadLine();
            }
        }
    }
    

