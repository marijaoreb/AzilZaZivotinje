using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azil
{
    public partial class Udomi : Form
    {
        private List<string> linije = new List<string>();
        private List<int> neudomljeneIndexe = new List<int>();
        private int trenutniIndex = 0;

        private string putanjaDatoteke = Path.Combine(Application.StartupPath, "zivotinje.txt");
        private string folderSlike = Path.Combine(Application.StartupPath, "Slike");

        public Udomi()
        {
            InitializeComponent();
            UcitajZivotinje();
            PrikaziTrenutnu();
        }

        private void PrikaziTrenutnu()
        {
            if (neudomljeneIndexe.Count == 0)
            {
                MessageBox.Show("Nema neudomljenih životinja!");
                pictureBox1.Image = null;
                return;
            }

            int index = neudomljeneIndexe[trenutniIndex];
            string[] p = linije[index].Split('|');

            // Učitavanje slike
            string imeSlike = p[5];
            string punaPutanja = Path.Combine(folderSlike, imeSlike);
            if (File.Exists(punaPutanja))
            {
                pictureBox1.Image = Image.FromFile(punaPutanja);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void UcitajZivotinje()
        {
            if (!File.Exists(putanjaDatoteke))
            {
                MessageBox.Show("Datoteka s podacima o životinjama ne postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            linije = File.ReadAllLines(putanjaDatoteke).ToList();
            neudomljeneIndexe.Clear();

            for (int i = 0; i < linije.Count; i++)
            {
                string[] polja = linije[i].Split('|');
                if (polja.Length >= 13)
                {
                    string udomitelj = polja[11].Trim();
                    if (udomitelj == "nitko")
                    {
                        neudomljeneIndexe.Add(i);
                    }
                }
            }

            trenutniIndex = 0;
        }

        private void btnudomi_Click(object sender, EventArgs e)
        {
            if (neudomljeneIndexe.Count == 0) return;

            string udomitelj = textBoxIme.Text.Trim() + " " + textBoxPrezime.Text.Trim();
            string kontakt = textBoxKontakt.Text.Trim();

            if (udomitelj == "")
            {
                MessageBox.Show("Unesite podatke udomitelja!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = neudomljeneIndexe[trenutniIndex];
            string[] p = linije[index].Split('|');

            // Ažuriranje podataka
            p[11] = udomitelj;
            p[12] = kontakt;
            p[7] = DateTime.Now.ToString("dd.MM.yyyy.");

            linije[index] = string.Join("|", p);
            File.WriteAllLines(putanjaDatoteke, linije);

            MessageBox.Show($"Životinja '{p[0]}' je uspješno udomljena!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxIme.Clear();
            textBoxPrezime.Clear();
            textBoxKontakt.Clear();
            if (Controls.OfType<DateTimePicker>().Any())
            {
                foreach (DateTimePicker dtp in Controls.OfType<DateTimePicker>())
                    dtp.Value = DateTime.Now;
            }

            // Uklanjanje iz liste neudomljenih i prikaz sljedeće
            neudomljeneIndexe.RemoveAt(trenutniIndex);
            if (trenutniIndex >= neudomljeneIndexe.Count)
                trenutniIndex = 0;

            PrikaziTrenutnu();
        }

        private void btnnaprijed_Click(object sender, EventArgs e)
        {
            // listanje zivotinja... botun za naprijed
            if (neudomljeneIndexe.Count == 0) return;

            trenutniIndex++;
            if (trenutniIndex >= neudomljeneIndexe.Count)
                trenutniIndex = 0; // vraćamo se na prvu životinju

            PrikaziTrenutnu();

        }

        private void btnnatrag_Click(object sender, EventArgs e)
        {
            //listanje zivotinja... botun za natrag
            if (neudomljeneIndexe.Count == 0) return;

            trenutniIndex--;
            if (trenutniIndex < 0)
                trenutniIndex = neudomljeneIndexe.Count - 1; // idemo na zadnju

            PrikaziTrenutnu();
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
