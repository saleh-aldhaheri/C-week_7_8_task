using System;
using System.Collections.Generic;
using System.Security.Principal;
using wee8_7_task.main.Entities;
using wee8_7_task.main.Utilities;

namespace wee8_7_task.main; 
internal class Program
{
    static void Main()
    {
        // Accounts
        var accounts = new List<Account>();
        accounts.Add(new Account());
        accounts.Add(new Account("Larry"));
        accounts.Add(new Account("Moe", 2000));
        accounts.Add(new Account("Curly", 5000));

        AccountUtil.Display(accounts);
        AccountUtil.Deposit(accounts, 1000);
        AccountUtil.Withdraw(accounts, 2000);

        // Savings
        var savAccounts = new List<Account>();
        savAccounts.Add(new SavingsAccount());
        savAccounts.Add(new SavingsAccount("Superman"));
        savAccounts.Add(new SavingsAccount("Batman", 2000));
        savAccounts.Add(new SavingsAccount("Wonderwoman", 5000, 5.0));

        AccountUtil.Display(savAccounts);
        AccountUtil.Deposit(savAccounts, 1000);
        AccountUtil.Withdraw(savAccounts, 2000);

        // Checking
        var checkingAccounts = new List<Account>();
        checkingAccounts.Add(new CheckingAccount());
        checkingAccounts.Add(new CheckingAccount("Larry2"));
        checkingAccounts.Add(new CheckingAccount("Moe2", 2000));
        checkingAccounts.Add(new CheckingAccount("Curly2", 5000));

        AccountUtil.Display(checkingAccounts);
        AccountUtil.Deposit(checkingAccounts, 1000);
        AccountUtil.Withdraw(checkingAccounts, 2000);
        AccountUtil.Withdraw(checkingAccounts, 2000);

        // Trust
        var trustAccounts = new List<Account>();
        trustAccounts.Add(new TrustAccount());
        trustAccounts.Add(new TrustAccount("Superman2"));
        trustAccounts.Add(new TrustAccount("Batman2", 2000));
        trustAccounts.Add(new TrustAccount("Wonderwoman2", 5000, 5.0));

        AccountUtil.Display(trustAccounts);
        AccountUtil.Deposit(trustAccounts, 1000);
        AccountUtil.Deposit(trustAccounts, 6000);
        AccountUtil.Withdraw(trustAccounts, 2000);
        AccountUtil.Withdraw(trustAccounts, 3000);
        AccountUtil.Withdraw(trustAccounts, 500);

        Console.WriteLine();
    }
}