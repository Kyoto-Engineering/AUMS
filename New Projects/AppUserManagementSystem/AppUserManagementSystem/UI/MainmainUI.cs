using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppUserManagementSystem.UI
{
    public partial class MainmainUI : Form
    {
        public MainmainUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainUI mu = new MainUI();
            this.Visible = false;
            mu.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NonPCusers np = new NonPCusers();
            this.Visible = false;
            np.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserProfile uf = new UserProfile();
            this.Visible = false;
            uf.ShowDialog();
            this.Visible = false;
        }
    }
}
