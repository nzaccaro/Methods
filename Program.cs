/*
 * Author: Nick Zaccaro
 * Date: 02/06/2020
 * Description: This program asks the user for a name and responds with a greeted message.
 */
using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for name
            Console.WriteLine("Please enter your name: ");

            //create a string variable from input
            string name = Console.ReadLine();

            //call greet user method to greet the user
            Greet_User(name);
        }

        //method that takes input from user and greets their input
        private static void Greet_User (string input)
        {
            //removes white spaces from string
            string result = input.Replace(" ", String.Empty);

            //create integer variable for while loop count
            int i = 0;

            //create boolean to later check if user input is clear of integers
            Boolean check = false;

            //while loop to go through the user input string to check each character for an integer
            while (i < result.Length)
            {
                //looks at the individual character in string to see if it returns true
                if(Char.IsLetter(result, i) == false)
                {
                    Console.WriteLine("Your input is not within the parameters of a correct name :(");
                    Console.WriteLine("Please press any key to leave the program.");
                    i = result.Length;
                    check = true;
                }
                else
                {
                    i++;
                }
            }

            //makes sure that the greeting display isnt shown when there is invalid input
            if (check == false)
            {
                Console.WriteLine("Hello " + input + "!");
            }
        }
    }
}
