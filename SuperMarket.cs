using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Limbaje
{
    class SuperMarket: Magazin
    {
        private int _nrAngajati;

        public SuperMarket(string nume, string tip, int suprafata, int angajati, int clienti) : base(nume, tip, suprafata, clienti)
        {
            _nrAngajati = angajati;
        }

        public string Oferta()
        {
            return "Magazinul are oferte la fructe si legume";
        }

        public override string ToString()
        {
            return string.Format("Magazinul se numeste {0}, este un {1} si are {4}. {2} si {3}", _nume, _tipMagazin, Oferta(), Aglomerat(),_nrAngajati);
        }
    }
}
