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

namespace WPF_Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nimi = txtNimi.Text;
            txbMessu.Text = "Terve " + nimi;
        }

        private void btnSuurenna_Click(object sender, RoutedEventArgs e)
        {
            //Suurennetaan tekstiä
            txbMessu.FontSize = txbMessu.FontSize + 1;
        }

        private void cmbVarit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Selvitetään mikä väri valittu
            ListBoxItem li = (ListBoxItem)cmbVarit.SelectedItem;
            string testi = li.Content.ToString();
            //string vari = cmbVarit.SelectedValue.ToString();
            //txbMessu.Text = testi;
            Brush mybrush = Brushes.Blue;
            //HUOM: Tietyt kontrollien ominaisuudet vaativat tietyn tyyppisen muuttujan
            //Tässä Foreground-ominaisuus vaatii brush-tyypin!!!
            txbMessu.Foreground = mybrush;
        }
    }
}
