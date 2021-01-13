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
    /// Lógica de interacción para UnirsePartidaPG.xaml
    /// </summary>
    /// 

    public partial class UnirsePartidaPG : Page {

        List<String> partidas = new List<string>();

        PartidaServiceClient partidaService = new PartidaServiceClient();
        public UnirsePartidaPG() {
            InitializeComponent();
        }

        private void btnRefrescar_Click(object sender, RoutedEventArgs e) {
            
            foreach (Partida aPart in partidaService.getPartidasActivas()) {
                partidas.Add(aPart.Nombre);       
            }
            lsVPartidasActivas.ItemsSource = partidas;
            lsVPartidasActivas.Items.Refresh();
        }

        private void btnAtras_Click(object sender, RoutedEventArgs e) {
            this.NavigationService.Navigate(new InicioPG());
        }
    }

}
