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
            int i = 0;
            Boolean check = false;
            while (i < input.Length)
            {
                if(Char.IsNumber(input, i) == true)
                {
                    Console.WriteLine("Your input is not within the parameters of a correct name :(");
                    Console.WriteLine("Please press any key to leave the program.");
                    i = input.Length;
                    check = true;
                }
                else
                {
                    i++;
                }
            }

            if (check == false)
            {
                Console.WriteLine("Hello " + input + "!");
            }
        }
    }
}
