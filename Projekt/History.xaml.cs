using CurrencyNamespace;
using CurrencyViewModelNamespace;
using CurrentPageHandlerNameSpace;
using HistoryDateViewModelNamespace;
using HttpGetNameSpace;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UtilitiesNamespace;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WinRTXamlToolkit.Controls.DataVisualization.Charting;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Projekt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class History : Page
    {
        CurrencyHistoryViewModel currencyHistoryViewModel { get; set; }
        public CurrentPageHandler currentPageHandler { get; set; }
        public HistoryDateViewModel historyDateViewModel { get; set; }
        HttpGet http;

        public History()
        {
            this.InitializeComponent();
            this.currentPageHandler = CurrentPageHandler.getInstance();
            this.historyDateViewModel = new HistoryDateViewModel();
            this.currencyHistoryViewModel = new CurrencyHistoryViewModel();
            http = new HttpGet();
            historyDateStart.MinDate = new DateTime(2002, 1, 2);
            historyDateStart.MaxDate = new DateTime(2020, 12, 12);
            historyDateEnd.MinDate = new DateTime(2002, 1, 2);
            historyDateEnd.MaxDate = new DateTime(2020, 12, 12);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), null);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Debug.WriteLine("Last page History");
            Currency currency = (Currency)e.Parameter;
            if (currency != null)
            {
                this.historyDateViewModel.Code = currency.ShortName;
            }
            else
            {
                //this.historyDateViewModel.Code = 
            }
            Debug.WriteLine("History, currency: " + this.historyDateViewModel.Code);
            currentPageHandler.LastOpenedPage = "History";
        }
        private void Exit_ItemClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void Back_ItemClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), null);
        }

        public async void downloadData()
        {
            string httpGetResult = await http.httpGet(HttpGet.history + this.historyDateViewModel.Code + "/"  + historyDateViewModel.normalDateTimeStart + "/" + historyDateViewModel.normalDateTimeEnd + "/");
            Debug.WriteLine("HttpGet result:" + httpGetResult);


            if (httpGetResult == null)
            {
                DisplayNoDataForThisDataAvailable();
            }
            else
            {
                dynamic CurrencyData = Utilities.parseCurrencyHistoryData(httpGetResult);
                currencyHistoryViewModel.addCurrencies(CurrencyData);
                Debug.WriteLine(currencyHistoryViewModel.CurrenciesHistory);
                (LineChart.Series[0] as LineSeries).ItemsSource = currencyHistoryViewModel.CurrenciesHistory;
            }
        }

        private void Download_Data_Button_Click(object sender, RoutedEventArgs e)
        {
            downloadData();
        }

        private async void DisplayNoDataForThisDataAvailable()
        {
            ContentDialog noWifiDialog = new ContentDialog
            {
                Title = "No data",
                Content = "No data available for this period",
                CloseButtonText = "Ok"
            };

            ContentDialogResult result = await noWifiDialog.ShowAsync();
        }
    }
}
