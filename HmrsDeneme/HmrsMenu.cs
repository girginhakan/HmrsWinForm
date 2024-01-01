using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HmrsDeneme
{
    public partial class frmHmrsMenu : Form
    {
        public frmHmrsMenu()
        {
            InitializeComponent();
        }

        private void btnHastaKabul_Click(object sender, EventArgs e)
        {
            frmHmrsHastaKabul frmHmrsHastaKabul = new frmHmrsHastaKabul();
            frmHmrsHastaKabul.Show();
            this.Close();
        }

        private void btnPoliklinik_Click(object sender, EventArgs e)
        {
            frmPoliklinikListe frmPoliklinikListe = new frmPoliklinikListe();
            frmPoliklinikListe.Show();
            this.Close();
        }

        private void btnLaboratuvar_Click(object sender, EventArgs e)
        {
            frmLaboratuvarListe frmLaboratuvarListe = new frmLaboratuvarListe();
            frmLaboratuvarListe.Show();
            this.Close();
        }

        private void btnyoneticiModul_Click(object sender, EventArgs e)
        {
            frmYoneticiModul frmYoneticiModul = new frmYoneticiModul();
            frmYoneticiModul.Show();
            this.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmHmrsGiris frmHmrsGiris = new frmHmrsGiris();
            frmHmrsGiris.Show(); 
            this.Close();
        }

        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.FromArgb(0, 94, 102);

        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.FromArgb(0, 109, 119);

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            var durum = MessageBox.Show("Çıkış yapmak istiyormusunuz?", "Çıkış yapılıyor", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (durum == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void lblMinimalize_MouseHover(object sender, EventArgs e)
        {
            lblMinimalize.BackColor = Color.FromArgb(0, 94, 102);

        }

        private void lblMinimalize_MouseLeave(object sender, EventArgs e)
        {
            lblMinimalize.BackColor = Color.FromArgb(0, 109, 119);

        }

        private void lblMinimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
