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
    public partial class frmHastaGuncelle : Form
    {
        public Patient Patient { get; set; }
        public User User { get; set; }
        public frmHastaGuncelle(Patient? patient, User? user)
        {
            InitializeComponent();
            Patient = patient;
            User = user;

        }

        private void frmHastaGuncelle_Load(object sender, EventArgs e)
        {
            var context = new HmrsContext();
            var selectedEmployee = context.Patients.FirstOrDefault(a => a.UserId == Patient.UserId);
            var selectedUser = context.Users.FirstOrDefault(a => a.UserId == User.UserId);

            var dataEmployee = selectedEmployee;
            var dataUser = selectedUser;

            txtTcNo.Text = User.TcNo;
            txtFirstName.Text = User.FirstName;
            txtLastName.Text = User.LastName;
            txtFatherName.Text = Patient.FatherName;
            txtMotherName.Text = Patient.MotherName;
            dtBirthDate.Format = DateTimePickerFormat.Custom;
            dtBirthDate.CustomFormat = "dd MMM yyyy";
            dtBirthDate.Value = User.BirthDate;

            if (User.Gender == "Erkek")
            {
                rbMan.Checked = true;
            }
            else
            {
                rbWoman.Checked = true;
            }

            txtJob.Text = Patient.Job;
            cbEducationStatus.Text = Patient.EducationStatus;
            txtPhoneNumber.Text = User.MobilePhone;

        }

        private void btnCalisanGuncelle_Click(object sender, EventArgs e)
        {
            var context = new HmrsContext();
            var selectedPatient = context.Patients.FirstOrDefault(a => a.UserId == Patient.UserId);
            var selectedUser = context.Users.FirstOrDefault(a => a.UserId == User.UserId);


            selectedUser.TcNo = txtTcNo.Text;
            selectedUser.FirstName = txtFirstName.Text;
            selectedUser.LastName = txtLastName.Text;
            selectedPatient.FatherName=txtFatherName.Text;
            selectedPatient.MotherName=txtMotherName.Text;
            selectedUser.BirthDate = dtBirthDate.Value;


            if (rbMan.Checked)
            {
                selectedUser.Gender = rbMan.Text;
            }
            else
            {
                selectedUser.Gender = rbWoman.Text;
            }

            selectedPatient.Job = txtJob.Text;
            selectedPatient.EducationStatus = cbEducationStatus.Text;
            selectedUser.MobilePhone = txtPhoneNumber.Text;

            context.SaveChanges();
            MessageBox.Show("Seçilen kişi başarıyla güncellenmiştir.");
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            frmYoneticiModul yoneticiModul = new frmYoneticiModul();
            yoneticiModul.Show();
            this.Close();
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
