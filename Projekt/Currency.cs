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
    

}
