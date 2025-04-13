namespace TASK9_2
{
    public class SavingsAccount : Account
    {
        public SavingsAccount(string name = "UnNamed", double balance = 0.0, double interestRata = 0.0) : base(name, balance)
        {
            this.interestRata = interestRata;
        }

        public double interestRata { get; set; }

        public override bool Deposit(double amount)
        {
            if (amount <= 0)
                return false;
            else
            {
                Balance += amount;
                return true;
            }
        }

        public override bool Withdraw(double amount)
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
}
