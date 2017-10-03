using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppUserManagementSystem.DbGateway;
using AppUserManagementSystem.Log_in_Ui;
using AppUserManagementSystem.Ui;

namespace AppUserManagementSystem.UI
{
    public partial class NonPcUsercreationUI : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr, rdr1, rdr2;
        ConnectionString cs = new ConnectionString();
        public int emailHostId, nationalityId, departmentId, designationId, genderId, maritalStatusId, emailHostId1;

        public string countryCode, nUserId, divisionIdPA, divisionIdPer, postofficeIdPre, postofficeIdPer, districtIdPA, districtIdPer, thanaIdPA, thanaIdPer, countryId, emailAddresTo;
        public int instantUserId, instantUserId1;
        public string senderEmailHostId, emailAddressFrom, senderEmailDomain, readyPassword, hostName, userName, smtpHost;
        public DateTime myDate;
        public string dbUserFullName, dbEmailAddress, currentEmailAddress;
        public int dbUserId;
        public int catid;
        public string catname;



        public NonPcUsercreationUI()
        {
            InitializeComponent();
        }

        private void GetMaxUserId()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ctk = "SELECT  MAX(UserId) from Users ";
                cmd = new SqlCommand(ctk, con);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    instantUserId = (rdr.GetInt32(0));
                    instantUserId1 = instantUserId + 1;
                    txtNewProbableId.Text = Convert.ToString(instantUserId1);
                    txtLogInID.Text = Convert.ToString(instantUserId1);

                }

                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveOverSeasAddress()
        {
            int fr = 0;
            UserManager amanager = new UserManager();
            try
            {
                OverSeasAddress ovAddress = new OverSeasAddress
                {
                    Street = txtStreetName.Text,
                    State = txtState.Text,
                    PostalCode = txtPostalCode.Text,
                    OUserId = instantUserId.ToString()
                };
                fr = amanager.SaveOverSeasAddress(ovAddress);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SavePermanantAddress()
        {
            int pr = 0;
            UserManager amanager = new UserManager();
            try
            {
                PerManantAddress aperAddress = new PerManantAddress
                {
                    PerFlatNo = txtPerFlatNo.Text,
                    PerHouseNo = txtPerHouseNo.Text,
                    PerRoadNo = txtPerRoadNo.Text,
                    PerBlock = txtPerBlock.Text,
                    PerArea = txtPerArea.Text,
                    PerLandmark = txtPerLandMark.Text,
                    PerBuilding = txtPerBuilding.Text,
                    PerRoadName = txtPerRoadName.Text,
                    PerPostOfficeId = Convert.ToInt32(postofficeIdPer),
                    PerUserId = instantUserId

                };
                pr = amanager.SavePermanantAddress(aperAddress);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void SavePresentAddress()
        {
            int pa = 0;
            UserManager amanager = new UserManager();
            try
            {
                PresentAddress apresentAddress = new PresentAddress
                {
                    PreFlatNo = txtPreFlatNo.Text,
                    PreHouseNo = txtPreHouseNo.Text,
                    PreRoadNo = txtPreRoadNo.Text,
                    PreBlock = txtPreBlock.Text,
                    PreArea = txtPreArea.Text,
                    PreLandmark = txtPreLandMark.Text,
                    PreRoadName = txtPreRoadName.Text,
                    PreBuilding = txtPreBuildingName.Text,
                    PrePostOfficeId = Convert.ToInt32(postofficeIdPre),
                    UserId = instantUserId
                };
                pa = amanager.SavePresentAddress(apresentAddress);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //private void SaveUserEmail(int emailHostIdK, string emailUser, Boolean statuss)
        //{
        //    try
        //    {
        //        int ug = 0;
        //        UserManager aManager = new UserManager();
        //        UserEmail aEmail = new UserEmail();
        //        aEmail.UserPart = emailUser;
        //        aEmail.HostEmailId = emailHostIdK;
        //        aEmail.UserId = instantUserId;
        //        aEmail.IsPrimaryStatus = statuss;
        //        ug = aManager.SaveUserEmail(aEmail);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void SaveUserInformation()
        {
            int ig = 0;
            UserManager auManager = new UserManager();
            try
            {

                Users aUser = new Users
                {
                    EmployeeId = txtEmployeeId.Text,
                    UserName = txtLogInID.Text,
                    FullName = txtFullName.Text,
                    NickName = txtNickName.Text,
                    FatherName = txtFatherName.Text,
                    MotherName = txtMotherName.Text,
                    NationalId = txtNationalId.Text,
                    CountryId = Convert.ToInt32(countryId),
                    PassportNo = txtPassportNo.Text,
                    BirthCertificateNo = txtBirthCertificatNo.Text,
                    DesignationId = designationId,
                    GenderId = genderId,
                    MaritalStatusId = maritalStatusId,

                    DateOfBirth = Convert.ToDateTime(dateOfBirth.Value, System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat),
                    Password = readyPassword,
                    EmpStatus = 3,
                    Caaatid = catid
                };
                ig = auManager.SaveUserDetail(aUser);
                GetMaxUserId();
                //SaveUserEmail(emailHostId, txtPrimaryUserPart.Text, true);
                //if (!string.IsNullOrWhiteSpace(txtSecondaryEmailUser.Text) || !string.IsNullOrWhiteSpace(cmbSecondaryDomain.Text))
                //{
                //    SaveUserEmail(emailHostId1, txtSecondaryEmailUser.Text, false);
                //}
                NewMailMessage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SaveContactNo()
        {
            try
            {
                for (int i = 0; i <= listView1.Items.Count - 1; i++)
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string cb = "insert into ContactNumbers(CountryCode,ContactNo,UserId) VALUES (@d1,@d2,@d3)";
                    cmd = new SqlCommand(cb, con);
                    cmd.Parameters.AddWithValue("@d1", listView1.Items[i].SubItems[1].Text);
                    cmd.Parameters.AddWithValue("@d2", listView1.Items[i].SubItems[2].Text);
                    cmd.Parameters.AddWithValue("@d3", instantUserId);
                    cmd.ExecuteReader();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PermanantSameAsPreentAddress()
        {
            try
            {
                int sag = 0;
                UserManager amanager = new UserManager();

                PresentAddress aperAddress = new PresentAddress
                {
                    PreFlatNo = txtPreFlatNo.Text,
                    PreHouseNo = txtPerHouseNo.Text,
                    PreRoadNo = txtPreRoadName.Text,
                    PreBlock = txtPreBlock.Text,
                    PreArea = txtPreArea.Text,
                    PreLandmark = txtPerLandMark.Text,
                    PreRoadName = txtPerRoadName.Text,
                    PreBuilding = txtPerBuilding.Text,
                    PrePostOfficeId = Convert.ToInt32(postofficeIdPre),
                    UserId = instantUserId
                };
                sag = amanager.PerManantSameAsPresentAddress(aperAddress);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PresentAddress()
        {
            txtPreFlatNo.Clear();
            txtPreHouseNo.Clear();
            txtPreRoadNo.Clear();
            txtPreBlock.Clear();
            txtPreArea.Clear();
            txtPrePostCode.Clear();
            txtPreRoadName.Clear();
            txtPreBuildingName.Clear();
            txtPreLandMark.Clear();
            PAPostOfficeCombo.SelectedIndex = -1;
            PAThanaCombo.SelectedIndex = -1;
            PADistrictCombo.SelectedIndex = -1;
            PADivisionCombo.SelectedIndex = -1;
        }

        private void ResetPermanantAddress2()
        {
            txtPerFlatNo.Clear();
            txtPerHouseNo.Clear();
            txtPerRoadNo.Clear();
            txtPerBlock.Clear();
            txtPerArea.Clear();
            txtPerRoadName.Clear();
            txtPerBuilding.Clear();
            txtPerLandMark.Clear();
            txtPerPostCode.Clear();
            PerAPostOfficeCombo.SelectedIndex = -1;
            PerAThanaCombo.SelectedIndex = -1;
            PerADistrictCombo.SelectedIndex = -1;
            PerADivisionCombo.SelectedIndex = -1;

            SameAsPACheckBox.CheckedChanged -= SameAsPACheckBox_CheckedChanged;
            SameAsPACheckBox.Checked = false;
            SameAsPACheckBox.CheckedChanged += SameAsPACheckBox_CheckedChanged;

        }

        private void Reset()
        {
            txtEmployeeId.Clear();
            txtNewProbableId.Clear();
            txtFullName.Clear();
            txtNickName.Clear();
            txtFatherName.Clear();
            txtMotherName.Clear();
           // txtPrimaryUserPart.Clear();
           // txtSecondaryEmailUser.Clear();
            //cmbPrimaryDomain.SelectedIndex = -1;
            //cmbSecondaryDomain.SelectedIndex = -1;
            if (cmbCountry.Text != "Bangladesh")
            {
                txtStreetName.Clear();
                txtState.Clear();
                txtPostalCode.Clear();
            }
            cmbCountry.SelectedIndex = -1;
            cmbDesignation.SelectedIndex = -1;

            cmbGender.SelectedIndex = -1;
            cmbMaritalStatus.SelectedIndex = -1;
            dateOfBirth.Value = DateTime.Today;



            txtBirthCertificatNo.Clear();
            txtPassportNo.Clear();
            txtNationalId.Clear();
           // txtPrimaryUserPart.Clear();
            txtLogInID.Clear();
            txtPassword.Clear();
            txtFormPassword.Clear();
            cmbCountryCode.SelectedIndex = -1;

            PresentAddress();
            ResetPermanantAddress2();
            listView1.Items.Clear();

            dbUserId = 0;


            senderEmailHostId = emailAddressFrom = senderEmailDomain = readyPassword = hostName = userName = smtpHost = "";
            emailHostId = nationalityId = departmentId = designationId = genderId = maritalStatusId = emailHostId1 = 0;
            countryCode =
                divisionIdPA =
                    divisionIdPer =
                        postofficeIdPre =
                            postofficeIdPer =
                                districtIdPA =
                                    districtIdPer = thanaIdPA = thanaIdPer = countryId = emailAddresTo = "";

        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFormPassword.Text))
            {
                MessageBox.Show("Please type your Mail Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFormPassword.Visible = true;
                label43.Visible = true;
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmployeeId.Text))
            {
                MessageBox.Show("Please enter employee Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter full  Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFatherName.Text))
            {
                MessageBox.Show("Please enter father Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMotherName.Text))
            {
                MessageBox.Show("Please enter mother Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (string.IsNullOrWhiteSpace(txtPrimaryUserPart.Text))
            //{
            //    MessageBox.Show("Please enter user part of primary email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (string.IsNullOrWhiteSpace(cmbPrimaryDomain.Text))
            //{
            //    MessageBox.Show("Please select domain of primary email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (!string.IsNullOrWhiteSpace(txtSecondaryEmailUser.Text) && string.IsNullOrWhiteSpace(cmbSecondaryDomain.Text))
            //{
            //    MessageBox.Show("You  must select domain of secondary email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            if (string.IsNullOrWhiteSpace(cmbCountry.Text))
            {
                MessageBox.Show("Please select Country Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbGender.Text))
            {
                MessageBox.Show("Please select Gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbMaritalStatus.Text))
            {
                MessageBox.Show("Please select MaritalStatus", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLogInID.Text))
            {
                MessageBox.Show("Please enter User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please type user password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(PADivisionCombo.Text))
            {
                MessageBox.Show("Please select Present Address division", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(PADistrictCombo.Text))
            {
                MessageBox.Show("Please Select Present Address district", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(PAThanaCombo.Text))
            {
                MessageBox.Show("Please select Present Address Thana", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(PAPostOfficeCombo.Text))
            {
                MessageBox.Show("Please Select Present Address Post Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPrePostCode.Text))
            {
                MessageBox.Show("Please select Present Address Post Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbCountry.Text != "Bangladesh")
            {
                if (string.IsNullOrWhiteSpace(txtStreetName.Text))
                {
                    MessageBox.Show("Please enter Street Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtState.Text))
                {
                    MessageBox.Show("Please enter state Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPostalCode.Text))
                {
                    MessageBox.Show("Please enter Postal Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {

                if (SameAsPACheckBox.Checked == false)
                {
                    if (string.IsNullOrWhiteSpace(PerADivisionCombo.Text))
                    {
                        MessageBox.Show("Please select Permanant Address division", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(PerADistrictCombo.Text))
                    {
                        MessageBox.Show("Please Select Permanant Address district", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(PerAThanaCombo.Text))
                    {
                        MessageBox.Show("Please select Permanant Address Thana", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(PerAPostOfficeCombo.Text))
                    {
                        MessageBox.Show("Please Select Permanant Address Post Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txtPerPostCode.Text))
                    {
                        MessageBox.Show("Please select Permanant Address Post Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Please add Contact No to Chart,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct3 = "select Users.FullName from Users where  Users.FullName='" + txtFullName.Text + "'";
                cmd = new SqlCommand(ct3, con);
                rdr = cmd.ExecuteReader();
                if (rdr.Read() && !rdr.IsDBNull(0))
                {
                    dbUserFullName = (rdr.GetString(0));
                    con.Close();


                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ct4 = "select Users.UserId from Users where  Users.FullName='" + dbUserFullName + "'";
                    cmd = new SqlCommand(ct4, con);
                    rdr1 = cmd.ExecuteReader();
                    if (rdr1.Read())
                    {
                        dbUserId = (rdr1.GetInt32(0));
                    }
                    con.Close();
                    //con = new SqlConnection(cs.DBConn);
                    //con.Open();
                    //string ct5 = "SELECT  (UserEmail.UserPart+'@'+EmailHostBank.EmailHostName) as EmailAddress FROM  Users INNER JOIN  UserEmail ON Users.UserId = UserEmail.UserId INNER JOIN  EmailHostBank ON UserEmail.EmailHostId = EmailHostBank.EmailHostId where  Users.FullName='" + dbUserFullName + "' and UserEmail.IsPrimaryKey='true'";
                    //cmd = new SqlCommand(ct5, con);
                    //rdr2 = cmd.ExecuteReader();
                    //if (rdr2.Read())
                    //{
                    //    dbEmailAddress = (rdr2.GetString(0));
                    //    currentEmailAddress = txtPrimaryUserPart.Text + '@' + cmbPrimaryDomain.Text;
                    //}
                    //con.Close();
                    //if (currentEmailAddress == dbEmailAddress)
                    //{
                    //    MessageBox.Show("This User Already Exists,Please Input another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}
                }
                else
                {
                    string clearText = txtPassword.Text;
                    string password = clearText;
                    byte[] bytes = Encoding.Unicode.GetBytes(password);
                    byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
                    string readyPassword1 = Convert.ToBase64String(inArray);
                    readyPassword = readyPassword1;
                    if (cmbCountry.Text != "Bangladesh")
                    {
                        SaveUserInformation();
                        SavePresentAddress();
                        SaveOverSeasAddress();
                        SaveContactNo();
                    }
                    else
                    {
                        if (SameAsPACheckBox.Checked == true)
                        {
                            SaveUserInformation();
                            SavePresentAddress();
                            PermanantSameAsPreentAddress();
                            SaveContactNo();
                            MessageBox.Show("Successfully Saved", "record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Reset();
                            groupBox3.Visible = true;
                            groupBox4.Visible = true;
                            groupBox5.Enabled = true;
                            label43.Visible = false;
                            txtFormPassword.Visible = false;
                            GetMaxUserId();
                        }
                        else
                        {
                            SaveUserInformation();
                            SavePresentAddress();
                            SavePermanantAddress();
                            SaveContactNo();
                            MessageBox.Show("Successfully Saved", "record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Reset();
                            groupBox3.Visible = true;
                            groupBox4.Visible = true;
                            groupBox5.Enabled = true;
                            label43.Visible = false;
                            txtFormPassword.Visible = false;
                            GetMaxUserId();
                        }
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }


        private void MaritalStatusLoad()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ctt = "select MaritalStatus from MaritalStatuss";
                cmd = new SqlCommand(ctt);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmbMaritalStatus.Items.Add(rdr.GetValue(0).ToString());
                }
                cmbMaritalStatus.Items.Add("Not In The List");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DesignationLoad()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ctt = "select Designation from Designations";
                cmd = new SqlCommand(ctt);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmbDesignation.Items.Add(rdr.GetValue(0).ToString());
                }
                cmbDesignation.Items.Add("Not In The List");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetSenderEMailAddress()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select RTRIM(UserEmail.EmailHostId),RTRIM(UserEmail.UserPart) from UserEmail  Where UserEmail.UserId = '" + nUserId + "' and  UserEmail.IsPrimaryKey='true'";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    senderEmailHostId = (rdr.GetString(0));
                    userName = (rdr.GetString(1));
                }
                con.Close();
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct3 = "select RTRIM(EmailHostBank.EmailHostName),RTRIM(EmailHostBank.SmtpHostName) from EmailHostBank  Where EmailHostBank.EmailHostId = '" + senderEmailHostId + "'";
                cmd = new SqlCommand(ct3);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    senderEmailDomain = (rdr.GetString(0));
                    hostName = (rdr.GetString(1));
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewMailMessage()
        {
            try
            {
                GetSenderEMailAddress();
                emailAddressFrom = userName + "@" + senderEmailDomain;
                //emailAddresTo = "hr@keal.com.bd";
                emailAddresTo = "iqbal.h@keal.com.bd";
                smtpHost = "smtp." + hostName + ".com";
                string body = "Your LogIn Id is:'" + txtLogInID.Text + "' and  Password is:'" + txtPassword.Text + "'.Thank you.";
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(emailAddressFrom, "Kyoto Engineering & Automation Ltd");
                //msg.From = new MailAddress("iqbalbdrocky@gmail.com");
                msg.To.Add(new MailAddress(emailAddresTo));
                msg.Subject = "User Id & Password";
                msg.Body = body;
                msg.IsBodyHtml = true;
                if ((body.Length) > 0)
                {
                    if (System.IO.File.Exists(body))
                    {
                        msg.Attachments.Add(new Attachment(body));
                    }
                    SmtpClient smtp = new SmtpClient();

                    smtp.Host = smtpHost;
                    smtp.Credentials = new NetworkCredential(emailAddressFrom, txtFormPassword.Text);
                    //smtp.Credentials = new NetworkCredential("iqbalbdrocky@gmail.com", txtFormPassword.Text);
                    smtp.EnableSsl = true;
                    smtp.Send(msg);

                }
                MessageBox.Show("Successfully Mail Send", "record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch
            {
                MessageBox.Show("Invalid EmailAddress or Password.Please check your EmailAddress & Password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void LoadCountryCode()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ctt = "select CountryCode from Countries";
                cmd = new SqlCommand(ctt);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmbCountryCode.Items.Add(rdr.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CountryLoad()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ctt = "select CountryName from Countries";
                cmd = new SqlCommand(ctt);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmbCountry.Items.Add(rdr.GetValue(0).ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FillPermanantDivisionCombo()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select RTRIM(Divisions.Division) from Divisions  order by Divisions.Division_ID desc ";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    PerADivisionCombo.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FillPresentDivisionCombo()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select RTRIM(Divisions.Division) from Divisions  order by Divisions.Division_ID desc";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    PADivisionCombo.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsercreationUi_Load(object sender, EventArgs e)
        {
            txtFormPassword.Visible = false;
            label43.Visible = false;
            GetMaxUserId();
            groupBox4.Visible = false;
            FillPresentDivisionCombo();
            FillPermanantDivisionCombo();
            nUserId = Loginuiaums.uId.ToString();
            LoadCountryCode();
            CountryLoad();
           // HostEmailAddress2();
           // HostEmailAddress();

            DesignationLoad();
            MaritalStatusLoad();
            GetGender();
            getcat();
        }

        private void getcat()
        {
            con = new SqlConnection(cs.DBConn);
            con.Open();
            string getc = "select UsercatId, Usercatname from UserCategory where UsercatId = 1 ";
            cmd = new SqlCommand(getc, con);
            rdr = cmd.ExecuteReader();
            if (rdr.Read() == true)
            {
                catid = rdr.GetInt32(0);
                catname = rdr.GetString(1);
                catidtxtbox.Text = catid.ToString();
                catnametxtbox.Text = catname;
            }
            con.Close();


        }

        //private void HostEmailAddress2()
        //{
        //    try
        //    {
        //        con = new SqlConnection(cs.DBConn);
        //        con.Open();
        //        string ctt = "select EmailHostName from EmailHostBank";
        //        cmd = new SqlCommand(ctt);
        //        cmd.Connection = con;
        //        rdr = cmd.ExecuteReader();
        //        while (rdr.Read())
        //        {
        //            cmbSecondaryDomain.Items.Add(rdr.GetValue(0).ToString());
        //        }
        //        // cmbSecondaryDomain.Items.Add("Not In the list");
        //        cmbSecondaryDomain.Items.Add("Not In The List");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //private void HostEmailAddress()
        //{
        //    try
        //    {
        //        con = new SqlConnection(cs.DBConn);
        //        con.Open();
        //        string ctt = "select EmailHostName from EmailHostBank";
        //        cmd = new SqlCommand(ctt);
        //        cmd.Connection = con;
        //        rdr = cmd.ExecuteReader();
        //        while (rdr.Read())
        //        {
        //            cmbPrimaryDomain.Items.Add(rdr.GetValue(0).ToString());
        //        }
        //        cmbPrimaryDomain.Items.Add("Not In The List");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void GetGender()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ctt = "select GenderName from Gender";
                cmd = new SqlCommand(ctt);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmbGender.Items.Add(rdr.GetValue(0).ToString());
                }
                //  cmbGender.Items.Add("Not In The List");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
