using System;

namespace InlineIfExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt the user for input
            Console.WriteLine("There is 1 marshmallow on the table. How many marshmallows will you eat?:");

            //acquire user input
            string userInputStr = Console.ReadLine();

            //convert user input from string to integer
            int userInputInt = int.Parse(userInputStr);

            //if user input is equal to 0, integer outputInt is equal to 1; otherwise, outputInt is equal to 0.
            int outputInt = (userInputInt == 0) ? 1 : 0;

            //output information to the user
            Console.WriteLine("There are " + outputInt + " marshmallow(s) remaining on the table.");

            //keep the program open until the user presses ENTER or closes the program
            Console.ReadLine();
        }
    }
}
