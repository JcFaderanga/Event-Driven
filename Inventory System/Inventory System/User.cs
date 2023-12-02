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
    public partial class UserForm : Form
    {
        public UserForm(DataTable data)
        {
            InitializeComponent();
            LoadData(data);
            btnAddUsers.Click += nav_Click;
            btnRecords.Click += nav_Click;
        }
        public MySqlConnection connection = new MySqlConnection();
        private void LoadData(DataTable data)
        {
            dataGridView1.DataSource = data;
        }
        private void nav_Click(object sender, EventArgs e)
        {
            if (sender == btnRecords)
            {
                //OPEN ADD ITEM FORM INSIDE PRODUCT FORM
                ClearPanelControls(usersContainer);
                DataTable recordData = GetDataFromDatabase();
                UserRecords records = new UserRecords(recordData);
                records.TopLevel = false;
                usersContainer.Controls.Add(records);
                records.Show();
            }
      
            else if (sender == btnAddUsers)
            {
                //OPEN ADD ITEM FORM INSIDE PRODUCT FORM
                ClearPanelControls(usersContainer);
                AddUsers Addusers = new AddUsers();
                Addusers.TopLevel = false;
                usersContainer.Controls.Add(Addusers);
                Addusers.Show();
            }

        }
        private void ClearPanelControls(Panel panel)
        {
            // Iterate through the Controls collection and remove each control
            foreach (Control control in panel.Controls)
            {
                control.Dispose();
            }
            // Clear the Controls collection
            panel.Controls.Clear();
        }
        private DataTable GetDataFromDatabase()
        {
            string connection = "server=localhost;username=root;password=;database=inventorysystem";
            //string query = "SELECT Admin_records.username, Admin_records.password, Admin_records.date, Admin_records.time, Admin_records.Action, users.firstname, users.lastname FROM Admin_records JOIN users ON Admin_records.username = users.username ORDER BY Admin_records.date DESC, Admin_records.time DESC;";
            //string query = "SELECT users.firstname, users.lastname, Admin_records.username, ENCRYPT(Admin_records.password) AS encrypted_password, Admin_records.date, Admin_records.time, Admin_records.Action FROM Admin_records JOIN users ON Admin_records.username = users.username ORDER BY Admin_records.date DESC, Admin_records.time DESC;";
            string query = "SELECT  Users.firstname, Users.lastname, Admin_records.date, Admin_records.time, Admin_records.Action FROM Admin_records INNER JOIN Users ON Admin_records.username = Users.username OR Admin_records.UserId = Users.UserId ORDER BY Admin_records.date DESC, Admin_records.time DESC";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btAnddItem_Click(object sender, EventArgs e)
        {
          
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
