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
using MySql.Data.MySqlClient;

namespace Inventory_System
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
        }
        public MySqlConnection connection = new MySqlConnection();

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;username=root;password=;database=inventorysystem";
            string query = "INSERT INTO products(product_name, category, price)VALUES('" + this.txtproductname.Text + "','" + this.txtcategory.Text + "','" + this.txtprice.Text +"')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            txtproductname.Text = string.Empty;
            txtprice.Text = string.Empty;
            MessageBox.Show("Successfully saved");
            conn.Close();
        }
        private void AddItem_Load(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtcategory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
