using System.Dynamic;
using System.Reflection.Metadata.Ecma335;

namespace wee8_7_task.main.Entities; 

class TrustAccount : Account
{
    #region attribute
    private const int MaxWithdrawals = 3;

    #endregion 
    
    #region properties
    public double InterestRate { get; set; }
    private int NumOfWithdrawals { get; set; }
    private int LastWithdrawalYear { get; set; }

    #endregion

    public TrustAccount(string name = "Unnamed Account", double balance = 0.0, double interestRate = 1.5): base(name, balance)
    {
        InterestRate = interestRate;
    }

    public override bool Deposit(double amount)
    {
        if (amount <= 0)
            return false;

        amount += amount * (InterestRate / 100.0);

        if (amount >= 5000)
            amount += 50;

        return base.Deposit(amount);
    }

    public override bool Withdraw(double amount)
    {

        if (LastWithdrawalYear != DateTime.Now.Year)
        {
            NumOfWithdrawals = 0;
            LastWithdrawalYear = DateTime.Now.Year;
        }

        if (NumOfWithdrawals >= MaxWithdrawals)
            return false;

        if (amount > Balance * 0.2)
            return false;

        if (base.Withdraw(amount))
        {
            NumOfWithdrawals++;
            return true;
        }

        return false;
    }

    public override string ToString()
    {
        return $"[Account: {this.Name}: {this.Balance}: {this.InterestRate}]";
    }
}