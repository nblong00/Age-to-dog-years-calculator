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

            // Declare variables
            // User entered age
            int humanYears;

            // Storage for dog years conversion
            int dogYears;

            // Creating boolean to control when program closes
            bool Exit = false;

            // Storage to contain user's entry to keep program open for another run at logic
            string AnswerToContinue;

            // Start of program output in console
            Console.WriteLine("Welcome, Human, to the age to dog years calculator!");
            Console.Write("How old are you? (whole number): ");
 
            while (Exit == false)
            {
                // User enters current age. Converts from string to int and stores in variable
                humanYears = Convert.ToInt32(Console.ReadLine());

                // Conversion of user entered age into dog years. Assumes 1 human year equals 15 dog years
                dogYears = humanYears * 15;

                // Buffer
                Console.WriteLine("...");

                // Pause program for 7/10 of a second
                System.Threading.Thread.Sleep(700);

                // Outputs user's entered age as dog years in the console
                Console.WriteLine("Your age in dog years is: " + dogYears);

                // Pause program for 7/10 of a second
                System.Threading.Thread.Sleep(700);

                // Asking user for entry on if they'd like the code to loop again
                Console.Write("Would you like to calculate another age to dog years? ");

                // Storing user's response
                AnswerToContinue = Console.ReadLine();

                // Testing if user wants to loop logic based on expected string responses
                if (AnswerToContinue == "yes" || AnswerToContinue == "y" || AnswerToContinue =="ye" || AnswerToContinue == "YES" || AnswerToContinue == "Y" || AnswerToContinue == "YE") {
                    
                    // Beginning of code loop again
                    Console.Write("Please type new age (whole number): ");
                    // Logic will loop back to top of WHILE statement
                } else
                {
                    // Adds blank line in console
                    Console.WriteLine();

                    // Setting 'end program' variable to true so WHILE statement does not loop
                    Exit = true;

                    // Pause program for 1/2 a second
                    System.Threading.Thread.Sleep(500);

                    // 'Thank you' message prior to program close
                    Console.WriteLine("Thanks for using the age to dog years calculator!");

                    // Pause program for 1/2 a second
                    System.Threading.Thread.Sleep(500);

                    // 'Closing' notification
                    Console.WriteLine("Program Closing");

                    // Pause program for 1 second
                    System.Threading.Thread.Sleep(1000);

                    // Buffer
                    Console.WriteLine("...");

                    // Pause for 1/2 a second
                    System.Threading.Thread.Sleep(500);
                }
            }


        }
    }
}
