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
using ProjekatMEDICA.ViewModels;
using System.Windows.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjekatMEDICA
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FormOdabirUloge : Page
    {
        public ICommand loginKupac { get; set; }
        public ICommand loginProdavac { get; set; }
        public ICommand loginMenadzer { get; set; }
        public ICommand loginDostavljac { get; set; }

        public FormOdabirUloge()
        {
            this.InitializeComponent();
            DataContext = new OdabirUlogeViewModel();
        }
    }
}
