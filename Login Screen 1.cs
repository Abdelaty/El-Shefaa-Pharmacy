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
    public partial class Loginscreen : Form
    {
        
        public Loginscreen()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Suppliers F5 = new Suppliers();
            F5.Show();
            Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Employees F4 = new Employees();
           F4.Show();
           Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            Medicine F6= new Medicine();
            F6.Show();
            Visible = false;

        }

        private void Loginscreen_Load(object sender, EventArgs e)
        {

        }
    }
}
