using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppUserManagementSystem.DbGateway;
using AppUserManagementSystem.UI;

namespace AppUserManagementSystem.Log_in_Ui
{

    public partial class Loginuiaums : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr, rdr1, rdr2;
        ConnectionString cs = new ConnectionString();
        public string readyPassword, dbUserName, dbPassword;
        public static int uId;
        public static string userType, fullName;
        public string userId;
        public string userName, password;
        public Loginuiaums()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }


        private void MaintainCOOAuthorization()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qry = "SELECT COOId FROM  COO WHERE  (UserId = @UI) AND (ResignationDate IS NULL)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@UI", userId);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    if (rdr.HasRows)
                    {
                        userType = "COO";
                        
                         MainmainUI frm = new MainmainUI();
                        this.Visible = false;
                        frm.ShowDialog();
                        this.Visible = true;
                    }

                }
                else
                {
                    MessageBox.Show("This COO (" + fullName + ") has retired now", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtUserName.Clear();
                    return;

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            try
            {

                string clearText = txtPassword.Text.Trim();
                string password = clearText;
                byte[] bytes = Encoding.Unicode.GetBytes(password);
                byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
                string readyPassword1 = Convert.ToBase64String(inArray);
                readyPassword = readyPassword1;


                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qry = "SELECT  RTRIM(Users.UserId),RTRIM(Users.UserName),RTRIM(Users.Password) FROM  Users  WHERE Users.UserName = '" + txtUserName.Text + "' AND  Users.Password = '" + readyPassword + "'";
                cmd = new SqlCommand();
                cmd.CommandText = qry;
                cmd.Connection = con;
                rdr1 = cmd.ExecuteReader();
                if (rdr1.Read())
                {
                    userId = (rdr1.GetString(0));
                    dbUserName = (rdr1.GetString(1));
                    dbPassword = (rdr1.GetString(2));
                    uId = Convert.ToInt32(userId);
                }
                else
                {
                    MessageBox.Show("User Id Or Password does not match", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtUserName.Clear();
                    return;
                }
                con.Close();

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string qry1 = "Select RTRIM(Users.UserType),RTRIM(Users.FullName)  from  Users WHERE Users.UserName = '" + dbUserName + "' AND  Users.Password = '" + dbPassword + "'";
                cmd = new SqlCommand(qry1, con);
                rdr2 = cmd.ExecuteReader();
                if (rdr2.Read())
                {
                    userType = (rdr2.GetString(0));
                    fullName = (rdr2.GetString(1));
                    string caseSwitch = userType;
                    switch (caseSwitch)
                    {
                        case "COO":
                            MaintainCOOAuthorization();
                            txtUserName.Clear();
                            txtPassword.Clear();
                            txtUserName.Focus();
                            break;
                        
                        default:
                            MessageBox.Show("You are not Authorized to log in", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUserName.Clear();
                            txtPassword.Clear();
                            txtUserName.Focus();
                            break;
                    }
                }

                else
                {
                    MessageBox.Show("Login is Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
