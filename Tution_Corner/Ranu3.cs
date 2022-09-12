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
    public partial class Ranu3 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Ranu3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into tutors values(@select_location,@select_category,@select_class,@day_per_week,@select_gender,@select_subject,@salary_range,@details)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@select_location",comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@select_category", comboBox2.SelectedItem);
            cmd.Parameters.AddWithValue("@select_class", comboBox5.SelectedItem);
            cmd.Parameters.AddWithValue("@day_per_week", comboBox3.SelectedItem);
           
            cmd.Parameters.AddWithValue("@select_gender", radioButton1.Checked);
            cmd.Parameters.AddWithValue("@select_subject", comboBox4.SelectedItem);
            cmd.Parameters.AddWithValue("@salary_range", comboBox6.SelectedItem);
            cmd.Parameters.AddWithValue("@details", richTextBox1.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();



            if (a > 0)
            {
                MessageBox.Show("Data Inserted Successfully!");
                Ranu1 r = new Ranu1();
                r.Show();
                r.Hide();
            }
            else
            {
                MessageBox.Show("Data not Inserted Successfully!");



            }

        }

        private void Ranu3_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ranu1 r = new Ranu1();
            r.Show();
            this.Hide();
        }
    }
}
