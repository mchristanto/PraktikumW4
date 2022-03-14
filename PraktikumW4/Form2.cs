using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumW4
{
    public partial class FormTampilanData : Form
    {
        public FormTampilanData()
        {
            InitializeComponent();
        }
        public static int showIndex = 0;

        private void FormTampilanData_Load(object sender, EventArgs e)
        {
            tBoxNama2.Text = FormTambahData.arrayName[showIndex];
            tBoxAlamat2.Text = FormTambahData.arrayAddress[showIndex];
            tBoxTelp2.Text = FormTambahData.arrayTelp[showIndex];
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormTambahData form1 = new FormTambahData();
            this.Hide();
            form1.ShowDialog();
        }

        private void btnPrevData_Click(object sender, EventArgs e)
        {
            showIndex = showIndex--;
            if (showIndex < 0)
            {
                showIndex = showIndex++;
                MessageBox.Show("Data sudah data pertama");
            }
            tBoxNama2.Text = FormTambahData.arrayName[showIndex];
            tBoxAlamat2.Text = FormTambahData.arrayAddress[showIndex];
            tBoxTelp2.Text = FormTambahData.arrayTelp[showIndex];
        }

        private void btnNextData_Click(object sender, EventArgs e)
        {
            showIndex = showIndex++;
            if (showIndex >= 10)
            {
                showIndex = showIndex++;
                MessageBox.Show("Data sudah data terakhir");
            }
            if (showIndex > FormTambahData.indexInputArray--)
            {
                showIndex = showIndex--;
                MessageBox.Show("Data sudah data terakhir");
            }
            tBoxNama2.Text = FormTambahData.arrayName[showIndex];
            tBoxAlamat2.Text = FormTambahData.arrayAddress[showIndex];
            tBoxTelp2.Text = FormTambahData.arrayTelp[showIndex];
        }

        private void tBoxNama2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxAlamat2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxTelp2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
