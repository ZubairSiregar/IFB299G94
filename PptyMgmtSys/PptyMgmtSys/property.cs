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
    public partial class property : Form
    {
        public property()
        {
            InitializeComponent();
        }

        private void property_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'propertymanagementDataSet4.property' table. You can move, or remove it, as needed.
            this.propertyTableAdapter1.Fill(this.propertymanagementDataSet4.property);

            try
            {
                MySqlConnection mcon = new MySqlConnection("Server=team94.cczx3nnzcur7.us-west-2.rds.amazonaws.com;Database=propertyManagementDB;Uid=team94user;Pwd=592road$;");
                string s = "SELECT * from propertyManagementDB.property;";
                mcon.Open();
                MySqlCommand mcd = new MySqlCommand(s, mcon);
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    comboBox1.Items.Add(mdr.GetInt32("PropertyID"));
                }
                mcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.propertyTableAdapter.FillBy(this.propertymanagementDataSet3.property);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mcon = new MySqlConnection("Server=team94.cczx3nnzcur7.us-west-2.rds.amazonaws.com;Database=propertyManagementDB;Uid=team94user;Pwd=592road$;");
                string s = "SELECT * from propertyManagementDB.property WHERE PropertyID = '" + comboBox1.SelectedIndex +"';";
                mcon.Open();
                MySqlCommand mcd = new MySqlCommand(s, mcon);
                MySqlDataReader mdr = mcd.ExecuteReader();
                while (mdr.Read())
                {
                    comboBox1.Items.Add(mdr.GetInt32("PropertyID"));
                    textBox1.Text = mdr.GetString("Status");
                    textBox2.Text = mdr.GetString("HouseNumber") + " " + mdr.GetString("StreetName") + " " + mdr.GetString("Postcode") + " " + mdr.GetString("Suburb") + " " + mdr.GetString("State") + " " + mdr.GetString("City") + " " + mdr.GetString("Country");
                        //" StreetName" + " Postcode" + " Suburb" + " State" + " City" + " Country");
                    textBox3.Text = mdr.GetInt32("Bedrooms").ToString();
                    textBox4.Text = mdr.GetInt32("Bathrooms").ToString();
                    textBox5.Text = mdr.GetFloat("TotalRent").ToString();
                    textBox6.Text = mdr.GetString("Property_Type");
                    pictureBox1.ImageLocation = mdr.GetString("PhotoOne");
                    pictureBox2.ImageLocation = mdr.GetString("PhotoTwo");
                    pictureBox3.ImageLocation = mdr.GetString("PhotoThree");



                }
                mcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
