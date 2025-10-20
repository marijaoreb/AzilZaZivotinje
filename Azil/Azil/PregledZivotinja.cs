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
    public partial class PregledZivotinja : Form
    {
        List<string> linije = new List<string>();
        public PregledZivotinja()
        {
            InitializeComponent();
            UcitajZivotinje();
        }

        private void UcitajZivotinje()
        {
            try
            {
                string putanja = Path.Combine(Application.StartupPath, "zivotinje.txt");

                if (!File.Exists(putanja))
                {
                    MessageBox.Show("Datoteka zivotinje.txt nije pronađena.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                linije = File.ReadAllLines(putanja).ToList();

                listBox1.Items.Clear();

                foreach (string linija in linije)
                {
                    string[] podaci = linija.Split('|');
                    if (podaci.Length > 0)
                    {
                        listBox1.Items.Add(podaci[0]);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju datoteke: " + ex.Message, "Greška: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //svi zapisi iz datoteke
            int index = listBox1.SelectedIndex;
            if (index < 0 || index >= linije.Count) return;

            string linija = linije[index];
            string[] podaci = linija.Split("|");

            if (podaci.Length >= 9)
            {
                textBox1.Text =
                    $"Ime: {podaci[0]}\r\n" +
                    $"Vrsta: {podaci[1]}\r\n" +
                    $"Pasmina: {podaci[2]}\r\n" +
                    $"Spol: {podaci[3]}\r\n" +
                    $"Dob: {podaci[4]}\r\n" +
                    $"Datum dolaska: {podaci[5]}\r\n" +
                    $"Cijepljen: {podaci[6]}\r\n" +
                    $"Kastriran: {podaci[7]}\r\n" +
                    $"Napomena: {podaci[8]}";
                //dodati sliku
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //slika odabrane zivotinje
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //detaljan prikaz podataka
            //sve ih prikazati u istom textboxu, svaki podatak u novom redu
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // brisanje zivotinje
            int index = listBox1.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Odaberite životinju koju želite obrisati.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var potvrda = MessageBox.Show($"Jeste li sigurni da želite obrisati '{listBox1.SelectedItem}'?",
                                           "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (potvrda == DialogResult.Yes)
            {
                try
                {
                    // ukloni iz liste i listBoxa
                    linije.RemoveAt(index);
                    listBox1.Items.RemoveAt(index);

                    // obriši datoteku i upiši nove podatke
                    string putanja = Path.Combine(Application.StartupPath, "zivotinje.txt");
                    File.WriteAllLines(putanja, linije);

                    textBox1.Clear();

                    MessageBox.Show("Životinja je obrisana.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri brisanju: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // uredivanje zivotinje
            // moze se urediti samo ime, vrsta i napomena (zasad)
            int index = listBox1.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Odaberite životinju koju želite urediti.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string linija = linije[index];
            string[] podaci = linija.Split('|');

            // Otvori jednostavnu formu za uređivanje
            string novoIme = Microsoft.VisualBasic.Interaction.InputBox("Unesite novo ime:", "Uređivanje", podaci[0]);
            string novaVrsta = Microsoft.VisualBasic.Interaction.InputBox("Unesite novu vrstu:", "Uređivanje", podaci[1]);
            string novaNapomena = Microsoft.VisualBasic.Interaction.InputBox("Unesite novu napomenu:", "Uređivanje", podaci[8]);

            if (novoIme != "" && novaVrsta != "")
            {
                podaci[0] = novoIme;
                podaci[1] = novaVrsta;
                podaci[8] = novaNapomena;

                // Spoji natrag u liniju
                linije[index] = string.Join(";", podaci);

                // Spremi u datoteku
                string putanja = Path.Combine(Application.StartupPath, "zivotinje.txt");
                File.WriteAllLines(putanja, linije);

                // Ažuriraj ListBox i TextBox
                listBox1.Items[index] = novoIme;

                listBox1.SelectedIndex = index; // prikaz detalja u textBox1
                MessageBox.Show("Životinja je uređena.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ime i vrsta ne smiju biti prazni.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
