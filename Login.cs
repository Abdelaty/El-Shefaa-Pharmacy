using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;                    //new line

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
          /*  OleDbConnection con1 = new OleDbConnection();                                                   //new line 
            con1.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kareem Mohammedmagdi\Desktop\Database3.accdb;";             //new line
            con1.Open();              ///new
            OleDbCommand com = new OleDbCommand();    //new
            com.Connection = con1; //new
            com.CommandText = "Select * from Login where Username = ' + textBox1 + ' and Password = ' + textBox2 '" ; // new line 
            OleDbDataReader rea = com.ExecuteReader();  //newline
            int count = 0;  //new line
            while (rea.Read())         //new line
            {
                count++;
            }
            if (count ==1)
            {
                MessageBox.Show("User name and password match"); //new line
            
            }
            con1.Close();//new*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          string admin = "kareem";
            string password = "admin";
            if ((textBox1.Text == admin) && (textBox2.Text == password))
                 {
                    MessageBox.Show("Login Success\n Hello Kareem");   
                    Interface   F3 = new Interface();
                    F3.Show();
                    Visible = false;
                 }
            else
                MessageBox.Show("Username or password are wrong,try again");
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
