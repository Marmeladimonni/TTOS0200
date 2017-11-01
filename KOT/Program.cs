using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOT
{
    class Program
    {
        static void Main(string[] args)
        {
            //KÄYTÄ AINA TRY-CATCH
            try
            {
                string nimi;
                string filupath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filu = filupath + @"\testi.txt";
                //Kirjoitetaan käyttäjän antamat rivit tiedostoon
                //Luodaan (StreamWriter-) olio, johon kirjoitetaan
                StreamWriter sw = new StreamWriter(filu);

                do
                {
                    Console.Write("Anna nimi (Enter lopettaa):");
                    nimi = Console.ReadLine();
                    if (nimi.Length > 0)
                        sw.WriteLine(nimi);
                } while (nimi.Length != 0);
                sw.Close();
                if (File.Exists(filu))
                {
                    //Avataan tiedosto uudestaan ja luetaan se. Näytetään konsolissa.
                    string teksti = File.ReadAllText(filu);
                    Console.WriteLine(teksti);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Tiedostoa ei löydy!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
