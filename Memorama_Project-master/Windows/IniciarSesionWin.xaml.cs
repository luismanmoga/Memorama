
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MaterialDesignThemes.Wpf;
using Memorama.DataAccessService;
using Memorama.Model;
using Memorama.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Memorama.Windows {
    /// <summary>
    /// Lógica de interacción para IniciarSesionWin.xaml
    /// </summary>
    public partial class IniciarSesionWin : MetroWindow {

        public IniciarSesionWin() {
            InitializeComponent();
            framePrincipal.Navigate(new IniciarSesionPG());
        }
    }
}
