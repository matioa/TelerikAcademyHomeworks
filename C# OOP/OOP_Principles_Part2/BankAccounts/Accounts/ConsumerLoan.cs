namespace BankAccounts
{
    public class ConsumerLoan : CreditAccount
    {
        public ConsumerLoan(Owner owner, decimal amount, double interest, int tenorInMonths)
            : base(owner, amount,interest, tenorInMonths)
        {
        }

        public override decimal CalculateInterest()
        {
            decimal interest = 0;
            int interestFreePeriod = 0;
            if (this.AccountOwner.Type == OwnerType.Individual )
            {
                interestFreePeriod = 3;
                int interstBearingPeriod = this.TenorInMonths - interestFreePeriod;
                interest = (decimal)this.InterestRate * interstBearingPeriod;
            }
            else
            {
                interestFreePeriod = 2;
                int interstBearingPeriod = this.TenorInMonths - interestFreePeriod;
                interest = (decimal)this.InterestRate * interstBearingPeriod;
            }
            return interest;
        }
    }
}
