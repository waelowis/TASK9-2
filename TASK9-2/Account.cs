public class Account
{
    public string Name { get; set; }
    public double Balance { get; set; }

    public Account(string name = "Unnamed Account", double balance = 0.0)
    {
        this.Name = name;
        this.Balance = balance;
    }

    public bool Deposit(double amount)
    {
        if (amount < 0)
            return false;
        else
        {
            Balance += amount;
            return true;
        }
    }

    public bool Withdraw(double amount)
    {
        if (Balance - amount >= 0)
        {
            Balance -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }
}