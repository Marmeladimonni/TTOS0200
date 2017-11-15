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
using JAMK.IT;

namespace VK46AutoTalli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Auto> autot; //muuttuja käytettävissä kaikissa luokan metodeissa ja tapahtumakäsittelijöissä
        private const string polku = @"D:\K2001\OlioOhjelmointi\";

        public MainWindow()
        {
            //Tänne koodi joka suoritetaan ikkunan avauksen luonnissa
            InitializeComponent();
            //Pyydetään BL-kerrokselta autot ja näytetään ne käyttäjälle
            autot = Autotalli.HaeAutot();
            NaytaKuva("autotalli.png");
            //Asetetaan ComboBoxiin kaikki eri automerkit
            //VE1: Käsin koodamalla
            List<string> merkit = new List<string>();
            merkit.Add("Audi");
            merkit.Add("Saab");
            merkit.Add("Volvo");
            merkit.Add("Renault");

            //VE2: Parempi, kysytään LINQ:lla datasta eri automerkit
            var result = autot.Select(m => m.Merkki).Distinct();

            cmbAutot.ItemsSource = merkit;
        }

        private void btnHaeAutot_Click(object sender, RoutedEventArgs e)
        {
            dgAutot.ItemsSource = autot;
        }
        private void btnHaeAudit_Click(object sender, RoutedEventArgs e)
        {
            //näkyviin vain audit
            var result = autot.Where(m => m.Merkki.Contains("Audi"));
            dgAutot.ItemsSource = result;
        }

        private void NaytaKuva(string url)
        {
            try
            {
                if (string.IsNullOrEmpty(url))
                {
                    url = "puuttuu.png";
                }
                //lisätään vakiopolku
                url = polku + url;
                //kuvan näyttö
                BitmapImage pic = new BitmapImage();
                pic.BeginInit();
                pic.UriSource = new Uri(url);
                pic.EndInit();
                imgAuto.Stretch = Stretch.Fill;
                imgAuto.Source = pic;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //huom, olemme itse täyttäneet datagridin auto-olioilla, joten kukin datagridin jäsen/alkio on itse asiassa auto-olio

            object obj = dgAutot.SelectedItem;
            if (obj != null)
            {
                Auto valittu = (Auto)obj;
                NaytaKuva(valittu.URL);
            }
        }

        private void cmbAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Suodatetaan DataGridiin näkyviin vain valittu automerkki'
            string merkki = cmbAutot.SelectedValue.ToString();
            var result = autot.Where(m => m.Merkki.Contains(merkki));
            dgAutot.ItemsSource = result;
            NaytaKuva("Autotalli.png");
        }
    }
}
