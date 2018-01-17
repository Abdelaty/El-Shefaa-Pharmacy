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
    public partial class Suppliers : Form
    {
        private OleDbConnection suppliers_connection = new OleDbConnection();
        public Suppliers()
        {
            suppliers_connection.ConnectionString = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=K:\Mega\WindowsFormsApplication1\Database3.accdb;
            Persist Security Info=False;";
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                suppliers_connection.Open();
                OleDbCommand suppliers_command = new OleDbCommand();
                suppliers_command.Connection = suppliers_connection;
                suppliers_command.CommandText = "insert into suppliers (Name,PhoneNumber,Email,fax,Adresse,Website,Visittime) values('" + textBox6.Text + "','" + textBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + V_Box.Text + "')";
                suppliers_command.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
                suppliers_connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                suppliers_connection.Open();
                OleDbCommand suppliers_command = new OleDbCommand();
                suppliers_command.Connection = suppliers_connection;
                string query = "update suppliers set Name='" + textBox6.Text + "' ,PhoneNumber = '" + textBox1.Text + "' ,Email = '" + textBox4.Text + "' ,fax = '" + textBox5.Text + "' ,Adresse = '" + textBox3.Text + "' ,Website = '"  + textBox2.Text + "' ,Visittime = '" + V_Box.Text + "'where ID =" + textBox8.Text + "";
                MessageBox.Show(query);
                suppliers_command.CommandText = query;
                suppliers_command.ExecuteNonQuery();
                MessageBox.Show("Data Edit Successfuly");
                suppliers_connection.Close();
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
                suppliers_connection.Open();
                OleDbCommand suppliers_command = new OleDbCommand();
                suppliers_command.Connection = suppliers_connection;
                string query = "delete from suppliers where ID = " + textBox8.Text + "";
                suppliers_command.CommandText = query;
                suppliers_command.ExecuteNonQuery();
                MessageBox.Show("Data Deleted");
                suppliers_connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                suppliers_connection.Open();
                OleDbCommand suppliers_command = new OleDbCommand();
                suppliers_command.Connection = suppliers_connection;
                string query = "select * from suppliers";
                suppliers_command.CommandText = query;
                OleDbDataAdapter med = new OleDbDataAdapter(suppliers_command);
                DataTable dt = new DataTable();
                med.Fill(dt);
                dataGridView1.DataSource = dt;


                suppliers_connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
