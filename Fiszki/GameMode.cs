using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiszki
{
    /// <summary>
    /// Klasa odpowiadająca za ustawienie trybu gry (Wzorzec Template Method)
    /// </summary>
    abstract class GameMode
    {
        /// <summary>
        /// Zmienna zliczająca punkty
        /// </summary>
        int points=0;
        /// <summary>
        /// Metida podnosząca liczbę punktów
        /// </summary>
        /// <returns>Aktualna liczba punktów</returns>
        public int scoreUp()
        {
            points += 10;
            return points;
        }
        /// <summary>
        /// Metida obniżająca liczbę punktów
        /// </summary>
        /// <returns>Aktualna liczba punktów</returns>
        public int scoreDown()
        {
            points -= 10;
            return points;
        }
        /// <summary>
        /// Metoda dostępu do liczby punktów
        /// </summary>
        /// <returns>Aktualna liczba punktów</returns>
        public int getPoints()
        {
            return points;
        }
        /// <summary>
        /// Metoda obsługująca wypisywany wynik w zależności od trybu
        /// </summary>
        /// <returns>Ciąg tekstu z wynikiem</returns>
        public abstract String goOn();
    }
    /// <summary>
    /// Klasa trybu Sandbox
    /// </summary>
    class Sandbox : GameMode
    {/// <summary>
    /// Metoda wypisująca wynik na ekran
    /// </summary>
    /// <returns>Wynik gracza</returns>
        public override String goOn()
        {
            return "Score\n";
        }

    }
    /// <summary>
    /// Klasa trybu Test
    /// </summary>
    class Test : GameMode
    {/// <summary>
    /// Metoda zwracająca wynik na ekran
    /// </summary>
    /// <returns>Ukryty wynik</returns>
        public override String goOn()
        {
            return "Score hidden";
        }
        
    }
}
