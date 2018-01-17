using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class loginasadmin : Form
    {
        public loginasadmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loginscreen logscr = new Loginscreen();
            logscr.Show();
            Visible = false;

        }

        private void loginasadmin_Load(object sender, EventArgs e)
        {

        }
    }
}
