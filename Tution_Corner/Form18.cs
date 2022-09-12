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
    public partial class Form18 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form18()
        {
            InitializeComponent();
            BindGridView();
        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "Select * from student_details where NAME= '" + Form11.name + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            ///Image Column
            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[9];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //AUTOSIZE
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Image Height
            dataGridView1.RowTemplate.Height = 50;
        }

        private void Form18_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
            Tajvir4 d = new Tajvir4();
            d.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update student_details set name = @name, parents_name=@parents_name,phone = @phone, password = @password, email = @email, gender = @gender, class = @class, age = @age, location=@location, picture = @image where name = @name";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", textBox7.Text);
            cmd.Parameters.AddWithValue("@parents_name", textBox8.Text);
            cmd.Parameters.AddWithValue("@phone", textBox9.Text);
            cmd.Parameters.AddWithValue("@password", textBox10.Text);
            //cmd.Parameters.AddWithValue("@confirm_password", textBox5.Text);
            cmd.Parameters.AddWithValue("@email", textBox1.Text);
            cmd.Parameters.AddWithValue("@gender", textBox2.Text);
            cmd.Parameters.AddWithValue("@class", textBox3.Text);
            cmd.Parameters.AddWithValue("@age", textBox4.Text);
            cmd.Parameters.AddWithValue("@location", textBox5.Text);
            cmd.Parameters.AddWithValue("@image", SavePhoto());
            con.Open();
            int a = cmd.ExecuteNonQuery();//0 1
            if (a > 0)
            {
                MessageBox.Show("Data Updated Successfully ! ");
                BindGridView();
                ResetContro();
            }
            else
            {
                MessageBox.Show("Data not Updated ! ");
            }
        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
            //throw new NotImplementedException();
        }
        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }


        void ResetContro()
        {
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            pictureBox1.Image = Properties.Resources.images;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetContro();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            //comboBox1.SelectedItem = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            //numericUpDown1.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
            pictureBox1.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[9].Value);
        }
    }
}
