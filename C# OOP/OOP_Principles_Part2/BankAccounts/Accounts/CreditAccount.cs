namespace BankAccounts
{
    using System;

    public abstract class CreditAccount : Account
    {
        public CreditAccount(Owner owner,decimal amount, double interest, int tenorInMonths)
            : base(owner, interest, tenorInMonths)
        {
            this.OutstandingBalance = amount;
            this.Type = AccountType.Credit;
        }

        public void DepositMoney(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Amoount must be positive.");
            }
            this.OutstandingBalance -= amount;
        }
    }
}
