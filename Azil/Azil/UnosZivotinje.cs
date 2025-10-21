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
                string datumD = dateTimePicker1.Value.ToString("dd.MM.yyyy.");
                bool cijepljen = checkBox1.Checked;
                bool kastriran = checkBox2.Checked;

                if (ime == "" || vrsta == "" || pasmina == "" || spol == "" || dob <= 0 || putanjaSlike == "")
                {
                    MessageBox.Show("Sva polja osim napomene moraju biti popunjena!", "Greška: ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //nitko nije udomljen na pocetku
                string udomitelj = "nitko";
                string kontakt = "nema";
                string datumU = "nemaDatuma";

                Zivotinja z = new Zivotinja(ime, vrsta, pasmina, spol, dob, datumD, datumU, cijepljen, kastriran, napomena, udomitelj, kontakt, putanjaSlike);

                string putanja = Path.Combine(Application.StartupPath, "zivotinje.txt");
                using (StreamWriter sw = new StreamWriter(putanja, true))
                {
                    sw.WriteLine($"{z.Ime}|{z.Vrsta}|{z.Pasmina}|{z.Spol}|{z.Dob}|{z.Slika}|{z.DatumD}|{z.DatumU}|{z.Cijepljen}|{z.Kastriran}|{z.Napomena}|{z.Udomitelj}|{z.Kontakt}");
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

        private void button1_Click(object sender, EventArgs e)
        {
            //povratak na pocetnu
            Pocetna pocetna = new Pocetna();
            pocetna.Show();
            this.Close();
        }
        private string putanjaSlike = "";
        private void button2_Click(object sender, EventArgs e)
        {
            //upload slike
            openFileDialog1.Title = "Odaberite sliku životinje";
            openFileDialog1.Filter = "Slike (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string originalnaPutanja = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(originalnaPutanja);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                // Folder "Slike" unutar projekta
                string folderSlike = Path.Combine(Application.StartupPath, "Slike");
                Directory.CreateDirectory(folderSlike);

                // Kopiraj sliku u taj folder
                string imeDatoteke = Path.GetFileName(originalnaPutanja);
                string destinacija = Path.Combine(folderSlike, imeDatoteke);
                File.Copy(originalnaPutanja, destinacija, true);

                // Spremi samo ime slike (npr. "luna.jpg")
                putanjaSlike = imeDatoteke;
            }
        }
    }
}