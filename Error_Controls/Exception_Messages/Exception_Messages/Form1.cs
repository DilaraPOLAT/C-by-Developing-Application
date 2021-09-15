﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exception_Messages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                int s1, s2, sonuc;
                s1 = Convert.ToInt16(textBox1.Text);
                s2 = Convert.ToInt16(textBox2.Text);
                sonuc = s1 * s2;
                label1.Text = sonuc.ToString();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                MessageBox.Show("Finally Bloğu Çalıştı");
            }

        }
    }
}
