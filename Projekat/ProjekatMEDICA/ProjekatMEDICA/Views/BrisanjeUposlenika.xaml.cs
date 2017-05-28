﻿using ProjekatMEDICA.Models;
using ProjekatMEDICA.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatMEDICA
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BrisanjeUposlenika : Page
    {
        BrisanjeUposlenikaViewModel viewModel;
        public BrisanjeUposlenika()
        {
            this.InitializeComponent();
            //MenadzerForm otvara dodavanjeProizvoda
            //stavila da se vidi back u slucaju da menadzer slucajno klikne pogresan button i sl.
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += ThisPage_BackRequested;
            //DataContext = new BrisanjeKupcaViewModel();
            viewModel = new BrisanjeUposlenikaViewModel();
        }

        private void ThisPage_BackRequested(object sender, BackRequestedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
                e.Handled = true;
            }
        }
        private void Uposlenik_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                var uposlenik = (e.AddedItems[0] as Uposlenik);
                if (uposlenik != null) viewModel.odabrani = uposlenik;
            }
        }
    }
}
