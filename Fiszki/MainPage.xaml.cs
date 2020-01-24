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

namespace Fiszki
{
    /// <summary>
    /// Logika interakcji dla klasy MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {/// <summary>
    /// Zmienna przechowująca instancję słownika
    /// </summary>
        Dictionary instance;
        /// <summary>
        /// Konstruktor widoku, ustawiający instancję słownika
        /// </summary>
        /// <param name="dic">Instancja słownika</param>
        public MainPage(Dictionary dic)
        {
            InitializeComponent();
            instance = dic;
        }
        /// <summary>
        /// Metoda uruchamiająca stronę usuwania słowa ze słownika
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
             
            parentWindow.Content = null;
            DeleteWordPage nowa = new DeleteWordPage(instance);
            parentWindow.Content = null;
            parentWindow.Content = nowa;
        }
        /// <summary>
        /// Metoda uruchamiająca stronę dodawania słowa do słownika
        /// </summary>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);

            parentWindow.Content = null;
            AddWordPage nowa = new AddWordPage(instance);
            parentWindow.Content = null;
            parentWindow.Content = nowa;
        }
        /// <summary>
        /// Metoda uruchamiająca stronę trybu łatwego, gry sandbox, nauka angielskiego
        /// </summary>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (instance.getDictionary().Count < 4)
            {
                MessageBox.Show("Not enough words to start test", "Fiszki");
            }
            else
            {
                parentWindow.Content = null;
                Easy nowa = new Easy(1, instance);
                parentWindow.Content = null;
                parentWindow.Content = nowa;
            }
        }
        /// <summary>
        /// Metoda uruchamiająca stronę trybu łatwego, gry sandbox, nauka polskiego
        /// </summary>
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (instance.getDictionary().Count < 4)
            {
                MessageBox.Show("Not enough words to start test", "Fiszki");
            }
            else
            {
                parentWindow.Content = null;
                Easy nowa = new Easy(0, instance);
                parentWindow.Content = null;
                parentWindow.Content = nowa;
            }
        }
        /// <summary>
        /// Metoda uruchamiająca stronę trybu łatwego, gry test, nauka angielskiego
        /// </summary>
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (instance.getDictionary().Count < 4)
            {
                MessageBox.Show("Not enough words to start test", "Fiszki");
            }
            else
            {
                parentWindow.Content = null;
                EasyTest nowa = new EasyTest(1, instance);
                parentWindow.Content = null;
                parentWindow.Content = nowa;
            }
        }
        /// <summary>
        /// Metoda uruchamiająca stronę trybu łatwego, gry test, nauka polskiego
        /// </summary>
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (instance.getDictionary().Count < 4)
            {
                MessageBox.Show("Not enough words to start test", "Fiszki");
            }
            else
            {
                parentWindow.Content = null;
                EasyTest nowa = new EasyTest(0, instance);
                parentWindow.Content = null;
                parentWindow.Content = nowa;
            }
        }
        /// <summary>
        /// Metoda uruchamiająca stronę trybu trudnego, gry sandbox, nauka angielskiego
        /// </summary>
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (instance.getDictionary().Count < 4)
            {
                MessageBox.Show("Not enough words to start test", "Fiszki");
            }
            else
            {
                parentWindow.Content = null;
                Hard nowa = new Hard(1, instance);
                parentWindow.Content = null;
                parentWindow.Content = nowa;
            }
        }
        /// <summary>
        /// Metoda uruchamiająca stronę trybu trudnego, gry sandbox, nauka polskiego
        /// </summary>
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (instance.getDictionary().Count < 4)
            {
                MessageBox.Show("Not enough words to start test", "Fiszki");
            }
            else
            {
                parentWindow.Content = null;
                Hard nowa = new Hard(0, instance);
                parentWindow.Content = null;
                parentWindow.Content = nowa;
            }
        }
        /// <summary>
        /// Metoda uruchamiająca stronę trybu trudnego, gry test, nauka angielskiego
        /// </summary>
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (instance.getDictionary().Count < 4)
            {
                MessageBox.Show("Not enough words to start test", "Fiszki");
            }
            else
            {
                parentWindow.Content = null;
                HardTest nowa = new HardTest(1, instance);
                parentWindow.Content = null;
                parentWindow.Content = nowa;
            }
        }
        /// <summary>
        /// Metoda uruchamiająca stronę trybu trudnego, gry test, nauka polskiego
        /// </summary>
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (instance.getDictionary().Count < 4)
            {
                MessageBox.Show("Not enough words to start test", "Fiszki");
            }
            else
            {
                parentWindow.Content = null;
                HardTest nowa = new HardTest(0, instance);
                parentWindow.Content = null;
                parentWindow.Content = nowa;
            }
        }
    }
}
