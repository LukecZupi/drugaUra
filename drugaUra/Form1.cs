using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drugaUra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tocke = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton3.Checked && radioButton6.Checked)
            {
                tocke += 2;
                //MessageBox.Show("bravo nisi stupid");
            }
            else if (radioButton3.Checked)
            {
                tocke++;
                //MessageBox.Show("Pru uprasane je praviln");
            }
            else if (radioButton6.Checked)
            {
                tocke++;
                ///MessageBox.Show("drug uprasane je praviln");
            }
            else
            {
                //MessageBox.Show("stupid si smh");
            }
            if (checkBox1.Checked)
            {
                tocke++;
            }
            if (textBox1.Text.ToLower() == "radijski valovi") ;
            {
                tocke++;
            }
            if (!checkBox2.Checked)
            {
                tocke++;
            }
            tocke = tocke - 1;
            MessageBox.Show("tocke: " + tocke);
            tocke = 0;
            }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == "radijski valovi");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            radioButton1.Checked = false; //metoda shown se nardi pikico pred load tko da rabs tukej to napisat
        }
    }
}
