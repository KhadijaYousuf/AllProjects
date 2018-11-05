using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CONSTRUCTION_COMPANY_MANAGEMENT_SYSTEM
{
    public partial class Form1 : Form
    {
        SqlConnection CONSTRUCTION = new SqlConnection("Data Source=ACER-PC\\SQLEXPRESS;Initial Catalog=SUPERMARKET;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public string CON = "Data Source=ACER-PC\\SQLEXPRESS;Initial Catalog=SUPERMARKET;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            CONSTRUCTION.Open();
            SqlCommand cmd = CONSTRUCTION.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into EMPLOYEES values('"+textBox1.Text+"')";
            CONSTRUCTION.Close();
            textBox1.Text = "";
            DISPLAY(); //DISPLAY FUNCTION CALLED
            MessageBox.Show("DATA INSERTED SUCCESSFULLY");
        }

        //A FUNCTION TO DISPLAY DATA FROM DATABASE
        public void DISPLAY()
        {
            CONSTRUCTION.Open();
            SqlCommand cmd = CONSTRUCTION.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select from EMPLOYEES";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);
            CONSTRUCTION.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DISPLAY();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CONSTRUCTION.Open();
            SqlCommand cmd = CONSTRUCTION.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from EMPLOYEES where name='" + textBox1.Text + "'";
            CONSTRUCTION.Close();
            DISPLAY(); //DISPLAY FUNCTION CALLED
            MessageBox.Show("DATA DELETED SUCCESSFULLY");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CONSTRUCTION.Open();
            SqlCommand cmd = CONSTRUCTION.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update EMPLOYEES set name='" + textBox2.Text+"' where name ='" + textBox1.Text + "')";
            CONSTRUCTION.Close();
            DISPLAY(); //DISPLAY FUNCTION CALLED
            MessageBox.Show("DATA UPDATED SUCCESSFULLY");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DISPLAY(); //DISPLAY FUNCTION CALLED
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CONSTRUCTION.Open();
            SqlCommand cmd = CONSTRUCTION.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select from EMPLOYEES where name='" + textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DA.Fill(DT);
            CONSTRUCTION.Close();
        }
    }
}
