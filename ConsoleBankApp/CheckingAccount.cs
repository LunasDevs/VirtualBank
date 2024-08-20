using System.Collections.Generic;

namespace DataCanVirtualBank{

    public class CheckingAccount{
        private int _accountId;
        private float _balance;
        //public List<ExchangeRate> ExchangeRates = new List<ExchangeRate>();
        
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

        public CheckingAccount(){}
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
            if (currency.Equals("USD"))//ExchangeRates[0].GetCurrencyId()))
            {
                _balance = _balance + (amount * 0.50f);//ExchangeRates[0].GetRateValue());
            }else if(currency.Equals("MXN"))
            {
                _balance = _balance + (amount * 10.00f);
            }else if(currency.Equals("EUR"))
            {
                _balance = _balance + (amount * 0.25f);
            }else if(currency.Equals("CAD"))
            {
                _balance = _balance + (amount * 1.00f);
            }else{
                throw new ArgumentException("Currency","Currency not valid");
            }
            return _balance;                     
        }

        //Withdraw Method:
        public float Withdraw(float amount, string currency)
        {
            if (_balance < 0)
                throw new ArgumentException("Balance","Your current balance does not allow you to perform the transaction");

                if (currency.Equals("USD"))
                {
                    _balance = _balance - (amount * 0.50f);
                }else if(currency.Equals("MXN"))
                {
                    _balance = _balance - (amount * 10.00f);
                }else if(currency.Equals("EUR"))
                {
                    _balance = _balance - (amount * 0.25f);
                }else if(currency.Equals("CAD"))
                {
                    _balance = _balance - (amount * 1.00f);
                }else{
                    throw new ArgumentException("Currency","Currency not valid");
                }
                return _balance;
        }
    }
}

/*
  public static class Globals{
        private static readonly List<ExchangeRate> ExchangeRates = new();
        //List<ExchangeRate> ExchangeRates = new List<ExchangeRate>();
        {
            List<ExchangeRate>
        }
    }
        /*public ExchangeRate usd;
            usd = new ExchangeRate("USD",0.50f);
            ExchangeRates.Add(usd);
            var mxn = new ExchangeRate("MXN",10.0f);
        ExchangeRates.Add(mxn);
        var eur = new ExchangeRate("EUR",0.25f);
        ExchangeRates.Add(eur);
        var cad = new ExchangeRate("CAD",1.00f);
        ExchangeRates.Add(cad);
    }*/
