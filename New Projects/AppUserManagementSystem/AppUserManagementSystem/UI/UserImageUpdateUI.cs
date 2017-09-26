using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppUserManagementSystem.DbGateway;

namespace AppUserManagementSystem.UI
{
    public partial class UserImageUpdateUI : Form
    {
        private int userid;
        private SqlConnection con;
        private SqlCommand cmd;
        ConnectionString cs = new ConnectionString();
        private SqlDataReader rdr;
        private SqlParameter p;
        private SqlParameter p1;
        public UserImageUpdateUI()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void usergld()
        {
            con = new SqlConnection(cs.DBConn);
            con.Open();
            string q1 = "SELECT Users.EmployeeId, Users.FullName, Designations.Designation, Users.UserId, Users.UserImage  FROM Users LEFT OUTER JOIN Designations ON Users.DesignationId = Designations.DesignationId ";
            cmd = new SqlCommand(q1, con);
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            dataGridView1.Rows.Clear();
           
            while (rdr.Read() == true)
            {
                dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4]);
            }

            con.Close();


        }


        private void UserImageUpdateUI_Load(object sender, EventArgs e)
        {
            usergld();
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            button1.Enabled = false;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                groupBox3.Enabled = true;
                try
                {
                    DataGridViewRow dr = dataGridView1.CurrentRow;
                    userid = Convert.ToInt32(dr.Cells[3].Value.ToString());

                    label2.Text = dr.Cells[0].Value.ToString();
                    label3.Text = dr.Cells[1].Value.ToString();
                    label5.Text = dr.Cells[2].Value.ToString();
                    label7.Text = dr.Cells[3].Value.ToString();
                    // useridtxtbox.Text = dr.Cells[4].Value.ToString();


                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                var _with1 = openFileDialog1;

                _with1.Filter = ("Image Files |*.png;*.bmp; *.jpg;*.jpeg; *.gif;");
                _with1.FilterIndex = 4;

                openFileDialog1.FileName = "";
                //if (Image.FromFile(openFileDialog1.FileName).Height != 300)
                //{
                //    MessageBox.Show("Height Must Be 300 Pixel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (Image.FromFile(openFileDialog1.FileName).Height != 300)
                    {
                        MessageBox.Show("Height Must Be 300 Pixel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (Image.FromFile(openFileDialog1.FileName).Width != 300)
                    {
                        MessageBox.Show("Width Must Be 300 Pixel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        //if (ValidFile(openFileDialog1.FileName, 300, 2176))
                        //{

                        pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                        //pictureBrowseButton.Focus();
                    }
                    //else
                    //{
                    //    MessageBox.Show("Image Size is invalid");
                    //}
                    groupBox4.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {  
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qry = "Update Users set UserImage = @d12, Signature = @d13 where UserId = '" + userid + "'";
                cmd = new SqlCommand(qry, con);

                if (pictureBox1.Image != null && pictureBox1.Image != null)
                {
                    //button1.Enabled = true;
                    MemoryStream ms = new MemoryStream();
                    Bitmap bmpImage = new Bitmap(pictureBox1.Image);
                    bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] data = ms.GetBuffer();
                    p = new SqlParameter("@d12", SqlDbType.VarBinary);
                    p.Value = data;
                    cmd.Parameters.Add(p);

                    MemoryStream ms1 = new MemoryStream();
                    Bitmap bmpImage1 = new Bitmap(pictureBox2.Image);
                    bmpImage1.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] data1 = ms1.GetBuffer();
                    p1 = new SqlParameter("@d13", SqlDbType.VarBinary);
                    p1.Value = data1;
                    cmd.Parameters.Add(p1);


                }
                else
                {
                    MessageBox.Show("Select Images First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cmd.ExecuteScalar();
                con.Close();
                MessageBox.Show("Upload Done");
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                label2.Text = null;
                label3.Text = null;
                label5.Text = null;



            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
                  
        try
        {
        var _with1 = openFileDialog1;

        _with1.Filter = ("Image Files |*.png;*.bmp; *.jpg;*.jpeg; *.gif;");
        _with1.FilterIndex = 4;

        openFileDialog1.FileName = "";
        //if (Image.FromFile(openFileDialog1.FileName).Height != 300)
        //{
        //    MessageBox.Show("Height Must Be 300 Pixel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    return;
        //}
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
        if (Image.FromFile(openFileDialog1.FileName).Height != 80)
        {
        MessageBox.Show("Height Must Be 80 Pixel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
        }
        else if (Image.FromFile(openFileDialog1.FileName).Width != 300)
        {
        MessageBox.Show("Width Must Be 300 Pixel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
        }
        else
        {
        //if (ValidFile(openFileDialog1.FileName, 300, 2176))
        //{

        pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
        //pictureBrowseButton.Focus();
        }
        //else
        //{
        //    MessageBox.Show("Image Size is invalid");
        //}
        button1.Enabled = true;

        }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        }
    }
}
