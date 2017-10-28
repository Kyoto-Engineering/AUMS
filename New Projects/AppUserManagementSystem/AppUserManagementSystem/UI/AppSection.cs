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
    public partial class AppSection : Form
    {
        public AppSection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppCreationConsole acc = new AppCreationConsole();
            this.Visible = false;
            acc.ShowDialog();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ApplicationAssign aas = new ApplicationAssign();
            this.Visible = false;
            aas.ShowDialog();
            this.Visible = true;

        }
    }
}
