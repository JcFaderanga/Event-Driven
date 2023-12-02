using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Inventory_System
{
    public partial class dashboard : Form
    {
        
        
        public dashboard(string UserId, string firstName, string lastName)
        {
            InitializeComponent();
            UpdateLabel(UserId, firstName, lastName);
            dashbordForm dashboard = new dashbordForm();
            dashboard.TopLevel = false;
            container.Controls.Add(dashboard);
            dashboard.Show();
            //Onclick funtions
            dashboardBox.Click += nav_Click;
            productbox.Click += nav_Click;
            reportBox.Click += nav_Click;
            userBox.Click += nav_Click;
            transactionBox.Click += nav_Click;

        }
        public void UpdateLabel(string UserId, string firstName, string lastName)
        {
            this.txtUserId.Text = $"{UserId}";
            AdminName.Text = $"{firstName} {lastName}";

        }
        private int GetTotalRowCount()
        {
            string connection = "server=localhost;username=root;password=;database=inventorysystem";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();

                string query = "SELECT COUNT(*) AS total_rows FROM products";

                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return Convert.ToInt32(reader["total_rows"]);
                        }
                    }
                }
            }
            return 0; // Default to 0 if there is an issue
        }

        private DataTable GetDataFromDatabase()
        {
            //Product Form database code
            string connection = "server=localhost;username=root;password=;database=inventorysystem";
            string query = "SELECT product_id, product_name, category FROM products";

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
        private DataTable GetDataFromDatabaseAdminRecord()
        {
            string connection = "server=localhost;username=root;password=;database=inventorysystem";
            string query = "SELECT UserId,firstname,lastname, Username, CONCAT(LEFT(password, 1),REPEAT('*', LENGTH(password) - 1)) AS password FROM users";

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

        private void nav_Click(object sender, EventArgs e)
        {
            if (sender == dashboardBox)
            {
                //OPEN DASHBOARD FORM
                ClearPanelControls(container);
                dashbordForm dashboard = new dashbordForm(); 
                dashboard.TopLevel = false;
                container.Controls.Add(dashboard);
                dashboard.Show();
            }
            else if (sender == productbox){
                //OPEN PRDUCT FORM
                 ClearPanelControls(container);
                int totalCount = GetTotalRowCount();
                DataTable productsData = GetDataFromDatabase();
                   ProductForm Product = new ProductForm(productsData);
                   Product.TopLevel = false;
                   container.Controls.Add(Product);
                   Product.Show(); 
            }
            else if (sender == userBox) {
                //OPEN USER FORM
                ClearPanelControls(container);
                DataTable recordData = GetDataFromDatabaseAdminRecord();
                UserForm User = new UserForm(recordData);
                User.TopLevel = false;
                container.Controls.Add(User);
                User.Show();
            }
            else if (sender == reportBox)
            {
                //OPEN REPORT FORM
                ClearPanelControls(container);
                ReportsForm Reports = new ReportsForm();
                Reports.TopLevel = false;
                container.Controls.Add(Reports);
                Reports.Show();
            }
            else if (sender == transactionBox){
                //OPEN TRANSACTION FORM
                ClearPanelControls(container);
                TransactionsForm Transactions = new TransactionsForm();
                Transactions.TopLevel = false;
                container.Controls.Add(Transactions);
                Transactions.Show();
            }
            //this.Hide();


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



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string action = "Logged out";
            string userid = txtUserId.Text;
            string connection = "server=localhost;username=root;password=;database=inventorysystem";
            string query = "INSERT INTO admin_records(UserId, Action)VALUES('" + userid + "','" + action + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            conn.Close();
            // Close the current form and show the login form
            this.Hide();
            KKD frm1 = new KKD();
            frm1.Show();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dashboardBox_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dashboardNavExit() {
            
            dashboardBox.BackColor = Color.FromArgb(0, 146, 244);
        }
        private void dashboardNavEnter()
        {
            
        }
        //DASHBOARD HOVER
        private void dashboardBox_MouseHover(object sender, EventArgs e)
        {           
            dashboardBox.BackColor = Color.FromArgb(0, 146, 244);
        }

        private void dashboardBox_MouseLeave_1(object sender, EventArgs e)
        {
            dashboardBox.BackColor = Color.FromArgb(1, 112, 191);
        }
        private void navLbdashboard_MouseHover(object sender, EventArgs e)
        {
            dashboardBox.BackColor = Color.FromArgb(0, 146, 244);
        }

        private void navLbdashboard_MouseLeave(object sender, EventArgs e)
        {
            dashboardBox.BackColor = Color.FromArgb(1, 112, 191);
        }

        //TRANSACTION HOVER
        private void transactionBox_MouseHover(object sender, EventArgs e)
        {
            transactionBox.BackColor = Color.FromArgb(0, 146, 244);
        }
        private void transactionBox_MouseLeave(object sender, EventArgs e)
        {
            transactionBox.BackColor = Color.FromArgb(1, 112, 191);
        }
        private void navLblTranscation_MouseHover(object sender, EventArgs e)
        {
            transactionBox.BackColor = Color.FromArgb(0, 146, 244);
        }
        private void navLblTranscation_MouseLeave(object sender, EventArgs e)
        {
            transactionBox.BackColor = Color.FromArgb(1, 112, 191);
        }
        //PRODUCT HOVER
        private void productbox_MouseHover(object sender, EventArgs e)
        {
            
            productbox.BackColor = Color.FromArgb(0, 146, 244);
        }

        private void productbox_MouseLeave(object sender, EventArgs e)
        {
           
            productbox.BackColor = Color.FromArgb(1, 112, 191);
        }
        private void navLblProduct_MouseHover(object sender, EventArgs e)
        {
            
            productbox.BackColor = Color.FromArgb(0, 146, 244);
        }

        private void navLblProduct_MouseLeave(object sender, EventArgs e)
        {
            productbox.BackColor = Color.FromArgb(1, 112, 191);
        }
        //REPORT HOVER
        private void reportBox_MouseHover(object sender, EventArgs e)
        {

            reportBox.BackColor = Color.FromArgb(0, 146, 244);
        }

        private void reportBox_MouseLeave(object sender, EventArgs e)
        {
           
            reportBox.BackColor = Color.FromArgb(1, 112, 191);
        }
        private void navLblReports_MouseHover(object sender, EventArgs e)
        {
            reportBox.BackColor = Color.FromArgb(0, 146, 244);
        }

        private void navLblReports_MouseLeave(object sender, EventArgs e)
        {
            reportBox.BackColor = Color.FromArgb(1, 112, 191);
        }
        //USER HOVER
        private void userBox_MouseHover(object sender, EventArgs e)
        {
            
            userBox.BackColor = Color.FromArgb(0, 146, 244);
        }

        private void userBox_MouseLeave(object sender, EventArgs e)
        {
            
            userBox.BackColor = Color.FromArgb(1, 112, 191);
        }
        private void navLblUsers_MouseHover(object sender, EventArgs e)
        {
            userBox.BackColor = Color.FromArgb(0, 146, 244);
        }

        private void navLblUsers_MouseLeave(object sender, EventArgs e)
        {
            userBox.BackColor = Color.FromArgb(1, 112, 191);
        }
        private void transactionBox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productbox_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminName_Click(object sender, EventArgs e)
        {

        }

        private void AdminName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
