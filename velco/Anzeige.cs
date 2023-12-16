using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace velco
{
    public partial class Anzeige : Form
    {
        private readonly Controller Controlles;
        private List<parkplatz> parkplatze;
        public Anzeige(List<parkplatz> mylist, Controller controller)
        {
            InitializeComponent();
            parkplatze = mylist;
            Controlles = controller;
        }

        private void btn_info_Click(object sender, EventArgs e)//Hier ist nicht notwendig die eingabe ob um ein Auto geht oder Motorad
                                                               //Die suche wird anhand das Kennenzeichen passiert.
        {
            parkplatz pa = Controlles.InfoOrempty(parkplatze, tb_kennzeichen.Text.ToUpper());
            if (pa != null)
            {
                rtb_info.Text = "die gesuchte Fahrzeug  mit dem Kennzeichen: " + tb_kennzeichen.Text + " befindet sich im\n\n" + pa.ToString();
            }
            else MessageBox.Show("keine fahrzeug gefunden unter diese kennenzeichen");

        }

        private void btn_rein_Click(object sender, EventArgs e)
        {
            if (tb_kennzeichen.Text != "")
            {
                bool exsistenz = Controlles.PrufenKennzichenExsistenz(parkplatze, tb_kennzeichen.Text.ToUpper());//hier wird erstmal geprüft ob die angegene kennenzeichen da 
                if (exsistenz)
                {
                    MessageBox.Show("die angegebene kennenzeichen kann nicht akzeptiert werden\n überprufen sie Ihre eingabe");
                }
                else if (rbn_auto.Checked)// Hier wird  geprüft anhand der radiobutton ob um ein Auto oder Motorad geht
                {
                    Fahrzeug mycar = new Auto();

                    mycar.Kennzeichen = tb_kennzeichen.Text.ToUpper();
                    parkplatz pa = mycar.Reinfahren(parkplatze, mycar);// Hier wird wenn freiplatz gibt das Auto ein parkplatz zugewiesen oder null wenn kein parkplatz vorhanden
                    if (pa != null)
                    {
                        rtb_info.Text = "Der Parkplatz für das Auto mit dem Kennzeichen  " + mycar.Kennzeichen + "  ist\n\n"
                           + pa.ToString();
                    }
                    else rtb_info.Text = "\n\n\n    keine platz vorhanden ";
                }
                else if (rbn_motorad.Checked)
                {
                    Fahrzeug mymoto = new Motorad();
                    mymoto.Kennzeichen = tb_kennzeichen.Text.ToUpper();
                    parkplatz pa = mymoto.Reinfahren(parkplatze, mymoto);
                    if (pa != null)
                    {
                        rtb_info.Text = "Der Parkplatz für das Motorad mit dem Kennzeichen  :" + mymoto.Kennzeichen + "  ist\n\n"
                            + pa.ToString();
                    }
                    else rtb_info.Text = "\n\n\n   keine platz vorhanden ";
                }

            }
            else MessageBox.Show("bitte geben Sie Ihres Kennzeichen ein");
        }

        private void btn_raus_Click(object sender, EventArgs e)
        {
            if (rbn_auto.Checked) //hier wir erst anhand der eingabe festgestellt ob um Auto oder Motorad geht
            {
                Fahrzeug mycar = new Auto();

                bool ergebnis = mycar.Rausfahren(parkplatze, tb_kennzeichen.Text.ToUpper());//hier wird überprüft ob die kennzeichen vorhanden und
                                                                                            //wenn ja wird das Objekt von Parkplatz enfernt und true zurückgegeben sonst wird falls zurückgegeben

                if (!ergebnis)
                {
                    MessageBox.Show("die angegebene Kenenzeichen  " + tb_kennzeichen.Text + "  ist Falsch oder das Auto ist Raus");
                }
                else MessageBox.Show("Gute fahrt  "+tb_kennzeichen.Text);


            }
            if (rbn_motorad.Checked)
            {
                Fahrzeug mycar = new Motorad();

                bool ergebnis = mycar.Rausfahren(parkplatze, tb_kennzeichen.Text.ToUpper());
                if (!ergebnis)
                {
                    MessageBox.Show("die angegebene Kenenzeichen " + tb_kennzeichen.Text + "  ist Falsch  oder das Motorad ist Raus");
                }
                else MessageBox.Show("Gute fahrt  "+tb_kennzeichen.Text);


            }
        }
        private void Anzeige_Load(object sender, EventArgs e) //hier wird nur festgelegt das die radiobutton beim start auf Auto gesetzt
        {

            rbn_auto.Checked = true;

        }

        private void btn_frei_Click(object sender, EventArgs e)
        {
            string ergebniss = Controlles.Suchfreiplatze(parkplatze);
            rtb_info.Text = ergebniss;
        }
    }
}

