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
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Regstired");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            loginasadmin f0 = new loginasadmin();
            f0.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            orders fo = new orders();
            fo.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        
        }

        private void fontDialog2_Apply(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Contact f3 = new Contact();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Interface f4 = new Interface();
            Medicine1 F3 = new Medicine1();
            F3.Show();
            f4.Close();
           
            
        }
    }
}
