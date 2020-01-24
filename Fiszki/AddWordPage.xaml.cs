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
    /// Logika interakcji dla klasy AddWordPage.xaml
    /// </summary>
    public partial class AddWordPage : Page
    {/// <summary>
     /// Zmienna przechowujaca instancje slownika
     /// </summary>
        Dictionary instance;
        /// <summary>
        /// Metoda inicjująca komponent widoku i ustawiająca instancję słownika
        /// </summary>
        /// <param name="instance"></param>
        public AddWordPage(Dictionary instance)
        {
            InitializeComponent();
            this.instance = instance;
        }
        /// <summary>
        /// Metoda obsługująca kliknięcie przycisku odpowiadającego za zapis słowa do słownika
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Word> lista = instance.getDictionary();
            String wordPol = pol.Text;
            String wordEng = eng.Text;
            pol.Text = "";
            eng.Text = "";
            wordPol = wordPol.ToLower();
            wordEng = wordEng.ToLower();
            int flag = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].getPol() == wordPol && lista[i].getEng() == wordEng)
                {
                    flag = 1;
                    result.Content = "Combination already exists";
                }
            }

            if (wordPol == "" || wordEng == "")
            {
                result.Content = "Type words in the brackets";
                flag = 2;
            }
            else if ((string.IsNullOrEmpty(wordPol)) || (string.IsNullOrEmpty(wordEng)) || (string.IsNullOrWhiteSpace(wordPol)) || (string.IsNullOrWhiteSpace(wordEng)) || wordPol.Contains(" ") || wordEng.Contains(" "))
            {
                result.Content = "Words cannot contain spaces";
                flag = 2;
            }
            if (flag == 0)
            {
                instance.addWord(wordPol, wordEng);
                System.IO.StreamWriter file = new System.IO.StreamWriter("dic.txt", append: true);
                file.WriteLine(wordPol + " " + wordEng);
                file.Close();
                result.Content = "Word added successfully";
            }
        }
        /// <summary>
        /// Metoda odpowiadająca za kliknięcie przycisku powrotu do Menu
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
