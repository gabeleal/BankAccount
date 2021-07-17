using System; 

namespace BankAccount.Entities
{
    public class Owner
    {
        public string Name { get; private set; }
        public string Addres { get; set; }
        public string OwnerId { get; private set; }
        public Account Account { get; private set; }
        
        public Owner(string name, string addres, string id)
        {
            Name = name;
            Addres = addres; 
            OwnerId = id;
        }
        
    }
}