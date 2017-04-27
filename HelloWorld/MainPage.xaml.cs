using System;
using System.Collections.Generic;
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
using Windows.Media;
using Windows.Media.SpeechSynthesis;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MPM
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private Quote.QuoteView qView;
        private TemplateView tView;

        private void lviInventory_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (tView == null)
            {
                tView = new TemplateView();
            }

            MainUserControl.Content = tView;
        }

        private void lviQuote_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (qView == null)
            {
                qView = new Quote.QuoteView();
            }

            MainUserControl.Content = qView;
        }

        private void lviEstimates_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //gridText.Text = "Estimates";
        }

        private void lviSettings_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //gridText.Text = "Settings";
        }

        private void MainUserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
