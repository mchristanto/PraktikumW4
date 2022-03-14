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
    public partial class FormTambahData : Form
    {
            public FormTambahData()
            {

                InitializeComponent();

                
            }

        public static int indexInputArray = 0;
        public static int indexarray = 10;
        public static string[] arrayName = new string[indexarray];
        public static string[] arrayAddress= new string[indexarray];
        public static string[] arrayTelp = new string[indexarray];


        private void FormTambahData_Load(object sender, EventArgs e)
            {

            }

            private void tBoxAlamat_TextChanged(object sender, EventArgs e)
            {

            }

            private void tBoxTelp_TextChanged(object sender, EventArgs e)
            {

            }

            private void btnSimpan_Click(object sender, EventArgs e)
            {
            indexInputArray = indexInputArray++;
            arrayName[indexInputArray--] = tBoxNama.Text;
            arrayAddress[indexInputArray--] = tBoxAlamat.Text;
            arrayTelp[indexInputArray--] = tBoxTelp.Text;
            tBoxNama.Clear();
            tBoxAlamat.Clear();
            tBoxTelp.Clear();
            if(indexInputArray > 10)
            {
                MessageBox.Show("Data telah penuh!");
            }
        }

            private void btnLihatData_Click(object sender, EventArgs e)
            {
                FormTampilanData form2 = new FormTampilanData();
                this.Hide();
                form2.ShowDialog();
            }

            private void tBoxTelp_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }

            private void tBoxNama_TextChanged(object sender, EventArgs e)
            {

            }        
    }
    
}

