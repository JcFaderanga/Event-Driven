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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            //display dashboard after login 
            dashbordForm dashboard = new dashbordForm();
            dashboard.TopLevel = false;
            container.Controls.Add(dashboard);
            dashboard.Show();

            //Onclick funtions
            dashboardBox.Click += nav_Click;
            productbox.Click += nav_Click;
            reportBox.Click += nav_Click;
            userBox.Click += nav_Click;
            transactionBox.Click += nav_Click;
        }
        private void nav_Click(object sender, EventArgs e)
        {
            if (sender == dashboardBox)
            {
                //OPEN DASHBOARD FORM
                ClearPanelControls(container);
                dashbordForm dashboard = new dashbordForm();
                dashboard.TopLevel = false;
                container.Controls.Add(dashboard);
                dashboard.Show();
            }
            else if (sender == productbox){
                //OPEN PRDUCT FORM
                ClearPanelControls(container);
                ProductForm Product = new ProductForm();
                Product.TopLevel = false;
                container.Controls.Add(Product);
                Product.Show();
            }
            else if (sender == userBox) {
                //OPEN USER FORM
                ClearPanelControls(container);
                UserForm User = new UserForm();
                User.TopLevel = false;
                container.Controls.Add(User);
                User.Show();
            }
            else if (sender == reportBox)
            {
                //OPEN REPORT FORM
                ClearPanelControls(container);
                ReportsForm Reports = new ReportsForm();
                Reports.TopLevel = false;
                container.Controls.Add(Reports);
                Reports.Show();
            }
            else if (sender == transactionBox){
                //OPEN TRANSACTION FORM
                ClearPanelControls(container);
                TransactionsForm Transactions = new TransactionsForm();
                Transactions.TopLevel = false;
                container.Controls.Add(Transactions);
                Transactions.Show();
            }
            //this.Hide();


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



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //LOG OUT BACK TO LOGIN FORM
            this.Hide();
            KKD frm1 = new KKD();
            frm1.Show();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dashboardBox_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dashboardNavExit() {
            
            dashboardBox.BackColor = Color.FromArgb(0, 146, 244);
        }
        private void dashboardNavEnter()
        {
            
        }
        //DASHBOARD HOVER
        private void dashboardBox_MouseHover(object sender, EventArgs e)
        {           
            dashboardBox.BackColor = Color.FromArgb(0, 146, 244);
        }

        private void dashboardBox_MouseLeave_1(object sender, EventArgs e)
        {
            dashboardBox.BackColor = Color.FromArgb(1, 112, 191);
        }
        private void navLbdashboard_MouseHover(object sender, EventArgs e)
        {
            dashboardBox.BackColor = Color.FromArgb(0, 146, 244);
        }

        private void navLbdashboard_MouseLeave(object sender, EventArgs e)
        {
            dashboardBox.BackColor = Color.FromArgb(1, 112, 191);
        }

        //TRANSACTION HOVER
        private void transactionBox_MouseHover(object sender, EventArgs e)
        {
            transactionBox.BackColor = Color.FromArgb(0, 146, 244);
        }
        private void transactionBox_MouseLeave(object sender, EventArgs e)
        {
            transactionBox.BackColor = Color.FromArgb(1, 112, 191);
        }
        private void navLblTranscation_MouseHover(object sender, EventArgs e)
        {
            transactionBox.BackColor = Color.FromArgb(0, 146, 244);
        }
        private void navLblTranscation_MouseLeave(object sender, EventArgs e)
        {
            transactionBox.BackColor = Color.FromArgb(1, 112, 191);
        }
        //PRODUCT HOVER
        private void productbox_MouseHover(object sender, EventArgs e)
        {
            
            productbox.BackColor = Color.FromArgb(0, 146, 244);
        }

        private void productbox_MouseLeave(object sender, EventArgs e)
        {
           
            productbox.BackColor = Color.FromArgb(1, 112, 191);
        }
        private void navLblProduct_MouseHover(object sender, EventArgs e)
        {
            
            productbox.BackColor = Color.FromArgb(0, 146, 244);
        }

        private void navLblProduct_MouseLeave(object sender, EventArgs e)
        {
            productbox.BackColor = Color.FromArgb(1, 112, 191);
        }
        //REPORT HOVER
        private void reportBox_MouseHover(object sender, EventArgs e)
        {

            reportBox.BackColor = Color.FromArgb(0, 146, 244);
        }

        private void reportBox_MouseLeave(object sender, EventArgs e)
        {
           
            reportBox.BackColor = Color.FromArgb(1, 112, 191);
        }
        private void navLblReports_MouseHover(object sender, EventArgs e)
        {
            reportBox.BackColor = Color.FromArgb(0, 146, 244);
        }

        private void navLblReports_MouseLeave(object sender, EventArgs e)
        {
            reportBox.BackColor = Color.FromArgb(1, 112, 191);
        }
        //USER HOVER
        private void userBox_MouseHover(object sender, EventArgs e)
        {
            
            userBox.BackColor = Color.FromArgb(0, 146, 244);
        }

        private void userBox_MouseLeave(object sender, EventArgs e)
        {
            
            userBox.BackColor = Color.FromArgb(1, 112, 191);
        }
        private void navLblUsers_MouseHover(object sender, EventArgs e)
        {
            userBox.BackColor = Color.FromArgb(0, 146, 244);
        }

        private void navLblUsers_MouseLeave(object sender, EventArgs e)
        {
            userBox.BackColor = Color.FromArgb(1, 112, 191);
        }
        private void transactionBox_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
