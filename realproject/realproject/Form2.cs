using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realproject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = int.Parse(textBox1.Text);
            int bonus = int.Parse(textBox2.Text);
            int other = int.Parse(textBox3.Text);
            int outcome;
            {
                outcome = (month * 12) + bonus + other;
                textBox4.Text = outcome.ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int but1 = int.Parse(numericUpDown1.Text);
            int but2 = int.Parse(numericUpDown2.Text);
            int kun = int.Parse(numericUpDown3.Text);
            int pikan = int.Parse(numericUpDown4.Text);
            int moaw = 0;
            int fa = 0;
            int ma = 0;
            int famoaw = 0;
            int mamoaw = 0;
            int outcome1 = 0;
            if (radioButton5.Checked == true)
            {
                moaw = moaw + 60000;
            }
            if(checkBox1.Checked == true)
            {
                fa = fa + 30000;
            }
            if(checkBox2.Checked == true)
            {
                ma = ma + 30000;
            }
            if(checkBox3.Checked == true)
            {
                famoaw = famoaw + 30000;
            }
            if(checkBox4.Checked == true)
            {
                mamoaw = mamoaw + 30000;
            }
            but1 = but1 * 30000;
            but2 = but2 * 60000;
            pikan = pikan * 60000;
            {
                outcome1 = moaw + fa + ma + mamoaw + but1 + but2 + pikan + kun + famoaw;
                textBox5.Text = outcome1.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int allin = int.Parse(textBox4.Text);
            int outcome2;
            int bonus = int.Parse(textBox5.Text);
            if (bonus > 5000000)
            {
                bonus = ((bonus * 35) / 100);
            }
            else if (bonus > 2000000)
            {
                bonus = ((bonus * 30) / 100);
            }
            else if (bonus > 1000000)
            {
                bonus = ((bonus * 25) / 100);
            }
            else if (bonus > 750000)
            {
                bonus = ((bonus * 20) / 100);
            }
            else if (bonus > 500000)
            {
                bonus = ((bonus * 15) / 100);
            }
            else if (bonus > 300000)
            {
                bonus = ((bonus * 10) / 100);
            }
            else if (bonus > 150000)
            {
                bonus = ((bonus * 5) / 100);
            }
            else
            {
                bonus = 0;
            }
            textBox6.Text = bonus.ToString();
            outcome2 = allin - bonus;
            textBox7.Text = outcome2.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
