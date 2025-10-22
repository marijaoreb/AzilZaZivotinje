using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azil
{
    public partial class Statistika : Form
    {
        private string putanjaDatoteke = Path.Combine(Application.StartupPath, "zivotinje.txt");
        private List<string[]> podaci = new List<string[]>();

        public Statistika()
        {
            InitializeComponent();
            UcitajPodatke();
            IzracunajStatistiku();
            PopuniComboBoxVrste();
        }

        private void UcitajPodatke()
        {
            if (!File.Exists(putanjaDatoteke))
            {
                MessageBox.Show("Datoteka s podacima o životinjama ne postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            podaci = File.ReadAllLines(putanjaDatoteke)
                         .Select(linija => linija.Split('|'))
                         .Where(p => p.Length >= 13)
                         .ToList();
        }

        private void IzracunajStatistiku()
        {
            if (podaci.Count == 0)
            {
                lblUkupno.Text = "0";
                lblTrenutno.Text = "0";
                lblUdomljene.Text = "0";
                lblProsjecnaDob.Text = "0";
                lblVrstaBroj.Text = "0";
                return;
            }

            // Broj ukupnih
            int ukupno = podaci.Count;

            // Broj udomljenih
            int udomljene = 0;
            foreach (var red in podaci)
            {
                if (red[11] != "nitko")
                {
                    udomljene++;
                }
            }

            // Broj trenutno prisutnih
            int prisutne = ukupno - udomljene;

            // Prosječna dob
            double prosjek = 0;
            int zbrojDob = 0;
            int brojZivotinja = 0;

            foreach (var red in podaci)
            {
                int dob;
                if (int.TryParse(red[4], out dob) && dob > 0)
                {
                    zbrojDob += dob;
                    brojZivotinja++;
                }
            }

            if (brojZivotinja > 0)
            {
                prosjek = (double)zbrojDob / brojZivotinja;
            }


            lblUkupno.Text = ukupno.ToString();
            lblUdomljene.Text = udomljene.ToString();
            lblTrenutno.Text = prisutne.ToString();
            lblProsjecnaDob.Text = prosjek.ToString("0.0");

            // Ukupno po vrstama na početku
            lblVrstaBroj.Text = ukupno.ToString();
        }

        private void PopuniComboBoxVrste()
        {
            List<string> vrste = new List<string>();

            // prolazimo kroz sve redove i dodajemo vrste ako ih već nema na popisu
            foreach (var red in podaci)
            {
                string vrsta = red[1];

                if (!vrste.Contains(vrsta))
                {
                    vrste.Add(vrsta);
                }
            }

            comboBoxVrste.Items.Clear();
            comboBoxVrste.Items.Add("Ukupno"); // početna opcija
            foreach (var v in vrste)
                comboBoxVrste.Items.Add(v);

            comboBoxVrste.SelectedIndex = 0;
            comboBoxVrste.SelectedIndexChanged += comboBoxVrste_SelectedIndexChanged;
        }

        private void comboBoxVrste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVrste.SelectedIndex == 0)
            {
                lblVrstaBroj.Text = podaci.Count.ToString();
                return;
            }

            string odabrana = comboBoxVrste.SelectedItem.ToString();
            int brojVrste = podaci.Count(p => p[1].Equals(odabrana, StringComparison.OrdinalIgnoreCase));

            lblVrstaBroj.Text = brojVrste.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //povratak na pocetnu formu
            Pocetna pocetna = new Pocetna();
            pocetna.Show();
            this.Close();
        }
    }
}
