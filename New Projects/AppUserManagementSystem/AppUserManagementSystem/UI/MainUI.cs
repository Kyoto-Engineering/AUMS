using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppUserManagementSystem.Ui;
using AppUserManagementSystem.UI;

namespace AppUserManagementSystem
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserStatusUI ss = new UserStatusUI();
            this.Visible = false;
            ss.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsercreationUi uui = new UsercreationUi();
            this.Visible = false;
           uui.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserDetailsGrid udg = new UserDetailsGrid();
            this.Visible = false;
            udg.ShowDialog();
           this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserImageUpdateUI uiuui = new UserImageUpdateUI();
            this.Visible = false;
            uiuui.ShowDialog();
            this.Visible = true;
        }
    }
}
