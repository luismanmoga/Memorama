
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Memorama.DataAccessService;
using Memorama.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
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
using System.Windows.Forms;

namespace Memorama.Windows {
    /// <summary>
    /// Lógica de interacción para RegistroWin.xaml
    /// </summary>
    public partial class CuadroDialogo : MetroWindow {

        public CuadroDialogo() {
            InitializeComponent();
        }

        public string CodigoIntroducido { get; set; }

        private void btnRegistrarte_Click(object sender, RoutedEventArgs e) {
            // return txtCodigo.Text;
            DialogResult = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void txtCodigo_TextChanged(object sender, TextChangedEventArgs e) {
            CodigoIntroducido = txtCodigo.Text;
        }
    }
}
