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
        public Order(DataTable data)
        {
            InitializeComponent();
            LoadData(data);

        }
        public MySqlConnection connection = new MySqlConnection();
        private void LoadData(DataTable data)
        {
            dataGridView1.DataSource = data;
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
            string query = "SELECT product_id, product_name,quantity FROM products";
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
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;username=root;password=;database=inventorysystem";
            string query = "INSERT INTO tblrestock(product_id, product_name, stocks )VALUES('" + this.txtproductid.Text + "','" + this.txtproductname.Text + "','" + this.txtstock.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            txtproductname.Text = string.Empty;
            txtproductid.Text = string.Empty;
            txtstock.Text = string.Empty;
            MessageBox.Show("Successfully saved");
            conn.Close();
        }
    }
}
