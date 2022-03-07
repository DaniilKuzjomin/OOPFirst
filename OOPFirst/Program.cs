
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            inimene[] inimesed = new inimene[3];
            for (int i = 0; i < 3; i++)
            {
                inimesed[i] = new inimene();
                Console.WriteLine("Nimi: ");
                inimesed[i].Eesnimi = Console.ReadLine();
                Console.WriteLine("Vanus: ");
                inimesed[i].Vanus = int.Parse(Console.ReadLine());
            }
            foreach (inimene inimene in inimesed)
            {
                inimene.Tervitame();
            }

            inimene mehe = new inimene();
            inimene nais = new inimene();

            mehe.Sugu = "Mees";
            mehe.Kasv = "Keskmine";

            Console.WriteLine("Minu sugu on {0}, minu kasv on {1}", mehe.Sugu, mehe.Kasv);
            



            inimene m = new inimene("Petja",Sugu.mees);
            m.Eesnimi = "Peter";
            Console.WriteLine("Minu nimi on {0} ja minu sugu on {1}", m.Eesnimi, Sugu.mees);


            
            inimene mees = new inimene();
            mees.Eesnimi = "Mati";
            Console.WriteLine("Ma olen {0}, kui vana ma olen?", mees.Eesnimi);
            mees.Vanus = int.Parse(Console.ReadLine());
            mees.Tervitame();
            */



            /*
            inimene naine = new inimene("Marina", Emakeel.saksa, Sugu.naine);
            //naine.Tervitame();
            naine.Palk = 1000;
            double minutulu = naine.Tulumaks();
            Console.WriteLine("Minu tulumaks on " + minutulu);
            naine.Tervitame();
            

            //inimene m = new inimene("Petja", Sugu.mees);
            //m.Eesnimi = "Peter";
            //Console.WriteLine("Minu nimi on {0} ja minu sugu on {1}", m.Eesnimi, Sugu.mees);
            */

            Opilane o = new Opilane("Kati", "TARpv21",2);
            o.Hinne = 4;
            o.Information();

            o.idontknow();


            Console.ReadLine();
        }
    }
}
