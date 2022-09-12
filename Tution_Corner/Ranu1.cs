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
    public partial class Ranu1 : Form
    {
        public Ranu1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ranu2 f2 = new Ranu2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ranu3 f3 = new Ranu3();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ranu4 f4 = new Ranu4();
            f4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ranu5 f5 = new Ranu5();
            f5.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
