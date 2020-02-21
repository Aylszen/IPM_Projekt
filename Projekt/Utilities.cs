using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesNamespace
{
    class Utilities
    {
        public static dynamic parseCurrencyData(string currencyData)
        {
            dynamic obj = JsonConvert.DeserializeObject<dynamic>(currencyData)[0];
            return obj;
        }

        public static dynamic parseCurrencyHistoryData(string currencyData)
        {
            dynamic obj = JsonConvert.DeserializeObject<dynamic>(currencyData);
            return obj;
        }

        public static String parseDateTimeOffset(DateTimeOffset dateTime)
        {
            String newDateTime = dateTime.Date.ToString();
            char[] charSeparatorSpace = new char[] { ' ' };
            String newDateAfterSpaceSplit = newDateTime.Split(charSeparatorSpace)[0];
            char[] charSeparatorSlash = new char[] { '/' };
            String[] newDateAfterSlashSplit = newDateAfterSpaceSplit.Split(charSeparatorSlash);
            String newDay = newDateAfterSlashSplit[1];
            String newMonth = newDateAfterSlashSplit[0];
            String newYear = newDateAfterSlashSplit[2];
            String finalDate;

            if (newDay.Length < 2)
            {
                newDay = "0" + newDay;
            }

            if (newMonth.Length < 2)
            {
                newMonth = "0" + newMonth;
            }
            finalDate = newYear + "-" + newMonth + "-" + newDay;
            Debug.WriteLine("Parsed Date: " + finalDate);
            return finalDate;
        }
    }
}
