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
    public partial class Tajvir2 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Tajvir2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into student_details values(@name,@parents_name,@phone,@password,@email,@gender,@class,@age,@location,@image)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@parents_name", textBox2.Text);
            cmd.Parameters.AddWithValue("@phone", textBox5.Text);
            cmd.Parameters.AddWithValue("@password", textBox3.Text);
            //cmd.Parameters.AddWithValue("@confirm_password", textBox5.Text);
            cmd.Parameters.AddWithValue("@email", textBox6.Text);
            cmd.Parameters.AddWithValue("@gender", comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@class", numericUpDown1.Value);          
            cmd.Parameters.AddWithValue("@age", numericUpDown2.Value);
            cmd.Parameters.AddWithValue("@location", textBox7.Text );
            cmd.Parameters.AddWithValue("@image", SavePhoto());

            con.Open();
            int a = cmd.ExecuteNonQuery();

            if (a>0)
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

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            //ofd.Filter = "PNG FILE (*.png) | *.png";
            ofd.Filter = "IMAGE FILE (All files) (*.*) | *.*";
            //ofd.ShowDialog();

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tajvir1 f1 = new Tajvir1();
            f1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form7 fr = new Form7();
            fr.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
