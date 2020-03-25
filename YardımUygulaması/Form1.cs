/***************************************************************************************************************************************
 **                                         SAKARYA ÜNİVERSİTESİ                                                                        
 **                                BİGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 **                                 BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
 **                                   NESNEYE DAYALI PROGRAMLAMA DERSİ
 **                                        2019-2020 BAHAR DÖNEMİ
 **
 **         ÖDEV NUMARASI:1
 **         ÖĞRENCİ ADI: Hatice Salim
 **         ÖĞRENCİ NUMARASI: B191200045
 **         DERSİN ALINDIĞI GRUP:
 **********************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YardımUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "kullanıcı1" && textBox2.Text == "123456")
            {
                Form2 yardım = new Form2();
                yardım.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız! ");
            }
        }
    }
}
