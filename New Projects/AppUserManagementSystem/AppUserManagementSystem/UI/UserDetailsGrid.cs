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
    public partial class UserDetailsGrid : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        private SqlDataAdapter sda;
        public string g, a, a1, b, b1, c, c1, d, d1, x, x1, y, y1;
        public string userId;
        public UserDetailsGrid()
        {
            InitializeComponent();
        }

        private void GetListOfUser1()
        {
            con = new SqlConnection(cs.DBConn);
            con.Open();
            sda = new SqlDataAdapter("SELECT FU.UserId, FU.FullName, FU.NickName, FU.FatherName, FU.MotherName,FU.EmailAddress, FU.CountryName, FU.Designation,FU.NationalId,FU.BirthCertificateNumber, FU.PassportNumber,FU.GenderName, FU.MaritalStatus, FU.ParFlatNo As ParFlatNo,FU.ParHouseNo As ParHouseNo, FU.ParRoadNo As ParRoadNo, FU.ParBlock as ParBlock, FU.ParArea As ParArea,FU.ParLandMark as  ParLandMark,FU.ParRoadName As ParRoadName, FU.ParBuilding As ParBuilding,FU.ParDivision as ParDivision,FU.ParDistrict,FU.ParThana,FU.ParPostOfficeName,FU.ParPostCode, Q2.PreFlatNo as PreFlatNo,Q2.PreHouseNo As PreHouseNo,Q2.PreRoadNo As PreRoadNo,Q2.PreBlock As PreBlock,Q2.PreArea As PreArea,Q2.PreLandMark As PreLandmark,Q2.PreRoadName As PreRoadName,Q2.PrBuilding As PreBuilding,Q2.Division As PreDivision,Q2.District PreDistrict,Q2.Thana PreThana,Q2.PostOfficeName PrePostOfficeName,Q2.PostCode PrePostCode  from (SELECT f1.UserId, f1.FullName, f1.NickName, f1.FatherName, f1.MotherName,(UserEmail.UserPart+'@'+EmailHostBank.EmailHostName) As EmailAddress,Countries.CountryName, Designations.Designation,f1.NationalId,f1.BirthCertificateNumber, f1.PassportNumber,  Gender.GenderName, MaritalStatuss.MaritalStatus,ParmanentAddresses.PaFlatNo As ParFlatNo,ParmanentAddresses.PaHouseNo As ParHouseNo,ParmanentAddresses.PaRoadNo As ParRoadNo,ParmanentAddresses.PaBlock as ParBlock,ParmanentAddresses.PaArea As ParArea,ParmanentAddresses.PaLandMark as  ParLandMark,ParmanentAddresses.PaRoadName As ParRoadName,ParmanentAddresses.PaBuilding As ParBuilding,Divisions.Division As ParDivision,Districts.District as ParDistrict,Thanas.Thana As ParThana,PostOffice.PostOfficeName as ParPostOfficeName,PostOffice.PostCode as ParPostCode FROM  Users f1 Left JOIN  UserEmail ON f1.UserId = UserEmail.UserId  Left JOIN EmailHostBank ON UserEmail.EmailHostId = EmailHostBank.EmailHostId Left JOIN Countries ON f1.CountryId = Countries.CountryId   Left JOIN Designations ON f1.DesignationId = Designations.DesignationId  Left JOIN Gender ON f1.GenderId = Gender.GenderId  Left JOIN MaritalStatuss ON f1.MaritalStatusId = MaritalStatuss.MaritalStatusId  Left JOIN ParmanentAddresses ON f1.UserId = ParmanentAddresses.UserId Left JOIN PostOffice ON ParmanentAddresses.PostOfficeId = PostOffice.PostOfficeId   Left JOIN Thanas ON PostOffice.T_ID = Thanas.T_ID  Left JOIN  Districts ON Thanas.D_ID = Districts.D_ID  Left JOIN Divisions ON Districts.Division_ID = Divisions.Division_ID  Left JOIN  PresentAddresses ON f1.UserId = PresentAddresses.UserId where UserEmail.IsPrimaryKey = 'true') AS FU  LEFT jOIN (SELECT   Users.UserId,PresentAddresses.PrFlatNo As PreFlatNo, PresentAddresses.PrHouseNo As PreHouseNo,PresentAddresses.PrRoadNo As PreRoadNo, PresentAddresses.PrBlock As PreBlock,PresentAddresses.PrArea As PreArea,PresentAddresses.PrLandMark As PreLandMark, PresentAddresses.PrRoadName As PreRoadName,PresentAddresses.PrBuilding,Divisions.Division, Districts.District, Thanas.Thana, PostOffice.PostOfficeName,PostOffice.PostCode  FROM  Users Left JOIN PresentAddresses ON Users.UserId = PresentAddresses.UserId  Left JOIN  PostOffice ON PresentAddresses.PostOfficeId = PostOffice.PostOfficeId  Left JOIN Thanas ON PostOffice.T_ID = Thanas.T_ID   Left JOIN  Districts ON Thanas.D_ID = Districts.D_ID  Left JOIN  Divisions ON Districts.Division_ID = Divisions.Division_ID) aS Q2 ON FU.UserId =  Q2.UserId", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].Width = 140;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 120;
            dataGridView1.Columns[6].Width = 120;
            dataGridView1.Columns[7].Width = 180;
            dataGridView1.Columns[8].Width = 100;
            dataGridView1.Columns[9].Width = 140;
            dataGridView1.Columns[10].Width = 140;
            dataGridView1.Columns[11].Width = 120;
            dataGridView1.Columns[12].Width = 120;
            dataGridView1.Columns[13].Width = 120;
            dataGridView1.Columns[14].Width = 120;
            dataGridView1.Columns[15].Width = 180;
            dataGridView1.Columns[16].Width = 100;
            dataGridView1.Columns[17].Width = 140;
            dataGridView1.Columns[18].Width = 140;
            dataGridView1.Columns[19].Width = 120;
            dataGridView1.Columns[20].Width = 120;
            dataGridView1.Columns[21].Width = 120;
            dataGridView1.Columns[22].Width = 120;
            dataGridView1.Columns[23].Width = 180;
            dataGridView1.Columns[24].Width = 120;
            dataGridView1.Columns[25].Width = 120;
            dataGridView1.Columns[26].Width = 120;
            dataGridView1.Columns[27].Width = 120;
            dataGridView1.Columns[28].Width = 180;
            dataGridView1.Columns[29].Width = 100;
            dataGridView1.Columns[30].Width = 140;
            dataGridView1.Columns[31].Width = 140;
            dataGridView1.Columns[32].Width = 120;
            dataGridView1.Columns[33].Width = 120;
            dataGridView1.Columns[34].Width = 120;
            dataGridView1.Columns[35].Width = 120;
            dataGridView1.Columns[36].Width = 180;
            dataGridView1.Columns[37].Width = 100;
            dataGridView1.Columns[38].Width = 140;

            con.Close();
            //dataGridView1.Columns[7].DefaultCellStyle.NullValue = null;
            //for (int i = 0; i < dataGridView1.Columns.Count; i++)
            //    if (dataGridView1.Columns[i] is DataGridViewImageColumn)
            //    {
            //        ((DataGridViewImageColumn)dataGridView1.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;

            //    }            

        }

        private void UserDetailsGrid_Load(object sender, EventArgs e)
        {
            GetListOfUser1();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string k, h;
                DataGridViewRow dr = dataGridView1.CurrentRow;
                this.Visible = false;
                UpdateUI frm = new UpdateUI();
               // frm.ShowDialog();
               // this.Visible = true;
                frm.gUserId = Convert.ToInt32(dr.Cells[0].Value.ToString());
                frm.txtFullName.Text = dr.Cells[1].Value.ToString();
                frm.txtNickName.Text = dr.Cells[2].Value.ToString();
                frm.txtFatherName.Text = dr.Cells[3].Value.ToString();
                frm.txtMotherName.Text = dr.Cells[4].Value.ToString();
                frm.cmbPrimaryEmail.Text = dr.Cells[5].Value.ToString();
                k = frm.cmbCountry.Text = dr.Cells[6].Value.ToString();
                frm.cmbDesignation.Text = dr.Cells[7].Value.ToString();
                frm.txtNationalId.Text = dr.Cells[8].Value.ToString();
                frm.txtPassportNo.Text = dr.Cells[9].Value.ToString();
                frm.txtBirthCertificatNo.Text = dr.Cells[10].Value.ToString();
                frm.cmbGender.Text = dr.Cells[11].Value.ToString();
                frm.cmbMaritalStatus.Text = dr.Cells[12].Value.ToString();
                // frm.dateOfBirth.Text = dr.Cells[12].Value.ToString();
                a = frm.txtPreFlatNo.Text = dr.Cells[13].Value.ToString();
                b = frm.txtPreHouseNo.Text = dr.Cells[14].Value.ToString();
                c = frm.txtPreRoadNo.Text = dr.Cells[15].Value.ToString();
                d = frm.txtPreBlock.Text = dr.Cells[16].Value.ToString();
                x = frm.txtPreArea.Text = dr.Cells[17].Value.ToString();
                frm.txtPreLandMark.Text = dr.Cells[18].Value.ToString();
                frm.txtPreRoadName.Text = dr.Cells[19].Value.ToString();
                frm.txtPreBuildingName.Text = dr.Cells[20].Value.ToString();
                frm.PADivisionCombo.Text = dr.Cells[21].Value.ToString();
                frm.PADistrictCombo.Text = dr.Cells[22].Value.ToString();
                frm.PAThanaCombo.Text = dr.Cells[23].Value.ToString();
                frm.PAPostOfficeCombo.Text = dr.Cells[24].Value.ToString();
                y = frm.PAPostCodeText.Text = dr.Cells[25].Value.ToString();

                a1 = frm.txtPerFlatNo.Text = dr.Cells[26].Value.ToString();
                b1 = frm.txtPerHouseNo.Text = dr.Cells[27].Value.ToString();
                c1 = frm.txtPerRoadNo.Text = dr.Cells[28].Value.ToString();
                d1 = frm.txtPerBlock.Text = dr.Cells[29].Value.ToString();
                x1 = frm.txtPerArea.Text = dr.Cells[30].Value.ToString();
                frm.txtPerLandMark.Text = dr.Cells[31].Value.ToString();
                frm.txtPerRoadName.Text = dr.Cells[32].Value.ToString();
                frm.txtPerBuilding.Text = dr.Cells[33].Value.ToString();

                frm.PerADivisionCombo.Text = dr.Cells[34].Value.ToString();
                frm.PerADistrictCombo.Text = dr.Cells[35].Value.ToString();
                frm.PerAThanaCombo.Text = dr.Cells[36].Value.ToString();
                frm.PerAPostOfficeCombo.Text = dr.Cells[37].Value.ToString();
                y1 = frm.PerApostCodeText.Text = dr.Cells[38].Value.ToString();
                if (a == a1 && b == b1 && c == c1 && d == d1 && x == x1 && y == y1)
                {
                    frm.SameAsPACheckBox.Checked = true;
                }
                else
                {
                    frm.SameAsPACheckBox.Checked = false;
                }

                frm.hk = g;
                if (k == "Bangladesh")
                {
                    frm.groupBox4.Visible = false;
                }
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserDetailsGrid_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MainUI mui = new MainUI();
            //this.Visible = false;
            //mui.ShowDialog();
            //this.Visible = true;
        }







    }
}
