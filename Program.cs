using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Limbaje
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Magazin> magazine = new List<Magazin>();
            magazine.Add(new Boutique("Magazin 1", "Boutique", 120, "flori", 10));
            magazine.Add(new SuperMarket("Magazin 2", "SuperMarket", 500, 40, 100));
            magazine.Add(new Magazin("Magazin 3","Chiosc", 20, 4));

            File.ReadAllLines("Date.in");

            Console.WriteLine(Afisare(magazine));
            File.WriteAllText("Date.out", Afisare(magazine));

            Console.WriteLine("Ordonare dupa nr clienti");
            Console.WriteLine(rap1(magazine));


            Console.ReadKey();

        }

        static List<Magazin> CitesteFisier(string cale)
        {
            List<Magazin> magazine = new List<Magazin>();
            foreach (string rand in File.ReadAllLines(cale))
            {
                char f = ',';
                string[] atomi = rand.Split(f);
                if (atomi[2] == "SuperMarket")
                {
                    magazine.Add(new SuperMarket(atomi[1], atomi[2], int.Parse(atomi[3]), int.Parse(atomi[4]), int.Parse(atomi[5])));
                }
                else if (atomi[2] == "Boutique")
                {
                    magazine.Add(new Boutique(atomi[1], atomi[2], int.Parse(atomi[3]), atomi[4], int.Parse(atomi[5])));
                }
            }
            return magazine;

        }

        static string Afisare (List<Magazin> magazine)
        {
            string text = "";
            int SuperMarket=0, Boutique=0;
            foreach(Magazin a in magazine)
            {
                text+= a.ToString()+ '\n';
                if (a is SuperMarket)
                    SuperMarket++;
                if(a is Boutique)
                    Boutique++;
            }

            text += string.Format("{0} SuperMarketuri si {1} boutiqueuri", SuperMarket, Boutique);
            return text;
        }


        static string rap1(List<Magazin> magazine)
        {
            List<Magazin> nou = new List<Magazin>(magazine);
            nou.Sort();
            return Afisare(nou);
        }


    }
}
