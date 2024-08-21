using ConsoleBankApp.Aggregates;
using System.Collections.Generic;

namespace DataCanVirtualBank{

    public class CheckingAccount: ICheckingAccountAggregate
    {
        private int _accountId;
        private float _balance;
        public readonly ICheckingAccountAggregate _checkingAggregate;

        //Getters
        public int GetAccountId()
        {
            return _accountId;
        }
        public float GetBalance()
        {
            return _balance;
        }

        //Setters
        public void SetAccountId(int accountId){
            _accountId = accountId;
        }
        public void SetBalance(float balance){
            _balance = balance;
        }

        public CheckingAccount(ICheckingAccountAggregate checkingAccountAggregate) {
            _checkingAggregate = checkingAccountAggregate;
        }
        public CheckingAccount(int id){
            this._accountId = id;
        }
        public CheckingAccount(int id, float balance){
            this._accountId = id;
            this._balance = balance;
        }

        //Deposit Method:
        public float Deposit(float amount, string currency)
        {
            switch (currency) {
                case "USD":
                   _balance = _balance + (amount / 0.50f);
                    break;
                case "MXN":
                    _balance = _balance + (amount / 10.00f);
                    break;
                case "EUR":
                    _balance = _balance + (amount / 0.25f);
                    break;
                case "CAD":
                    _balance = _balance + (amount / 1.00f);
                    break;
                default:
                    throw new ArgumentException("Currency not found.");
            }
            return _balance;
            
        }

        //Withdraw Method:
        public float Withdraw(float amount, string currency)
        {
            switch (currency)
            {
                case "USD":
                    _balance = _balance - (amount / 0.50f);
                    break;
                case "MXN":
                    _balance = _balance - (amount / 10.00f);
                    break;
                case "EUR":
                    _balance = _balance - (amount / 0.25f);
                    break;
                case "CAD":
                    _balance = _balance - (amount / 1.00f);
                    break;
                default:
                    throw new ArgumentException("Currency not found.");
            }
            return _balance;
        }
    }
}
