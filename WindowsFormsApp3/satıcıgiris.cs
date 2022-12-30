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
    public partial class satıcıgiris : Form
    {
        public satıcıgiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-6HRTUR60\SQLEXPRESS;Initial Catalog=hayvankayıt;Integrated Security=True");

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text=="" || richTextBox1.Text == "")
            {
                MessageBox.Show("Boş alan bırakmayınız");
            }
            else
            {
                baglanti.Open();
                string kategory;
                string city;
                int age;
                int price;
                string title;
                kategory = textBox1.Text;
                city = textBox2.Text;
                age = Convert.ToInt32(textBox3.Text);
                price = Convert.ToInt32(textBox4.Text);
                title = richTextBox1.Text;
                
                SqlCommand ekle = new SqlCommand("insert into hayvankayıt(kategori,il,yaş,fiyat,başlık)values('" + kategory + "','" + city + "','"+age+"','"+price+"','"+title+"')");

                ekle.Connection = baglanti;
                ekle.ExecuteNonQuery();
                MessageBox.Show("kayıt başarılı.");
                baglanti.Close();



                telefonverisi = Convert.ToInt64(textBox5.Text);


            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            alıcı alıcı = new alıcı();
            alıcı.ShowDialog();
            this.Hide();
        }
        public static long telefonverisi;
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if(textBox5.Text=="")
            {
                MessageBox.Show("Telefon Numarası girmeyi unutmayınız!");
            }
            else
            {
                
                
            }
        }

        




        private void satıcıgiris_Load(object sender, EventArgs e)
        {

        }
    }
}
