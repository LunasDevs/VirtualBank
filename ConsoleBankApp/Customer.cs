using System.Collections.Generic;

namespace DataCanVirtualBank
{
    public class Customer
    {
        private int _id;
        private string _name;
        private string _lastName;
        public readonly List<CheckingAccount> CheckingAccounts = new List<CheckingAccount>();


        //Getters
        public int GetId()
        {
            return _id;
        }
        public string GetName()
        {
            return _name;
        }
        public string GetLastName()
        {
            return _lastName;
        }
        //Setters
        public void SetId(int id)
        {
            _id = id;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public void SetLastName(string lastName)
        {
            _lastName = lastName;
        }

        //Constructors
        public Customer()
        {
        }
        public Customer(int id)
        {
            this._id = id;
        }
        public Customer(int id, string name, string lastName)
            : this(id)
        {
            this._name = name;
            this._lastName = lastName;
        }
    }
}