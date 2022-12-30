using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        public static string gonderilecekmail;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Mail adresinizi yazmayı unutmayınız");

            }
            else
            {
                alıcı alıcı = new alıcı();
                alıcı.Show();
                this.Hide();
                gonderilecekmail = textBox1.Text;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            satıcıgiris satıcıgiris = new satıcıgiris();
            satıcıgiris.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void giris_Load(object sender, EventArgs e)
        {
            
        {

        }
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
