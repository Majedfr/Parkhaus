using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace velco
{
    public abstract class parkplatz
    {
        public int Nummer { get; set; }

        public int Etage { get; set; }
        public Fahrzeug wagen { get; set; }

        protected parkplatz(int etage,int position) { }
      public abstract override string ToString();
    }
}
