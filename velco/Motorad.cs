using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace velco
{
    internal class Motorad : Fahrzeug
    {
        public override bool Rausfahren(List<parkplatz> list, string kennzeichen)
        {
            foreach (var parkplatz in list)
            {
                if (parkplatz is Parkplatzmoto)
                {

                    if (parkplatz.wagen != null)
                    {
                        if (parkplatz.wagen.Kennzeichen == kennzeichen)
                        {
                            parkplatz.wagen = null;
                            return true;
                        }
                    }

                }
            }
            return false;
        }

        public override parkplatz Reinfahren(List<parkplatz> list, Fahrzeug car)
        {
            foreach (var parkplatz in list)
            {
                if (parkplatz is Parkplatzmoto)
                {

                    if (parkplatz.wagen == null)
                    {

                        parkplatz.wagen = car; 
                        return parkplatz;
                    }



                }
            }
            return null;
        }
    }
}
