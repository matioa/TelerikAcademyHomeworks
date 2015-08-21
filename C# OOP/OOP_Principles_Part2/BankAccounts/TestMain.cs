using System;
using System.Collections.Generic;
using System.Linq;

namespace BankAccounts
{
    class TestMain
    {
        static void Main()
        {
            Owner Peter = new Owner(223, OwnerType.Individual, "Peter Bambukov");
            Owner AstraOOD = new Owner(555, OwnerType.Company, "Astra OOD");

            Deposit peterDeposit = new Deposit(Peter, 3, 24);
            MortgageLoan peterMortgate = new MortgageLoan(Peter,25000 ,5.7, 120);


            Peter.listOfAccounts.Add(peterDeposit);
            Peter.listOfAccounts.Add(peterMortgate);

            peterDeposit.DepositMoney(300);
            peterDeposit.WithDrawMoney(120);
            peterMortgate.DepositMoney(300);

            Console.WriteLine("Deposit Interst: {0}",peterDeposit.CalculateInterest());
            Console.WriteLine("Deposit Balance: {0}",peterDeposit.OutstandingBalance);
            Console.WriteLine("Mortgage Balance: {0}",peterMortgate.OutstandingBalance);

            peterDeposit.DepositMoney(1000);

            Console.WriteLine();
            Console.WriteLine("Deposit Interst: {0}", peterDeposit.CalculateInterest());
            Console.WriteLine("Deposit Balance: {0}", peterDeposit.OutstandingBalance);
            Console.WriteLine("Mortgage Interest: {0}", peterMortgate.CalculateInterest());
            
        }
    }
}
