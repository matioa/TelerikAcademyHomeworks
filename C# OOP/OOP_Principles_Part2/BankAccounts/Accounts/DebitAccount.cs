namespace BankAccounts
{
    using System;

    public abstract class DebitAccount: Account
    {
        public DebitAccount(Owner owner, double interest, int tenorInMonths)
            :base(owner, interest,tenorInMonths)
        {
            this.Type = AccountType.Debit;
        }

        public override decimal CalculateInterest()
        {
            if (this.OutstandingBalance < 1000)
            {
                return 0;
            }

            decimal interest = 0;
            interest = (decimal)(this.TenorInMonths * this.InterestRate);
            return interest;
        }

        public void DepositMoney(decimal amount)
        {
            if (amount<0)
            {
                throw new ArgumentOutOfRangeException("Amoount must be positive.");
            }
            this.OutstandingBalance += amount;
        }

        public void WithDrawMoney(decimal amount)
        {
            if (amount <0)
            {
                throw new ArgumentOutOfRangeException("Amoount must be positive.");
            }
            this.OutstandingBalance -= amount;
        }

    }
}
