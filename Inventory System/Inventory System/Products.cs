using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Inventory_System
{
    public partial class ProductForm : Form
    {
        public ProductForm(DataTable data)
        {
            InitializeComponent();
            //MySql connection Code will find in Form2.cs
            LoadData(data);
            btAnddItem.Click += nav_Click;
            btnInventory.Click += nav_Click;
            btnOrder.Click += nav_Click;
        }
        public MySqlConnection connection = new MySqlConnection();
        private void LoadData(DataTable data)
        {
            dataGridView1.DataSource = data;
        }
        private void nav_Click(object sender, EventArgs e)
        {
            if (sender == btAnddItem)
            {
                //OPEN ADD ITEM FORM INSIDE PRODUCT FORM
                ClearPanelControls(productContainer);
                AddItem AddItem = new AddItem();
                AddItem.TopLevel = false;
                productContainer.Controls.Add(AddItem);
                AddItem.Show();
            }
            else if (sender == btnOrder)
            {
                //OPEN ORDER FORM INSIDE PRODUCT FORM
                ClearPanelControls(productContainer);
                Order order = new Order();
                order.TopLevel = false;
                productContainer.Controls.Add(order);
                order.Show();
            }
            //OPEN INVENTORY FORM INSIDE PRODUCT FORM
            else if (sender == btnInventory) {
                ClearPanelControls(productContainer);
                DataTable productsData = GetDataFromDatabase();
                Inventory inventory = new Inventory(productsData);
                inventory.TopLevel = false;
                productContainer.Controls.Add(inventory);
                inventory.Show();
            }
          
        }
        private DataTable GetDataFromDatabase()
        {
            string connection = "server=localhost;username=root;password=;database=inventorysystem";
            string query = "SELECT * FROM products";

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard dashboard = new dashboard();
            dashboard.Show();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* string connection = "server=localhost;username=root;password=;database=inventorysystem";
            string query = "SELECT product_id, product_name, category FROM products";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;*/
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
