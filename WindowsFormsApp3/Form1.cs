using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Data Source=LAPTOP-6HRTUR60\SQLEXPRESS;Initial Catalog=girisyap;Integrated Security=True
        SqlConnection baglanti=new SqlConnection(@"Data Source=LAPTOP-6HRTUR60\SQLEXPRESS;Initial Catalog=girisyap;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""||textBox2.Text=="")
            {
                MessageBox.Show("Boş alan bırakmayınız.");
            }
            else
            {
                baglanti.Open();
                string phone;
                string password;
                phone=textBox1.Text;
                password=textBox2.Text;
                SqlCommand komut=new SqlCommand("select * from girisyap where telefon='" + phone + "'", baglanti);
                komut.Connection = baglanti;
                SqlDataReader oku=komut.ExecuteReader();
                if (!oku.Read())
                {
                    MessageBox.Show("Hatalı telefon numarası veya şifre.");
                    this.Close();
                }

                baglanti.Close();
                giris giris = new giris();
                giris.Show();
                this.Hide();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Telefon ve şifre giriniz.");
            }
            else
            {
                baglanti.Open();
                string phone;
                string password;
                phone = textBox1.Text;
                password = textBox2.Text;
                SqlCommand komut = new SqlCommand("select * from girisyap where telefon='"+phone+"'",baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    MessageBox.Show("Bu telefona kayıtlı bir eşleşme var.");
                }
                else
                {
                    oku.Close();
                    SqlCommand ekle = new SqlCommand("insert into girisyap(telefon,sifre)values('" + phone + "','" + password + "')");
                    ekle.Connection = baglanti;
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("kayıt başarılı.");
                }
                baglanti.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        
    }
}
