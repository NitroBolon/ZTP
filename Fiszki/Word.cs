using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Fiszki
{
    /// <summary>
    /// Klasa będąca konstruktorem tłumaczeń w bazie (Wzorzec Builder): Interfejs
    /// </summary>
    public interface IBuilder
    {
        /// <summary>
        /// Metoda tworząca polską część tłumaczenia
        /// </summary>
        /// <param name="x">Polskie słowo</param>
        void BuildWordPol(String x);
        /// <summary>
        /// Metoda tworząca angielską część tłumaczenia
        /// </summary>
        /// <param name="x">Angielskie słowo</param>
        void BuildWordEng(String y);
    }
    /// <summary>
    /// Klasa tworząca budowniczego tłumaczenia
    /// </summary>
    public class WordBuilder : IBuilder
    {/// <summary>
    /// Zmienna przechowująca nowy produkt (klasy Word)
    /// </summary>
        private Word _product = new Word();
        /// <summary>
        /// Konstruktor resetujący ustawienia
        /// </summary>
        public WordBuilder()
        {
            this.Reset();
        }
        /// <summary>
        /// Metoda resetująca tworzony produkt
        /// </summary>
        public void Reset()
        {
            this._product = new Word();
        }
        /// <summary>
        /// Metoda tworząca polską część tłumaczenia
        /// </summary>
        /// <param name="x">Polskie słowo</param>
        public void BuildWordPol(String x)
        {
            this._product.setPol(x);
        }
        /// <summary>
        /// Metoda tworząca angielską część tłumaczenia
        /// </summary>
        /// <param name="x">Angielskie słowo</param>
        public void BuildWordEng(String x)
        {
            this._product.setEng(x);
        }
        /// <summary>
        /// Metoda dostępu do gotowego produktu
        /// </summary>
        /// <returns>Produkt klasy Word</returns>
        public Word GetWord()
        {
            Word result = this._product;

            this.Reset();

            return result;
        }
    }
    /// <summary>
    /// Klasa pojedynczego tłumaczenia
    /// </summary>
    public class Word
    {/// <summary>
    /// Zmienne przechowujące odpowiednie części tłumaczenia
    /// </summary>
        public string wordPol;
        public string wordEng;
        /// <summary>
        /// Metoda ustawiająca polską część tłumaczenia
        /// </summary>
        /// <param name="pol">Polskie słowo</param>
        public void setPol(String pol)
        {
            this.wordPol = pol;
        }/// <summary>
        /// Metoda ustawiająca angielską część tłumaczenia
        /// </summary>
        /// <param name="eng">Angielskie słowo</param>
        public void setEng(String eng)
        {
            this.wordEng = eng;
        }
        /// <summary>
        /// Metoda dostępu do polskiej części tłumaczenia
        /// </summary>
        /// <returns>Polskie słowo (String)</returns>
        public String getPol()
        {
            return wordPol;
        }
        /// <summary>
        /// Metoda dostępu do angielskiej części tłumaczenia
        /// </summary>
        /// <returns>Angielskie słowo (String)</returns>
        public String getEng()
        {
            return wordEng;
        }

    }
    /// <summary>
    /// Klasa Directora zarządzającego wytwarzaniem tłumaczenia przez Buildera
    /// </summary>
    public class Director
    {/// <summary>
    /// Zmienna przechowująca budowniczego
    /// </summary>
        private IBuilder _builder;
        /// <summary>
        /// Metotda ustawiająca wartość utworzonego Buildera
        /// </summary>
        public IBuilder Builder
        {
            set { _builder = value; }
        }
        /// <summary>
        /// Metoda budująca nowe tłumaczenie
        /// </summary>
        /// <param name="x">Polskie słowo</param>
        /// <param name="y">Angielskie słowo</param>
        public void buildWord(String x, String y)
        {
            this._builder.BuildWordPol(x);
            this._builder.BuildWordEng(y);
        }

    }

}
