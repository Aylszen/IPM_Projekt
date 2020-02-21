using CurrentPageHandlerNameSpace;
using HistoryDateViewModelNamespace;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Projekt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class History : Page
    {
        public CurrentPageHandler currentPageHandler { get; set; }
        public HistoryDateViewModel historyDateViewModel { get; set; }

        public History()
        {
            this.InitializeComponent();
            this.currentPageHandler = CurrentPageHandler.getInstance();
            this.historyDateViewModel = new HistoryDateViewModel();

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
    }
}
