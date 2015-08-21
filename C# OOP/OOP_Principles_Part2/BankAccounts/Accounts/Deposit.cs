namespace BankAccounts
{
    public class Deposit: DebitAccount
    {
        public Deposit(Owner owner, double interest,int tenorInMonths)
            :base(owner, interest, tenorInMonths)
        {
        }

    }
}
