namespace BankAccounts
{
    using System.Collections.Generic;

    public class Owner
    {
        public Owner (int id, OwnerType type, string name)
        {
            this.ID = id;
            this.Type = type;
            this.Name = name;
            this.listOfAccounts = new List<Account>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public OwnerType Type { get; private set; }
        public List<Account> listOfAccounts { get; set; }
    }
}
