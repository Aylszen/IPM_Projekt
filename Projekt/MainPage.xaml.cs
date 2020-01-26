using CurrencyNamespace;
using HttpGetNameSpace;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Projekt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        HttpGet http;
        public MainPage()
        {
            this.InitializeComponent();
            http = new HttpGet();
            start();
        }

        public async void start()
        {
            string httpGetResult = await http.httpGet(HttpGet.averageExchangeRate);
            Debug.WriteLine(httpGetResult);
            dynamic currencyData = Utilities.parseCurrencyData(httpGetResult);

        }
    }
}
