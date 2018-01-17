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
    public partial class Medicine : Form
    {   
        private OleDbConnection medicine_connection = new OleDbConnection();
 
        public Medicine()
        {
            InitializeComponent();
            medicine_connection.ConnectionString =@" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=K:\Mega\WindowsFormsApplication1\Database3.accdb;
            Persist Security Info=False;";

        }

        private void Medicine_Load(object sender, EventArgs e)
        {
           
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                medicine_connection.Open();
                OleDbCommand medicine_command = new OleDbCommand();
                medicine_command.Connection = medicine_connection;
                medicine_command.CommandText = "insert into medicine (Name,price,Pieces) values('" + textBox5.Text + "','" + textBox4.Text + "','" + textBox3.Text + "')";
                medicine_command.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
                medicine_connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
                try
            {
                medicine_connection.Open();
                OleDbCommand medicine_command = new OleDbCommand();
                medicine_command.Connection = medicine_connection;
                string query = "update medicine set Name='" + textBox5.Text + "' ,Price = '" + textBox4.Text + "' ,Pieces = '" + textBox3.Text + "'where ID =" + textBox2.Text + "";
                MessageBox.Show(query);
                medicine_command.CommandText = query;
                medicine_command.ExecuteNonQuery();
                MessageBox.Show("Data Edit Successfuly");
                medicine_connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                medicine_connection.Open();
                OleDbCommand medicine_command = new OleDbCommand();
                medicine_command.Connection = medicine_connection;
                string query = "delete from medicine where ID = " + textBox2.Text + "";
               // MessageBox.Show(query);
                medicine_command.CommandText = query;
                medicine_command.ExecuteNonQuery();
                MessageBox.Show("Data Deleted");
                medicine_connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
