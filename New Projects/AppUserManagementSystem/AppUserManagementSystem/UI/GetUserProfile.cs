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
using AppUserManagementSystem.Reports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Web.HtmlReportRender;

namespace AppUserManagementSystem.UI
{
    public partial class GetUserProfile : Form
    {
        public string x;
        private SqlConnection con;
        private SqlCommand cmd;
        ConnectionString cs = new ConnectionString();
        private SqlDataReader rdr;
        private string id;
        public GetUserProfile()
        {
            InitializeComponent();
        }
         
        private void unameld()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string q1 = "select UserName from Users where UsercatId = 1";
                cmd = new SqlCommand(q1, con);
                rdr = cmd.ExecuteReader();
                while (rdr.Read()== true)
                {
                    comboBox1.Items.Add(rdr.GetValue(0).ToString());
                }
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetUserProfile_Load(object sender, EventArgs e)
        {
            unameld();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //creating an object of ParameterField class
            ParameterField paramField = new ParameterField();

            //creating an object of ParameterFields class
            ParameterFields paramFields = new ParameterFields();

            //creating an object of ParameterDiscreteValue class
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            //set the parameter field name
            paramField.Name = "id";

            //set the parameter value
            paramDiscreteValue.Value = id;

            //add the parameter value in the ParameterField object
            paramField.CurrentValues.Add(paramDiscreteValue);

            //add the parameter in the ParameterFields object
            paramFields.Add(paramField);

            //set the parameterfield information in the crystal report



            viwer f2 = new viwer();
            TableLogOnInfos reportLogonInfos = new TableLogOnInfos();
            TableLogOnInfo reportLogonInfo = new TableLogOnInfo();
            ConnectionInfo reportConInfo = new ConnectionInfo();
            Tables tables = default(Tables);
            //	Table table = default(Table);
            var with1 = reportConInfo;
            with1.ServerName = "tcp:KyotoServer,49172";
            with1.DatabaseName = "KeyRegistar_ForTest";
            with1.UserID = "sa";
            with1.Password = "SystemAdministrator";
            userprofile cr = new userprofile();
            tables = cr.Database.Tables;
            foreach (Table table in tables)
            {
                reportLogonInfo = table.LogOnInfo;
                reportLogonInfo.ConnectionInfo = reportConInfo;
                table.ApplyLogOnInfo(reportLogonInfo);
            }
            f2.crystalReportViewer1.ParameterFieldInfo = paramFields;
            //set the parameterfield information in the crystal report
            f2.crystalReportViewer1.ReportSource = cr;
            this.Visible = false;

            f2.ShowDialog();
            this.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

           
            if (comboBox1.SelectedIndex != -1)
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string q2 = "select UserName from Users where UserName = "+ comboBox1.Text +"";
                cmd = new SqlCommand(q2, con);
                rdr = cmd.ExecuteReader();
                if (rdr.Read() == true)
                {
                    id = rdr.GetString(0);
                }
                con.Close();

            }
            
            
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}


