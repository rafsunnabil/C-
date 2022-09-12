using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Tution_Corner
{
    public partial class Form4 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            //ofd.Filter = "PNG File (*.png) | *.png";
            //ofd.Filter = "JPG File (*.jpg) | *.jpg";
            //ofd.Filter = "Image File (*.png;*.jpg) | *.png; *.jpg";
            ofd.Filter = "Image File (All files) *.* | *.*";
            //ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into tutors_details values(@name,@phone,@email,@password,@gender,@qualification,@institution,@image)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            //cmd.Parameters.AddWithValue("@parents_name", textBox2.Text);
            cmd.Parameters.AddWithValue("@phone", textBox2.Text);
            cmd.Parameters.AddWithValue("@email", textBox3.Text);
            cmd.Parameters.AddWithValue("@password", textBox4.Text);
            //cmd.Parameters.AddWithValue("@confirm_password", textBox5.Text);
            cmd.Parameters.AddWithValue("@gender", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@qualification", textBox6.Text);
            cmd.Parameters.AddWithValue("@institution", textBox7.Text);
            //cmd.Parameters.AddWithValue("@class", numericUpDown1.Value);
            //cmd.Parameters.AddWithValue("@age", numericUpDown2.Value);
            //cmd.Parameters.AddWithValue("@location", textBox7.Text);
            cmd.Parameters.AddWithValue("@image", SavePhoto());

            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully!");
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Data not Inserted Successfully!");

            }
        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
           // throw new NotImplementedException();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 fr = new Form7();
            fr.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
                     
        }
    }
}
