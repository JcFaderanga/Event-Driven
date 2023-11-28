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
using System.Xml.Linq;

namespace Inventory_System
{
    public partial class KKD : Form
    {
        public KKD()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "admin" && txtpassword.Text == "123")
            {
                this.Hide();
                // Execute the SQL query to get the total count
                int totalCount = GetTotalRowCount();

                // Open Form2 (Dashboard) and pass the total count as a parameter
                dashbordForm Dboard = new dashbordForm(totalCount);
                dashboard dashboardForm1 = new dashboard();
                dashboardForm1.Show();

            }
            else
            {
                txtpassword.Clear();
                txtusername.Clear();
            }
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
