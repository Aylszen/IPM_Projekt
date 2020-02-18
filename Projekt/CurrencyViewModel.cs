using CurrencyNamespace;
using Projekt;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

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
            this.currencies.Clear();
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

        public void ClickItemList(object sender, ItemClickEventArgs e)
        {
            
            //bool v = Frame.Navigate(typeof(History), null);
        }
    }
}
