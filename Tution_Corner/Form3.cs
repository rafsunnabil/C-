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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total user 460 people", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todays visist 76 people", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total tutors 260", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total guardians 90", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button28_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Students 110", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.ShowDialog();
            this.Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.ShowDialog();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 fr = new Form5();
            fr.ShowDialog();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.ShowDialog();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form13 fr = new Form13();
            fr.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form14 q = new Form14();
            q.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form15 g = new Form15();
            g.Show();
        }
    }
}
