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

namespace Tution_Corner
{
    public partial class Form11 : Form
    {
        public static string name;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            switch (status)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textBox2.UseSystemPasswordChar = true;
                    break;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "Enter your user name please");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                textBox2.Focus();
                errorProvider2.SetError(this.textBox2, "Enter your user name please");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string query = "Select NAME from student_details where NAME= '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            name = cmd.ExecuteScalar().ToString();
            MessageBox.Show("Login Successfull");
            Tajvir4 t = new Tajvir4();
            t.Show();
            this.Hide();
            con.Close();
            //if (textBox1.Text != "" && textBox2.Text != "")
            //{
            //    SqlConnection con = new SqlConnection(cs);
            //    string query = "select * from student_details where name = @name and password = @password";
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    cmd.Parameters.AddWithValue("@name", textBox1.Text);
            //    cmd.Parameters.AddWithValue("@password", textBox2.Text);


            //    con.Open();

            //    SqlDataReader dr = cmd.ExecuteReader();
            //    if (dr.HasRows == true)
            //    {
            //        MessageBox.Show("Login Successfull");
            //        Tajvir3 t = new Tajvir3();
            //        t.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Login Failed!");
            //    }
            //}
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 fr = new Form8();
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tajvir2 t = new Tajvir2();
            t.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We sent you an email to reset your password\nPlease check your email");
        }
    }
}
