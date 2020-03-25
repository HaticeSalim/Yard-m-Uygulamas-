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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = checkBox1.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = checkBox2.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = checkBox3.Text;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = checkBox4.Text;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = checkBox5.Text;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = checkBox6.Text;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            label12.Text = checkBox7.Text;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            label13.Text = checkBox8.Text;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            label14.Text = checkBox9.Text;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            label15.Text = checkBox10.Text;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            label16.Text = checkBox11.Text;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            label17.Text = checkBox12.Text;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            label18.Text = checkBox13.Text;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            label19.Text = checkBox14.Text;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            label20.Text = checkBox15.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label6.Text);
            listBox1.Items.Add(label7.Text);
            listBox1.Items.Add(label8.Text);
            listBox1.Items.Add(label9.Text);
            listBox1.Items.Add(label10.Text);
            listBox1.Items.Add(label11.Text);
            listBox1.Items.Add(label12.Text);
            listBox1.Items.Add(label13.Text);
            listBox1.Items.Add(label14.Text);
            listBox1.Items.Add(label15.Text);
            listBox1.Items.Add(label16.Text);
            listBox1.Items.Add(label17.Text);
            listBox1.Items.Add(label18.Text);
            listBox1.Items.Add(label19.Text);
            listBox1.Items.Add(label20.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sonuç = 0;
            int makarnafiyat, bulgurfiyat, sıvıyağfiyat, unfiyat, tuzfiyat, şekerfiyat;
            int kurumamafiyat, ıslakmamafiyat;
            int tişörtfiyat, montfiyat, pantolonfiyat, ayakkabıfiyat;
            int kalemfiyat, defterfiyat, çantafiyat;


            if (checkBox1.Checked)
            {
                makarnafiyat = Convert.ToInt32(label21.Text);
                sonuç = sonuç + makarnafiyat;

            }
            if (checkBox2.Checked)
            {
                bulgurfiyat = Convert.ToInt32(label22.Text);
                sonuç = sonuç + bulgurfiyat;

            }
            if (checkBox3.Checked)
            {
                sıvıyağfiyat = Convert.ToInt32(label23.Text);
                sonuç = sonuç + sıvıyağfiyat;

            }
            if (checkBox4.Checked)
            {
                unfiyat = Convert.ToInt32(label24.Text);
                sonuç = sonuç + unfiyat;

            }
            if (checkBox5.Checked)
            {
                tuzfiyat = Convert.ToInt32(label25.Text);
                sonuç = sonuç + tuzfiyat;

            }
            if (checkBox6.Checked)
            {
                şekerfiyat = Convert.ToInt32(label26.Text);
                sonuç = sonuç + şekerfiyat;

            }
            if (checkBox7.Checked)
            {
                kurumamafiyat = Convert.ToInt32(label27.Text);
                sonuç = sonuç + kurumamafiyat;

            }
            if (checkBox8.Checked)
            {
                ıslakmamafiyat = Convert.ToInt32(label28.Text);
                sonuç = sonuç + ıslakmamafiyat;

            }
            if (checkBox9.Checked)
            {
                tişörtfiyat = Convert.ToInt32(label29.Text);
                sonuç = sonuç + tişörtfiyat;

            }
            if (checkBox10.Checked)
            {
                montfiyat = Convert.ToInt32(label30.Text);
                sonuç = sonuç + montfiyat;

            }
            if (checkBox11.Checked)
            {
                pantolonfiyat = Convert.ToInt32(label31.Text);
                sonuç = sonuç + pantolonfiyat;

            }
            if (checkBox12.Checked)
            {
                ayakkabıfiyat = Convert.ToInt32(label32.Text);
                sonuç = sonuç + ayakkabıfiyat;

            }
            if (checkBox13.Checked)
            {
                kalemfiyat = Convert.ToInt32(label33.Text);
                sonuç = sonuç + kalemfiyat;

            }
            if (checkBox14.Checked)
            {
                defterfiyat = Convert.ToInt32(label34.Text);
                sonuç = sonuç + defterfiyat;

            }
            if (checkBox15.Checked)
            {
                çantafiyat = Convert.ToInt32(label35.Text);
                sonuç = sonuç + çantafiyat;

            }

            textBox1.Text = sonuç.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 son = new Form3();
            son.Show();
            this.Hide();
        }
    }
}
