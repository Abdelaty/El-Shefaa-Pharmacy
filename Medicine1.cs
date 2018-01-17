using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsFormsApplication1
{
    public partial class Medicine1 : Form
    {   private OleDbConnection medicine_connection = new OleDbConnection();
        public Medicine1()
        {   medicine_connection.ConnectionString =@" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=K:\Mega\WindowsFormsApplication1\Database3.accdb;
            Persist Security Info=False;";
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
             private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
             try
            {
                medicine_connection.Open();
                OleDbCommand medicine_command = new OleDbCommand();
                medicine_command.Connection = medicine_connection;
                string query = "select * from medicine";
                medicine_command.CommandText = query;
                OleDbDataAdapter med = new OleDbDataAdapter(medicine_command);
                DataTable dt = new DataTable();
                med.Fill(dt);
                dataGridView1.DataSource = dt;
                medicine_connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
