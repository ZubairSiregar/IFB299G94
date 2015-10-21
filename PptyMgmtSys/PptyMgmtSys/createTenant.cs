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
            // TODO: This line of code loads data into the 'propertyManagementDBDataSet1.tenant' table. You can move, or remove it, as needed.
            this.tenantTableAdapter3.Fill(this.propertyManagementDBDataSet1.tenant);
            // TODO: This line of code loads data into the 'propertymanagementDataSet2.tenant' table. You can move, or remove it, as needed.
            //this.tenantTableAdapter2.Fill(this.propertymanagementDataSet2.tenant);
            // TODO: This line of code loads data into the 'sql689558DataSet.tenant' table. You can move, or remove it, as needed.
            //this.tenantTableAdapter1.Fill(this.sql689558DataSet.tenant);
            dateTimePicker1.Value = new DateTime(1990, 01, 01);
            
            

        }
        //opens connection to online database
        private void db_connection()
        {
            try
            {

                conn = "Server=team94.cczx3nnzcur7.us-west-2.rds.amazonaws.com;Database=propertyManagementDB;Uid=team94user;Pwd=592road$;";
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

            cmd.CommandText = "INSERT INTO `propertyManagementDB`.`tenant` (`TenantID`, `TenantName`, `TenantPhone`, `TenantDOB`, `TenantDocument`, `TenantContact`, `TenantAccountNo`, `TenantBSB`) VALUES (NULL, '" + fullName + "','" + phoneNumber + "','" + dateOfBirth + "','" + doc + "','" + contacts + "','" + account + "','" + bankBsb + "');";
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
            cmd.CommandText = "DELETE FROM tenant WHERE TenantID = '" + cell + "';";
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
                this.tenantTableAdapter3.Fill(this.propertyManagementDBDataSet1.tenant);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int i = dataGridView1.SelectedRows[0].Index;
            //int cell = int.Parse(dataGridView1.Rows[1].Cells[0].Value.ToString());
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            int i = Convert.ToInt32(selectedRow.Cells[0].Value);

            DeleteTenant(i);
            MessageBox.Show("Successfully Deleted!");
            this.tenantTableAdapter3.Fill(this.propertyManagementDBDataSet1.tenant);
            
            
        }
        //Fills textboxes with data from cells from selected row.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataRow row = dataGridView1.SelectedRows;
            
            int i = dataGridView1.SelectedCells[0].RowIndex;
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            name.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            phone.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            document.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            contact.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            bankAccount.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            bsb.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            label8.Text = Convert.ToString(selectedRow.Cells[0].Value);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
