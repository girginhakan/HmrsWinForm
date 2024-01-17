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
    public partial class frmHastaListe : Form
    {
        public frmHastaListe()
        {
            InitializeComponent();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmHmrsHastaKabul frmHmrsHastaKabul = new frmHmrsHastaKabul();
            frmHmrsHastaKabul.Show();
            this.Close();
        }

        private void HmrsHastaListe_Load(object sender, EventArgs e)
        {
            dgwHastaListele.RowHeadersVisible = false;

            var context = new HmrsContext();

            var list = from x in context.Users
                       join y in context.Patients
                      on x.UserId equals y.UserId
                       select new
                       {
                           x.UserId,
                           x.TcNo,
                           x.FirstName,
                           x.LastName,
                           y.FatherName,
                           y.MotherName,
                           x.BirthDate,
                           x.Gender,
                           y.Job,
                           y.EducationStatus,
                           x.MobilePhone
                       };
            dgwHastaListele.DataSource = list.ToList();

            context.SaveChanges();


        }

        private void btnDonMenu_Click(object sender, EventArgs e)
        {
            frmHmrsMenu frmHmrsMenu = new frmHmrsMenu();
            frmHmrsMenu.Show();
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var context = new HmrsContext();

            var selectedIndex = (int)dgwHastaListele.CurrentRow.Cells[0].Value;
            var a = context.Users.FirstOrDefault(a => a.UserId == selectedIndex);
            var b = context.Patients.FirstOrDefault(a => a.UserId == selectedIndex);
            context.Users.Remove(a);
            context.Patients.Remove(b);

            MessageBox.Show("Seçilen hastamız veritabanından silinmiştir.");


            context.SaveChanges();

        }

        private void dgwHastaListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            var context = new HmrsContext();

            var list = from x in context.Users
                       join y in context.Patients
                      on x.UserId equals y.UserId
                       select new
                       {
                           x.UserId,
                           x.FirstName,
                           x.LastName,
                           y.FatherName,
                           y.MotherName,
                           x.BirthDate,
                           x.Gender,
                           y.Job,
                           y.EducationStatus,
                           x.MobilePhone
                       };
            dgwHastaListele.DataSource = list.ToList();

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

        private void dgwHastaListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
