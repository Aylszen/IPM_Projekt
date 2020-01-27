using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyNamespace
{
    public class Currency
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Price { get; set; }
        public string CountryImage { get; set; }

        public const string imagePathFirst = "https://www.countryflags.io/";
        public const string imagePathSecond = "/flat/64.png";
        public Currency()
        {

        }
        public Currency(String Name, String ShortName, String Price)
        {
            this.Name = Name;
            this.ShortName = ShortName;
            this.Price = Price;
        }
    }
    public class CurrencyViewModel{

        private ObservableCollection<Currency> currencies = new ObservableCollection<Currency>();
        public ObservableCollection<Currency> Currencies { get { return this.currencies; } }

        public CurrencyViewModel()
        {

        }

        public void addCurrencies(dynamic CurrencyData)
        {
            foreach(dynamic CurrencyDataElement in CurrencyData.rates)
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
