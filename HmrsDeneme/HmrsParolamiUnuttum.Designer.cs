namespace HmrsDeneme
{
    partial class frmParolamiUnuttum
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
            this.txtParolaYenile = new System.Windows.Forms.TextBox();
            this.btnParolaYenile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.lblMinimalize = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtParolaYenile
            // 
            this.txtParolaYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.txtParolaYenile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParolaYenile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtParolaYenile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.txtParolaYenile.Location = new System.Drawing.Point(35, 131);
            this.txtParolaYenile.Name = "txtParolaYenile";
            this.txtParolaYenile.PlaceholderText = "Kullanici adınızı giriniz";
            this.txtParolaYenile.Size = new System.Drawing.Size(474, 27);
            this.txtParolaYenile.TabIndex = 1;
            // 
            // btnParolaYenile
            // 
            this.btnParolaYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParolaYenile.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnParolaYenile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.btnParolaYenile.Location = new System.Drawing.Point(35, 178);
            this.btnParolaYenile.Name = "btnParolaYenile";
            this.btnParolaYenile.Size = new System.Drawing.Size(474, 50);
            this.btnParolaYenile.TabIndex = 2;
            this.btnParolaYenile.Text = "Parola Yenilemek için tıklayın";
            this.btnParolaYenile.UseVisualStyleBackColor = true;
            this.btnParolaYenile.Click += new System.EventHandler(this.btnParolaYenile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.label2.Location = new System.Drawing.Point(165, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola Yenile";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGeriDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.btnGeriDon.Location = new System.Drawing.Point(35, 234);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(474, 50);
            this.btnGeriDon.TabIndex = 4;
            this.btnGeriDon.Text = "Geri";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // lblMinimalize
            // 
            this.lblMinimalize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMinimalize.AutoSize = true;
            this.lblMinimalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.lblMinimalize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMinimalize.Location = new System.Drawing.Point(476, 5);
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
            this.lblExit.Location = new System.Drawing.Point(509, 5);
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
            this.label3.Size = new System.Drawing.Size(539, 35);
            this.label3.TabIndex = 18;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(197)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(35, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lütfen sistemde kayıtlı olan kullanıcı adınızı giriniz : ";
            // 
            // frmParolamiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(539, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMinimalize);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnParolaYenile);
            this.Controls.Add(this.txtParolaYenile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmParolamiUnuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HmrsParolamiUnuttum";
            this.Load += new System.EventHandler(this.frmParolamiUnuttum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtParolaYenile;
        private Button btnParolaYenile;
        private Label label2;
        private Button btnGeriDon;
        private Label lblMinimalize;
        private Label lblExit;
        private Label label3;
        private Label label1;
    }
}