using System;
using System.Collections.Generic;
using System.Linq;

class BankAccount
{
    public int AccountNumber { get; set; }
    public double Balance { get; set; }
}

class Program
{
    static void Main()
    {
        List<BankAccount> accounts = Console.ReadLine()
            .Split(',')
            .Select(acc =>
            {
                string[] accDetails = acc.Split('-');
                return new BankAccount
                {
                    AccountNumber = int.Parse(accDetails[0]),
                    Balance = double.Parse(accDetails[1])
                };
            })
            .ToList();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "End")
                break;

            string[] command = input.Split();
            string operation = command[0];

            try
            {
                if (operation == "Deposit")
                {
                    int accountNumber = int.Parse(command[1]);
                    double sum = double.Parse(command[2]);

                    var account = accounts.FirstOrDefault(acc => acc.AccountNumber == accountNumber);

                    if (account == null)
                    {
                        Console.WriteLine("Invalid account!");
                    }
                    else
                    {
                        account.Balance += sum;
                        Console.WriteLine($"Account {accountNumber} has new balance: {account.Balance:F2}");
                    }
                }
                else if (operation == "Withdraw")
                {
                    int accountNumber = int.Parse(command[1]);
                    double sum = double.Parse(command[2]);

                    var account = accounts.FirstOrDefault(acc => acc.AccountNumber == accountNumber);

                    if (account == null)
                    {
                        Console.WriteLine("Invalid account!");
                    }
                    else if (account.Balance < sum)
                    {
                        Console.WriteLine("Insufficient balance!");
                    }
                    else
                    {
                        account.Balance -= sum;
                        Console.WriteLine($"Account {accountNumber} has new balance: {account.Balance:F2}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid command!");
            }

            Console.WriteLine("Enter another command");
        }
    }
}