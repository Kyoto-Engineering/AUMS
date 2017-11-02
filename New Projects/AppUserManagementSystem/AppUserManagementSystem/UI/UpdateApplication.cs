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
    public partial class UpdateApplication : Form
    {
        public UpdateApplication()
        {
            InitializeComponent();
        }

        private SqlConnection con;
        private SqlCommand cmd;
        private ConnectionString cs = new ConnectionString();
        private SqlDataReader rdr;
        private int appidkey;
        



        private void appupdate()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qry = "select AppId, AppName from AppsTable";
                cmd = new SqlCommand(qry, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1]);
                }
                

                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void UpdateApplication_Load(object sender, EventArgs e)
        {
            appupdate();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    try
                    {
                        DataGridViewRow dr = dataGridView1.CurrentRow;
                        // userid = Convert.ToInt32(dr.Cells[5].Value.ToString());
                        
                        exappname.Text = dr.Cells[1].Value.ToString();

                        appidkey = Convert.ToInt32(dr.Cells[0].Value.ToString());

                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(upname.Text))
            {
                MessageBox.Show("No input FOUND", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Updatebutton.Visible = false;
                return;
            }
            else
            {

                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string cb = "UPDATE AppsTable SET AppName =  '" + upname.Text + "' WHERE AppId='" + appidkey + "'";
                    cmd = new SqlCommand(cb, con);
                    // cmd.Parameters.AddWithValue("@d1", .Text);

                    cmd.ExecuteReader();
                    con.Close();




                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();
                    upname.Clear();
                    exappname.Clear();
                    appupdate();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}