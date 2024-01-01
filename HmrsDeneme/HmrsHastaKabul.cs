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
    public partial class frmHmrsHastaKabul : Form
    {
        public frmHmrsHastaKabul()
        {
            InitializeComponent();
        }

        private void btnHastaKabul_Click(object sender, EventArgs e)
        {
            var context = new HmrsContext();
            var user = new User();
            user.TcNo = txtTcKimlikPassport.Text;
            user.FirstName = txtAd.Text;
            user.LastName = txtSoyad.Text;
            user.MobilePhone = txtPhoneNumber.Text;
            user.BirthDate = DateTime.Now;
            
            if (rbMan.Checked)
            {
                user.Gender = rbMan.Text;
            }
            else
            {
                user.Gender = rbWoman.Text;
            }
           
            context.Users.Add(user);
            var patient = new Patient();
            patient.EducationStatus = cbEducationStatus.Text;
            patient.Job = txtMeslek.Text;
            patient.FatherName = txtBaba.Text;
            patient.MotherName = txtAna.Text;
            patient.User = user;
     
            patient.UserId = user.UserId;
            context.Patients.Add(patient);
            MessageBox.Show("İlgili kişi eklenmiştir.");
            context.SaveChanges();
            //var b = context.Patients.FirstOrDefault(/*e => e.FatherName == txtBaba.Text && e.MotherName == txtAna.Text && e.EducationStatus == cbEducationStatus.Text && e.Job == txtMeslek.Text*/);
            
            
                     

        }

        private void btnHastaListele_Click(object sender, EventArgs e)
        {
            frmHastaListe frmHastaListe = new frmHastaListe();
            frmHastaListe.Show();
            this.Close();
           
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmHmrsMenu frmHmrsMenu=new frmHmrsMenu();
            frmHmrsMenu.Show();
            this.Hide();
        }

        private void frmHmrsHastaKabul_Load(object sender, EventArgs e)
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
