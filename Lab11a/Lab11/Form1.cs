using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            string plainText = textBox2.Text;
            int plainTextLength = plainText.Length;
            int kunciPengirim = Convert.ToInt32(textBox1.Text);
            char ch;
            textBox3.Text = "";
            textBox5.Text = "";
            for (int i = 0; i < plainTextLength; i++)
            {
                ch = (char)(plainText[i] ^ kunciPengirim);
                textBox3.Text += ch.ToString();
            }
            textBox5.Text = textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string encryptedText = textBox5.Text;
            int encryptedTextLength = encryptedText.Length;
            int kunciPenerima = Convert.ToInt32(textBox4.Text);
            char ch;
            textBox6.Text = "";
            for (int i = 0; i < encryptedTextLength; i++)
            {
                ch = (char)(encryptedText[i] ^ kunciPenerima);
                textBox6.Text += ch.ToString();
            }
        }
    }
}
