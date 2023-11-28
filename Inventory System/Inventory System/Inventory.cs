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
    public partial class Inventory : Form
    {
        public Inventory(DataTable data)
        {
            InitializeComponent();
            LoadData(data);
        }
        private void LoadData(DataTable data)
        {
            dataGridView1.DataSource = data;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }
        private void productContainer_Paint(object sender, PaintEventArgs e)
        {
        }
        private void bltLowStocks_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;username=root;password=;database=inventorysystem";
            string query = "SELECT * FROM products WHERE QUANTITY < 20";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnhighStocks_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;username=root;password=;database=inventorysystem";
            string query = "SELECT * FROM products WHERE QUANTITY > 50";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;username=root;password=;database=inventorysystem";
            string query = "SELECT * FROM products";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}