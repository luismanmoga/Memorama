using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Memorama.DataAccessService;
using Memorama.Model;
using Memorama.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Memorama.Pages {
    /// <summary>
    /// Lógica de interacción para RecuperarContraseniaPG.xaml
    /// </summary>
    public partial class RecuperarContraseniaPG : Page {
        public RecuperarContraseniaPG() {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, RoutedEventArgs e) {
           /* Boolean endDo = false;
            Correo mail = new Correo();
            String codigoIntroducido = "";
            var (mensaje, codigo) = mail.EnviarCorreo(txtCorreo.Text);

            do {
                CuadroDialogo dialogo = new CuadroDialogo();
                if (dialogo.ShowDialog() == dialogo.DialogResult) {
                    codigoIntroducido = dialogo.CodigoIntroducido;
                }

                if (codigoIntroducido.Equals(codigo)) {
                    endDo = true;
                } else {
                    ((MetroWindow)(Application.Current.MainWindow)).ShowMessageAsync("Alerta", "Codigo erroneo");
                }

            } while (!endDo);*/

            RecuperarContrasenia2PG.Correo = txtCorreo.Text;
            this.NavigationService.Navigate(new RecuperarContrasenia2PG());
        }
    }
}
