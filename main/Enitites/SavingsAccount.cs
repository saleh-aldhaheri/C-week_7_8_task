using System;

namespace wee8_7_task.main.Entities; 

class SavingsAccount : Account
{
    #region properties
    public double InterestRate { get; set; }

    #endregion

    public SavingsAccount(string name = "Unnamed Account", double balance = 0.0, double  interestRate = 1.5): base(name, balance)
    {
        this.InterestRate = interestRate; 
    }
    
    public override bool Deposit(double amount)
    {
        amount += amount * (this.InterestRate / 100.0);
        
        return base.Deposit(amount);
    }
    
    public override string ToString()
    {
        return $"[Account: {this.Name}: {this.Balance}: {this.InterestRate}]";
    }
}