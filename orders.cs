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
    public partial class orders : Form
    {
        private OleDbConnection medicine_connection = new OleDbConnection();
        public orders()
        {
            medicine_connection.ConnectionString = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=K:\Mega\WindowsFormsApplication1\Database3.accdb;
            Persist Security Info=False;";
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                medicine_connection.Open();
                OleDbCommand medicine_command = new OleDbCommand();
                medicine_command.Connection = medicine_connection;
                string query = "select * from orders";
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

        private void button2_Click(object sender, EventArgs e)
        {
              try
            {
                medicine_connection.Open();
                OleDbCommand medicine_command = new OleDbCommand();
                medicine_command.Connection = medicine_connection;
                medicine_command.CommandText = "insert into orders (Medicine,Statue,DeliverboyName,PatientName,Adresse,PatientPhone) values('" + textBox6.Text + "','" + checkBox1.Text+ "','" + textBox1.Text +"','" + textBox5.Text +"','" + textBox2.Text +"','" + textBox4.Text + "')";
                medicine_command.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
                medicine_connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
                  try
            {
                medicine_connection.Open();
                OleDbCommand medicine_command = new OleDbCommand();
                medicine_command.Connection = medicine_connection;
                string query = "update orders set Medicine='" + textBox6.Text + "' ,Statue = '" + checkBox1.Text + "' ,DeliverboyName = '" + textBox1.Text + "' ,PatientName = '" + textBox5.Text + "' ,Adresse = '" + textBox2.Text + "' ,PatientPhone = '" + textBox4.Text + "'where ID =" + textBox7.Text + "";
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                medicine_connection.Open();
                OleDbCommand medicine_command = new OleDbCommand();
                medicine_command.Connection = medicine_connection;
                string query = "delete from orders where ID = " + textBox7.Text + "";
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

        private void orders_Load(object sender, EventArgs e)
        {

        }

        }
    }

