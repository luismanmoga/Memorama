using MahApps.Metro.Controls;
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
    /// Lógica de interacción para InicioPG.xaml
    /// </summary>
    public partial class InicioPG : Page {
        public InicioPG() {
            InitializeComponent();
            lblBienvenida.Content = Memorama.Languages.Resources.MensajeBienvenida + " " + JugadorSingleton.GetJugador().Username;  //Posible excepcion
        }

        private void btnCrearPartida_Click(object sender, RoutedEventArgs e) {
            this.NavigationService.Navigate(new CrearPartidaPG());
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e) {
            Window.GetWindow(this).Close();
        }

        private void btnPuntuacion_Click(object sender, RoutedEventArgs e) {

        }

        private void btnUnirPartida_Click(object sender, RoutedEventArgs e) {
            this.NavigationService.Navigate(new UnirsePartidaPG());
        }

        private void btnConfiguracion_Click(object sender, RoutedEventArgs e) {
            this.NavigationService.Navigate(new ConfiguracionPG());
        }
    }
}
