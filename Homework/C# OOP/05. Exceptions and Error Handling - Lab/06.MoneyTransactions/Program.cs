using System;
using System.Collections.Generic;
using System.Linq;

namespace MoneyTransactions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> banksAccount = new Dictionary<int, double>();
            string[] bankAccountInfo = Console.ReadLine().Split(",");

            for (int i = 0; i < bankAccountInfo.Length; i++)
            {
                string[] currentAccountInfo = bankAccountInfo[i].Split("-");
                int currentAccountNumber = int.Parse(currentAccountInfo[0]);
                double currentBankNumber = double.Parse(currentAccountInfo[1]);
                banksAccount.Add(currentAccountNumber, currentBankNumber);
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                try
                {
                    string[] currentCommand = input.Split();
                    string action = currentCommand[0];
                    int accountN = int.Parse(currentCommand[1]);
                    int sum = int.Parse(currentCommand[2]);

                    if (action == "Deposit")
                    {
                        Deposit(accountN, sum, banksAccount);
                    }
                    else if (action == "Withdraw")
                    {
                        Withdraw(accountN, sum, banksAccount);
                    } 
                    else
                    {
                        throw new ArgumentException();
                    }
                    Console.WriteLine($"Account {accountN} has new balance: {banksAccount[accountN]:f2}");
                }
                catch (KeyNotFoundException)
                {
                    Console.WriteLine("Invalid account!");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid command!"); 
                }  
                catch (FormatException)
                {
                    Console.WriteLine("Insufficient balance!");
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
              
            }
        }

        private static void Withdraw(int accountN, int sum, Dictionary<int, double> banksAccount)
        {
            banksAccount[accountN] -= sum; 
            if (banksAccount[accountN ] < 0)
            {
                throw new FormatException();
            }
        }

        private static void Deposit(int accountN, int sum, Dictionary<int, double> banksAccount)
        {
            banksAccount[accountN] += sum;
        }
    }
}
