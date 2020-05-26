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
    public partial class Form1 : Form
    {
        public static String money;
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelBT.Visible = false;
            panelg1.Visible = false;
            panelgr2.Visible = false;
            panelgr3.Visible = false;
            panelgr4.Visible = false;
            panelgr5.Visible = false;
            morepanel.Visible = false;
            endcreditpanel.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelBT.Visible == true)
                panelBT.Visible = false;
            if (morepanel.Visible == true)
                morepanel.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
            //...สั่งให้ซับเมนูปิดอีกรอบถ้าเปิดอยู่
        }

        private void ความรู้_Click(object sender, EventArgs e)
        {
            showSubmenu(panelBT);
        }

 

        private void ออก_Click(object sender, EventArgs e)
        {
            MessageBox.Show("คุณจะจากผมไปแล้วหรอซาร่า", "ออกจากโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            ///...ใช่คำสั่งแมสเสจบล้อก
            Application.Exit();
        }


        private void BGpanel_Paint(object sender, PaintEventArgs e)
        {
            ///g11.Hide();
            ///g21.Hide();
            ///g31.Hide();
            ///g41.Hide();
            ///g51.Hide();
        }

        private void ลดหย่อน_Click(object sender, EventArgs e)
        {
            panelg1.Show();
            panelg1.BringToFront();
            ///Form2 gr1 = new Form2();
            ///gr1.Show(); 
            ///this.Hide();
        }

        private void panelg1_Paint(object sender, PaintEventArgs e)
        {
            
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
            if (checkBox1.Checked == true)
            {
                fa = fa + 30000;
            }
            if (checkBox2.Checked == true)
            {
                ma = ma + 30000;
            }
            if (checkBox3.Checked == true)
            {
                famoaw = famoaw + 30000;
            }
            if (checkBox4.Checked == true)
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
            int bonus = int.Parse(textBox5.Text);
            int b;
            b = allin - bonus;
            textBox7.Text = b.ToString();
            int outcome2 = int.Parse(textBox7.Text);
            if (outcome2 > 5000000)
            {
                outcome2 = ((outcome2 * 35) / 100);
            }
            else if (outcome2 > 2000000)
            {
                outcome2 = ((outcome2 * 30) / 100);
            }
            else if (outcome2 > 1000000)
            {
                outcome2 = ((outcome2 * 25) / 100);
            }
            else if (outcome2 > 750000)
            {
                outcome2 = ((outcome2 * 20) / 100);
            }
            else if (outcome2 > 500000)
            {
                outcome2 = ((outcome2 * 15) / 100);
            }
            else if (outcome2 > 300000)
            {
                outcome2 = ((outcome2 * 10) / 100);
            }
            else if (outcome2 > 150000)
            {
                outcome2 = ((outcome2 * 5) / 100);
            }
            else
            {
                outcome2 = 0;
            }
            textBox6.Text = outcome2.ToString();
            Program.money = int.Parse(textBox7.Text);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton7.Checked == true)
            {
                numericUpDown11.Enabled = false;
            }
            else
            {
                numericUpDown11.Enabled = true;
            }
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelgr2.Show();
            panelgr2.BringToFront();

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void panelgr2_Paint(object sender, PaintEventArgs e)
        {
            textBox8.Text = Program.money.ToString();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                numericUpDown11.Enabled = false;
            }
            else
            {
                numericUpDown11.Enabled = true;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                numericUpDown11.Enabled = false;
            }
            else
            {
                numericUpDown11.Enabled = true;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                numericUpDown11.Enabled = true;
            }
            else
            {
                numericUpDown11.Enabled = false;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int pragun1 = int.Parse(numericUpDown5.Text);
            int pragun2 = int.Parse(numericUpDown6.Text);
            int pragun3 = int.Parse(numericUpDown7.Text);
            int pragunfama = int.Parse(numericUpDown8.Text);
            int samrong = int.Parse(numericUpDown9.Text);
            int sasom = int.Parse(numericUpDown10.Text);
            int pragunmoaw = int.Parse(numericUpDown11.Text);
            int pragun23 = 0;
            int outcomeall;
            if ((pragun2 + pragun3) > 100000)
            {
                pragun23 = 100000;
            }
            else if ((pragun2 + pragun3) < 100000)
            {
                pragun23 = pragun2 + pragun3;
            }

            {
                outcomeall = (pragun1 + pragun23 + pragunfama + samrong + sasom + pragunmoaw);
                textBox9.Text = outcomeall.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int allin = int.Parse(textBox8.Text);
            int bonus = int.Parse(textBox9.Text);
            int b;
            b = allin - bonus;
            textBox11.Text = b.ToString();
            int outcome2 = int.Parse(textBox11.Text);
            if (outcome2 > 5000000)
            {
                outcome2 = ((outcome2 * 35) / 100);
            }
            else if (outcome2 > 2000000)
            {
                outcome2 = ((outcome2 * 30) / 100);
            }
            else if (outcome2 > 1000000)
            {
                outcome2 = ((outcome2 * 25) / 100);
            }
            else if (outcome2 > 750000)
            {
                outcome2 = ((outcome2 * 20) / 100);
            }
            else if (outcome2 > 500000)
            {
                outcome2 = ((outcome2 * 15) / 100);
            }
            else if (outcome2 > 300000)
            {
                outcome2 = ((outcome2 * 10) / 100);
            }
            else if (outcome2 > 150000)
            {
                outcome2 = ((outcome2 * 5) / 100);
            }
            else
            {
                outcome2 = 0;
            }
            textBox10.Text = outcome2.ToString();
            Program.money = int.Parse(textBox11.Text);

        }


        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                groupBox6.Enabled = false;
            }
            else
            {
                groupBox6.Enabled = true;
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                groupBox5.Enabled = false;
            }
            else
            {
                groupBox5.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int pee58 = int.Parse(numericUpDown13.Text);
            int kaban = int.Parse(numericUpDown12.Text);
            int outcomesemi;
            int outcomesemi2;
            int outcomeend;
            {
                outcomesemi = (pee58 * 20) / 100;
                textBox12.Text = outcomesemi.ToString();
                outcomesemi2 = (outcomesemi * 4) / 100;
                textBox13.Text = outcomesemi2.ToString();
                outcomeend = (kaban + outcomesemi2);
                textBox14.Text = outcomeend.ToString();
                
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int pee62 = int.Parse(numericUpDown14.Text);
            int kabannewgen = int.Parse(numericUpDown13.Text);
            int outcomeplayoff;
            int outcomeend62;
            int bot = 0;
            if (pee62 <= 5000000)
            {
                bot = 200000;
            }
            outcomeplayoff = bot;
            textBox17.Text = outcomeplayoff.ToString();
            outcomeend62 = kabannewgen + bot;
            textBox18.Text = outcomeend62.ToString();
        }

        private void panelgr3_Paint(object sender, PaintEventArgs e)
        {
            allin3.Text = Program.money.ToString();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            int allin = int.Parse(allin3.Text);
            int bonus = int.Parse(textBox14.Text);
            int b;
            b = allin - bonus;
            textBox16.Text = b.ToString();
            int outcome2 = int.Parse(textBox16.Text);
            if (outcome2 > 5000000)
            {
                outcome2 = ((outcome2 * 35) / 100);
            }
            else if (outcome2 > 2000000)
            {
                outcome2 = ((outcome2 * 30) / 100);
            }
            else if (outcome2 > 1000000)
            {
                outcome2 = ((outcome2 * 25) / 100);
            }
            else if (outcome2 > 750000)
            {
                outcome2 = ((outcome2 * 20) / 100);
            }
            else if (outcome2 > 500000)
            {
                outcome2 = ((outcome2 * 15) / 100);
            }
            else if (outcome2 > 300000)
            {
                outcome2 = ((outcome2 * 10) / 100);
            }
            else if (outcome2 > 150000)
            {
                outcome2 = ((outcome2 * 5) / 100);
            }
            else
            {
                outcome2 = 0;
            }
            textBox15.Text = outcome2.ToString();
            Program.money = int.Parse(textBox16.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int allin = int.Parse(allin3.Text);
            int bonus = int.Parse(textBox18.Text);
            int b;
            b = allin - bonus;
            textBox19.Text = b.ToString();
            int outcome2 = int.Parse(textBox19.Text);
            if (outcome2 > 5000000)
            {
                outcome2 = ((outcome2 * 35) / 100);
            }
            else if (outcome2 > 2000000)
            {
                outcome2 = ((outcome2 * 30) / 100);
            }
            else if (outcome2 > 1000000)
            {
                outcome2 = ((outcome2 * 25) / 100);
            }
            else if (outcome2 > 750000)
            {
                outcome2 = ((outcome2 * 20) / 100);
            }
            else if (outcome2 > 500000)
            {
                outcome2 = ((outcome2 * 15) / 100);
            }
            else if (outcome2 > 300000)
            {
                outcome2 = ((outcome2 * 10) / 100);
            }
            else if (outcome2 > 150000)
            {
                outcome2 = ((outcome2 * 5) / 100);
            }
            else
            {
                outcome2 = 0;
            }
            textBox20.Text = outcome2.ToString();
            Program.money = int.Parse(textBox19.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panelgr4.Show();
            panelgr4.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelgr3.Show();
            panelgr3.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int month = int.Parse(allin4.Text);
            int ten;
            {
                ten = ((month * 10) / 100);
                textBox21.Text = ten.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int ED = int.Parse(numericUpDown21.Text);
            int PE = int.Parse(numericUpDown20.Text);
            int NU = int.Parse(numericUpDown19.Text);
            int HEL = int.Parse(numericUpDown18.Text);
            int allgive;
            {
                allgive = ((ED + PE + NU + HEL) * 2);
                textBox29.Text = allgive.ToString();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int pulblic = int.Parse(numericUpDown17.Text);
            int water = int.Parse(numericUpDown16.Text);
            int cola = int.Parse(numericUpDown15.Text);
            int allgive2;
            {
                allgive2 = pulblic + water + cola;
                textBox30.Text = allgive2.ToString();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int givesemi = int.Parse(textBox29.Text);
            int givefull = int.Parse(textBox30.Text);
            int allgivefull;
            {
                allgivefull = givesemi + givefull;
                textBox22.Text = allgivefull.ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int allin = int.Parse(allin4.Text);
            int bonus = int.Parse(textBox22.Text);
            int b;
            b = allin - bonus;
            textBox24.Text = b.ToString();
            int outcome2 = int.Parse(textBox24.Text);
            if (outcome2 > 5000000)
            {
                outcome2 = ((outcome2 * 35) / 100);
            }
            else if (outcome2 > 2000000)
            {
                outcome2 = ((outcome2 * 30) / 100);
            }
            else if (outcome2 > 1000000)
            {
                outcome2 = ((outcome2 * 25) / 100);
            }
            else if (outcome2 > 750000)
            {
                outcome2 = ((outcome2 * 20) / 100);
            }
            else if (outcome2 > 500000)
            {
                outcome2 = ((outcome2 * 15) / 100);
            }
            else if (outcome2 > 300000)
            {
                outcome2 = ((outcome2 * 10) / 100);
            }
            else if (outcome2 > 150000)
            {
                outcome2 = ((outcome2 * 5) / 100);
            }
            else
            {
                outcome2 = 0;
            }
            textBox23.Text = outcome2.ToString();
            Program.money = int.Parse(textBox24.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panelgr5.Show();
            panelgr5.BringToFront();
        }

        private void panelgr5_Paint(object sender, PaintEventArgs e)
        {
            theendofallin.Text = Program.money.ToString();
        }

        private void panelgr4_Paint(object sender, PaintEventArgs e)
        {
            allin4.Text = Program.money.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int shop1 = int.Parse(numericUpDown22.Text);
            int shop2 = int.Parse(numericUpDown23.Text);
            int shop3 = int.Parse(numericUpDown24.Text);
            int shop4 = int.Parse(numericUpDown25.Text);
            int tour1 = int.Parse(numericUpDown26.Text);
            int tour2 = int.Parse(numericUpDown27.Text);
            int fixhome1 = int.Parse(numericUpDown28.Text);
            int fixcar1 = int.Parse(numericUpDown29.Text);
            int fixhome2 = int.Parse(numericUpDown30.Text);
            int fixcar2 = int.Parse(numericUpDown31.Text);
            int bottour = 0;
            int botfix1 = 0;
            int botfix2 = 0;
            int allend;
            if ((tour1 + tour2) >= 20000)
            {
                bottour = 20000;
            }
            else if ((tour1 + tour2) < 20000)
            {
                bottour = tour1 + tour2;
            }
            if ((fixhome1 + fixcar1) >= 100000)
            {
                botfix1 = 100000;
            }
            else if ((fixhome1 + fixcar1) < 100000)
            {
                botfix1 = fixhome1 + fixcar1;
            }
            if ((fixhome2 + fixcar2) >= 100000)
            {
                botfix2 = 100000;
            }
            else if ((fixhome2 + fixcar2) < 100000)
            {
                botfix2 = fixhome2 + fixcar2;
            }
            {
                allend = (shop1 + shop2 + shop3 + shop4 + bottour + botfix1 + botfix2);
                textBox25.Text = allend.ToString();

            }
            ///////////////
            int allin = int.Parse(theendofallin.Text);
            int bonus = int.Parse(textBox25.Text);
            int b;
            b = allin - bonus;
            textBox26.Text = b.ToString();
            int outcome2 = int.Parse(textBox26.Text);
            if (outcome2 > 5000000)
            {
                outcome2 = ((outcome2 * 35) / 100);
            }
            else if (outcome2 > 2000000)
            {
                outcome2 = ((outcome2 * 30) / 100);
            }
            else if (outcome2 > 1000000)
            {
                outcome2 = ((outcome2 * 25) / 100);
            }
            else if (outcome2 > 750000)
            {
                outcome2 = ((outcome2 * 20) / 100);
            }
            else if (outcome2 > 500000)
            {
                outcome2 = ((outcome2 * 15) / 100);
            }
            else if (outcome2 > 300000)
            {
                outcome2 = ((outcome2 * 10) / 100);
            }
            else if (outcome2 > 150000)
            {
                outcome2 = ((outcome2 * 5) / 100);
            }
            else
            {
                outcome2 = 0;
            }
            textBox27.Text = outcome2.ToString();
            Program.money = int.Parse(textBox26.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            showSubmenu(morepanel);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            endcreditpanel.Show();
            endcreditpanel.BringToFront();
        }

        private void home_Click(object sender, EventArgs e)
        {
            BGpanel.Show();
            BGpanel.BringToFront();
        }
    }
}
