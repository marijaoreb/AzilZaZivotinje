using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azil
{
    public partial class Admin : Form
    {
        private string putanjaDatoteke = Path.Combine(Application.StartupPath, "admin.txt");
        private string korisnickoImeDat = "";
        private string lozinkaDat = "";

        public Admin()
        {
            InitializeComponent();
            UcitajAdminPodatke();
        }

        private void UcitajAdminPodatke()
        {
            // provjera postoji li datoteka
            if (!File.Exists(putanjaDatoteke))
            {
                MessageBox.Show("Datoteka s admin podacima ne postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // čitamo prvu liniju (npr. "admin|1234")
            string linija = File.ReadAllText(putanjaDatoteke).Trim();
            string[] dijelovi = linija.Split('|');

            if (dijelovi.Length == 2)
            {
                korisnickoImeDat = dijelovi[0];
                lozinkaDat = dijelovi[1];
            }
            else
            {
                MessageBox.Show("Pogrešan format datoteke admin.txt!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorisnickoIme.Text.Trim();
            string lozinka = txtLozinka.Text.Trim();

            // provjera prema podacima iz datoteke
            if (korisnickoIme == korisnickoImeDat && lozinka == lozinkaDat)
            {
                MessageBox.Show("Prijava uspješna!", "Dobrodošli", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Pocetna poc = new Pocetna();
                poc.Show();
                this.Hide();
                txtKorisnickoIme.Clear();
                txtLozinka.Clear();
            }
            else
            {
                MessageBox.Show("Neispravno korisničko ime ili lozinka!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLozinka.Clear();
                txtKorisnickoIme.Clear();
            }
        }

        
    }
}
