using System;
using System.Text;

namespace FullNameII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please type your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine(YourFullName(firstName, lastName));

            Console.ReadLine();
        }

        private static string YourFullName (string firstName, string lastName)
        {
            StringBuilder fullName = new StringBuilder();

            fullName.Append(firstName);
            fullName.Append(" ");
            fullName.Append(lastName);

            string fullNameStr = fullName.ToString();

            return fullNameStr;


        
        }
    }
}
