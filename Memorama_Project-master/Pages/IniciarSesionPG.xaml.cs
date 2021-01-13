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
         * BOTÓN INICIAR SESIÓN
         * 
         */

        Boolean CamposLlenos() {
            Boolean respuesta = false;
            if (!txtUsuario.Text.Equals("") && !txtContrasenia.Password.Equals("")) {
                respuesta = true;
            }
            return respuesta;
        }

        private void BtnIniciarSesion_Click(object sender, RoutedEventArgs e) {

            DataAccessServiceClient client = new DataAccessServiceClient();
            if (CamposLlenos()) {
                try {
                    if (client.Autenticar(txtUsuario.Text, txtContrasenia.Password)) {
                        JugadorSingleton jugador = JugadorSingleton.GetJugador(client.GetJugador(txtUsuario.Text, txtContrasenia.Password));
                        Inicio ventanaInicio = new Inicio();
                        ventanaInicio.Show();
                        Window.GetWindow(this).Close();
                        client.Close();
                    } else {
                        ((MetroWindow)(Application.Current.MainWindow)).ShowMessageAsync("Alerta","Usuario y/o contraseña incorrecta");
                    }
                } catch (System.ServiceModel.EndpointNotFoundException ex) {
                    ((MetroWindow)(Application.Current.MainWindow)).ShowMessageAsync("Alerta", "Error de conexión");
                } catch (System.TimeoutException ex) {
                    ((MetroWindow)(Application.Current.MainWindow)).ShowMessageAsync("Alerta", "Tiempo de espera agotado");
                } catch (System.ServiceModel.CommunicationException ex) {
                    ((MetroWindow)(Application.Current.MainWindow)).ShowMessageAsync("Alerta", "Tiempo de espera agotado");
                }
            } else {
                ((MetroWindow)(Application.Current.MainWindow)).ShowMessageAsync("Alerta", "Campos incompletos");
            }

            //BORRAR
            /*Inicio ventanaInicio = new Inicio();
            ventanaInicio.Show();
            Window.GetWindow(this).Close();*/
        }

        private void btnOlvideContrasenia_Click(object sender, RoutedEventArgs e) {
            this.NavigationService.Navigate(new RecuperarContraseniaPG());
        }

        private void txtContrasenia_KeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Enter) {
                BtnIniciarSesion_Click(sender, e);
            }
        }
    }
}
