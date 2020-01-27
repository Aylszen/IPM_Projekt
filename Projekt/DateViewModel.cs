using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DateViewModelNamespace
{
    public class DateViewModel : INotifyPropertyChanged
    {
        private Windows.Storage.ApplicationDataContainer localSettings;
        private Windows.Storage.ApplicationDataCompositeValue composite;
        private const string CONTAINER_NAME = "currentDateSetting";
        private const string CONTAINER_DATETIME_FIELD = "dateTime";

        private DateTimeOffset dateTime;
        public String normalDate;
        public DateTimeOffset DateTime
        {
            get => dateTime;
            set
            {
                this.dateTime = value.Date;
                StoreData();
                Debug.WriteLine("Date time: " + dateTime);
                normalDate = parseDateTimeOffset();
                this.OnPropertyChanged();
            }
        }

        public DateViewModel()
        {
            localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            composite = (Windows.Storage.ApplicationDataCompositeValue)localSettings.Values[CONTAINER_NAME];
            if (composite == null)
            {
                composite = new Windows.Storage.ApplicationDataCompositeValue();
                StoreData();
            }
            else
            {
                dateTime = (DateTimeOffset)composite[CONTAINER_DATETIME_FIELD];
            }
        }

        public String parseDateTimeOffset()
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
            finalDate = newDay + "-" + newMonth +"-" + newYear;
            Debug.WriteLine("Parsed Date: " + finalDate);
            return finalDate;
        }

        public void StoreData()
        {
            composite[CONTAINER_DATETIME_FIELD] = dateTime;
            localSettings.Values[CONTAINER_NAME] = composite;
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // Raise the PropertyChanged event, passing the name of the property whose value has changed.
            Debug.WriteLine("Weszlo");
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
