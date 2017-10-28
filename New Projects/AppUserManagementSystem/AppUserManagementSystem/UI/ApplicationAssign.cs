using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppUserManagementSystem.DbGateway;

namespace AppUserManagementSystem.UI
{
    public partial class ApplicationAssign : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        ConnectionString cs = new ConnectionString();
        private SqlDataReader rdr;
        public int usid, appsid, uacessid;
        public ApplicationAssign()
        {
            InitializeComponent();
        }

        

        private void ApplicationAssign_Load(object sender, EventArgs e)
        {
            usergrdld();
            appld();
            usertypecomboload();
            accesloggrdld();
        }

        private void usergrdld()
        {

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qqw = "select UserName, FullName, EmployeeId, UserId from Users where UsercatId=1 and StatusID=1 ";
                cmd = new SqlCommand(qqw, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();

                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3]);
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void appld()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qry = "select AppId, AppName from AppsTable";
                cmd = new SqlCommand(qry, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView2.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView2.Rows.Add(rdr[0], rdr[1]);
                }
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usertypecomboload()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string tpld = "select AccessType from AccessTable where AccessId < 4 ";
                cmd = new SqlCommand(tpld, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read()== true)
                {
                    comboBox1.Items.Add(rdr.GetString(0));
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void accesloggrdld()
        {

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qry1 = "select AccessLogTable.AccessLogId, Users.UserName, Users.FullName, AppsTable.AppName, AccessTable.AccessType from Users INNER JOIN AccessLogTable ON Users.UserId = AccessLogTable.UserId INNER JOIN AppsTable ON AccessLogTable.AppId = AppsTable.AppId INNER JOIN AccessTable ON AccessLogTable.AccessId = AccessTable.AccessId ";
                cmd = new SqlCommand(qry1, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView3.Rows.Clear();
                while (rdr.Read()== true)
                {
                    dataGridView3.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4]);
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow dr = dataGridView1.CurrentRow;
                    usid = Convert.ToInt32(dr.Cells[3].Value.ToString());

                    textBox2.Text = dr.Cells[0].Value.ToString();
                    textBox1.Text = dr.Cells[1].Value.ToString();
                    textBox4.Text = dr.Cells[2].Value.ToString();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
           

        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow dr1 = dataGridView2.CurrentRow;
                    appsid = Convert.ToInt32(dr1.Cells[0].Value.ToString());

                    textBox3.Text = dr1.Cells[0].Value.ToString();
                    textBox5.Text = dr1.Cells[1].Value.ToString();

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string qr = "select AccessId from AccessTable where AccessType ='" + comboBox1.Text + "' ";
                    cmd = new SqlCommand(qr, con);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() == true)
                    {
                        uacessid = rdr.GetInt32(0);
                    }
                    con.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Assignbutton_Click(object sender, EventArgs e)
        {
            
           if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Select User.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Select App.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Select Access Right Type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string qq1 = "Select UserId, AppId From AccessLogTable where UserId = @uid and AppId=@apid ";
                    cmd = new SqlCommand(qq1, con);
                    cmd.Parameters.AddWithValue("@uid", usid);
                    cmd.Parameters.AddWithValue("@apid", appsid);
                    //int usexist = (int) cmd.ExecuteScalar();
                    //int apexist = (int)cmd.ExecuteScalar();
                    int aaa = Convert.ToInt32(cmd.ExecuteScalar());
                    if (aaa > 0 )
                    {
                       MessageBox.Show("This User Already Has Been Assigned to This App","Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    }

                    else
                    {
                        try
                        {
                            con = new SqlConnection(cs.DBConn);
                            string qwer = "INSERT INTO AccessLogTable (UserId, AppId, AccessId) VALUES (@d1,@d2,@d3) " + "SELECT CONVERT(int, SCOPE_IDENTITY())";
                            cmd = new SqlCommand(qwer, con);
                            cmd.Parameters.AddWithValue("@d1", usid);
                            cmd.Parameters.AddWithValue("@d2", appsid);
                            cmd.Parameters.AddWithValue("@d3", uacessid);

                            con.Open();
                            cmd.ExecuteScalar();
                            con.Close();
                            MessageBox.Show("App Assigned Successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                   

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                
            }



        }





    }
}

//try
//{
//con = new SqlConnection(cs.DBConn);
//string qwer = "INSERT INTO AccessLogTable (UserId, AppId, AccessId) VALUES (@d1,@d2,@d3) " + "SELECT CONVERT(int, SCOPE_IDENTITY())";
//cmd = new SqlCommand(qwer, con);
//cmd.Parameters.AddWithValue("@d1", usid);
//cmd.Parameters.AddWithValue("@d2", appsid);
//cmd.Parameters.AddWithValue("@d3", uacessid);

//con.Open();
//cmd.ExecuteScalar();
//con.Close();
//MessageBox.Show("App Assigned Successfully","Completed",MessageBoxButtons.OK,MessageBoxIcon.Information);
//}
//catch (Exception exception)
//{
//MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//}