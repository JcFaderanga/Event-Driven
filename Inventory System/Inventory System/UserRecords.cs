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
    public partial class UserRecords : Form
    {
        public UserRecords(DataTable data)
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
    }
}
