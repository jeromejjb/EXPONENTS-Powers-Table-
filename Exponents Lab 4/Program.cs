using System;

namespace Exponents_Lab_4
{
    class Program
    {

     
  
        static void Main(string[] args)
        {


            int userInput;
            string userContinue = "y";

            while (userContinue == "y")
            {
            Console.WriteLine("Enter an integer");
            userInput = Int16.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");
                if (userInput > 1 && userInput < 10)
                {
                Console.WriteLine("Number\tSquare\tCube");
                    for (int x = 0; x <= userInput; x = x + 1)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}", x, x * x, x * x * x);
                    }
                }
                else
                {
                    Console.WriteLine("invalid number try again");
                }
                Console.WriteLine("Would you like to continue? y/n");
                userContinue = Console.ReadLine();
            }
        }
    }
}


