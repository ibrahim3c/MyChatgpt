using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace MyChatgpt
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server=.;database=MyChatgpt; user id=test;password=ibrahimhany1020");

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("spSelectall", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[5].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form f = new fADD();
            f.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            fADD f = new fADD(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            f.ShowDialog();



        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            // from byte[] to image
            if (!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[5].Value.ToString()))
            {
                byte[] pic = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream m = new MemoryStream(pic);
                Image picCode = Image.FromStream(m);

                Form image = new Form3(picCode);
                image.ShowDialog();
            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are u sure ?", "confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {


                try
                {
                    string ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    SqlCommand com = new SqlCommand("spDelete", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@ID", ID);

                    con.Open();
                    com.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    Application.Restart();
                }
            }

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSearch.Text))
            {
                try
                {
                  
                    SqlDataAdapter com = new SqlDataAdapter("spSearch", con);
                    //com.SelectCommand = CommandType.StoredProcedure;
                    com.SelectCommand.CommandType = CommandType.StoredProcedure;
                    com.SelectCommand.Parameters.AddWithValue("@param", '%' + tbSearch.Text + '%');

                    con.Open();
                 
                    DataTable ds = new DataTable();
                    com.Fill(ds);
                    dataGridView1.DataSource = ds;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();

                }

            }
            else
            {

                try
                {

                    SqlDataAdapter da = new SqlDataAdapter("spSelectall", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[5].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}



