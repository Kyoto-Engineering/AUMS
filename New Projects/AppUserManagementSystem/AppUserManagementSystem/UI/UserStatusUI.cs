using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
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
    public partial class UserStatusUI : Form
    {
        public bool statusidselected;
        public int statusId;
        private int userid;
        private SqlConnection con;
        private SqlCommand cmd;
        ConnectionString cs = new ConnectionString();
        private SqlDataReader rdr;

        public UserStatusUI()
        {
            InitializeComponent();
        }

        private void UserStatusUI_Load(object sender, EventArgs e)
        {
            usergrdload();
            Statusload();
            groupBox3.Enabled = false;
            button1.Enabled = false;
        }

        private void usergrdload()
        {
           
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string q1 = "SELECT Users.UserName, Users.EmployeeId, Users.FullName, Designations.Designation, StatusTable.StatusName, Users.UserId  FROM Users LEFT OUTER JOIN Designations ON Users.DesignationId = Designations.DesignationId LEFT OUTER JOIN StatusTable ON Users.StatusID =  StatusTable.StatusID where Users.UsercatId = 1";
                cmd = new SqlCommand(q1, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
            while (rdr.Read() == true)
            {
                dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5]);
            }    

            con.Close();

           

        }

        private void Statusload()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string q2 = "SELECT StatusName FROM StatusTable where StatusID < 3";
                cmd = new SqlCommand(q2, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read() == true)
                {
                    StatusCombo.Items.Add(rdr.GetValue(0).ToString());
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
                    userid = Convert.ToInt32(dr.Cells[5].Value.ToString());

                    usernametxtbox.Text = dr.Cells[0].Value.ToString();
                    emplyeeidtxtbox.Text = dr.Cells[1].Value.ToString();
                    fullnametxtbox.Text = dr.Cells[2].Value.ToString();
                    designationtxtbox.Text = dr.Cells[3].Value.ToString();
                    currentstatustxtbox.Text = dr.Cells[4].Value.ToString();
                    useridtxtbox.Text = dr.Cells[5].Value.ToString();


                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                groupBox3.Enabled = true;
            }

        }

        private void StatusCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusCombo.SelectedIndex != -1)
            {

                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string q3 = "SELECT StatusID FROM StatusTable where StatusName ='" + StatusCombo.Text + "'";
                    cmd = new SqlCommand(q3, con);
                    rdr = cmd.ExecuteReader();
                    if(rdr.Read())
                    {
                        statusId = (rdr.GetInt32(0));
                        statusidselected = true;
                        textBox1.Text = statusId.ToString();

                    }
                    con.Close();
                    
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
  
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qs = "UPDATE Users SET StatusID = '" + statusId + "' where UserId = '"+ userid +"'";
                cmd = new SqlCommand(qs, con);
                cmd.ExecuteScalar();
                con.Close();


                if (statusId == 1)
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string qs1 = "UPDATE Users SET ActiveDate = @date where UserId = '" + userid + "'";
                    cmd = new SqlCommand(qs1, con);

                    cmd.Parameters.AddWithValue("@date", DateTime.UtcNow.ToLocalTime());
                    //cmd.Parameters.AddWithValue("@date1", DBNull.Value);


                    //cmd.Parameters.AddWithValue("@date1", DateTime.UtcNow.ToLocalTime());
                    //cmd.Parameters.AddWithValue("@date", DBNull.Value);



                    cmd.ExecuteScalar();
                    con.Close();

                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string qs3 = "UPDATE Users SET InactiveDate = @date3 where UserId = '" + userid + "'";
                    cmd = new SqlCommand(qs3, con);

                   // cmd.Parameters.AddWithValue("@date3", DateTime.UtcNow.ToLocalTime());
                    cmd.Parameters.AddWithValue("@date3", DBNull.Value);


                    //cmd.Parameters.AddWithValue("@date1", DateTime.UtcNow.ToLocalTime());
                    //cmd.Parameters.AddWithValue("@date", DBNull.Value);



                    cmd.ExecuteScalar();
                    con.Close();



                }

                else if (statusId == 2)
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string qs2 = "UPDATE Users SET InactiveDate = @date1 where UserId = '" + userid + "'";
                    cmd = new SqlCommand(qs2, con);

                    cmd.Parameters.AddWithValue("@date1", DateTime.UtcNow.ToLocalTime());
                    //cmd.Parameters.AddWithValue("@date1", DBNull.Value);


                    //cmd.Parameters.AddWithValue("@date1", DateTime.UtcNow.ToLocalTime());
                    //cmd.Parameters.AddWithValue("@date", DBNull.Value);



                    cmd.ExecuteScalar();
                    con.Close();

                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string qs4 = "UPDATE Users SET ActiveDate = @date4 where UserId = '" + userid + "'";
                    cmd = new SqlCommand(qs4, con);

                   // cmd.Parameters.AddWithValue("@date4", DateTime.UtcNow.ToLocalTime());
                    cmd.Parameters.AddWithValue("@date4", DBNull.Value);


                    //cmd.Parameters.AddWithValue("@date1", DateTime.UtcNow.ToLocalTime());
                    //cmd.Parameters.AddWithValue("@date", DBNull.Value);



                    cmd.ExecuteScalar();
                    con.Close();

                }
                MessageBox.Show("Status given Done");
                usernametxtbox.Clear();
                fullnametxtbox.Clear();
                designationtxtbox.Clear();
                currentstatustxtbox.Clear();
                StatusCombo.Items.Clear();
                Statusload();
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                usergrdload();

            }

            catch (Exception ere)
            {
                MessageBox.Show(ere.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
         


            //MessageBox.Show("Status given Done");
            //usernametxtbox.Clear();
            //fullnametxtbox.Clear();
            //designationtxtbox.Clear();
            //currentstatustxtbox.Clear();
            //StatusCombo.Items.Clear();
            //Statusload();
            //dataGridView1.Rows.Clear();
            //dataGridView1.Refresh();
            //usergrdload();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
