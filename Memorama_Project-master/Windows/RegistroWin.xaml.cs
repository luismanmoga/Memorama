
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Memorama.DataAccessService;
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

namespace Memorama.Windows {
    /// <summary>
    /// Lógica de interacción para RegistroWin.xaml
    /// </summary>
    public partial class RegistroWin : MetroWindow {

        public RegistroWin() {
            InitializeComponent();
        } 

        /*
         * 
         * ¿ESTA EN INGLES?
         * 
         */

        private Boolean isEnglish() {
            if (txbTitulo.Text.Equals("Player Registration")) {
                return true;
            } else {
                return false;
            }
        }

        /*
         * 
            Información de los campos Usuario & Contraseña
         *
         */
        private void btnInfoUsuario_MouseEnter(object sender, MouseEventArgs e) {
            
            if (isEnglish()) {
                lblInfo.Text = "Username max lenght 16 characters";
            } else {
                lblInfo.Text = "El nombre de usuario no debe ser mayor a 16 caractéres";
            }
        }

        private void btnInfoUsuario_MouseLeave(object sender, MouseEventArgs e) {
            lblInfo.Text = "";
        }

        private void btnInfoPass_MouseEnter(object sender, MouseEventArgs e) {
            if (isEnglish()) {
                lblInfo.Text = "Password max 8 caracters";
            } else {
                lblInfo.Text = "La contraseña no debe ser mayor a 8 caractéres";
            }
        }

        private void btnInfoPass_MouseLeave(object sender, MouseEventArgs e) {
            lblInfo.Text = "";
        }

        /*
         * 
         * BOTON REGRESAR
         * 
         */

        private void btnRegresar_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void btnRegresar_MouseEnter(object sender, RoutedEventArgs e) {
            lblRegresar.Visibility = Visibility.Visible;
        }

        private void btnRegresar_MouseLeave(object sender, MouseEventArgs e) {
            lblRegresar.Visibility = Visibility.Hidden;
        }

        /*
         * 
            COMPARACIÓN DE CORREOS
         *  
         */

        private Boolean correosIguales() {
            Boolean resultado = false;
            if (txtCorreo2.Text.Equals(txtCorreo.Text)) {
                resultado = true ;  
            }
            return resultado;
        }
        private void txtCorreo_lostFocus(object sender, RoutedEventArgs e) {
            if (!correosIguales()) {
                txtCorreo.BorderBrush = Brushes.Red;
                txtCorreo2.BorderBrush = Brushes.Red;
               
                if (isEnglish()) {
                    lblInfo.Text = "Mail does not match";
                } else {
                    lblInfo.Text = "El correo no coincide";
                }
            } 
        }

        private void txtCorreo_GotFocus(object sender, RoutedEventArgs e) {
            txtCorreo.BorderBrush = Brushes.White;
            txtCorreo2.BorderBrush = Brushes.White;
            lblInfo.Text = "";
        }

        /*
         * 
         * COMPARACION DE CONTRASEÑAS
         * 
         */

        private Boolean contraseniasIguales() {
            Boolean resultado = false;
            if (pswContrasenia.Password.Equals(pswContrasenia2.Password)) {
                resultado = true;
            }
            return resultado;
        }
        private void pswContrsenias_lostFocus(object sender, RoutedEventArgs e) {
            if (!contraseniasIguales()) {
                pswContrasenia.BorderBrush = Brushes.Red;
                pswContrasenia2.BorderBrush = Brushes.Red;
                if (isEnglish()) {
                    lblInfo.Text = "Passwords do not match";
                } else {
                    lblInfo.Text = "Las contraseñas no coinciden";
                }
            } 
        }

        private void pswContrasenia_GotFocus(object sender, RoutedEventArgs e) {
            pswContrasenia.BorderBrush = Brushes.White;
            pswContrasenia2.BorderBrush = Brushes.White;
            lblInfo.Text = "";
        }

        /*
         * 
         * BOTON REGISTRAR Y VALIDACION DE CAMPOS
         * 
         */
        private Boolean camposLlenos() {
            Boolean resultado = false;
            if (!txtUsuario.Equals("") & !txtCorreo.Equals("") & !txtCorreo2.Equals("") 
                & !pswContrasenia.Password.Equals("") & !pswContrasenia2.Password.Equals("")) {
                resultado = true;
            }
            return resultado;
              
        }

        private Boolean camposCorrectos() {
            Boolean resultado;
            if (correosIguales() & contraseniasIguales()) {
                resultado = true;
            } else {
                resultado = false;
            }
            return resultado;
        }

        private void btnRegistrarte_Click(object sender, RoutedEventArgs e) {

            if (camposLlenos() & camposCorrectos()) {
                // TODO LO DEMAS

                DataAccessServiceClient client = new DataAccessServiceClient();
                int resultado = client.RegistrarJugador(txtUsuario.Text, txtCorreo.Text, pswContrasenia.Password);

                if (resultado==1) {
                    MessageBoxResult result = MessageBox.Show("Registro exitoso", "Mensaje", MessageBoxButton.OK);
                    switch (result) {
                        case MessageBoxResult.OK:
                            this.Close();
                            break;
                    }
                } else if(resultado==2) {
                    this.ShowMessageAsync("Alerta", "El correo ya existe");
                }  
            } else {
                if (isEnglish()) {
                    this.ShowMessageAsync("Warning", "Fill fields correctly");
                } else {
                    this.ShowMessageAsync("Advertencia", "Se deben llenar todos los campos correctamente");
                }
            }
        }
    }
}
