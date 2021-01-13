using Memorama.ChatService;
using Memorama.DataAccessService;
using Memorama.Model;
using Memorama.PartidaService;
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
    /// Lógica de interacción para CrearPartidaPG.xaml
    /// </summary>
    public partial class CrearPartidaPG : Page {
        DataAccessServiceClient client = new DataAccessServiceClient();
        PartidaServiceClient partidaService = new PartidaServiceClient();
        public CrearPartidaPG() {
            InitializeComponent();
           
        }

        private void btnAtras_Click(object sender, RoutedEventArgs e) {
            this.NavigationService.Navigate(new InicioPG());
            partidaService.EliminarPartida(JugadorSingleton.GetJugador().Username); //validar error de conexión
        }

        private void Salir( object sender ,ExitEventHandler e) {
            partidaService.EliminarPartida(JugadorSingleton.GetJugador().Username);
        }

        private void btnComenzar_Click(object sender, RoutedEventArgs e) {

        }

        private void btnCrearPartida_Click(object sender, RoutedEventArgs e) {

            partidaService.CrearPartida(JugadorSingleton.GetJugador().Username); //Validar error de conexión
            lblJugadorUno.Content = JugadorSingleton.GetJugador().Username;
            eJugadorUno.Fill = Brushes.DarkGreen;

        }
    }
}