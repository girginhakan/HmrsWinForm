namespace HmrsDeneme
{
    partial class frmHastaListe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnGeriDon = new Button();
            dgwHastaListele = new DataGridView();
            btnDonMenu = new Button();
            btnSil = new Button();
            btnYenile = new Button();
            lblMinimalize = new Label();
            lblExit = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwHastaListele).BeginInit();
            SuspendLayout();
            // 
            // btnGeriDon
            // 
            btnGeriDon.FlatStyle = FlatStyle.Flat;
            btnGeriDon.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnGeriDon.ForeColor = Color.FromArgb(131, 197, 190);
            btnGeriDon.Location = new Point(10, 272);
            btnGeriDon.Margin = new Padding(3, 2, 3, 2);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(679, 34);
            btnGeriDon.TabIndex = 0;
            btnGeriDon.Text = "GERİ DÖN";
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // dgwHastaListele
            // 
            dgwHastaListele.AllowUserToAddRows = false;
            dgwHastaListele.BackgroundColor = Color.FromArgb(131, 197, 190);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 109, 119);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(131, 197, 190);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgwHastaListele.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgwHastaListele.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 109, 119);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(131, 197, 190);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgwHastaListele.DefaultCellStyle = dataGridViewCellStyle2;
            dgwHastaListele.Location = new Point(10, 49);
            dgwHastaListele.Margin = new Padding(3, 2, 3, 2);
            dgwHastaListele.Name = "dgwHastaListele";
            dgwHastaListele.RowHeadersWidth = 51;
            dgwHastaListele.RowTemplate.Height = 29;
            dgwHastaListele.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwHastaListele.Size = new Size(679, 178);
            dgwHastaListele.TabIndex = 1;
            dgwHastaListele.CellClick += dgwHastaListele_CellClick;
            dgwHastaListele.CellContentClick += dgwHastaListele_CellContentClick;
            // 
            // btnDonMenu
            // 
            btnDonMenu.FlatStyle = FlatStyle.Flat;
            btnDonMenu.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDonMenu.ForeColor = Color.FromArgb(131, 197, 190);
            btnDonMenu.Location = new Point(10, 311);
            btnDonMenu.Margin = new Padding(3, 2, 3, 2);
            btnDonMenu.Name = "btnDonMenu";
            btnDonMenu.Size = new Size(679, 34);
            btnDonMenu.TabIndex = 2;
            btnDonMenu.Text = "ANA MENÜ";
            btnDonMenu.UseVisualStyleBackColor = true;
            btnDonMenu.Click += btnDonMenu_Click;
            // 
            // btnSil
            // 
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSil.ForeColor = Color.FromArgb(131, 197, 190);
            btnSil.Location = new Point(10, 349);
            btnSil.Margin = new Padding(3, 2, 3, 2);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(679, 34);
            btnSil.TabIndex = 3;
            btnSil.Text = "SEÇİLİ KULLANICIYI SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnYenile
            // 
            btnYenile.FlatStyle = FlatStyle.Flat;
            btnYenile.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnYenile.ForeColor = Color.FromArgb(131, 197, 190);
            btnYenile.Location = new Point(10, 234);
            btnYenile.Margin = new Padding(3, 2, 3, 2);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(679, 34);
            btnYenile.TabIndex = 4;
            btnYenile.Text = "YENİLE";
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.Click += btnYenile_Click;
            // 
            // lblMinimalize
            // 
            lblMinimalize.Anchor = AnchorStyles.Top;
            lblMinimalize.AutoSize = true;
            lblMinimalize.BackColor = Color.FromArgb(0, 109, 119);
            lblMinimalize.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMinimalize.Location = new Point(651, 3);
            lblMinimalize.Name = "lblMinimalize";
            lblMinimalize.Size = new Size(19, 21);
            lblMinimalize.TabIndex = 59;
            lblMinimalize.Text = "‒";
            lblMinimalize.TextAlign = ContentAlignment.MiddleCenter;
            lblMinimalize.Click += lblMinimalize_Click;
            lblMinimalize.MouseLeave += lblMinimalize_MouseLeave;
            lblMinimalize.MouseHover += lblMinimalize_MouseHover;
            // 
            // lblExit
            // 
            lblExit.Anchor = AnchorStyles.Top;
            lblExit.AutoSize = true;
            lblExit.BackColor = Color.FromArgb(0, 109, 119);
            lblExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblExit.Location = new Point(680, 3);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(19, 21);
            lblExit.TabIndex = 58;
            lblExit.Text = "x";
            lblExit.TextAlign = ContentAlignment.MiddleCenter;
            lblExit.Click += lblExit_Click;
            lblExit.MouseLeave += lblExit_MouseLeave;
            lblExit.MouseHover += lblExit_MouseHover;
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(131, 197, 190);
            label11.Dock = DockStyle.Top;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(703, 26);
            label11.TabIndex = 57;
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // frmHastaListe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 109, 119);
            ClientSize = new Size(703, 394);
            Controls.Add(lblMinimalize);
            Controls.Add(lblExit);
            Controls.Add(label11);
            Controls.Add(btnYenile);
            Controls.Add(btnSil);
            Controls.Add(btnDonMenu);
            Controls.Add(dgwHastaListele);
            Controls.Add(btnGeriDon);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmHastaListe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HmrsHastaListe";
            Load += HmrsHastaListe_Load;
            ((System.ComponentModel.ISupportInitialize)dgwHastaListele).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGeriDon;
        private DataGridView dgwHastaListele;
        private Button btnDonMenu;
        private Button btnSil;
        private Button btnYenile;
        private Label lblMinimalize;
        private Label lblExit;
        private Label label11;
    }
}