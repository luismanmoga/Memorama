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
    public partial class RecuperarContrasenia2PG : Page {
        private static String correo;
        public RecuperarContrasenia2PG() {
            InitializeComponent();
        }

        public static string Correo { get => correo; set => correo = value; }

        private void btnEnviar_Click(object sender, RoutedEventArgs e) {
            Boolean respuesta = false;

            DataAccessServiceClient client = new DataAccessServiceClient();

            if (contraseniasIguales()) {
                if (respuesta = client.CambiarContrasenia(correo,pswContrasenia.Password)) {
                    ((MetroWindow)(Application.Current.MainWindow)).ShowMessageAsync("Alerta", "Contraseña cambiada con éxito");
                } else {
                    ((MetroWindow)(Application.Current.MainWindow)).ShowMessageAsync("Alerta", "Contraseña cambiada con éxito");
                }
            }

        }

        private Boolean contraseniasIguales() {
            Boolean respuesta = false;
            if (pswContrasenia.Password.Equals(pswContraseniaRep.Password)) {
                respuesta = true;
            }
            return respuesta;
        }

    }
}
