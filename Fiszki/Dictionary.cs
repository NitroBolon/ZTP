using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiszki
{/// <summary>
/// Klasa słownika (Wzorzec Singleton)
/// </summary>
    public sealed class Dictionary
    {/// <summary>
    /// Lista słów w słowniku
    /// </summary>
        private static List<Word> wordList = new List<Word>();
        /// <summary>
        /// Konstruktor
        /// </summary>
        private Dictionary() { }
        /// <summary>
        /// Zmienna przechowująca instancję słownika
        /// </summary>
        private static Dictionary _instance;
        /// <summary>
        /// Metoda tworząca instancję słownika (jeśli jeszcze nie istnieje)
        /// </summary>
        /// <returns>Zwraca instancję słownika</returns>
        public static Dictionary getInstance()
        {
            if (_instance == null)
            {
                _instance = new Dictionary();
                string[] words;
                String line;
                System.IO.StreamReader file = new System.IO.StreamReader("dic.txt");
                while ((line = file.ReadLine()) != null)
                {
                    words = line.Split(' ');
                    var director = new Director();
                    var builder = new WordBuilder();
                    director.Builder = builder;

                    director.buildWord(words[0], words[1]);
                    wordList.Add(builder.GetWord());
                }
                file.Close();
            }
            return _instance;
        }
        /// <summary>
        /// Metoda dostępu do listy słów
        /// </summary>
        /// <returns>Lista słów w formie kolekcji</returns>
        public List<Word> getDictionary()
        {
            return wordList;
        }
        /// <summary>
        /// Metoda dodająca słowo do słownika przy pomocy Buildera
        /// </summary>
        /// <param name="pol">Słowo polskie</param>
        /// <param name="ang">Słowo angielskie</param>
        public void addWord(String pol, String ang)
        {
            var director = new Director();
            var builder = new WordBuilder();
            director.Builder = builder;
            
            director.buildWord(pol,ang);
            wordList.Add(builder.GetWord());
        }
        /// <summary>
        /// Metoda usuwająca tłumaczenia ze słownika
        /// </summary>
        /// <param name="pol">Słowo polskie</param>
        /// <param name="ang">Słowo angielskie</param>
        /// <returns>Kod wynikowy (0 - powodzenie, 1 niepowodzenie)</returns>
        public int deleteWord(String pol, String ang)
        {
            int index = -1;
            for (int i=0; i<wordList.Count; i++)
            {
                if(wordList[i].wordEng==ang && wordList[i].wordPol == pol)
                {
                    index = i;
                }
            }
            if (index >= 0)
            {
                wordList.RemoveAt(index);
                return 0;
            }
            return 1;
        }
        /// <summary>
        /// Metoda losowania tłumaczenia
        /// </summary>
        /// <returns>Losowo wybrane słowo (klasy Word)</returns>
        public Word randomWord()
        {
            var rand = new Random();
            return wordList[rand.Next(wordList.Count)];
        }
    }
}

