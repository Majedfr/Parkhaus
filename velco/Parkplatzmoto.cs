using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace velco
{
    internal class Parkplatzmoto : parkplatz
    {
        
        public Parkplatzmoto(int etage, int position) : base(etage, position)
        {
            this.Etage = etage;
            this.Nummer = position;
        }

        public override string ToString()
        {
            if(this.Etage == 0)
            {
                string eteage = "EG";
                return "Etage : " + eteage + "\n\n" + "Parkplatz Nummer : " + this.Nummer;
            }
            else return "Etage : " + this.Etage + "\n\n" + "Parkplatz Nummer : " + this.Nummer;
            
        }
    }
}
