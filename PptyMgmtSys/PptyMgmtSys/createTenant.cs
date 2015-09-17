using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PptyMgmtSys
{
    public partial class createTenant : Form
    {
        private string conn;
        private MySqlConnection connect;

        public createTenant()
        {
            InitializeComponent();
            
            
        }

        //Displays list of existing tenants
        private void createTenant_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sql689558DataSet.tenant' table. You can move, or remove it, as needed.
            this.tenantTableAdapter1.Fill(this.sql689558DataSet.tenant);
            dateTimePicker1.Value = new DateTime(1990, 01, 01);
            
            

        }
        //opens connection to online database
        private void db_connection()
        {
            try
            {
                
                conn = "Server=sql6.freesqldatabase.com;Database=sql689558;Uid=sql689558;Pwd=vA7*lR3%;";
                connect = new MySqlConnection(conn);
                connect.Open();
             
                
            }
            catch (MySqlException e)
            {
                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
            //label8.Text = dateTimePicker1.Value.Date.ToString("d");
            
            //label8.Text = String.Format("{0:yyyy-MM-dd}", dateTimePicker1.Value);
        }
        //Creates a record of a new tenant into online database
        private bool create_tenant(string fullName, string phoneNumber, string dateOfBirth, string doc, string contacts, string account, string bankBsb)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            
            cmd.CommandText = "INSERT INTO `sql689558`.`tenant` (`TenantID`, `TenantName`, `TenantPhone`, `TenantDOB`, `TenantDocument`, `TenantContact`, `TenantAccountNo`, `TenantBSB`) VALUES (NULL, '" + fullName + "','" + phoneNumber + "','" + dateOfBirth + "','" + doc + "','" + contacts + "','" + account + "','" + bankBsb + "');";
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }
        //Deletes selected row of tenant using tenantID(PK)
        private bool DeleteTenant(int cell)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "DELETE FROM `sql689558`.`tenant` WHERE tenantID= '" + cell + "');";
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }
        //Connects to online database and creates a new record of tenant, then refreshing list of tenants.
        private void create_Click(object sender, EventArgs e)
        {
            string fullName;
            string phoneNumber;
            string dateOfBirth;
            string doc;
            string contacts;
            string account;
            string bankBsb;
           

            fullName = name.Text;
            phoneNumber = phone.Text;
            dateOfBirth = String.Format("{0:yyyy-MM-dd}", dateTimePicker1.Value); 
            doc = document.Text;
            contacts = contact.Text;
            account = bankAccount.Text;
            bankBsb = bsb.Text;

            if (fullName == "" || phoneNumber == "" || dateOfBirth == "" || account == "" || bankBsb == "")
            {
                MessageBox.Show("Please fill in all mandatory fields!");
            }
            else
            {
                create_tenant(fullName, phoneNumber, dateOfBirth, doc, contacts, account, bankBsb);
                this.tenantTableAdapter1.Fill(this.sql689558DataSet.tenant);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            int cell = int.Parse(dataGridView1.Rows[1].Cells[0].Value.ToString());
            DeleteTenant(cell);
            
            
        }
        //Fills textboxes with data from cells from selected row.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataRow row = dataGridView1.SelectedRows;
            //label8.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            name.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            phone.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            document.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            contact.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            bankAccount.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            bsb.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
