namespace PraktikumW4
{
    partial class FormTambahData
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTelp = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.tBoxTelp = new System.Windows.Forms.TextBox();
            this.tBoxAlamat = new System.Windows.Forms.TextBox();
            this.tBoxNama = new System.Windows.Forms.TextBox();
            this.btnLihatData = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTelp
            // 
            this.lblTelp.AutoSize = true;
            this.lblTelp.Location = new System.Drawing.Point(26, 96);
            this.lblTelp.Name = "lblTelp";
            this.lblTelp.Size = new System.Drawing.Size(31, 15);
            this.lblTelp.TabIndex = 5;
            this.lblTelp.Text = "Telp:";
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(26, 60);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAlamat.Size = new System.Drawing.Size(48, 15);
            this.lblAlamat.TabIndex = 4;
            this.lblAlamat.Text = "Alamat:";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(26, 25);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(42, 15);
            this.lblNama.TabIndex = 3;
            this.lblNama.Text = "Nama:";
            // 
            // tBoxTelp
            // 
            this.tBoxTelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxTelp.Location = new System.Drawing.Point(74, 93);
            this.tBoxTelp.Name = "tBoxTelp";
            this.tBoxTelp.Size = new System.Drawing.Size(163, 23);
            this.tBoxTelp.TabIndex = 12;
            this.tBoxTelp.TextChanged += new System.EventHandler(this.tBoxTelp_TextChanged);
            this.tBoxTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxTelp_KeyPress);
            // 
            // tBoxAlamat
            // 
            this.tBoxAlamat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tBoxAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxAlamat.Location = new System.Drawing.Point(74, 57);
            this.tBoxAlamat.Name = "tBoxAlamat";
            this.tBoxAlamat.Size = new System.Drawing.Size(413, 23);
            this.tBoxAlamat.TabIndex = 11;
            this.tBoxAlamat.TextChanged += new System.EventHandler(this.tBoxAlamat_TextChanged);
            // 
            // tBoxNama
            // 
            this.tBoxNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxNama.Location = new System.Drawing.Point(74, 22);
            this.tBoxNama.Name = "tBoxNama";
            this.tBoxNama.Size = new System.Drawing.Size(285, 23);
            this.tBoxNama.TabIndex = 10;
            this.tBoxNama.TextChanged += new System.EventHandler(this.tBoxNama_TextChanged);
            // 
            // btnLihatData
            // 
            this.btnLihatData.Location = new System.Drawing.Point(115, 134);
            this.btnLihatData.Name = "btnLihatData";
            this.btnLihatData.Size = new System.Drawing.Size(75, 23);
            this.btnLihatData.TabIndex = 9;
            this.btnLihatData.Text = "Lihat Data";
            this.btnLihatData.UseVisualStyleBackColor = true;
            this.btnLihatData.Click += new System.EventHandler(this.btnLihatData_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(21, 134);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 8;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // FormTambahData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(523, 174);
            this.Controls.Add(this.tBoxTelp);
            this.Controls.Add(this.tBoxAlamat);
            this.Controls.Add(this.tBoxNama);
            this.Controls.Add(this.btnLihatData);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.lblTelp);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.lblNama);
            this.Name = "FormTambahData";
            this.Text = "Form Penambahan Data";
            this.Load += new System.EventHandler(this.FormTambahData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTelp;
        private Label lblAlamat;
        private Label lblNama;
        private TextBox tBoxTelp;
        private TextBox tBoxAlamat;
        private TextBox tBoxNama;
        private Button btnLihatData;
        private Button btnSimpan;
    }
}