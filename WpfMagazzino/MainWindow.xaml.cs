using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfMagazzino
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtIndmento.Focus();
        }
        string[] arrayIndumento = new string[30];
        int numeroElementi;
        double[] arrayPrezzo = new double[30];

        private void btnImmetti_Click(object sender, RoutedEventArgs e)
        {
            arrayIndumento[numeroElementi] = txtIndmento.Text;
            arrayPrezzo[numeroElementi] = double.Parse(txtPrezzo.Text);
            numeroElementi++;
            LblLista.Content = "";
            for (int i = 0; i < numeroElementi; i++)
            {
                LblLista.Content += $"Indumento : {arrayIndumento[i]} {arrayPrezzo[i]} € \n";
            }
            txtIndmento.Clear();
            txtIndmento.Focus();
            txtPrezzo.Clear();
        }

        private void btnCreaFile_Click(object sender, RoutedEventArgs e)
        {
            
                StreamWriter sw = new StreamWriter("pubbica.txt", false, Encoding.UTF8);
                for (int i = 0; i < numeroElementi; i++)
                {
                    sw.WriteLine($"Indumento : {arrayIndumento[i]} {arrayPrezzo[i]} € \n");
                }
                sw.Flush();
                sw.Close();
            
        }
    }
}
