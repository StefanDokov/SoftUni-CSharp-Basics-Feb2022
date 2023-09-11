using System;

namespace PasswordGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passTry = Console.ReadLine();

            string pass = "s3cr3t!P@ssw0rd";

            if (passTry == pass)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
