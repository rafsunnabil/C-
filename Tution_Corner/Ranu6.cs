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
    public partial class Ranu6 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Ranu6()
        {
            InitializeComponent();
            BindGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "Select * from tutors_details where NAME= '" + Form9.name + "'";
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
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ranu2 r = new Ranu2();
            r.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ranu6_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update tutors_details set name=@name, phone=@phone, password=@password, email=@email, gender=@gender, qualification=@qualification, institution=@institution, picture=@image where name=@name";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", textBox7.Text);
            cmd.Parameters.AddWithValue("@phone", textBox8.Text);
            cmd.Parameters.AddWithValue("@password", textBox9.Text);
            cmd.Parameters.AddWithValue("@email", textBox10.Text);
            cmd.Parameters.AddWithValue("@gender", textBox1.Text);
            cmd.Parameters.AddWithValue("@qualification", textBox2.Text);
            cmd.Parameters.AddWithValue("@institution", textBox3.Text);
            cmd.Parameters.AddWithValue("@image", SavePhoto());
            //cmd.Parameters.AddWithValue("@id", textBox1.Text);
            //cmd.Parameters.AddWithValue("@name", textBox2.Text);
            //cmd.Parameters.AddWithValue("@age", numericUpDown1.Value);
            //cmd.Parameters.AddWithValue("@img", SavePhoto());

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
            pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
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
            pictureBox2.Image = Properties.Resources.images;
        }

        private void button6_Click(object sender, EventArgs e)
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
            //comboBox1.SelectedItem = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            //numericUpDown1.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
            pictureBox2.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[7].Value);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            //ofd.Filter = "PNG FILE (*.png) | *.png";
            ofd.Filter = "IMAGE FILE (All files) (*.*) | *.*";
            //ofd.ShowDialog();



            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(ofd.FileName);
            }
        }
    }
}
