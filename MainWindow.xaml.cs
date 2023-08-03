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
using Microsoft.Win32;

namespace Uklady_3_08
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

        private void Zapisz(object sender, RoutedEventArgs e)
        {
            SaveFileDialog oknoDoZapisu = new SaveFileDialog();//Nowe okno do zapisu (oknoZapisu)
            oknoDoZapisu.Filter = "PlainText | *.txt";//filtr
            oknoDoZapisu.Title = "Zapisywanie";

            if(oknoDoZapisu.ShowDialog() == true)
            {
                /*Creates a new file, writes the specified string to the file using the specified encoding,
                 * and then closes the file*/
                File.WriteAllText(oknoDoZapisu.FileName, tekstDoZapisu.Text);
                /* (W NOWO UWTTORZONYM OKNIE DO ZAPISU -> (oknoDoZapisu)) 
                 * FileName -> W eksploratorze otwieranie pliku (nazwa)
                 * Text -> Nazwa pliku */
            }
            
        }


        private void Oblicz(object sender, RoutedEventArgs e)
        {

        }

        private void NWW(object sender, RoutedEventArgs e)
        {
            // used to pass arguments to methods by reference
            /*W zmiennych typu referencyjnego są przechowywane odwołania do ich danych (obiekty),
            /a zmienne typu wartości zawierają bezpośrednio swoje dane*/

            if (int.TryParse(liczba1.Text, out int a) && int.TryParse(liczba2.Text, out int b)){
                int wynik = nww(a, b);//przekazujemy argumenty
                MessageBox.Show("Największa wspólna wielokrotność liczb " + a + " i " + b + " to: " + wynik);
                
            }
        }
        //Tworzymy osobna peywatna funkcje
        static int nww(int a, int b)
        {
            if (a < b)
                return nww(b, a);
            //Podajemy zmienną k
            int k = a; //Tworzymy zmienna k i przypisjemy ja do a
            while (k % b != 0) //reszta = 0
                               //The addition assignment operator, +=, is a shorthand way to add a value to a variable.
                               //(Skrócony zapis dodanie wartości do zmiennej->+=a);

                k += a;//Jeśli reszta dzielenia zmiennej k przez b jest różna od 0, to dopisujemy wartość a do k
            return k;
        }

        private void Powieksz(object sender, RoutedEventArgs e)
        {
            liczba1.FontSize = 25;
            liczba2.FontSize = 35;
        }

        private void zmien_kolor_tekstu(object sender, RoutedEventArgs e)
        {
            liczba1.Background = new SolidColorBrush(Colors.LightBlue);
            liczba2.Background = new SolidColorBrush(Colors.LightBlue);
                
        }
    }
}
