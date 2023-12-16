using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace velco
{
     public class Controller
    {
        public parkplatz InfoOrempty(List<parkplatz> list, string kennzeichen)//hier wird Die parkplatz für bestemmte kennzeichen zurück gegeben falls vorhanden 
                                                                              //sonst wird null zurückgegeben.
        {
            foreach (parkplatz parkplatz in list)
            {
                if (parkplatz != null)
                {
                    if (parkplatz.wagen!=null)
                    {
                        if(parkplatz.wagen.Kennzeichen==kennzeichen)
                            return parkplatz;

                    }
                }
            }
            return null;
        }

        public bool PrufenKennzichenExsistenz(List<parkplatz> list, string kennzeichen)
        {
            foreach (var parkplatz in list)
            {
                if(parkplatz.wagen!=null) 
                {
                 if(parkplatz.wagen.Kennzeichen==kennzeichen)
                    {
                        return true;
                    }
                
                }
            }
            return false;
        }//hier wird die Existenz des kennzeichen nummer überprüft

        public string Suchfreiplatze(List<parkplatz> list) //hier werden alle Freiplätze erfasst und die Anzahl zurückgegeben
                                                           //sowohl für Motoräder als auch für Autos
        {
            int autofreiplatz = 0;
            int motoradfreiplatz = 0;
           foreach(var parkplatz in list)
            {
                if(parkplatz is ParkplatzAuto) 
                {
                    if (parkplatz.wagen == null)
                    {
                        ++autofreiplatz;
                    }
                
                }
                if (parkplatz is Parkplatzmoto)
                {
                    if (parkplatz.wagen == null)
                    {
                        ++motoradfreiplatz;
                    }

                }
            }
           string ausgabe="Anzahl Autos Freiplätze = "+autofreiplatz+"\n\n"+"Motorad Freiplätze = "+motoradfreiplatz+"";
            return ausgabe;
        }
        public List<parkplatz> Erstellenparkplatze(int[] autos, int[] motorad, int etage) //hier wurden die parkplätze erstllt nach die Eingabe die Etagen und die Anzahl die parkplätze
                                                                                          //pro etage sowol für Motorad als auch für auto
        {
            List<parkplatz> parkplatze = new List<parkplatz>();
            for (int i = 0; i < etage; i++)
            {
                for (int j = 1; j <= autos[i]; j++)
                {
                    parkplatz pa = new ParkplatzAuto(i, j);
                    parkplatze.Add(pa);
                }
                for (int n = 1 + autos[i]; n <= motorad[i] + autos[i]; n++)//hier wird Extra die Anzahl der autos addieret damit nicht die gleiche
                                                                            //parkplatznummer für Autos und Motoräder  bekommen
                {
                    parkplatz moto = new Parkplatzmoto(i, n);
                    parkplatze.Add(moto);
                }
            }
            return parkplatze;

        }
    }
}
