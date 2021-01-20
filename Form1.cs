using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ideal_kilonuz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char cinsiyet;
            double yas, boy, ideal;

            cinsiyet = Convert.ToChar(comboBox1.Text);
            yas = Convert.ToDouble(textBox2.Text);
            boy = Convert.ToDouble(textBox1.Text);

            if (cinsiyet == 'K')
            {
                ideal = (boy - 100 + (yas / 10)) * 0.8;
                label5sonuc.Text = ideal.ToString();
            }
            if (cinsiyet == 'E')
            {
                ideal = (boy - 100 + (yas / 10)) * 0.9;
                label5sonuc.Text = ideal.ToString();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/n.beyi");
        }
    }
}
