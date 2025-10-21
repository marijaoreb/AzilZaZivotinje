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
    public partial class Udomi : Form
    {
        private List<string> linije = new List<string>(); 
        private List<int> neudomljeneIndexe = new List<int>(); 
        private int trenutniIndex = 0;
        public Udomi()
        {
            InitializeComponent();
            UcitajZivotinje();
            PrikaziTrenutnu();
        }
        private void UcitajZivotinje()
        {
            
        }

        private void PrikaziTrenutnu()
        {
            
        }

        private void btnudomi_Click(object sender, EventArgs e)
        {
            
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
    }
}
