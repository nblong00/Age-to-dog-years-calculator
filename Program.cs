using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_to_dog_years_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int humanYears;
            int dogYears;

            bool Exit = false;

            string AnswerToContinue;

            Console.WriteLine("Welcome, Human, to the age to dog years calculator!");
            Console.Write("How old are you? (whole number): ");

            while (Exit == false)
            {
                humanYears = Convert.ToInt32(Console.ReadLine());

                dogYears = humanYears * 15;

                Console.WriteLine("...");

                System.Threading.Thread.Sleep(700);

                Console.WriteLine("Your age in dog years is: " + dogYears);

                System.Threading.Thread.Sleep(700);

                Console.Write("Would you like to calculate another age to dog years? ");

                AnswerToContinue = Console.ReadLine();

                if (AnswerToContinue == "yes" || AnswerToContinue == "y" || AnswerToContinue =="ye" || AnswerToContinue == "YES" || AnswerToContinue == "Y" || AnswerToContinue == "YE") {

                    Console.Write("Please type new age (whole number): ");

                } else
                {
                    Console.WriteLine();

                    Exit = true;

                    System.Threading.Thread.Sleep(500);

                    Console.WriteLine("Thanks for using the age to dog years calculator!");

                    System.Threading.Thread.Sleep(500);

                    Console.WriteLine("Program Closing");

                    System.Threading.Thread.Sleep(1000);

                    Console.WriteLine("...");

                    System.Threading.Thread.Sleep(500);
                }
            }


        }
    }
}
