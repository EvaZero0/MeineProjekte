using System.Linq;

namespace Lotto
{
    public partial class Form1 : Form
    {
        Random lottozahlen = new Random(); // Random-Feld
        int[] ziehung = new int[6];
        int superzahlSchein;
        int superzahlZiehung;

        string[] tipp = { "", "", "", "", "", "" };
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Numbers_Click(object sender, EventArgs e)   // Alle Buttons mit Zahlen
        {
            string zahl = (sender as Button).Text;
            for (int i = 0; i < tipp.Length; i++)
            {
                if (tipp[i] == "" && !tipp.Contains(zahl))
                {
                    tipp[i] = zahl; // wenn der Wert an index[i] der Zahl entspricht...
                    (sender as Button).BackColor = Color.LightBlue; // ... färbe Kästchen hellblau...
                    Controls["txtb_" + i].Text = zahl;  // ... und ändere die Ausgabe der Textbox -> TRICK: mit Controls["..." + i] kann man auf das Element zugreifen, wenn der Index der Nummerierung entspricht

                    break;
                }
                else if (tipp[i] == (zahl))
                {
                    tipp[i] = "";
                    (sender as Button).BackColor = Color.Snow;
                    Controls["txtb_" + i].Text = "";
                    break;

                }
            }
        }

        private void chb_Superzahl_CheckedChanged(object sender, EventArgs e)   // Häkchenbox für die Superzahl
        {
            if (chb_Superzahl.Checked)
            {
                txtb_6.Visible = true;
                txtb_Superzahl.Visible = true;
                superzahlSchein = lottozahlen.Next(0, 10);
                txtb_Superzahl.Text = superzahlSchein.ToString();
                txtb_6.Text = txtb_Superzahl.Text;
            }
            else
            {
                txtb_6.Visible = false;
                txtb_Superzahl.Visible = false;
            }
        }

        private void bt_Spielen_Click(object sender, EventArgs e)   // Spielen-Button
        {
            if (!tipp.Contains("")) // sorgt dafür, dass erst gespielt werden kann, wenn alle 6 Kästchen angekreuzt wurden
            {
                for (int i = 0; i < ziehung.Length; i++)    // zuerst werden die Lottozahlen gezogen
                {
                    int randomZahl;

                    do
                    {
                        randomZahl = lottozahlen.Next(1, 50);
                    } while (ziehung.Contains(randomZahl)); // sorgt dafür, dass keine Zahlen mehrfach gezogen werden

                    ziehung[i] = randomZahl;    // übergeben der zufälligen Zahl ins Ziehungs-Array

                }

                Array.Sort(ziehung);    // Sortierung der fertigen

                for (int i = 0; i < ziehung.Length; i++)    // gibt das Ergebnis grafisch aus (Kugeln werden sichtbar)
                {
                    Controls["tb_" + i].Text = ziehung[i].ToString();
                    Controls["pb_" + i].Visible = true;
                    Controls["tb_" + i].Visible = true;
                }

                if (chb_Superzahl.Checked)  // wie oben drüber, nur mit Superzahl (+ Ziehung)
                {
                    superzahlZiehung = lottozahlen.Next(0, 10);
                    pb_6.Visible = true;
                    tb_6.Visible = true;
                    tb_6.Text = superzahlZiehung.ToString();
                }

                for (int i = 0; i < 6; i++) // Abgleich der Zahlen
                {
                    if (int.TryParse(tipp[i], out int number) && ziehung.Contains(number))
                    {
                        Controls["txtb_" + i].BackColor = Color.LightGreen;
                    }
                    else
                    {
                        Controls["txtb_" + i].BackColor = Color.White;
                    }
                }
                if (superzahlZiehung == superzahlSchein)
                {
                    txtb_6.BackColor = Color.DarkGreen;
                }
                else
                {
                    txtb_6.BackColor = Color.Coral;

                }
                //(sender as Button).Enabled = false;
            }
            else
                MessageBox.Show("Kreuzen Sie 6 Kästchen an.");
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {

        }
    }
}
