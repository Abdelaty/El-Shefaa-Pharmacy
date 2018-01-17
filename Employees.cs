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
    public partial class Employees : Form
    {
        private OleDbConnection employees_connection = new OleDbConnection();
        public Employees()
        {
            InitializeComponent();
            employees_connection.ConnectionString = @" Provider=Microsoft.ACE.OLEDB.12.0;Data Source=K:\Mega\WindowsFormsApplication1\Database3.accdb;
            Persist Security Info=False;";
        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                employees_connection.Open();
                OleDbCommand employees_command = new OleDbCommand();
                employees_command.Connection = employees_connection;
                employees_command.CommandText = "insert into employees (FirstName,LastName,Email,Job,NationalID,Salary,Adresse,Sheft,PhoneNumber,MobileNumber) values('" + textBox5.Text + "','" + textBox4.Text + "','" + textBox8.Text + "','" + Job_Box.Text + "','" + textBox7.Text + "','" + textBox2.Text + "','" + textBox1.Text + "','" + Shift_Box.Text + "','" + textBox6.Text + "','" + textBox9.Text + "')";
                employees_command.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
                employees_connection.Close();
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
                employees_connection.Open();
                OleDbCommand employees_command = new OleDbCommand();
                employees_command.Connection = employees_connection;
                string query = "update employees set FirstName='" + textBox5.Text + "' ,LastName = '" + textBox4.Text + "' ,Email = '" + textBox8.Text + "' ,Job = '" + Job_Box.Text + "' ,NationalID = '" + textBox7.Text + "' ,Salary = '" + textBox2.Text + "' ,Adresse = '" + textBox1.Text + "' ,Sheft = '" + Shift_Box.Text + "' ,PhoneNumber = '" + textBox6.Text + "' ,MobileNumber = '" + textBox9.Text + "'where ID =" + textBox3.Text + "";
                MessageBox.Show(query);
                employees_command.CommandText = query;
                employees_command.ExecuteNonQuery();
                MessageBox.Show("Data Edit Successfuly");
                employees_connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            try
            {
                employees_connection.Open();
                OleDbCommand employees_command = new OleDbCommand();
                employees_command.Connection = employees_connection;
                string query = "delete from employees where ID = " + textBox3.Text + "";
                // MessageBox.Show(query);
                employees_command.CommandText = query;
                employees_command.ExecuteNonQuery();
                MessageBox.Show("Data Deleted");
                employees_connection.Close();
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
                employees_connection.Open();
                OleDbCommand employees_command = new OleDbCommand();
                employees_command.Connection = employees_connection;
                string query = "select * from employees";
                employees_command.CommandText = query;
                OleDbDataAdapter med = new OleDbDataAdapter(employees_command);
                DataTable dt = new DataTable();
                med.Fill(dt);
                dataGridView1.DataSource = dt;
                employees_connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
