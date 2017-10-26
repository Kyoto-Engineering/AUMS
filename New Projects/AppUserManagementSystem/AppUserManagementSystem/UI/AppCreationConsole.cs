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
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            

        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
