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
    public partial class frmLaboratuvarListe : Form
    {
        public frmLaboratuvarListe()
        {
            InitializeComponent();
        }

        private void frmLaboratuvarListe_Load(object sender, EventArgs e)
        {
            dgwLaboratuvarListe.RowHeadersVisible = false;

            var context = new HmrsContext();

            var list = from x in context.Users
                       join y in context.Employees
                      on x.UserId equals y.UserId
                       where y.WorkingUnit == "Laboratuvar"
                       select new
                       {
                           x.UserId,
                           y.WorkingUnit,
                           x.TcNo,
                           x.FirstName,
                           x.LastName,
                           x.BirthDate,
                           x.Gender,
                           x.MobilePhone,
                           y.UserName
                       };


            dgwLaboratuvarListe.DataSource = list.ToList();

            context.SaveChanges();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            var context = new HmrsContext();

            var list = from x in context.Users
                       join y in context.Employees
                      on x.UserId equals y.UserId
                       where y.WorkingUnit == "Laboratuvar"
                       select new
                       {
                           x.UserId,
                           y.WorkingUnit,
                           x.TcNo,
                           x.FirstName,
                           x.LastName,
                           x.BirthDate,
                           x.Gender,
                           x.MobilePhone,
                           y.UserName
                       };


            dgwLaboratuvarListe.DataSource = list.ToList();

            context.SaveChanges();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var context = new HmrsContext();

            var selectedIndex = (int)dgwLaboratuvarListe.CurrentRow.Cells[0].Value;
            var a = context.Users.FirstOrDefault(a => a.UserId == selectedIndex);
            var b = context.Employees.FirstOrDefault(a => a.UserId == selectedIndex);
            context.Users.Remove(a);
            context.Employees.Remove(b);

            MessageBox.Show("Seçilen çalışanımız veritabanından silinmiştir.");


            context.SaveChanges();

        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmHmrsMenu frmHmrsMenu = new frmHmrsMenu();
            frmHmrsMenu.Show();
            this.Hide();
        }

        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            lblMinimalize.BackColor = Color.FromArgb(0, 94, 102);

        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblMinimalize.BackColor = Color.FromArgb(0, 109, 119);

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
