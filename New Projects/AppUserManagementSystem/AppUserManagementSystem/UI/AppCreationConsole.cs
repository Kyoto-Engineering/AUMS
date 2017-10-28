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
    public partial class AppCreationConsole : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        ConnectionString cs = new ConnectionString();
        private SqlDataReader rdr;
        public AppCreationConsole()
        {
            InitializeComponent();
        }

        private void appgrdld()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qry = "select AppId, AppName from AppsTable";
                cmd = new SqlCommand(qry , con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                AppGrid.Rows.Clear();
                while (rdr.Read()==true)
                {
                    AppGrid.Rows.Add(rdr[0],rdr[1]);
                }
                con.Close();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AppCreationConsole_Load(object sender, EventArgs e)
        {
            appgrdld();
        }

        private void InsertAppbutton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(ApptextBox.Text))
            {
                MessageBox.Show("Please Input Application Name", "Caution", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            else
            {
                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string qq1 = "Select AppName From AppsTable where AppName = @appname ";
                    cmd = new SqlCommand(qq1, con);
                    cmd.Parameters.AddWithValue("@appname", ApptextBox.Text);
                    //int appexist = (int) cmd.ExecuteScalar();
                    //if (appexist > 0)
                    //{
                    //    mes
                    //}
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() == true)
                    {
                        MessageBox.Show("This Application Exists", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        try
                        {
                            con = new SqlConnection(cs.DBConn);
                            //con.Open();
                            string ins = "INSERT INTO AppsTable (AppName) VALUES(@d1)";
                            cmd = new SqlCommand(ins, con);
                            cmd.Parameters.AddWithValue("@d1", ApptextBox.Text);
                            con.Open();
                            cmd.ExecuteScalar();

                            con.Close();
                            MessageBox.Show("Application Created Successfully", "Insertoin Completed",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ApptextBox.Clear();
                            AppGrid.Rows.Clear();
                            appgrdld();

                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, "Insert Failed", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    con.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }



    }
}
