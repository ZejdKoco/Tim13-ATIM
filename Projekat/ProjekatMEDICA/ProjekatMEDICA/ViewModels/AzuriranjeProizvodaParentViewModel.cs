﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Windows.UI.Popups;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using ProjekatMEDICA.Models;
using System.Collections.ObjectModel;
using ProjekatMEDICA.Helper;

namespace ProjekatMEDICA.ViewModels
{
    class AzuriranjeProizvodaParentViewModel : INotifyPropertyChanged
    {
        public string naziv { get; set; }
        public ICommand pretragaBtn { get; set; }
        public ObservableCollection<Proizvod> proizvodi { get; set; }
        public ICommand potvrdiBtn { get; set; }
        public INavigationService AzuriranjeProizvodaParent { get => NavigationService; set => NavigationService = value; }
        public event PropertyChangedEventHandler PropertyChanged;
        private INavigationService NavigationService;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public void pozivAzuriranjeProizvodaParent()
        {
            AzuriranjeProizvodaParent.Navigate(typeof(AzurirajProizvodParent));
        }
        public AzuriranjeProizvodaParentViewModel()
        {
            NavigationService = new NavigationService();
            potvrdiBtn = new RelayCommand<object>(potvrdiZapocniAzuriranje, mozeLiSeAzurirati);
        }
        public bool mozeLiSeAzurirati(object parametar)
        {
            return true;
        }
        public void potvrdiZapocniAzuriranje(object parametar)
        {
            NavigationService.Navigate(typeof(AzuriranjeProizvodaChild));
        }
    }
}
