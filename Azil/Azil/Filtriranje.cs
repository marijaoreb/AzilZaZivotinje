using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Azil
{
    public partial class Filtriranje : Form
    {
        private List<string> linije = new List<string>();
        public Filtriranje()
        {
            InitializeComponent();
            UcitajZivotinje();
            PopuniComboBox();
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
                PrikaziSve();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju datoteke: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopuniComboBox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Sve vrste");
            // automatski dodaj sve jedinstvene vrste iz datoteke
            var vrste = linije.Select(l => l.Split('|')[1]).Distinct();
            foreach (var v in vrste)
                comboBox1.Items.Add(v);

            comboBox1.SelectedIndex = 0; // default "Sve vrste"
        }

        private void PrikaziSve()
        {
            listBox1.Items.Clear();
            foreach (string linija in linije)
            {
                string[] podaci = linija.Split('|');
                if (podaci.Length > 0)
                    listBox1.Items.Add(podaci[0]); // ime životinje
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string odabrano = comboBox1.SelectedItem.ToString();

            listBox1.Items.Clear();

            foreach (string linija in linije)
            {
                string[] podaci = linija.Split('|');
                string vrsta = podaci[1];

                if (vrsta == odabrano)
                {
                    listBox1.Items.Add(podaci[0]);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //povratak na pocetnu formu
            Pocetna pocetna = new Pocetna();
            pocetna.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0; 
            PrikaziSve();
        }
    }
}
