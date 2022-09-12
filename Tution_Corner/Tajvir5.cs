using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tution_Corner
{
    public partial class Tajvir5 : Form
    {
        int panelWidth;
        bool Hidden;
        public Tajvir5()
        {
            InitializeComponent();
            panelWidth = panel3.Width;
            Hidden = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                panel5.Width = panel5.Width + 10;
                if (panel5.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panel5.Width = panel5.Width - 10;
                if (panel5.Width <= 0)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                panel8.Width = panel8.Width + 20;
                if (panel8.Width >= panelWidth)
                {
                    timer2.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panel8.Width = panel8.Width - 20;
                if (panel8.Width <= 0)
                {
                    timer2.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("+8801234567891");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("+8801234567891");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Munim1 m = new Munim1();
            m.Show();
            this.Hide();
        }
    }
}
