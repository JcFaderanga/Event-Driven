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
    public partial class dashbordForm : Form
    {
        public dashbordForm()
        {
            InitializeComponent();
           // totalProduct.Text = $"{totalCount}";
            Load += Restock;
            Load += Product;
            
        }
        
        private void Product(object sender, EventArgs e)
        {
            // Your MySQL database connection string
            string connectionString = "server=localhost;username=root;password=;database=inventorysystem";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Assuming you have a table named 'your_table' and want to display a specific column value
                string query = "SELECT COUNT(*) AS total_rows FROM products";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Execute the query
                    object result = command.ExecuteScalar();

                    // Check if the result is not null
                    if (result != null)
                    {
                        // Update the label with the retrieved data
                        totalProduct.Text = result.ToString();
                    }
                    else
                    {
                        // Handle the case where no data is retrieved
                        totalProduct.Text = "No data found";
                    }
                }
            }
        }
        private void Restock(object sender, EventArgs e)
        {
            // Your MySQL database connection string
            string connectionString = "server=localhost;username=root;password=;database=inventorysystem";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Assuming you have a table named 'your_table' and want to display a specific column value
                string query = "SELECT COUNT(*) AS total_rows FROM tblrestock";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Execute the query
                    object result = command.ExecuteScalar();

                    // Check if the result is not null
                    if (result != null)
                    {
                        // Update the label with the retrieved data
                        totalpending.Text = result.ToString();
                    }
                    else
                    {
                        // Handle the case where no data is retrieved
                        totalpending.Text = "No data found";
                    }
                }
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void totalProduct_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dashbordForm_Load(object sender, EventArgs e)
        {

        }
    }
}
