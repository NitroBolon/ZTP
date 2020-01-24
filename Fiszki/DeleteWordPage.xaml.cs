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
    /// Logika interakcji dla klasy DeleteWordPage.xaml
    /// </summary>
    public partial class DeleteWordPage : Page
    {
        /// <summary>
        /// Zmienna przechowujaca instancje slownika
        /// </summary>
        Dictionary instance;
        /// <summary>
        /// Metoda inicjujaca komponent widoku i ustawiająca instancję słownika
        /// </summary>
        /// <param name="instance">Instancja slownika</param>
        public DeleteWordPage(Dictionary instance)
        {
            InitializeComponent();
            this.instance = instance;
        }
        /// <summary>
        /// Metoda obsługująca kliknięcie przycisku zatwierdzającego usuwanie słowa ze słownika
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String wordPol = pol.Text;
            String wordEng = eng.Text;
            pol.Text = "";
            eng.Text = "";
            wordPol = wordPol.ToLower();
            wordEng = wordEng.ToLower();

            int res = instance.deleteWord(wordPol, wordEng);
            if (res == 0)
            {
                result.Content = "Word deleted successfully";
                System.IO.StreamWriter file2 = new System.IO.StreamWriter("dic.txt");
                if (instance.getDictionary().Count > 0)
                {
                    for (int i = 0; i < instance.getDictionary().Count; i++)
                    {
                        file2.WriteLine(instance.getDictionary()[i].getPol() + " " + instance.getDictionary()[i].getEng());
                    }
                }
                file2.Close();
            }
            else result.Content = "Word cannot be deleted";
        }
        /// <summary>
        /// Metoda obsługująca kliknięcie przycisku odpowiadającego za wyjście do Menu
        /// </summary>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            
            parentWindow.Content = null;
            MainPage nowa = new MainPage(instance);
            parentWindow.Content = null;
            parentWindow.Content = nowa;
        }
    }
}
