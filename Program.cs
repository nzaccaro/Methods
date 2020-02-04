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
            Console.WriteLine("Hello " + input + "!");
        }
    }
}
