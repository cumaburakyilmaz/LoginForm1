using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtŞifre.PasswordChar = '*';
        }
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullanıcıAdi.Text.Trim()) || string.IsNullOrEmpty(txtŞifre.Text.Trim()))
            {
                MessageBox.Show("Kullanıcı adı ve Şifre boş geçilemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            string KullanıcıAdı = txtKullanıcıAdi.Text.Trim();
            string Şifre = txtŞifre.Text.Trim();
            if (KullanıcıAdı == "admin" && Şifre == "12345")
            {
                this.Hide();
                Form2 form2Form = new Form2();
                form2Form.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
