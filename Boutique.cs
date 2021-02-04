using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Limbaje
{
    class Boutique: Magazin
    {
        public string _ceVinde;

        public Boutique(string nume, string tip, int suprafata, string ceVinde, int clienti): base(nume, tip, suprafata, clienti)
        {
            _ceVinde = ceVinde;
            
        }

        public override string Oferta()
        {
            return "Magazinul nu are oferte";
        }

        public override string ToString()
        {
            return string.Format("Magazinul se numeste {0}, este un {1} si vinde {2}. {3} si {4}", _nume, _tipMagazin, _ceVinde, Oferta(), Aglomerat());
        }
    }
}
