using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
           
        public MainWindow()
        {
            InitializeComponent();
            List<Juego> juegos = new List<Juego>(); 
            juegos.Add(new Juego { Puntaje1 = 2, Puntaje2 = 3, Eq1 = "Barcelona", Eq2 = "Real Madrid ", Progreso = 80 });
            juegos.Add(new Juego { Puntaje1 = 2, Puntaje2 = 3, Eq1 = "Barcelona", Eq2 = "Real Madrid ", Progreso = 90 });
            juegos.Add(new Juego { Puntaje1 = 2, Puntaje2 = 3, Eq1 = "Barcelona", Eq2 = "Real Madrid ", Progreso = 80 });
            juegos.Add(new Juego { Puntaje1 = 2, Puntaje2 = 3, Eq1 = "Barcelona", Eq2 = "Real Madrid ", Progreso = 80 });
            juegos.Add(new Juego { Puntaje1 = 2, Puntaje2 = 3, Eq1 = "Barcelona", Eq2 = "Real Madrid ", Progreso = 10 });
            lbJuego.ItemsSource = juegos;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(lbJuego.SelectedItem != null)
            {
                MessageBox.Show("Juego Seleccionado" + (lbJuego.SelectedItems as Juego).Eq1 + " " + (lbJuego.SelectedItems as Juego).Eq2);
            }
        }
    }

    public class Juego
    {
        public int Puntaje1 { get; set; }
        public int Puntaje2 { get; set; }
        public string Eq1 { get; set; }
        public string Eq2 { get; set; }
        public int Progreso { get; set; }   


    }
}