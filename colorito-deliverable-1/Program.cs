using System;

namespace colorito_deliverable_1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* DIRECTIONS FOR PROJECT
             * #1 Ask the user to input an amount.
             * #2 Ask the user to input a measurement type.
             * #3 Take the amount and parse it into a number variable that can handle decimals.
             * #4 Check the input units and convert the amount based on the table provided. You only need to convert a unit to its equivalent in the other system.
             * #5 After doing the conversion, ask the user if they want to do another one.
             * --If yes: loop and run through another conversion.
             * --If anything else: exit the program.
             * 
             * POINTS
             * 1 point: Ask the user to input a measurement type. Assume you will get valid inputs. --- COMPLETE
             * 1 point: Ask the user for an amount. Assume valid inputs (ex: user won't enter a string when a number is called for). --- COMPLETE
             * 1 point: Convert and store that amount from a string into a number. --- COMPLETE
             * --Hint: Use a data type that can handle decimals, as "int" cannot.
             * 1 point: Inch value is converted properly to fidget spinners value. --- COMPLETE
             * 1 point: Fidget spinners value is converted properly to inch value. --- COMPLETE
             * 1 point: Foot value is converted properly to meme value. --- COMPLETE
             * 1 point: Meme value is converted properly to foot value. --- COMPLETE
             * 1 point: Output the result of the conversion along with the correct units (for instance, if input is 1 inch, output is 3.5 fidget spinners) --- COMPLETE
             * Ask the user if they wish to do another calculation
             * 1 point: If yes... Loop back to the top of the program --- COMPLETE
             * 1 point: If anything else... End the program --- COMPLETE
             * */

            string runAnotherCalculation = "yes";

            do
            {
                Console.WriteLine("Enter a measurement type: ");
                string measurementType = Console.ReadLine();
                Console.WriteLine("Enter the amount: ");
                double amount = double.Parse(Console.ReadLine());

                if (measurementType == "inches")
                {
                    Console.WriteLine("Your conversion is: " + (amount * 3.5) + " fidget spinners");
                }
                else if (measurementType == "fidget spinners")
                {
                    Console.WriteLine("Your conversion is: " + (amount / 3.5) + " inches");
                }
                else if (measurementType == "feet")
                {
                    Console.WriteLine("Your conversion is " + (amount * 5) + " memes");
                }
                else if (measurementType == "memes")
                {
                    Console.WriteLine("Your conversion is " + (amount / 5) + " feet");
                }

                Console.WriteLine("Would you like to run another calculation?: ");
                runAnotherCalculation = Console.ReadLine();

            } while (runAnotherCalculation == "yes");



        }
    }
}