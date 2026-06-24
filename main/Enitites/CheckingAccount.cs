

using System;
using System.Runtime.InteropServices;

namespace wee8_7_task.main.Entities; 

class CheckingAccount : Account
{
    #region properties
    public double Fees { get; set; }

    #endregion

    public CheckingAccount(string name = "Unnamed Account", double balance = 0.0, double  fees = 1.5): base(name, balance)
    {
        this.Fees = fees; 
    }

    public override bool Withdraw(double amount)
    {
        return base.Withdraw(amount + this.Fees);
    }

    public override string ToString()
    {
        return $"[Account: {this.Name}: {this.Balance}: {this.Fees}]";
    }
}
