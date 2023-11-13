using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyChatgpt
{
    public partial class fADD : Form
    {
        SqlConnection con = new SqlConnection("server=.;database=MyChatgpt; user id=test;password=ibrahimhany1020");
         string ID;
        public fADD()
        {
            InitializeComponent();
        }
        public fADD(string ID)
        {
            InitializeComponent();
            this.ID = ID;
            try
            {
                SqlCommand cmd = new SqlCommand("spSelectByID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ID);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    tbID.Text = dr[0].ToString();
                    tbError.Text = dr[1].ToString();
                    tbDescription.Text = dr[3].ToString();
                    tbProcess.Text = dr[4].ToString();
                    if (!string.IsNullOrEmpty(dr[5].ToString())){
                        byte[] pic = (byte[])dr[5];
                        MemoryStream m = new MemoryStream(pic);
                        pictureBox1.Image = Image.FromStream(m); }
                    if (!string.IsNullOrEmpty(dr[2].ToString()))
                    {
                        tbPL.Text = dr[2].ToString();
                    }


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
                
                
                }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ID))
            {
                try
                {

                    //add

                    //strore the image to array->from image to byte[]
                    MemoryStream m = new MemoryStream();
                    pictureBox1.Image.Save(m, ImageFormat.Png);
                    var pic = m.ToArray();

                    SqlCommand com = new SqlCommand("spAddEntry2", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@name", tbError.Text.ToString());
                    com.Parameters.AddWithValue("@programmingLanguage", tbPL.Text.ToString());
                    com.Parameters.AddWithValue("@description", tbDescription.Text.ToString());
                    com.Parameters.AddWithValue("@process", tbProcess.Text.ToString());
                    com.Parameters.AddWithValue("@image", pic);
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
            else
            {
                //edit


                try
                {

                 

                    //strore the image to array->from image to byte[]
                    MemoryStream m = new MemoryStream();
                    pictureBox1.Image.Save(m, ImageFormat.Png);
                    var pic = m.ToArray();

                    SqlCommand com = new SqlCommand("spEdit2", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@name", tbError.Text);
                    com.Parameters.AddWithValue("@ID", ID);
                    com.Parameters.AddWithValue("@programmingLanguage", tbPL.Text);
                    com.Parameters.AddWithValue("@description", tbDescription.Text);
                    com.Parameters.AddWithValue("@process", tbProcess.Text);
                    com.Parameters.AddWithValue("@image", pic);
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

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog p = new OpenFileDialog();
                p.Filter = "Image Files|*.JPG;*.PNG;";
                if (p.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(p.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
