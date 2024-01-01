using HmrsDeneme.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HmrsDeneme
{
    public partial class frmParolaYenile : Form
    {
        public Employee Employee { get; set; }
        public frmParolaYenile(Employee? employee)
        {
            Employee = employee;
           
            InitializeComponent();
        }

        private void frmParolaYenile_Load(object sender, EventArgs e)
        {

        }

        private void btnYeniParola_Click(object sender, EventArgs e)
        {
            var context = new HmrsContext();
            
            var selected = context.Employees.FirstOrDefault(e => e.UserId == Employee.UserId);
            selected.Password = txtYeniParola.Text;
            
            if (selected.Password!=null)
            {
                context.SaveChanges();
                MessageBox.Show("Şifreniz başarıyla değiştirildi.");
                frmHmrsGiris frmHmrsGiris = new frmHmrsGiris();
                frmHmrsGiris.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("lütfen geçerli bir şifre giriniz.");
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmParolamiUnuttum frmParolamiUnuttum= new frmParolamiUnuttum();
            frmParolamiUnuttum.Show();
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
