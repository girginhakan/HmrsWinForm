using HmrsDeneme.Entity;
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
    public partial class frmParolamiUnuttum : Form
    {
        public frmParolamiUnuttum()
        {
            InitializeComponent();
        }

        
        private void btnParolaYenile_Click(object sender, EventArgs e)
        {
            var context = new HmrsContext();
            //var b = context.Users.FirstOrDefault(e => e.TcNo == txtParolaYenile.Text);
            var a = context.Employees.FirstOrDefault(e => e.UserName == txtParolaYenile.Text);
            var data1 = a;
            //var data2 = b;

            if (data1 != null /*|| data2 != null*/)
            {
                frmParolaYenile frmParolaYenile = new frmParolaYenile(a);
                frmParolaYenile.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen yenilemek istediğiniz kullanıcının Tc Nosunu yada kullanıcı adını giriniz.");
            }
        }

        private void frmParolamiUnuttum_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmHmrsGiris frmHmrsGiris = new frmHmrsGiris();
            frmHmrsGiris.Show();
            this.Hide();
        }

        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.FromArgb(0, 94, 102);

        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.FromArgb(0, 109, 119);

        }

        private void lblMinimalize_MouseHover(object sender, EventArgs e)
        {
            lblMinimalize.BackColor = Color.FromArgb(0, 94, 102);

        }

        private void lblMinimalize_MouseLeave(object sender, EventArgs e)
        {
            lblMinimalize.BackColor = Color.FromArgb(0, 109, 119);

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            var durum = MessageBox.Show("Çıkış yapmak istiyormusunuz?", "Çıkış yapılıyor", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (durum == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void lblMinimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
