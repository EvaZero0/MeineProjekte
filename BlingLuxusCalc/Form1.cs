using System.Data;
namespace BlingLuxusCalc
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Plus_Click(object sender, EventArgs e)
        {
            string term = txtb_Rechnung.Text + txtb_Input.Text;
            decimal ergebnis = Rechne(term);
            txtb_Rechnung.Text = ergebnis.ToString();
            txtb_Rechnung.Text += " + ";
            txtb_Input.Text = "";
        }

        private void bt_Minus_Click(object sender, EventArgs e)
        {
            string term = txtb_Rechnung.Text + txtb_Input.Text;
            decimal ergebnis = Rechne(term);
            txtb_Rechnung.Text = ergebnis.ToString();
            txtb_Rechnung.Text += " - ";
            txtb_Input.Text = "";
        }

        private void bt_Mal_Click(object sender, EventArgs e)
        {
            string term = txtb_Rechnung.Text + txtb_Input.Text;
            decimal ergebnis = Rechne(term);
            txtb_Rechnung.Text = ergebnis.ToString();
            txtb_Rechnung.Text += " × ";
            txtb_Input.Text = "";
        }

        private void bt_Geteiltdurch_Click(object sender, EventArgs e)
        {
            string term = txtb_Rechnung.Text + txtb_Input.Text;
            decimal ergebnis = Rechne(term);
            txtb_Rechnung.Text = ergebnis.ToString();
            txtb_Rechnung.Text += " ÷ ";
            txtb_Input.Text = "";
        }
        private void bt_Gleich_Click(object sender, EventArgs e)
        {
            string term = txtb_Rechnung.Text + txtb_Input.Text;
            decimal ergebnis = Rechne(term);
            txtb_Rechnung.Text += txtb_Input.Text;

            txtb_Rechnung.Text += " = ";
            txtb_Input.Text = ergebnis.ToString();

            bt_1.Enabled = false;
            bt_2.Enabled = false;
            bt_3.Enabled = false;
            bt_4.Enabled = false;
            bt_5.Enabled = false;
            bt_6.Enabled = false;
            bt_7.Enabled = false;
            bt_8.Enabled = false;
            bt_9.Enabled = false;
            bt_0.Enabled = false;
            bt_Plus.Enabled = false;
            bt_Minus.Enabled = false;
            bt_Mal.Enabled = false;
            bt_Geteiltdurch.Enabled = false;
            bt_Komma.Enabled = false;
            bt_ClearEntry.Enabled = false;
            bt_Back.Enabled = false;
            bt_Gleich.Enabled = false;

        }
        private void bt_0_Click(object sender, EventArgs e)
        {

            txtb_Input.Text += "0";

        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            txtb_Input.Text += "1";
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            txtb_Input.Text += "2";
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            txtb_Input.Text += "3";
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            txtb_Input.Text += "4";
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            txtb_Input.Text += "5";
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            txtb_Input.Text += "6";
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            txtb_Input.Text += "7";
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            txtb_Input.Text += "8";
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            txtb_Input.Text += "9";
        }

        private void bt_Komma_Click(object sender, EventArgs e)
        {
            txtb_Input.Text += ",";
        }

        private void bt_ClearEntry_Click(object sender, EventArgs e)
        {
            txtb_Input.Text = "";
        }
        private void bt_ClearAll_Click(object sender, EventArgs e)
        {
            bt_1.Enabled = true;
            bt_2.Enabled = true;
            bt_3.Enabled = true;
            bt_4.Enabled = true;
            bt_5.Enabled = true;
            bt_6.Enabled = true;
            bt_7.Enabled = true;
            bt_8.Enabled = true;
            bt_9.Enabled = true;
            bt_0.Enabled = true;
            bt_Plus.Enabled = true;
            bt_Minus.Enabled = true;
            bt_Mal.Enabled = true;
            bt_Geteiltdurch.Enabled = true;
            bt_Komma.Enabled = true;
            bt_ClearEntry.Enabled = true;
            bt_Back.Enabled = true;
            bt_Gleich.Enabled = true;

            txtb_Rechnung.Text = "";
            txtb_Input.Text = "";
        }
        private void bt_Back_Click(object sender, EventArgs e)
        {
            if (txtb_Input.Text.Length > 0)
            {
                txtb_Input.Text = txtb_Input.Text.Substring(0, txtb_Input.Text.Length - 1);
            }
        }

        private decimal Rechne(string rechnung)
        {
            rechnung = rechnung.Replace("×", "*").Replace("÷", "/").Replace(",", ".");

            if (rechnung.Contains("/0"))
            { }
            try
            {
                var ergebnis = new DataTable().Compute(rechnung, null);
                return Convert.ToDecimal(ergebnis);
            }
            catch (Exception)
            {
                MessageBox.Show("Fehlerhafte Eingabe! Division durch 0 ist nicht erlaubt!");
                return 0;
            }
        }

    }
}