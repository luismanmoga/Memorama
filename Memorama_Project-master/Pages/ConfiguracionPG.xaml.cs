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
    /// Lógica de interacción para ConfiguracionPG.xaml
    /// </summary>
    public partial class ConfiguracionPG : Page {
        public ConfiguracionPG() {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, RoutedEventArgs e) {
            this.NavigationService.Navigate(new InicioPG());
        }

        private void imgMX_MouseDown(object sender, MouseButtonEventArgs e) {

        }

        private void imgEU_MouseDown(object sender, MouseButtonEventArgs e) {

        }
    }
}
