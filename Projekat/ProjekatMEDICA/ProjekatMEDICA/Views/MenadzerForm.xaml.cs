using ProjekatMEDICA.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
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
    public sealed partial class MenadzerForm : Page
    {
        public ICommand dodajProizvod { get; set; }
        public ICommand dodajUposlenika { get; set; }
        public ICommand dodajKupca { get; set; }
        public ICommand brisiProizvod { get; set; }
        public ICommand brisiUposlenika { get; set; }
        public ICommand brisiKupca { get; set; }
        public ICommand azurirajProizvod { get; set; }
        public ICommand azurirajUposlenika { get; set; }
        public MenadzerForm()
        {
            this.InitializeComponent();
            DataContext = new MenadzerFormViewModel();
        }
    }
}
