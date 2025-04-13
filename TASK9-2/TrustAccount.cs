namespace TASK9_2
{
    public class TrustAccount : SavingsAccount
    {
        private int withdrawalsThisYear = 0;
        private const int MaxWithdrawals = 3;
        private const double MaxWithdrawPercent = 0.2;
        private const double BonusThreshold = 5000.0;
        private const double BonusAmount = 50.0;

        public TrustAccount(string name = "Unnamed Trust Account", double balance = 0.0, double interestRate = 0.0)
            : base(name, balance)
        {
        }

        public override bool Deposit(double amount)
        {
            if (amount >= BonusThreshold)
                amount += BonusAmount;

            return base.Deposit(amount);
        }

        public override bool Withdraw(double amount)
        {
            if (withdrawalsThisYear >= MaxWithdrawals)
                return false;

            if (amount > Balance * MaxWithdrawPercent)
                return false;

            if (base.Withdraw(amount))
            {
                withdrawalsThisYear++;
                return true;
            }

            return false;
        }


    }

}

