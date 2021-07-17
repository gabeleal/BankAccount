using System;
using BankAccount.Entities;
using System.Globalization;


namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, my name is Banky and I'll help you to make your account?");
            Console.Write("What is owner's name this account ");
            string name = Console.ReadLine();
            Console.Write("Hello " + name + ", I need to know, where you live, write your adrres here: ");
            string addres = Console.ReadLine();
            Console.Write("Thanks " + name + ", please write your National Id:");
            string id = Console.ReadLine();
            Owner owner = new Owner(name, addres, id);

            System.Console.WriteLine(owner);

            
        }

    }
}
