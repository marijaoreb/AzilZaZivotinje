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
    public partial class UnosZivotinje : Form
    {
        public UnosZivotinje()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //unos imena
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //unos vrste
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //unos pasmine
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //unos dobi
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //cijepljen
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //unos napomene
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            //spremanje unesene zivotinje u datoteku
            try
            {
                string ime = textBox1.Text;
                string vrsta = textBox2.Text;
                string pasmina = textBox3.Text;
                string napomena = textBox4.Text;
                string spol = "";
                if (radioButton1.Checked)
                {
                    spol = "Muški";
                }
                else
                {
                    spol = "Ženski";
                }
                int dob = (int)numericUpDown1.Value;
                string datum = dateTimePicker1.Value.ToString("dd.MM.yyyy.");
                bool cijepljen = checkBox1.Checked;
                bool kastriran = checkBox2.Checked;

                if(ime == "" || vrsta == "" || pasmina == "" || spol == "" || dob <= 0)
                {
                    MessageBox.Show("Sva polja osim napomene moraju biti popunjena!", "Greška: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                string slika = "ovo treba napraviti";

                Zivotinja z = new Zivotinja(ime, vrsta, pasmina, spol, dob, datum,cijepljen, kastriran, napomena, slika);

                string putanja = Path.Combine(Application.StartupPath, "zivotinje.txt");
                using (StreamWriter sw = new StreamWriter(putanja, true))
                {
                    sw.WriteLine($"{z.Ime}|{z.Vrsta}|{z.Pasmina}|{z.Spol}|{z.Dob}|{z.Datum}|{z.Cijepljen}|{z.Kastriran}|{z.Napomena}");
                }

                MessageBox.Show("Životinja uspješno spremljena!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("Datoteka spremljena u: " + putanja);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                numericUpDown1.Value = 0;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                dateTimePicker1.Value = DateTime.Now;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Dogodila se pogreška pri spremanju: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //unos datuma dolaska
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //kastriran
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //spol je muski
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //spol je zenski
        }
    }
}
