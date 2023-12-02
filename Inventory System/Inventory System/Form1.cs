using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Inventory_System
{
    public partial class KKD : Form
    {
        private MySqlConnection connection;
        public KKD()
        {
            InitializeComponent();
            InitializeDatabase();

        }
        private void InitializeDatabase()
        {
            string connectionString;
            connectionString = "server=localhost;username=root;password=;database=inventorysystem";
            connection = new MySqlConnection(connectionString);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            string action = "Logged in";

            if (AuthenticateUser(username, password))
            {
                login();
                MessageBox.Show("Login successful!");
                string connection2 = "server=localhost;username=root;password=;database=inventorysystem";
                string query = $"INSERT INTO Admin_records(username , password ,Action) VALUES ('" + username + "','" + password  + "','" + action + "')";
                MySqlConnection conn = new MySqlConnection(connection2);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
        

        private bool AuthenticateUser(string username, string password)
        {
            try
            {
 
                connection.Open();
                string query = $"SELECT * FROM users WHERE Username='{username}' AND Password='{password}'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                return dt.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        private void login() {
                this.Hide();
            string username = txtusername.Text; // Replace with the actual logged-in username
            DatabaseManager dbManager = new DatabaseManager();
            string[] userInfo = dbManager.GetUserInfo(username);

            dashboard dashboardForm1 = new dashboard(userInfo[0], userInfo[1], userInfo[2]);
                dashboardForm1.Show();
                txtpassword.Clear();
                txtusername.Clear();
            
        }
        private void success(){
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
        }
    }
}
