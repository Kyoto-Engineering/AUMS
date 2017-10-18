using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppUserManagementSystem.Reports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Microsoft.Reporting.WinForms;

namespace AppUserManagementSystem.UI
{
    public partial class UserProfile : Form
    {
        public int x;
        public UserProfile()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            GetUserProfile gup = new GetUserProfile();
            gup.ShowDialog();
            this.Visible = true;

        }
    }
}




