using CurrencyNamespace;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyViewModelNamespace
{
    public class CurrencyViewModel
    {

        private ObservableCollection<Currency> currencies = new ObservableCollection<Currency>();
        public ObservableCollection<Currency> Currencies { get { return this.currencies; } }

        public CurrencyViewModel()
        {

        }

        public void addCurrencies(dynamic CurrencyData)
        {
            foreach (dynamic CurrencyDataElement in CurrencyData.rates)
            {
                string currencyName = CurrencyDataElement.currency;
                string currencyShortName = CurrencyDataElement.code;
                string currencyPrice = CurrencyDataElement.mid;
                string tempCurrencyCode = CurrencyDataElement.code;
                string currencyCode = tempCurrencyCode.Remove(tempCurrencyCode.Length - 1);
                this.currencies.Add(new Currency() { Name = currencyName, ShortName = currencyShortName, Price = currencyPrice, CountryImage = Currency.imagePathFirst + currencyCode.ToLower() + Currency.imagePathSecond});
            }
        }
    }
}
