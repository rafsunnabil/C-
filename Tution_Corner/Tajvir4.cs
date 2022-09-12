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
    public partial class Tajvir4 : Form
    {
        //public string pass, name;
        //int panelWidth;
        //bool Hidden;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString; 

        //SqlConnection con = new SqlConnection();
        //SqlCommand cmd = new SqlCommand();
        //SqlDataAdapter sda = new SqlDataAdapter();
        //DataSet ds = new DataSet();

        //public object Response { get; private set; }

        public Tajvir4()
        {
            InitializeComponent();
            BindGridView();
            //panelWidth = panel3.Width;
            //Hidden = true;

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

        private void Form4_Load(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //timer2.Start();


        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    if (Hidden)
        //    {
        //        panel3.Width = panel3.Width + 8;
        //        if (panel3.Width >= panelWidth)
        //        {
        //            timer1.Stop();
        //            Hidden = false;
        //            this.Refresh();
        //        }
        //    }
        //    else
        //    {
        //        panel3.Width = panel3.Width - 8;
        //        if (panel3.Width <= 0)
        //        {
        //            timer1.Stop();
        //            Hidden = true;
        //            this.Refresh();
        //        }
        //    }
        //}

        private void button5_Click(object sender, EventArgs e)
        {
            Tajvir3 f3 = new Tajvir3();
            f3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        //private void timer2_Tick_1(object sender, EventArgs e)
        //{
        //    if (Hidden)
        //    {
        //        panel5.Width = panel5.Width + 10;
        //        if (panel5.Width >= panelWidth)
        //        {
        //            timer2.Stop();
        //            Hidden = false;
        //            this.Refresh();
        //        }
        //    }
        //    else
        //    {
        //        panel5.Width = panel5.Width - 10;
        //        if (panel5.Width <= 0)
        //        {
        //            timer2.Stop();
        //            Hidden = true;
        //            this.Refresh();
        //        }
        //    }
        //}

        private void button7_Click(object sender, EventArgs e)
        {
            Form18 t = new Form18();
            t.Show();
            //t.Hide();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Silver;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.ForeColor = Color.Black;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.ForeColor = Color.Silver;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[9].Value);
        }
        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }
    }

    //internal class DataAccess
    //{
    //    internal static DataTable LoadData(object p)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
