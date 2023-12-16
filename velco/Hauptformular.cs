namespace velco
{
    public partial class Hauptformular : Form
    {
        private readonly Controller Controle;
        public Hauptformular(Controller controle)
        {
            InitializeComponent();
            Controle = controle;
        }

        private void btn_festlegen_Click(object sender, EventArgs e)
        {
            try
            {
                // anfang wird die Eingabe in gesplietet und conviertet um die Parkplätze zu erstellen
                int etage = Convert.ToInt32(tb_etage.Text);
                string[] motoradanzahl = tb_motorad.Text.Split(',');
                string[] autoanzahl = tb_auto.Text.Split(',');
                int[] motorad = new int[motoradanzahl.Length];
                int[] autos = new int[autoanzahl.Length];
                for (int i = 0; i < motoradanzahl.Length; i++)
                {
                    motorad[i] = Convert.ToInt32(motoradanzahl[i]);
                }
                for (int i = 0; i < autoanzahl.Length; i++)
                {
                    autos[i] = Convert.ToInt32(autoanzahl[i]);
                }

                List<parkplatz> list = Controle.Erstellenparkplatze(autos, motorad, etage);//hier wird die methode in controller klasse gerufen um die parkplätze Objekte zu erstellen

                Anzeige myanzeige = new Anzeige(list, Controle); //danach wird das form Anzeige die liste alle parkplätze übergeben und Instannz die klasse Controller übergeben um die methoden der klasse zu benutzen
                this.Hide();
                myanzeige.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("überprufen sie ihre Eingabe bitte beachten das Trennzeichen (,)\n" +
                    "Bitte geben sie auch nur Zahlen und keine andere Zeichen oder Buchtaben\n sehen sie Das Beispiel ");
            }



        }

    }
}