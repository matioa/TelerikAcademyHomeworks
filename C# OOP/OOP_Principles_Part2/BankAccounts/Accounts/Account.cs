namespace BankAccounts
{
    using System;

    public abstract class Account
    {
        private int tenorInMonths;

        public Account(Owner owner, double interest, int tenorInMonths)
        {
            this.OutstandingBalance = 0;
            this.AccountOwner = owner;
            this.InterestRate = interest;
            this.TenorInMonths = tenorInMonths;
        }


        //All fields that should not be change-able once set are private.
        public AccountType Type { get; protected set; }
        public int TenorInMonths
        {
            get
            {
                return this.tenorInMonths;
            }
            set
            {
                
                if (value <=0)
                {
                    throw new ArgumentOutOfRangeException("Tenor cannot be negative.");
                }
                this.tenorInMonths = value;
            }
        }
        public decimal OutstandingBalance { get; protected set; }
        public double InterestRate { get; private set; }
        public Owner AccountOwner {get;private set;}

        public abstract decimal CalculateInterest();
    }
}
