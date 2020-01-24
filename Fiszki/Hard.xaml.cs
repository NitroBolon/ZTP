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
    /// Logika interakcji dla klasy Hard.xaml
    /// </summary>
    public partial class Hard : Page
    {/// <summary>
     /// Zmienne przechowujące język gry, instancję słownika, pozycję w teście, zestaw pytań i tryb gry
     /// </summary>
        int language = 0;
        Dictionary instance;
        int pos = 0;
        ILanguage set;
        Sandbox gameMode;
        /// <summary>
        /// Konstruktor okna gry na poziomie trudnym w trybie Sandbox
        /// </summary>
        /// <param name="lang">Język gry</param>
        /// <param name="ins">Instancja słownika</param>
        public Hard(int lang, Dictionary ins)
        {
            InitializeComponent();
            this.language = lang;
            this.instance = ins;

            Sandbox gameMode = new Sandbox();
            this.DataContext = gameMode;
            this.gameMode = gameMode;
            ILanguage set = null;

            if (lang == 1)
            {
                set = new LearnEnglish(ins);
            }
            else
            {
                set = new LearnPolish(ins);
            }
            this.set = set;
            setContent();
        }
        /// <summary>
        /// Metoda obsługująca kliknięcie przycisku z błędną odpowiedzią
        /// </summary>
        private void Button_Click_false(object sender, RoutedEventArgs e)
        {
            score.Content = gameMode.goOn() + gameMode.scoreDown();
        }
        /// <summary>
        /// Metoda obsługująca kliknięcie przycisku z prawidłową odpowiedzią
        /// </summary>
        private void Button_Click_true(object sender, RoutedEventArgs e)
        {
            score.Content = gameMode.goOn() + gameMode.scoreUp();
            pos++;
            setContent();
        }
        /// <summary>
        /// Metoda obsługująca kliknięcie przycisku powrotu do Menu
        /// </summary>
        private void Button_Click_close(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            parentWindow.Content = null;
            MainPage nowa = new MainPage(instance);
            parentWindow.Content = null;
            parentWindow.Content = nowa;
        }
        /// <summary>
        /// Metoda wyświetlająca odpowiednią zawartość strony w zależności od pozycji w teście;
        /// Odpowiada też za losowość ułożenia przycisków
        /// </summary>
        private void setContent()
        {
            Thickness p1 = new Thickness();
            p1.Left = 245;
            p1.Top = 210;
            Thickness p2 = new Thickness();
            p2.Left = 405;
            p2.Top = 210;
            Thickness p3 = new Thickness();
            p3.Left = 245;
            p3.Top = 260;
            Thickness p4 = new Thickness();
            p4.Left = 405;
            p4.Top = 260;
            Random x = new Random(Guid.NewGuid().GetHashCode());
            int wyn = x.Next(4);

            if (pos < 5)
            {
                switch (wyn)
                {
                    case 0:
                        {
                            button1.Margin = p2;
                            button2.Margin = p1;
                            button3.Margin = p3;
                            button4.Margin = p4;
                        }
                        break;
                    case 1:
                        {
                            button1.Margin = p1;
                            button2.Margin = p2;
                            button3.Margin = p3;
                            button4.Margin = p4;
                        }
                        break;
                    case 2:
                        {
                            button1.Margin = p1;
                            button2.Margin = p3;
                            button3.Margin = p2;
                            button4.Margin = p4;
                        }
                        break;
                    default:
                        {
                            button1.Margin = p1;
                            button2.Margin = p4;
                            button3.Margin = p2;
                            button4.Margin = p3;
                        }
                        break;
                }
                button1.Content = set.chosenLearningLanguage(pos + 1).returnFalse1();
                button2.Content = set.chosenLearningLanguage(pos + 1).returnAnswer();
                button3.Content = set.chosenLearningLanguage(pos + 1).returnFalse2();
                button4.Content = set.chosenLearningLanguage(pos + 1).returnFalse3();
                que.Content = set.chosenLearningLanguage(pos + 1).returnQuestion();
            }
            else
            {
                que.Content = "You scored " + gameMode.getPoints() + ".";
                next.Visibility = Visibility.Visible;
                button1.Visibility = Visibility.Hidden;
                button2.Visibility = Visibility.Hidden;
                button3.Visibility = Visibility.Hidden;
                button4.Visibility = Visibility.Hidden;
            }
        }


    }
}
