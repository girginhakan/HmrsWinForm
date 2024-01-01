using HmrsDeneme.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace HmrsDeneme
{
    public partial class frmHmrsGiris : Form
    {
        public frmHmrsGiris()
        {
            InitializeComponent();
        }
       
            
        private void Form1_Load(object sender, EventArgs e)
        {
            cbSifreyiGoster.CheckState=CheckState.Checked;
            cbSifreyiGoster.Text = "Şifreyi Göster";
        }
       
        



        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {
            frmYeniKullanici frmYeniKullanici= new frmYeniKullanici();
            frmYeniKullanici.Show();
            this.Hide();
        }

        private void cbSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbSifreyiGoster.CheckState ==CheckState.Unchecked)
            {
                txtPassword.UseSystemPasswordChar = false;
                cbSifreyiGoster.Text = "Şifreyi Gizle";
            }
            else if (cbSifreyiGoster.CheckState==CheckState.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
                cbSifreyiGoster.Text = "Şifreyi Göster";

            }
        }

        private void cbSifreyiGoster_Click(object sender, EventArgs e)
        {
            
        }

        private void btnParolamıUnuttum_Click(object sender, EventArgs e)
        {
            frmParolamiUnuttum frmParolamiUnuttum = new frmParolamiUnuttum();
            frmParolamiUnuttum.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            var durum = MessageBox.Show("Çıkış yapmak istiyormusunuz", "Çıkış yapılıyor...",MessageBoxButtons.OKCancel);
            if (durum == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var context = new HmrsContext();
            var a = context.Employees.FirstOrDefault(e => e.UserName == txtUsername.Text && e.Password == txtPassword.Text);
            var data = a;




            if (data == null)
            {
                MessageBox.Show("yeniden deneyiniz.");
            }
            else
            {
                MessageBox.Show("Girişiniz yapılmıştır Hasta giriş ekranına yönlendiriliyorsunuz.");

                frmHmrsMenu menüGiris = new frmHmrsMenu();
                menüGiris.Show();
                this.Hide();

            }
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
            var durum = MessageBox.Show("Çıkış yapmak istiyormusunuz?", "Çıkış yapılıyor", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (durum == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void label3_MouseHover(object sender, EventArgs e)
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}