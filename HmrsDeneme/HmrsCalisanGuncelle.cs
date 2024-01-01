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
    public partial class frmCalisanGuncelle : Form
    {
        public Employee Employee{ get; set; }
        public User User { get; set; }

        public frmCalisanGuncelle(Employee? employee, User? user)
        {
            InitializeComponent();
            Employee = employee;
            User = user;
        }

        private void frmCalisanGuncelle_Load(object sender, EventArgs e)
        {
            var context = new HmrsContext();
            var selectedEmployee = context.Employees.FirstOrDefault(a => a.UserId == Employee.UserId);
            var selectedUser = context.Users.FirstOrDefault(a => a.UserId == User.UserId);

            var dataEmployee = selectedEmployee;
            var dataUser = selectedUser;

                cbWorkingUnit.Text = Employee.WorkingUnit.ToString();
                txtTcNo.Text = User.TcNo;
                txtFirstName.Text = User.FirstName;
                txtLastName.Text = User.LastName;
                dtBirthDate.Format = DateTimePickerFormat.Custom;
                dtBirthDate.CustomFormat = "dd MMM yyyy";
                dtBirthDate.Value= User.BirthDate;

            if (User.Gender=="Erkek")
            {
                rbMan.Checked = true;
            }
            else
            {
                rbWoman.Checked = true;
            }
                txtPhoneNumber.Text = User.MobilePhone;
                txtUserName.Text = Employee.UserName.ToString();

        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmYoneticiModul frmYoneticiModul = new frmYoneticiModul();
            frmYoneticiModul.Show();
            this.Close();
        }

        private void btnCalisanGuncelle_Click(object sender, EventArgs e)
        {
            var context = new HmrsContext();
            var selectedEmployee = context.Employees.FirstOrDefault(a => a.UserId == Employee.UserId);
            var selectedUser = context.Users.FirstOrDefault(a => a.UserId == User.UserId);


            selectedEmployee.WorkingUnit = cbWorkingUnit.Text;
            selectedUser.TcNo = txtTcNo.Text;
            selectedUser.FirstName = txtFirstName.Text;
            selectedUser.LastName = txtLastName.Text;
            selectedUser.BirthDate = dtBirthDate.Value;
           

            if (rbMan.Checked)
            {
                selectedUser.Gender = rbMan.Text;
            }
            else
            {
                selectedUser.Gender = rbWoman.Text;
            }

            selectedUser.MobilePhone = txtPhoneNumber.Text;
            selectedEmployee.UserName = txtUserName.Text;

            context.SaveChanges();
            MessageBox.Show("Seçilen kişi başarıyla güncellenmiştir.");
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
            lblExit.BackColor = Color.FromArgb(0, 94, 102);

        }

        private void lblMinimalize_MouseLeave(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.FromArgb(0, 109, 119);

        }

        private void lblMinimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
