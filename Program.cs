using System;
using BankAccount.Entities;
using System.Globalization;


namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Qual nome do titular da conta?");
            string name = Console.ReadLine();
            System.Console.WriteLine("Qual endereço do titular da conta?");
            string addres = Console.ReadLine();
            string ownerid = "444695";
            Owner owner = new Owner(name, addres, ownerid);

            Account acc = new Account(owner, 0.0);

            Owner owner2 = new Owner("Lais", "Rua 4, 345", "447388");
            Account acc2 = new Account(owner2, 100.0);



            Console.WriteLine("Nome do titular da conta " + acc.Number + " é " + acc.Owner.Name + " O saldo é: " + acc.Balance);
            Console.WriteLine("Nome do titular da conta " + acc2.Number + " é " + acc2.Owner.Name + " O saldo é: " + acc2.Balance);

            acc2.Transfer(acc2,100.0);

            Console.WriteLine("Nome do titular da conta " + acc.Number + " é " + acc.Owner.Name + " O saldo é: " + acc.Balance);
            Console.WriteLine("Nome do titular da conta " + acc2.Number + " é " + acc2.Owner.Name + " O saldo é: " + acc2.Balance);

        }

    }
}
