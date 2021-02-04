using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Limbaje
{
    class Magazin : IComparable
    {
        protected string _nume;
        protected string _tipMagazin;
        int _suprafata;
        int _nrClienti;

        public Magazin(string nume, string tip, int suprafata, int clienti)
        {
            _nume = nume;
            _tipMagazin = tip;
            _suprafata = suprafata;
            _nrClienti = clienti;
        }

        public Boolean calcul()
        {
            if (_suprafata / _nrClienti > 5)
                return false;
            return true;
        }

        public string Aglomerat()
        {
            if (calcul())
                return "nu este aglomerat";
            return "este aglomerat";
        }

        public override string ToString()
        {
            return string.Format("Magazinul se numeste {0}, este un {1} si are suprafata {2}mp. Sunt {3} clienti.", _nume, _tipMagazin, _suprafata, _nrClienti);
        }
        public int CompareTo(object b)
        {//dupa nr de clienti
            Magazin _b = b as Magazin;
            return this._nrClienti.CompareTo(_b._nrClienti);
        }


        public virtual string Oferta()
        {
            return string.Format("Magazinele au diferite oferte");
        }


        public static int operator + (Magazin a, Magazin b)
            {
            return a._suprafata + b._suprafata;
            }

        public static int operator -(Magazin a, Magazin b)
        {
            return a._suprafata-b._suprafata;
        }
    }
}
