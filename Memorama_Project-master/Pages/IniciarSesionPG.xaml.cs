using Memorama.DataAccessService;
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
    /// Lógica de interacción para IniciarSesionPG.xaml
    /// </summary>
    public partial class IniciarSesionPG : Page {
        public IniciarSesionPG() {
            InitializeComponent();
        }

        private void BtnRegistrarse_Click(object sender, RoutedEventArgs e) {
            this.NavigationService.Navigate(new RegistroUsuarioPG());
        }

        /*
         * 
         * BOTÓN SALIR
         * 
         */

        /*
         * 
         * BOTÓN INICIAR SESIÓN
         * 
         */

        Boolean CamposLlenos() {
            Boolean respuesta = false;
            if (!txtCorreo.Text.Equals("") && !txtContrasenia.Password.Equals("")) {
                respuesta = true;
            }
            return respuesta;
        }
        private void BtnIniciarSesion_Click(object sender, RoutedEventArgs e) {

            DataAccessServiceClient client = new DataAccessServiceClient();
            if (CamposLlenos()) {
                try {
                    if (client.Autenticar(txtCorreo.Text, txtContrasenia.Password)) {
                        Inicio ventanaInicio = new Inicio();
                        ventanaInicio.Show();
                        client.Close();
                    } else {
                       // this.ShowMessageAsync("Alerta", "Usuario/Contraseña incorrecta");
                    }
                } catch (System.ServiceModel.EndpointNotFoundException ex) {
                   // this.ShowMessageAsync("Alerta", "Error de conexión");
                } catch (System.TimeoutException ex) {
                   // this.ShowMessageAsync("Alerta", "Tiempo de espera agotado");
                } catch (System.ServiceModel.CommunicationException ex) {
                   // this.ShowMessageAsync("Alerta", "Tiempo de espera agotado");
                }
            } else {
               // this.ShowMessageAsync("Alerta", "Campos vacios");
            }
        }
    }
}
