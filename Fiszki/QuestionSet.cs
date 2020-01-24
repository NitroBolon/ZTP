using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiszki
{
    /// <summary>
    /// Klasa odpowiadająca za tworzenie listy pytań (Wzorzec Composite): Interfejs
    /// </summary>
    interface IQuestion
    {
        /// <summary>
        /// Metoda dostępu do słowa będącego pytaniem
        /// </summary>
        /// <returns>Pytanie w formie String</returns>
        string returnQuestion();
        /// <summary>
        /// Metoda dostępu do słowa będącego odpowiedzią
        /// </summary>
        /// <returns>Fałszywa odpowiedź w formie String</returns>
        string returnAnswer();
        /// <summary>
        /// Metoda dostępu do słowa będącego fałszywą odpowiedzią
        /// </summary>
        /// <returns>Fałszywa odpowiedź w formie String</returns>
        string returnFalse1();
        /// <summary>
        /// Metoda dostępu do słowa będącego fałszywą odpowiedzią
        /// </summary>
        /// <returns>Fałszywa odpowiedź w formie String</returns>
        string returnFalse2();
        /// <summary>
        /// Metoda dostępu do słowa będącego fałszywą odpowiedzią
        /// </summary>
        /// <returns>Fałszywa odpowiedź w formie String</returns>
        string returnFalse3();
        /// <summary>
        /// Metoda dostępu do pytania podrzędnego
        /// </summary>
        /// <returns>Pytanie podrzędne w formie obiektu klasy IQuestion</returns>
        IQuestion returnNext();

    }
    /// <summary>
    /// Klasa będąca pytaniem nadrzędnym
    /// </summary>
    class MasterQuestion : IQuestion
    {
        private string Que, AnsT, AnsF1, AnsF2, AnsF3;
        private List<IQuestion> questions = new List<IQuestion>();
        /// <summary>
        /// Konstruktor tworzący pytanie i fałszywe odpowiedzi
        /// </summary>
        /// <param name="mode">Język nauki</param>
        /// <param name="instance">Instancja słownika</param>
        public MasterQuestion(int mode, Dictionary instance)
        {
            Word word = instance.randomWord();
            int flag = 0;
            if (mode == 1)
            {
                Que = word.getPol();
                AnsT = word.getEng();
            }
            else
            {
                Que = word.getEng();
                AnsT = word.getPol();
            }
            while (flag != 1)
            {
                Word bait = instance.randomWord();
                switch (mode)
                {
                    case 1:
                        {
                            if (bait.getEng() != AnsT)
                            {
                                AnsF1 = bait.getEng();
                                flag = 1;
                            }
                        }break;
                    default:
                        {
                            if (bait.getPol() != AnsT)
                            {
                                AnsF1 = bait.getPol();
                                flag = 1;
                            }
                        }
                        break;
                        
                }
            }
            flag = 0;
            while (flag != 1)
            {
                Word bait = instance.randomWord();
                switch (mode)
                {
                    case 1:
                        {
                            if (bait.getEng() != AnsT && bait.getEng() != AnsF1)
                            {
                                AnsF2 = bait.getEng();
                                flag = 1;
                            }
                        }
                        break;
                    default:
                        {
                            if (bait.getPol() != AnsT && bait.getPol() != AnsF1)
                            {
                                AnsF2 = bait.getPol();
                                flag = 1;
                            }
                        }
                        break;

                }
            }
            flag = 0;
            while (flag != 1)
            {
                Word bait = instance.randomWord();
                switch (mode)
                {
                    case 1:
                        {
                            if (bait.getEng() != AnsT && bait.getEng() != AnsF1 && bait.getEng() != AnsF2)
                            {
                                AnsF3 = bait.getEng();
                                flag = 1;
                            }
                        }
                        break;
                    default:
                        {
                            if (bait.getPol() != AnsT && bait.getPol() != AnsF1 && bait.getPol() != AnsF2)
                            {
                                AnsF3 = bait.getPol();
                                flag = 1;
                            }
                        }
                        break;

                }
            }
        }
        /// <summary>
        /// Metoda dostępu do pytania podrzędnego
        /// </summary>
        /// <returns>Pytanie podrzędne w formie obiektu klasy IQuestion</returns>
        public IQuestion returnNext()
        {
            return questions[0];
        }
        /// <summary>
        /// Metoda dodająca pytanie do listy pytań podrzędnych
        /// </summary>
        /// <param name="que">Pytanie klasy IQuestion</param>
        public void AddQuestion(IQuestion que)
        {
            questions.Add(que);
        }
        /// <summary>
        /// Metoda dostępu do słowa będącego pytaniem
        /// </summary>
        /// <returns>Pytanie w formie String</returns>
        public string returnQuestion()
        {
            return Que;
        }
        /// <summary>
        /// Metoda dostępu do słowa będącego odpowiedzią
        /// </summary>
        /// <returns>Fałszywa odpowiedź w formie String</returns>
        public string returnAnswer()
        {
            return AnsT;
        }
        /// <summary>
        /// Metoda dostępu do słowa będącego fałszywą odpowiedzią
        /// </summary>
        /// <returns>Fałszywa odpowiedź w formie String</returns>
        public string returnFalse1()
        {
            return AnsF1;
        }
        /// <summary>
        /// Metoda dostępu do słowa będącego fałszywą odpowiedzią
        /// </summary>
        /// <returns>Fałszywa odpowiedź w formie String</returns>
        public string returnFalse2()
        {
            return AnsF2;
        }
        /// <summary>
        /// Metoda dostępu do słowa będącego fałszywą odpowiedzią
        /// </summary>
        /// <returns>Fałszywa odpowiedź w formie String</returns>
        public string returnFalse3()
        {
            return AnsF3;
        }
    }
}
