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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();

        }

        private void Order_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;username=root;password=;database=inventorysystem";
            string query = "SELECT product_id, product_name,quantity FROM products WHERE QUANTITY < 20";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            string query2 = "SELECT product_id, product_name,quantity FROM products";
            MySqlConnection conn2 = new MySqlConnection(connection);
            MySqlCommand cmd2 = new MySqlCommand(query2, conn2);
            MySqlDataAdapter da2 = new MySqlDataAdapter();
            da2.SelectCommand = cmd2;
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

        }

        private void btnAll_Click(object sender, EventArgs e)
        {

        }
    }
}
