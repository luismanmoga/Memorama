
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MaterialDesignThemes.Wpf;
using Memorama.DataAccessService;
using Memorama.Model;
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
        }


        private void BtnRegistrarse_Click(object sender, RoutedEventArgs e) {
            RegistroWin ventanaRegistro = new RegistroWin();
            ventanaRegistro.ShowDialog();
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

            /*DataAccessServiceClient client = new DataAccessServiceClient();

            if (CamposLlenos()) {
                try {
                    if (client.autenticar(txtCorreo.Text, txtContrasenia.Password)) {
                        //MessageBox.Show("correcto");
                        Inicio ventanaInicio = new Inicio();
                        ventanaInicio.Show();
                        client.Close();
                        this.Close();
                    } else {
                        this.ShowMessageAsync("Alerta","Usuario/Contraseña incorrecta"); 
                    }
                } catch (System.ServiceModel.EndpointNotFoundException ex) {
                    this.ShowMessageAsync("Alerta", "Error de conexión");
                } catch (System.TimeoutException ex) {
                    this.ShowMessageAsync("Alerta", "Tiempo de espera agotado");
                } catch (System.ServiceModel.CommunicationException ex) {
                    this.ShowMessageAsync("Alerta", "Tiempo de espera agotado");
                } 
            } else {
                this.ShowMessageAsync("Alerta", "Campos vacios");
            }*/

            Logic logic = new Logic();
            String res = logic.sendMail(txtCorreo.Text,"Código de confirmación" );
            this.ShowMessageAsync("Alerta", res);
        }
    }
}
