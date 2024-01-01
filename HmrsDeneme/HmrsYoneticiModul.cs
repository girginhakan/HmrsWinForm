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
    public partial class frmYoneticiModul : Form
    {
       
        public frmYoneticiModul()
        {
            InitializeComponent();  
        }

        private void frmYoneticiModul_Load(object sender, EventArgs e)
        {

            dgwCalisanlar.RowHeadersVisible=false;
            dgwHastaListe.RowHeadersVisible=false;
            var context = new HmrsContext();

            var listPatients = from x in context.Users
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

            var listEmployees = from x in context.Users
                       join y in context.Employees
                      on x.UserId equals y.UserId
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
            dgwCalisanlar.DataSource = listEmployees.ToList();
            dgwHastaListe.DataSource = listPatients.ToList();


            context.SaveChanges();
        }

        private void btnCalisanSil_Click(object sender, EventArgs e)
        {
            var context = new HmrsContext();

            var selectedIndex = (int)dgwCalisanlar.CurrentRow.Cells[0].Value;
            var a = context.Users.FirstOrDefault(a => a.UserId == selectedIndex);
            var b = context.Employees.FirstOrDefault(a => a.UserId == selectedIndex);
            context.Users.Remove(a);
            context.Employees.Remove(b);

            MessageBox.Show("Seçilen çalışan veritabanından silinmiştir.");


            context.SaveChanges();
        }

        private void btnCalisanYenile_Click(object sender, EventArgs e)
        {
            var context = new HmrsContext();

            var listEmployees = from x in context.Users
                                join y in context.Employees
                               on x.UserId equals y.UserId
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
            dgwCalisanlar.DataSource = listEmployees.ToList();
        }

        private void btnHastaSil_Click(object sender, EventArgs e)
        {
            var context = new HmrsContext();

            var selectedIndex = (int)dgwHastaListe.CurrentRow.Cells[0].Value;
            var a = context.Users.FirstOrDefault(a => a.UserId == selectedIndex);
            var b = context.Patients.FirstOrDefault(a => a.UserId == selectedIndex);
            context.Users.Remove(a);
            context.Patients.Remove(b);

            MessageBox.Show("Seçilen hastamız veritabanından silinmiştir.");


            context.SaveChanges();

        }

        private void btnHastaYenile_Click(object sender, EventArgs e)
        {
            var context = new HmrsContext();

            var listPatients = from x in context.Users
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
            dgwHastaListe.DataSource = listPatients.ToList();
            context.SaveChanges();

        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmHmrsMenu frmHmrsMenu = new frmHmrsMenu();
            frmHmrsMenu.Show();
            this.Close();
        }
//----------------------------------------------------------------------------------------------------------------------------
        private void btnCalisanGuncelle_Click(object sender, EventArgs e)
        {
            var context = new HmrsContext();
            var selectedIndex = (int)dgwCalisanlar.CurrentRow.Cells[0].Value;
            var selectedEmployee = context.Employees.FirstOrDefault(a => a.UserId == selectedIndex);
            var selectedUser = context.Users.FirstOrDefault(a => a.UserId == selectedIndex);
            var dataEmployee = selectedEmployee;
            var dataUser = selectedUser;

            if (dataUser!=null&&dataEmployee!=null)
            {
                frmCalisanGuncelle frmCalisanGuncelle = new frmCalisanGuncelle(selectedEmployee, selectedUser);
                frmCalisanGuncelle.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz çalışanı listeden seçiniz."); 
            }

        }

        private void btnHastaGuncelle_Click(object sender, EventArgs e)
        {
            var context = new HmrsContext();
            var selectedIndex = (int)dgwHastaListe.CurrentRow.Cells[0].Value;
            var selectedPatient = context.Patients.FirstOrDefault(e => e.UserId == selectedIndex);
            var selectedUser = context.Users.FirstOrDefault(a => a.UserId == selectedIndex);

            var dataUser = selectedUser;
            var dataPatient = selectedPatient;

            if (dataUser!= null &&dataPatient !=null)
            {
                frmHastaGuncelle frmHastaGuncelle= new frmHastaGuncelle(selectedPatient,selectedUser);
                frmHastaGuncelle.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz hastayı listeden seçiniz.");
            }
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
