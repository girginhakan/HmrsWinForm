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
    public partial class frmYeniKullanici : Form
    {
        public frmYeniKullanici()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var context = new HmrsContext();
            var user = new User();
            user.TcNo = txtTcNo.Text;
            user.FirstName= txtFirstName.Text;
            user.LastName= txtLastName.Text;
            user.BirthDate= DateTime.Now;
            if (rbMan.Checked)
            {
                user.Gender = rbMan.Text;
            }
            else
            {
                user.Gender=rbWoman.Text;
            }

            user.MobilePhone = txtPhoneNumber.Text;
            context.Users.Add(user);

            var employee =new Employee();
            employee.WorkingUnit = cbWorkingUnit.Text;
            employee.UserName =txtUserName.Text;
            employee.Password = txtPassword.Text;
            context.Employees.Add(employee);

            MessageBox.Show("İlgili kişi eklenmiştir.");
            context.SaveChanges();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmHmrsGiris frmHmrsGiris= new frmHmrsGiris();
            frmHmrsGiris.Show();
            this.Close();
        }

        private void frmYeniKullanici_Load(object sender, EventArgs e)
        {

        }

        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            lblMinimalize.BackColor = Color.FromArgb(0, 94, 102);

        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
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
