using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CurrentPageHandlerNameSpace
{
    public class CurrentPageHandler : INotifyPropertyChanged
    {
        private Windows.Storage.ApplicationDataContainer localSettings;
        private Windows.Storage.ApplicationDataCompositeValue composite;
        private const string CONTAINER_NAME = "lastPageSetting";
        private const string CONTAINER_LASTPAGE_FIELD = "lastPage";
        private static CurrentPageHandler myInstance;

        private String lastOpenedPage;
        public string LastOpenedPage
        {
            get { return this.lastOpenedPage; }
            set
            {
                this.lastOpenedPage = value;
                composite["lastPage"] = value;
                this.OnPropertyChanged();
                StoreData();
            }
        }

        public CurrentPageHandler()
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
                lastOpenedPage = (String)composite[CONTAINER_LASTPAGE_FIELD];
            }
        }

        public void StoreData()
        {
            composite[CONTAINER_LASTPAGE_FIELD] = lastOpenedPage;
            localSettings.Values[CONTAINER_NAME] = composite;
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // Raise the PropertyChanged event, passing the name of the property whose value has changed.
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public static CurrentPageHandler getInstance()
        {
            if (myInstance == null)
                myInstance = new CurrentPageHandler();
            return myInstance;

        }
    }
}