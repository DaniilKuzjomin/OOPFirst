using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirst
{
    public class inimene
    {
        string eesnimi; // Поля
        int vanus;
        string staatus;
        string sugu;
        int kasv;
        string stat;
        Emakeel emakeel;








        public inimene() { } // Конструктор
        public inimene(string Eesnimi, Emakeel emakeel)
        {
            eesnimi = Eesnimi;
            this.emakeel = emakeel;
        }



        //public inimene() { }
        //public inimene(string Sugu, int Kasv)
        //{
        //    sugu = Sugu;
        //    kasv = Kasv;
        //}



        public string Eesnimi
        {
            set
            {
                if (eesnimi == null) eesnimi = value;
            }
            get { return eesnimi; }
        } // Св-ва
        public int Vanus
        {
            set 
            { vanus = value;
                if (vanus<7)
                {
                    staatus = "Väike laps";
                }
                else if (vanus<17)
                {
                    staatus = "Kooli laps";
                }
                else if (vanus<65)
                {
                    staatus = "tööline inimene";
                }
                else
                {
                    staatus = "Senior";
                }
            }
            get { return vanus; }
        }
        public string Staatus
        {
            set { staatus = value; }
            get { return staatus; }
        }

        public string Sugu
        {
            set 
            { if (sugu == null) sugu = value; }
            get { return sugu; }
        }

        public int Kasv
        {
            set
            {
                kasv = value;
                if (kasv < 160)
                {
                    stat = "Väike";
                }
                else if (kasv < 185)
                {
                    stat = "Keskmine";
                }
                else if (kasv < 210)
                {
                    stat = "Pikk";
                }
            }
            get { return kasv; }
        }


        public void Tervitame() // Метод
        {
            Console.WriteLine("Tere!");
            Console.WriteLine("Minu nimi on {0}. Olen {1} aastat vana. Minu staatus on {2}", eesnimi, vanus, staatus );
        }

        public void Pool()
        {
            Console.WriteLine("Tervist!");
            Console.WriteLine("Minu kasv on {0} ja minu sugu on {1}", stat, sugu);
        }
    }
}
