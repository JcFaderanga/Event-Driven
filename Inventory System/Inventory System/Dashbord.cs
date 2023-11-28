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
        public dashbordForm(int totalCount)
        {
            InitializeComponent();
            totalProduct.Text = $"{totalCount}";
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
    }
}
