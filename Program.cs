using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module2_Lab1_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1- Write out an if/else statement

            Console.WriteLine("Please enter an integer value and press Enter.");

            //Enter an integer value
            int input = Int32.Parse(Console.ReadLine());

            if(input % 2 == 0)
            {
                Console.WriteLine("You entered an even number");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }

            //Part 2- The switch statement

            Console.WriteLine("Coffee sizes- 1: Small, 2: Medium, 3: Large");
            Console.Write("Please enter your choice: ");
            string choice = Console.ReadLine();
            int price = 0;

            switch (choice)
            {
                case "1":
                case "Small":
                    price += 25;
                    break;
                case "2":
                case "Medium":
                    price += 50;
                    break;
                case "3":
                case "Large":
                    price += 75;
                    break;
                default:
                    Console.WriteLine("Please enter a choice 1, 2, or 3.");
                    break;
            }
            if(price != 0)
            {
                Console.WriteLine("Please pay {0} cents", price);
            }
            Console.WriteLine("Thank you for your business");

            //Part 3- The for loop

            for(int joel = 0; joel < 10; joel++)
            {
                Console.WriteLine($"Counter is at: {joel}");
            }

            //Part 4- The nested for loop- Find all primes less than 150
        
            int robert, joseph; //Outer variable, inner variable

            for(robert = 2; robert < 150; robert++)
            {
                for(joseph = 2; joseph <= (robert/joseph); joseph++)
                {
                    if ((robert % joseph == 0))
                        break;
                }
                if(joseph > (robert / joseph))
                {
                    Console.WriteLine("{0} is prime", robert);
                }
            }

            //Part 5- While Loop

            int n = 1;
            while(n < 6)
            {
                Console.WriteLine($"Current value of n is {n}");
                n++;
            }

            //Part 6- Do While Loop 

            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 5);
            

        }
    }
}
