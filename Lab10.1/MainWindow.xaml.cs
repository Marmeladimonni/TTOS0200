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

namespace Lab10._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Muuttujien alustus
        int CarsAmount = 0;
        int TrucksAmount = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnCars_Click(object sender, RoutedEventArgs e)
        {
            //Lisätään napsautuksella 1 ja asetetaan tekstikenttään
            CarsAmount++;
            txtCarNum.Text = CarsAmount.ToString();
        }

        private void btnTrucks_Click_1(object sender, RoutedEventArgs e)
        {
            TrucksAmount++;
            txtTruckNum.Text = TrucksAmount.ToString();
        }
    }
}
