using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiszki
{
    /// <summary>
    /// Klasa odpowiadająca za odpowiednie ułożenie pytań w zależności od języka (Wzorzec Strategy): Interfejs
    /// </summary>
        interface ILanguage
        {
        /// <summary>
        /// Metoda dostępu do "listy"
        /// </summary>
        /// <param name="pointer">Numer żądanego pytania</param>
        /// <returns>Pytanie w formie obiektu klasy IQuestion</returns>
            IQuestion chosenLearningLanguage(int pointer);
        }
    /// <summary>
    /// Klasa układająca pytania do nauki języka polskiego
    /// </summary>
        class LearnPolish : ILanguage
        {/// <summary>
        /// Zmienna przechowująca pierwsze pytanie (Wszystkie inne zostaną pod nie podpięte, lista widoczna jako jeden obiekt)
        /// </summary>
            MasterQuestion pytanie1;
        /// <summary>
        /// Metoda układająca listę pytań
        /// </summary>
        /// <param name="instance">Instancja słownika</param>
            public LearnPolish(Dictionary instance)
            {
                pytanie1 = new MasterQuestion(0, instance);
                MasterQuestion pytanie2 = new MasterQuestion(0, instance);
                MasterQuestion pytanie3 = new MasterQuestion(0, instance);
                MasterQuestion pytanie4 = new MasterQuestion(0, instance);
                MasterQuestion pytanie5 = new MasterQuestion(0, instance);
                pytanie4.AddQuestion(pytanie5);
                pytanie3.AddQuestion(pytanie4);
                pytanie2.AddQuestion(pytanie3);
                pytanie1.AddQuestion(pytanie2);
            }/// <summary>
            /// Metoda wybierająca pytanie o zadanym numerze
            /// </summary>
            /// <param name="pointer">Numer żądanego pytania</param>
            /// <returns>Pytanie w formie obiektu klasy IQuestion</returns>
            public IQuestion chosenLearningLanguage(int pointer)
            {
                switch (pointer)
                {
                    case 1:
                        {
                            return pytanie1;
                        }
                    case 2:
                        {
                            return pytanie1.returnNext();
                        }
                    case 3:
                        {
                            return pytanie1.returnNext().returnNext();
                        }
                    case 4:
                        {
                            return pytanie1.returnNext().returnNext().returnNext();
                        }
                    default:
                        {
                            return pytanie1.returnNext().returnNext().returnNext().returnNext();
                        }
                }
            }
        }
    /// <summary>
    /// Klasa układająca pytania do nauki języka angielskiego
    /// </summary>
    class LearnEnglish : ILanguage
        {
        /// <summary>
        /// Zmienna przechowująca pierwsze pytanie (Wszystkie inne zostaną pod nie podpięte, lista widoczna jako jeden obiekt)
        /// </summary>
        MasterQuestion pytanie1;
        /// <summary>
        /// Metoda układająca listę pytań
        /// </summary>
        /// <param name="instance">Instancja słownika</param>
        public LearnEnglish(Dictionary instance)
            {
                pytanie1 = new MasterQuestion(1, instance);
                MasterQuestion pytanie2 = new MasterQuestion(1, instance);
                MasterQuestion pytanie3 = new MasterQuestion(1, instance);
                MasterQuestion pytanie4 = new MasterQuestion(1, instance);
                MasterQuestion pytanie5 = new MasterQuestion(1, instance);
                pytanie4.AddQuestion(pytanie5);
                pytanie3.AddQuestion(pytanie4);
                pytanie2.AddQuestion(pytanie3);
                pytanie1.AddQuestion(pytanie2);
            }
        /// <summary>
        /// Metoda wybierająca pytanie o zadanym numerze
        /// </summary>
        /// <param name="pointer">Numer żądanego pytania</param>
        /// <returns>Pytanie w formie obiektu klasy IQuestion</returns>
        public IQuestion chosenLearningLanguage(int pointer)
            {
                switch (pointer)
                {
                    case 1:
                        {
                            return pytanie1;
                        }
                    case 2:
                        {
                            return pytanie1.returnNext();
                        }
                    case 3:
                        {
                            return pytanie1.returnNext().returnNext();
                        }
                    case 4:
                        {
                            return pytanie1.returnNext().returnNext().returnNext();
                        }
                    default:
                        {
                            return pytanie1.returnNext().returnNext().returnNext().returnNext();
                        }
                }
            }
        }
}

