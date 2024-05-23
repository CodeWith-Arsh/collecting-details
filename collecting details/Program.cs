using System;

namespace UserProfile
{
    class EmpInfo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Data Collection Form");

            // Collecting name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Collecting email
            Console.Write("Enter your email address: ");
            string email = Console.ReadLine();

            // Collecting phone number
            Console.Write("Enter your Phone Number: ");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());

            // Displaying user profile
            Console.WriteLine("\nUser Profile:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Phone Number: " + phoneNumber);

            Console.ReadLine();

        }
    }
}