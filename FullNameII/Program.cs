using System;
using System.Text;

namespace FullNameII
{
    class Program
    {
        static void Main(string[] args)
        {
            //This method is asking user to enter in their first & last name to string them
            Console.WriteLine("Please type your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please type your last name:");
            string lastName = Console.ReadLine();

            //Telling system to string names and 'setting up' the next method
            Console.WriteLine(YourFullName(firstName, lastName));

            Console.ReadLine();
        }

        private static string YourFullName (string firstName, string lastName)
        {
            //Initializing StringBuilder
            StringBuilder fullName = new StringBuilder();

            //Adding names to string along with a space inbetween
            fullName.Append(firstName);
            fullName.Append(" ");
            fullName.Append(lastName);

            //prompting to convert stringbuilder to string 
            string fullNameStr = fullName.ToString();

            //intertwining both methods
            return fullNameStr;


        
        }
    }
}
