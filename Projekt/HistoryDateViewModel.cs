using CurrencyViewModelNamespace;
using HttpGetNameSpace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UtilitiesNamespace;
using Windows.UI.Xaml.Controls;

namespace HistoryDateViewModelNamespace
{
    public class HistoryDateViewModel : INotifyPropertyChanged
    {
        private Windows.Storage.ApplicationDataContainer localSettings;
        private Windows.Storage.ApplicationDataCompositeValue composite;
        private const string CONTAINER_NAME = "historyOfDateSetting";
        private const string CONTAINER_DATETIME_START_FIELD = "dateTimeStart";
        private const string CONTAINER_DATETIME_END_FIELD = "dateTimeEnd";
        private DateTimeOffset dateTimeStart;
        private DateTimeOffset dateTimeEnd;
        public String normalDateTimeStart;
        public String normalDateTimeEnd;
        HttpGet http;
        public DateTimeOffset DateTimeStart
        {
            get => dateTimeStart;
            set
            {
                this.dateTimeStart = value.Date;
                Debug.WriteLine("Date time start: " + dateTimeStart);
                normalDateTimeStart = Utilities.parseDateTimeOffset(this.dateTimeStart);
                StoreData();
                this.OnPropertyChanged();
            }
        }

        public DateTimeOffset DateTimeEnd
        {
            get => dateTimeEnd;
            set
            {
                this.dateTimeEnd = value.Date;
                Debug.WriteLine("Date time End: " + dateTimeEnd);
                normalDateTimeEnd = Utilities.parseDateTimeOffset(this.dateTimeEnd);
                StoreData();
                this.OnPropertyChanged();
            }
        }

        public HistoryDateViewModel()
        {
            this.http = new HttpGet();
            localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            composite = (Windows.Storage.ApplicationDataCompositeValue)localSettings.Values[CONTAINER_NAME];
            if (composite == null)
            {
                composite = new Windows.Storage.ApplicationDataCompositeValue();
                StoreData();
            }
            else
            {
                dateTimeStart = (DateTimeOffset)composite[CONTAINER_DATETIME_START_FIELD];
                normalDateTimeStart = Utilities.parseDateTimeOffset(dateTimeStart);
                dateTimeEnd = (DateTimeOffset)composite[CONTAINER_DATETIME_END_FIELD];
                normalDateTimeEnd = Utilities.parseDateTimeOffset(dateTimeEnd);
            }
        }

        public void StoreData()
        {
            composite[CONTAINER_DATETIME_START_FIELD] = dateTimeStart;
            composite[CONTAINER_DATETIME_END_FIELD] = dateTimeEnd;
            localSettings.Values[CONTAINER_NAME] = composite;
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // Raise the PropertyChanged event, passing the name of the property whose value has changed.
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
