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
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class alıcı : Form
    {
        public alıcı()
        {
            InitializeComponent();
        }
        
       


        private void alıcı_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hayvankayıtDataSet.hayvankayıt' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hayvankayıtTableAdapter.Fill(this.hayvankayıtDataSet.hayvankayıt);
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.HeaderText = "Satın Al";
            btn1.Text = "Satın Al";
            btn1.Name = "Satın Al";
            btn1.UseColumnTextForButtonValue = true;
            btn1.DefaultCellStyle.BackColor = Color.Transparent;
            btn1.Width = 80;
            dataGridView1.Columns.Add(btn1);
            
            

        }


        telefon telefon = new telefon();


        
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {

                MessageBox.Show("Başarıyla Satın aldınız."+ "\n"+"Lütfen satıcı ile iletişime geçiniz: "+satıcıgiris.telefonverisi);
                var fromAddress = new MailAddress("tekinyesilay@gmail.com", "HayvanPazarcım.com");
                giris frm = new giris();

                var toAddress = new MailAddress(giris.gonderilecekmail, "To Name");

                const string fromPassword = "njfupqwvjbsarjvk";

                const string subject = "Merhaba";
                satıcıgiris tel = new satıcıgiris();
                const string body = "Başarıyla satın alındı.";



                var smtp = new SmtpClient

                {

                    Host = "smtp.gmail.com",

                    Port = 587,

                    EnableSsl = true,

                    DeliveryMethod = SmtpDeliveryMethod.Network,

                    UseDefaultCredentials = true,

                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)

                };

                using (var message = new MailMessage(fromAddress, toAddress)

                {

                    Subject = subject,


                    Body = body
                })

                {

                    smtp.Send(message);

                }
            }
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
