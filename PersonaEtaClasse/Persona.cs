using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaEtaClasse
{
    internal class Persona
    {
        public DateTime DataN { get; set; }

        public int Calcoloe()
        {
            Persona p = new Persona();
            int mn = DataN.Month;
            int gn = DataN.Day;
            int an = DataN.Year;

            int anno = DateTime.Now.Year;
            int mese = DateTime.Now.Month;
            int gg = DateTime.Now.Day;

            if(mn > mese)
            {
                return anno - an - 1;
            }
            else if(mn < mese)
            {
                return anno - an;
            }
            else if(gn > gg)
            {
                return anno - an - 1;
            }else
            {
                return anno - an;
            }
        }

    }
}
