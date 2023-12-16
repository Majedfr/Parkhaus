using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace velco
{
    public abstract class Fahrzeug
    {
        public string Kennzeichen { get; set; }
        public abstract parkplatz Reinfahren(List<parkplatz> list, Fahrzeug car);
        public abstract bool Rausfahren(List<parkplatz> list, string kennzeichen);
        
    }
}
