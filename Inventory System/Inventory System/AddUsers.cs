using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class AddUsers : Form
    {
        public AddUsers()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                string connection = "server=localhost;username=root;password=;database=inventorysystem";
                string query = "INSERT INTO users(firstname,lastname,username, password )VALUES('" +  this.txtfirstname.Text + "','" + this.txtlastname.Text + "','" + this.txtusername.Text + "','" + this.txtpassword.Text + "')";
                MySqlConnection conn = new MySqlConnection(connection);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                txtfirstname.Text = string.Empty;
                txtlastname.Text = string.Empty;
                txtusername.Text = string.Empty;
                txtpassword.Text = string.Empty;

                MessageBox.Show("User Successfully added!");
                conn.Close();
            }
        }
    }
}
