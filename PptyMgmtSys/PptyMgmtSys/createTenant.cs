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
            // TODO: This line of code loads data into the 'propertymanagementDataSet.tenant' table. You can move, or remove it, as needed.
            this.tenantTableAdapter.Fill(this.propertymanagementDataSet.tenant);

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
           
            label8.Text = dateTimePicker1.Value.Date.ToString("d");
        }

        private bool create_tenant(string fullName, string phoneNumber, string dateOfBirth, string doc, string contacts, string account, string bankBsb)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            //string insertString = fullName + "', " + phoneNumber + "', 1980/2/1, '" + doc + "', " + contacts + "', " + account + "', " + bankBsb + "'";
            //cmd.CommandText = "insert into propertymanagement.tenant(TenantID, TenantName, TenantPhone, TenantPhone, TenantDOB, TenantDocument, TenantContact, TenantAccountNo, TenantBSB )values('" + insertString;

            cmd.CommandText = "INSERT INTO `owner`(`OwnerID`, `OwnerName`, `OwnerPhone`, `OwnerDOB`, `OwnerContact`, `OwnerAccountNo`, `OwnerBSB`, `Password`) VALUES (1,'Jack Daniels','0408777666',19800101,'sometimes','0001112223','123456','password')";
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
            dateOfBirth = dateTimePicker1.Value.Date.ToString("d");
            doc = document.Text;
            contacts = contact.Text;
            account = bankAccount.Text;
            bankBsb = bsb.Text;

            create_tenant(fullName, phoneNumber, dateOfBirth, doc, contacts, account, bankBsb);

        }
    }
}
