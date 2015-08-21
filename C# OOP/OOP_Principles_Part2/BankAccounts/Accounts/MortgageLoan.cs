namespace BankAccounts
{
    class MortgageLoan: CreditAccount
    {
        public MortgageLoan(Owner owner,decimal amount, double interest, int tenorInMonths)
            : base(owner, amount ,interest, tenorInMonths)
        {
        }

        public override decimal CalculateInterest()
        {
            decimal interest = 0;
            if (this.AccountOwner.Type == OwnerType.Individual )
            {
                int promoTenor = 6;
                decimal promoInterest = 0;
                decimal promoInterestAmount = promoTenor * promoInterest;

                int remainingTenor = this.TenorInMonths - promoTenor;
                decimal regularInterstAmount = (decimal)this.InterestRate * remainingTenor;

                interest = promoInterestAmount + regularInterstAmount;
            }
            else
            {
                int promoTenor = 12;
                decimal promoInterest = (decimal)this.InterestRate/2;
                decimal promoInterestAmount = promoTenor * promoInterest;

                int remainingTenor = this.TenorInMonths - promoTenor;
                decimal regularInterstAmount = (decimal)this.InterestRate * remainingTenor;

                interest = promoInterestAmount + regularInterstAmount;
            }
            return interest;
        }
    }
}
