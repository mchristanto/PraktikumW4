namespace PraktikumW4
{
    partial class FormTampilanData
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
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnPrevData = new System.Windows.Forms.Button();
            this.btnNextData = new System.Windows.Forms.Button();
            this.tBoxTelp2 = new System.Windows.Forms.TextBox();
            this.tBoxAlamat2 = new System.Windows.Forms.TextBox();
            this.tBoxNama2 = new System.Windows.Forms.TextBox();
            this.lblTelp = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(23, 138);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 0;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnPrevData
            // 
            this.btnPrevData.Location = new System.Drawing.Point(115, 138);
            this.btnPrevData.Name = "btnPrevData";
            this.btnPrevData.Size = new System.Drawing.Size(75, 23);
            this.btnPrevData.TabIndex = 1;
            this.btnPrevData.Text = "Prev Data";
            this.btnPrevData.UseVisualStyleBackColor = true;
            this.btnPrevData.Click += new System.EventHandler(this.btnPrevData_Click);
            // 
            // btnNextData
            // 
            this.btnNextData.Location = new System.Drawing.Point(213, 138);
            this.btnNextData.Name = "btnNextData";
            this.btnNextData.Size = new System.Drawing.Size(75, 23);
            this.btnNextData.TabIndex = 2;
            this.btnNextData.Text = "Next Data";
            this.btnNextData.UseVisualStyleBackColor = true;
            this.btnNextData.Click += new System.EventHandler(this.btnNextData_Click);
            // 
            // tBoxTelp2
            // 
            this.tBoxTelp2.Location = new System.Drawing.Point(90, 91);
            this.tBoxTelp2.Name = "tBoxTelp2";
            this.tBoxTelp2.Size = new System.Drawing.Size(139, 23);
            this.tBoxTelp2.TabIndex = 0;
            this.tBoxTelp2.TextChanged += new System.EventHandler(this.tBoxTelp2_TextChanged);
            // 
            // tBoxAlamat2
            // 
            this.tBoxAlamat2.Location = new System.Drawing.Point(90, 55);
            this.tBoxAlamat2.Name = "tBoxAlamat2";
            this.tBoxAlamat2.Size = new System.Drawing.Size(401, 23);
            this.tBoxAlamat2.TabIndex = 1;
            this.tBoxAlamat2.TextChanged += new System.EventHandler(this.tBoxAlamat2_TextChanged);
            // 
            // tBoxNama2
            // 
            this.tBoxNama2.Location = new System.Drawing.Point(90, 20);
            this.tBoxNama2.Name = "tBoxNama2";
            this.tBoxNama2.Size = new System.Drawing.Size(230, 23);
            this.tBoxNama2.TabIndex = 2;
            this.tBoxNama2.TextChanged += new System.EventHandler(this.tBoxNama2_TextChanged);
            // 
            // lblTelp
            // 
            this.lblTelp.AutoSize = true;
            this.lblTelp.Location = new System.Drawing.Point(23, 94);
            this.lblTelp.Name = "lblTelp";
            this.lblTelp.Size = new System.Drawing.Size(31, 15);
            this.lblTelp.TabIndex = 15;
            this.lblTelp.Text = "Telp:";
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(23, 58);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAlamat.Size = new System.Drawing.Size(48, 15);
            this.lblAlamat.TabIndex = 14;
            this.lblAlamat.Text = "Alamat:";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(23, 23);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(42, 15);
            this.lblNama.TabIndex = 13;
            this.lblNama.Text = "Nama:";
            // 
            // FormTampilanData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 174);
            this.Controls.Add(this.tBoxTelp2);
            this.Controls.Add(this.tBoxAlamat2);
            this.Controls.Add(this.tBoxNama2);
            this.Controls.Add(this.lblTelp);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.btnNextData);
            this.Controls.Add(this.btnPrevData);
            this.Controls.Add(this.btnKembali);
            this.Name = "FormTampilanData";
            this.Text = "Form Tampilan Data";
            this.Load += new System.EventHandler(this.FormTampilanData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnKembali;
        private Button btnPrevData;
        private Button btnNextData;
        private TextBox tBoxTelp2;
        private TextBox tBoxAlamat2;
        private TextBox tBoxNama2;
        private Label lblTelp;
        private Label lblAlamat;
        private Label lblNama;
    }
}