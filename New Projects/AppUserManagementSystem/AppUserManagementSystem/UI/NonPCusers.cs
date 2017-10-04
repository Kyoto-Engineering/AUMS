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
    public partial class NonPCusers : Form
    {
        public NonPCusers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NonPcUsercreationUI bla = new NonPcUsercreationUI();
            this.Visible = false;
            bla.ShowDialog();
            this.Visible = true;
        }
    }
}
