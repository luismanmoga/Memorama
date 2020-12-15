using MahApps.Metro.Controls;
using Memorama.Model;
using Memorama.Pages;
using Memorama.Languages;
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
using System.Windows.Shapes;

namespace Memorama.Windows {
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : MetroWindow {
       // ResXResourceSet ResourceSet = new ResXResourceSet(new Uri(@".Languages\Resources.resx",));
        public Inicio() {
            InitializeComponent();
            frameInicio.Navigate(new InicioPG());
        }
    }
}
