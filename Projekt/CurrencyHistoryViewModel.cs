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
    public class CurrencyHistoryViewModel
    {

        private List<Currency> currenciesHistory = new List<Currency>();
        public List<Currency> CurrenciesHistory { get { return this.currenciesHistory; } }

        public CurrencyHistoryViewModel()
        {

        }

        public void addCurrencies(dynamic CurrencyData)
        {
            this.currenciesHistory.Clear();
            foreach (dynamic CurrencyDataElement in CurrencyData.rates)
            {
                string currencyDate = CurrencyDataElement.effectiveDate;
                string currencyPrice = CurrencyDataElement.mid;
                this.currenciesHistory.Add(new Currency() { Date = currencyDate, Price = currencyPrice });
            }
        }

        public void ClickItemList(object sender, ItemClickEventArgs e)
        {
            //bool v = Frame.Navigate(typeof(History), null);
        }
    }
}
