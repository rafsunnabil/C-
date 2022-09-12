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
    public partial class Munim3 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Munim3()
        {
            InitializeComponent();
            BindGridView();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "Select * from guardian_details where FNAME= '" + Form10.fname + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            ///Image Column
            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[7];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //AUTOSIZE
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Image Height
            dataGridView1.RowTemplate.Height = 50;
        }

        private void Munim3_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void button4_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Munim1 m = new Munim1();
            m.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update guardian_details set fname=@fname, lname=@lname, phone=@phone, password=@password, email=@email, gender=@gender, location=@location, picture=@picture where fname=@fname";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@fname", textBox1.Text);
            cmd.Parameters.AddWithValue("@lname", textBox2.Text);
            cmd.Parameters.AddWithValue("@phone", textBox6.Text);
            cmd.Parameters.AddWithValue("@password", textBox3.Text);
            cmd.Parameters.AddWithValue("@email", textBox4.Text);
            cmd.Parameters.AddWithValue("@gender", textBox5.Text);
            cmd.Parameters.AddWithValue("@location", textBox7.Text);
            cmd.Parameters.AddWithValue("@picture", SavePhoto());

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
            pictureBox1.Image.Save(ms, pictureBox2.Image.RawFormat);
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
            textBox1.Clear();
            textBox2.Clear();
            textBox6.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            pictureBox1.Image = Properties.Resources.images;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            //comboBox1.SelectedItem = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            //numericUpDown1.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
            pictureBox1.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[7].Value);
        }      
        private void button2_Click_1(object sender, EventArgs e)
        {
            ResetContro();
        }
    }
}
