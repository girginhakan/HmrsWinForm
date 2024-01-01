namespace HmrsDeneme
{
    partial class frmYoneticiModul
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwCalisanlar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgwHastaListe = new System.Windows.Forms.DataGridView();
            this.btnCalisanSil = new System.Windows.Forms.Button();
            this.btnCalisanYenile = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnHastaSil = new System.Windows.Forms.Button();
            this.btnHastaYenile = new System.Windows.Forms.Button();
            this.btnCalisanGuncelle = new System.Windows.Forms.Button();
            this.btnHastaGuncelle = new System.Windows.Forms.Button();
            this.lblMinimalize = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCalisanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHastaListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCalisanlar
            // 
            this.dgwCalisanlar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.dgwCalisanlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwCalisanlar.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgwCalisanlar.Location = new System.Drawing.Point(40, 96);
            this.dgwCalisanlar.Name = "dgwCalisanlar";
            this.dgwCalisanlar.RowHeadersWidth = 51;
            this.dgwCalisanlar.RowTemplate.Height = 29;
            this.dgwCalisanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCalisanlar.Size = new System.Drawing.Size(778, 188);
            this.dgwCalisanlar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(337, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Çalışan Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.label2.Location = new System.Drawing.Point(337, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta Listesi";
            // 
            // dgwHastaListe
            // 
            this.dgwHastaListe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.dgwHastaListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwHastaListe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgwHastaListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwHastaListe.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgwHastaListe.Location = new System.Drawing.Point(40, 349);
            this.dgwHastaListe.Name = "dgwHastaListe";
            this.dgwHastaListe.RowHeadersWidth = 51;
            this.dgwHastaListe.RowTemplate.Height = 29;
            this.dgwHastaListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwHastaListe.Size = new System.Drawing.Size(778, 188);
            this.dgwHastaListe.TabIndex = 3;
            // 
            // btnCalisanSil
            // 
            this.btnCalisanSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalisanSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.btnCalisanSil.Location = new System.Drawing.Point(837, 112);
            this.btnCalisanSil.Name = "btnCalisanSil";
            this.btnCalisanSil.Size = new System.Drawing.Size(356, 47);
            this.btnCalisanSil.TabIndex = 4;
            this.btnCalisanSil.Text = "Seçili Çalışanı Sil";
            this.btnCalisanSil.UseVisualStyleBackColor = true;
            this.btnCalisanSil.Click += new System.EventHandler(this.btnCalisanSil_Click);
            // 
            // btnCalisanYenile
            // 
            this.btnCalisanYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanYenile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalisanYenile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.btnCalisanYenile.Location = new System.Drawing.Point(837, 223);
            this.btnCalisanYenile.Name = "btnCalisanYenile";
            this.btnCalisanYenile.Size = new System.Drawing.Size(356, 50);
            this.btnCalisanYenile.TabIndex = 5;
            this.btnCalisanYenile.Text = "Çalışanları Yenile";
            this.btnCalisanYenile.UseVisualStyleBackColor = true;
            this.btnCalisanYenile.Click += new System.EventHandler(this.btnCalisanYenile_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGeriDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.btnGeriDon.Location = new System.Drawing.Point(837, 290);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(356, 53);
            this.btnGeriDon.TabIndex = 6;
            this.btnGeriDon.Text = "Menüye geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnHastaSil
            // 
            this.btnHastaSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHastaSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.btnHastaSil.Location = new System.Drawing.Point(837, 359);
            this.btnHastaSil.Name = "btnHastaSil";
            this.btnHastaSil.Size = new System.Drawing.Size(356, 51);
            this.btnHastaSil.TabIndex = 7;
            this.btnHastaSil.Text = "Seçili Hastayı Sil";
            this.btnHastaSil.UseVisualStyleBackColor = true;
            this.btnHastaSil.Click += new System.EventHandler(this.btnHastaSil_Click);
            // 
            // btnHastaYenile
            // 
            this.btnHastaYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaYenile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHastaYenile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.btnHastaYenile.Location = new System.Drawing.Point(837, 475);
            this.btnHastaYenile.Name = "btnHastaYenile";
            this.btnHastaYenile.Size = new System.Drawing.Size(356, 54);
            this.btnHastaYenile.TabIndex = 8;
            this.btnHastaYenile.Text = "Hastaları Yenile";
            this.btnHastaYenile.UseVisualStyleBackColor = true;
            this.btnHastaYenile.Click += new System.EventHandler(this.btnHastaYenile_Click);
            // 
            // btnCalisanGuncelle
            // 
            this.btnCalisanGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalisanGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.btnCalisanGuncelle.Location = new System.Drawing.Point(837, 163);
            this.btnCalisanGuncelle.Name = "btnCalisanGuncelle";
            this.btnCalisanGuncelle.Size = new System.Drawing.Size(356, 55);
            this.btnCalisanGuncelle.TabIndex = 9;
            this.btnCalisanGuncelle.Text = "Seçilen Çalışanı Güncelle";
            this.btnCalisanGuncelle.UseVisualStyleBackColor = true;
            this.btnCalisanGuncelle.Click += new System.EventHandler(this.btnCalisanGuncelle_Click);
            // 
            // btnHastaGuncelle
            // 
            this.btnHastaGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHastaGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.btnHastaGuncelle.Location = new System.Drawing.Point(837, 416);
            this.btnHastaGuncelle.Name = "btnHastaGuncelle";
            this.btnHastaGuncelle.Size = new System.Drawing.Size(356, 53);
            this.btnHastaGuncelle.TabIndex = 10;
            this.btnHastaGuncelle.Text = "Seçilen Hastayı Güncelle";
            this.btnHastaGuncelle.UseVisualStyleBackColor = true;
            this.btnHastaGuncelle.Click += new System.EventHandler(this.btnHastaGuncelle_Click);
            // 
            // lblMinimalize
            // 
            this.lblMinimalize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMinimalize.AutoSize = true;
            this.lblMinimalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.lblMinimalize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMinimalize.Location = new System.Drawing.Point(1143, 3);
            this.lblMinimalize.Name = "lblMinimalize";
            this.lblMinimalize.Size = new System.Drawing.Size(24, 28);
            this.lblMinimalize.TabIndex = 20;
            this.lblMinimalize.Text = "‒";
            this.lblMinimalize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMinimalize.Click += new System.EventHandler(this.lblMinimalize_Click);
            this.lblMinimalize.MouseLeave += new System.EventHandler(this.lblMinimalize_MouseLeave);
            this.lblMinimalize.MouseHover += new System.EventHandler(this.lblMinimalize_MouseHover);
            // 
            // lblExit
            // 
            this.lblExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.lblExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExit.Location = new System.Drawing.Point(1176, 3);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(23, 28);
            this.lblExit.TabIndex = 19;
            this.lblExit.Text = "x";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            this.lblExit.MouseHover += new System.EventHandler(this.lblExit_MouseHover);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1205, 35);
            this.label3.TabIndex = 18;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmYoneticiModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(1205, 559);
            this.Controls.Add(this.lblMinimalize);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHastaGuncelle);
            this.Controls.Add(this.btnCalisanGuncelle);
            this.Controls.Add(this.btnHastaYenile);
            this.Controls.Add(this.btnHastaSil);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnCalisanYenile);
            this.Controls.Add(this.btnCalisanSil);
            this.Controls.Add(this.dgwHastaListe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwCalisanlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmYoneticiModul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HmrsYoneticiModul";
            this.Load += new System.EventHandler(this.frmYoneticiModul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCalisanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHastaListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgwCalisanlar;
        private Label label1;
        private Label label2;
        private DataGridView dgwHastaListe;
        private Button btnCalisanSil;
        private Button btnCalisanYenile;
        private Button btnGeriDon;
        private Button btnHastaSil;
        private Button btnHastaYenile;
        private Button btnCalisanGuncelle;
        private Button btnHastaGuncelle;
        private Label lblMinimalize;
        private Label lblExit;
        private Label label3;
    }
}