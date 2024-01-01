namespace HmrsDeneme
{
    partial class frmParolaYenile
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
            this.txtYeniParola = new System.Windows.Forms.TextBox();
            this.btnYeniParola = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMinimalize = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtYeniParola
            // 
            this.txtYeniParola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.txtYeniParola.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtYeniParola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.txtYeniParola.Location = new System.Drawing.Point(26, 124);
            this.txtYeniParola.Name = "txtYeniParola";
            this.txtYeniParola.PlaceholderText = "Lütfen yeni Parolanızı giriniz";
            this.txtYeniParola.Size = new System.Drawing.Size(395, 31);
            this.txtYeniParola.TabIndex = 0;
            // 
            // btnYeniParola
            // 
            this.btnYeniParola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniParola.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYeniParola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.btnYeniParola.Location = new System.Drawing.Point(26, 173);
            this.btnYeniParola.Name = "btnYeniParola";
            this.btnYeniParola.Size = new System.Drawing.Size(393, 51);
            this.btnYeniParola.TabIndex = 2;
            this.btnYeniParola.Text = "Yeni Parola Oluştur";
            this.btnYeniParola.UseVisualStyleBackColor = true;
            this.btnYeniParola.Click += new System.EventHandler(this.btnYeniParola_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGeriDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.btnGeriDon.Location = new System.Drawing.Point(26, 230);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(393, 51);
            this.btnGeriDon.TabIndex = 3;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.label1.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(106, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parola Yenile";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 35);
            this.label2.TabIndex = 16;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMinimalize
            // 
            this.lblMinimalize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMinimalize.AutoSize = true;
            this.lblMinimalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.lblMinimalize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMinimalize.Location = new System.Drawing.Point(387, 4);
            this.lblMinimalize.Name = "lblMinimalize";
            this.lblMinimalize.Size = new System.Drawing.Size(24, 28);
            this.lblMinimalize.TabIndex = 19;
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
            this.lblExit.Location = new System.Drawing.Point(420, 4);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(23, 28);
            this.lblExit.TabIndex = 18;
            this.lblExit.Text = "x";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            this.lblExit.MouseHover += new System.EventHandler(this.lblExit_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.label3.Location = new System.Drawing.Point(26, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = " Lütfen yeni Parolanızı giriniz : ";
            // 
            // frmParolaYenile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMinimalize);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnYeniParola);
            this.Controls.Add(this.txtYeniParola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmParolaYenile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HmrsParolaYenile";
            this.Load += new System.EventHandler(this.frmParolaYenile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtYeniParola;
        private Button btnYeniParola;
        private Button btnGeriDon;
        private Label label1;
        private Label label2;
        private Label lblMinimalize;
        private Label lblExit;
        private Label label3;
    }
}