using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasirBioskop
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string namaBenar = "Vikko "; // Validasi nama yang benar
            string passwordBenar = "23062010 "; // Validasi password yang benar

            string namaInput = textBox1.Text; 
            string passwordInput = textBox2.Text;

            if (namaBenar == namaInput && passwordBenar == passwordInput)
            {
                MessageBox.Show("Login berhasil ", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else if (namaBenar == namaInput) // Ketika password salah
            {
                MessageBox.Show("Password salah ", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); // Memberikan keterangan ketika password salah
            }
            else if (passwordBenar == passwordInput) // Ketika nama salah
            {
                MessageBox.Show("Nama salah ", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); // Memberikan keterangan ketika nama salah
            }
            else
            {
                MessageBox.Show("Nama dan Password salah ", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error); // Memberikan keterangan ketika nama dan password salah
            }
        }
    }
}
