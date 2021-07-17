using System; 

namespace BankAccount.Entities 
{
    public class Account
    {
        public string Number { get; private set; }
        public double Balance { get; private set; }
        public Owner Owner { get; set; }
              
        
        public Account(Owner owner, double value)
        {
            Random rnd = new Random();   
            Number = rnd.Next(9999).ToString("D5");
            Deposit(value); 
            Owner = owner;
        }

        public void Deposit(double value){
            Balance += value;
        }
        public void WithDraw(double value)
        {
            Balance -= value;
        }
        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Account)){
                return false;
            }
            Account other = obj as Account;
            return Number.Equals(other.Number);
        }
        public void Transfer(Account account, double value){
            if (Equals(account) == false){
                account.Deposit(value);
                WithDraw(value);               
            }
            else
            {
                Console.WriteLine("Operation is not allowed");
            }

        }
                
        
        
        
    }
}