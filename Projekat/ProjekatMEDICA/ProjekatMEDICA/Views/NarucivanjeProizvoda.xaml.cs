using ProjekatMEDICA.Models;
using ProjekatMEDICA.ViewModels;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatMEDICA
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
   
    public sealed partial class NarucivanjeProizvoda : Page
    {
        NarucivanjeProizvodaViewModel viewModel;
        public NarucivanjeProizvoda()
        {
            this.InitializeComponent();
            viewModel = new NarucivanjeProizvodaViewModel();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            viewModel = (NarucivanjeProizvodaViewModel)e.Parameter;
        }

        private void Proizvod_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                var proizvod = (e.AddedItems[0] as Proizvod);
                if (proizvod != null) viewModel.odabrani = proizvod;
            }
        }
    }
}
