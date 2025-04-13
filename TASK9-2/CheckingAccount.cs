namespace TASK9_2
{
    public class CheckingAccount : Account
    {
        const double fee = 1.50;

        public CheckingAccount(string name = "Unnamed Account", double balance = 0.0) : base(name, balance)
        {

        }
        public override bool Withdraw(double amount)
        {
            if (Balance - amount - fee >= 0)
            {
                Balance = Balance - amount - fee;
                return true;
            }
            else
            {
                return false;
            }
        }
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

    }
}
