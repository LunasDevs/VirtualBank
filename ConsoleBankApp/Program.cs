// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace DataCanVirtualBank{
    class Program{
        static void Main(string[] args)
        {
            //Test Customer
            var customer = new Customer();
            customer.SetId(4);
            customer.SetName("Lina");
            customer.SetLastName("Silva");
            customer.CheckingAccounts.Add(new CheckingAccount(421, 4000));
            var tstAccount = customer.CheckingAccounts[0].GetBalance();
            var txtWelcome = string.Concat("Welcome, " + customer.GetName() + " " + customer.GetLastName() + "!");
            
            //Tests:
            Console.WriteLine("Original balance in CAD: ");
            Console.WriteLine(tstAccount);
            Console.WriteLine("Updated balance in CAD: ");
            var newBalance = customer.CheckingAccounts[0].Withdraw(100.00f, "USB");
            Console.WriteLine(newBalance);
            var newBalance1 = customer.CheckingAccounts[0].Withdraw(100.00f, "MXN");
            Console.WriteLine(newBalance1);
            var newBalance2 = customer.CheckingAccounts[0].Withdraw(100.00f, "EUR");
            Console.WriteLine(newBalance);
            var newBalance3 = customer.CheckingAccounts[0].Withdraw(1.00f, "CAD");
            Console.WriteLine(newBalance3);
        }
    }
}