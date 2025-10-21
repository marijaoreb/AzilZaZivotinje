namespace Azil
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //filtriranje zivotinja
            this.Hide();
            Filtriranje filtriranje = new Filtriranje();
            filtriranje.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // unos zivotinje
            this.Hide();
            UnosZivotinje unos = new UnosZivotinje();
            unos.Show();
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            // pregled zivotinja
            this.Hide();
            PregledZivotinja pregled = new PregledZivotinja();
            pregled.Show();
        }

        private void btnUdomljavanje_Click(object sender, EventArgs e)
        {
            // udomljavanje zivotinja
            this.Hide();
            Udomi udomi = new Udomi();
            udomi.Show();
        }
    }
}
