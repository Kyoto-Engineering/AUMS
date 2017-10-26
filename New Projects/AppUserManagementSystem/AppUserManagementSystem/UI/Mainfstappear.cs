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
    public partial class Mainfstappear : Form
    {
        public Mainfstappear()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainmainUI ffm = new MainmainUI();
            ffm.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AppSection aps = new AppSection();
            aps.ShowDialog();
            this.Visible = true;
        }
    }
}
