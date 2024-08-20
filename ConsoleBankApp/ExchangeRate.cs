namespace DataCanVirtualBank{

    public class ExchangeRate{
        private string _currencyId;
        //public int Date;
        private float _rateValue;

        //Getters
        public string GetCurrencyId()
        {
            return _currencyId;
        }
        public float GetRateValue()
        {
            return _rateValue;
        }
        //Setters
        public void SetCurrencyId(string currency)
        {
            _currencyId = currency;
        }
        public void SetRateValue(float rateValue)
        {
            _rateValue = rateValue;
        }

       // public ExchangeRate()
       // {
       // }
        public ExchangeRate(string currency, float value)
        {
            this._currencyId = currency;
            this._rateValue = value;
        }
    }
}