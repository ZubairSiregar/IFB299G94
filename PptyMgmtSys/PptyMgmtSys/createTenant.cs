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

        private void createTenant_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sql689558DataSet.tenant' table. You can move, or remove it, as needed.
            this.tenantTableAdapter1.Fill(this.sql689558DataSet.tenant);
            

        }

        private void db_connection()
        {
            try
            {
                //conn = "Server=localhost;Database=propertymanagement;Uid=root;Pwd=pass;";
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
            label8.Text = String.Format("{0:yyyy-MM-dd}", dateTimePicker1.Value);
        }

        private bool create_tenant(string fullName, string phoneNumber, string dateOfBirth, string doc, string contacts, string account, string bankBsb)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            //string insertString = fullName + "', " + phoneNumber + "', 1980/2/1, '" + doc + "', " + contacts + "', " + account + "', " + bankBsb + "'";
            //cmd.CommandText = "insert into propertymanagement.tenant(TenantID, TenantName, TenantPhone, TenantPhone, TenantDOB, TenantDocument, TenantContact, TenantAccountNo, TenantBSB )values('" + insertString;

            //cmd.CommandText = "INSERT INTO 'tenant'('TenantID', 'TenantName', 'TenantPhone', 'TenantDOB', 'TenantDocument', 'TenantContact','TenantAccountNo', 'TenantBSB') VALUES ('3','Norah Alan','0408777666',1980-01-01,'document unavailable','sometimes','0001112223','123456')";
            //cmd.CommandText = "INSERT INTO `sql689558`.`tenant` (`TenantID`, `TenantName`, `TenantPhone`, `TenantDOB`, `TenantDocument`, `TenantContact`, `TenantAccountNo`, `TenantBSB`) VALUES (NULL, 'Norah Alan', '0454654534', '1980-01-01', 'doc unavailable', 'all day', '56746757456', '765654');";
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

        private bool DeleteTenant(string cell)
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
            string cell;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    cell = row.Cells[0].Value.ToString();
                    DeleteTenant(cell);
                }
                   
                    
                
                //dataGridView1.Rows.Remove(row);
            }

            
            
        }
        
    }
}
