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


            inimene mees = new inimene();
            mees.Eesnimi = "Mati";
            Console.WriteLine("Ma olen {0}, kui vana ma olen?", mees.Eesnimi);
            mees.Vanus = int.Parse(Console.ReadLine());
            mees.Tervitame();
            inimene naine = new inimene("Marina", Emakeel.saksa);

            Console.WriteLine(naine.Emakeel);
            naine.Tervitame();



            Console.ReadLine();
        }
    }
}
