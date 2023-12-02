namespace Inventory_System
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUserId = new System.Windows.Forms.Label();
            this.AdminName = new System.Windows.Forms.TextBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.transactionBox = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.navLblTranscation = new System.Windows.Forms.Label();
            this.dashboardBox = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.navLbdashboard = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.navLblUsers = new System.Windows.Forms.Label();
            this.productbox = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.navLblProduct = new System.Windows.Forms.Label();
            this.reportBox = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.navLblReports = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.container = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel18.SuspendLayout();
            this.transactionBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.dashboardBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.userBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.productbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.reportBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(191)))));
            this.panel2.Controls.Add(this.txtUserId);
            this.panel2.Controls.Add(this.AdminName);
            this.panel2.Controls.Add(this.panel18);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 702);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtUserId
            // 
            this.txtUserId.AutoSize = true;
            this.txtUserId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(191)))));
            this.txtUserId.Location = new System.Drawing.Point(100, 580);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(35, 13);
            this.txtUserId.TabIndex = 18;
            this.txtUserId.Text = "label1";
            // 
            // AdminName
            // 
            this.AdminName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(191)))));
            this.AdminName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.AdminName.ForeColor = System.Drawing.Color.White;
            this.AdminName.Location = new System.Drawing.Point(36, 617);
            this.AdminName.Name = "AdminName";
            this.AdminName.Size = new System.Drawing.Size(158, 14);
            this.AdminName.TabIndex = 17;
            this.AdminName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdminName.TextChanged += new System.EventHandler(this.AdminName_TextChanged);
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.transactionBox);
            this.panel18.Controls.Add(this.dashboardBox);
            this.panel18.Controls.Add(this.userBox);
            this.panel18.Controls.Add(this.productbox);
            this.panel18.Controls.Add(this.reportBox);
            this.panel18.Location = new System.Drawing.Point(-1, 222);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(239, 277);
            this.panel18.TabIndex = 16;
            // 
            // transactionBox
            // 
            this.transactionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(191)))));
            this.transactionBox.Controls.Add(this.pictureBox6);
            this.transactionBox.Controls.Add(this.navLblTranscation);
            this.transactionBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transactionBox.Location = new System.Drawing.Point(-2, 209);
            this.transactionBox.Name = "transactionBox";
            this.transactionBox.Size = new System.Drawing.Size(239, 46);
            this.transactionBox.TabIndex = 15;
            this.transactionBox.Paint += new System.Windows.Forms.PaintEventHandler(this.transactionBox_Paint);
            this.transactionBox.MouseLeave += new System.EventHandler(this.transactionBox_MouseLeave);
            this.transactionBox.MouseHover += new System.EventHandler(this.transactionBox_MouseHover);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Inventory_System.Properties.Resources.trending_up_regular_24;
            this.pictureBox6.Location = new System.Drawing.Point(13, 8);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // navLblTranscation
            // 
            this.navLblTranscation.AutoSize = true;
            this.navLblTranscation.Font = new System.Drawing.Font("Arial", 14.25F);
            this.navLblTranscation.ForeColor = System.Drawing.Color.White;
            this.navLblTranscation.Location = new System.Drawing.Point(44, 12);
            this.navLblTranscation.Name = "navLblTranscation";
            this.navLblTranscation.Size = new System.Drawing.Size(107, 22);
            this.navLblTranscation.TabIndex = 15;
            this.navLblTranscation.Text = "Transaction";
            this.navLblTranscation.MouseLeave += new System.EventHandler(this.navLblTranscation_MouseLeave);
            this.navLblTranscation.MouseHover += new System.EventHandler(this.navLblTranscation_MouseHover);
            // 
            // dashboardBox
            // 
            this.dashboardBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(191)))));
            this.dashboardBox.Controls.Add(this.pictureBox2);
            this.dashboardBox.Controls.Add(this.navLbdashboard);
            this.dashboardBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardBox.Location = new System.Drawing.Point(-1, 25);
            this.dashboardBox.Name = "dashboardBox";
            this.dashboardBox.Size = new System.Drawing.Size(239, 46);
            this.dashboardBox.TabIndex = 11;
            this.dashboardBox.Paint += new System.Windows.Forms.PaintEventHandler(this.dashboardBox_Paint);
            this.dashboardBox.MouseLeave += new System.EventHandler(this.dashboardBox_MouseLeave_1);
            this.dashboardBox.MouseHover += new System.EventHandler(this.dashboardBox_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Inventory_System.Properties.Resources.dashboard_solid_24__1_;
            this.pictureBox2.Location = new System.Drawing.Point(12, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // navLbdashboard
            // 
            this.navLbdashboard.AutoSize = true;
            this.navLbdashboard.Font = new System.Drawing.Font("Arial", 14.25F);
            this.navLbdashboard.ForeColor = System.Drawing.Color.White;
            this.navLbdashboard.Location = new System.Drawing.Point(43, 12);
            this.navLbdashboard.Name = "navLbdashboard";
            this.navLbdashboard.Size = new System.Drawing.Size(103, 22);
            this.navLbdashboard.TabIndex = 11;
            this.navLbdashboard.Text = "Dashboard";
            this.navLbdashboard.MouseLeave += new System.EventHandler(this.navLbdashboard_MouseLeave);
            this.navLbdashboard.MouseHover += new System.EventHandler(this.navLbdashboard_MouseHover);
            // 
            // userBox
            // 
            this.userBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(191)))));
            this.userBox.Controls.Add(this.pictureBox5);
            this.userBox.Controls.Add(this.navLblUsers);
            this.userBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userBox.Location = new System.Drawing.Point(-2, 163);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(239, 46);
            this.userBox.TabIndex = 14;
            this.userBox.MouseLeave += new System.EventHandler(this.userBox_MouseLeave);
            this.userBox.MouseHover += new System.EventHandler(this.userBox_MouseHover);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Inventory_System.Properties.Resources.user_solid_24;
            this.pictureBox5.Location = new System.Drawing.Point(13, 8);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // navLblUsers
            // 
            this.navLblUsers.AutoSize = true;
            this.navLblUsers.Font = new System.Drawing.Font("Arial", 14.25F);
            this.navLblUsers.ForeColor = System.Drawing.Color.White;
            this.navLblUsers.Location = new System.Drawing.Point(45, 12);
            this.navLblUsers.Name = "navLblUsers";
            this.navLblUsers.Size = new System.Drawing.Size(60, 22);
            this.navLblUsers.TabIndex = 14;
            this.navLblUsers.Text = "Users";
            this.navLblUsers.MouseLeave += new System.EventHandler(this.navLblUsers_MouseLeave);
            this.navLblUsers.MouseHover += new System.EventHandler(this.navLblUsers_MouseHover);
            // 
            // productbox
            // 
            this.productbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(191)))));
            this.productbox.Controls.Add(this.pictureBox3);
            this.productbox.Controls.Add(this.navLblProduct);
            this.productbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productbox.Location = new System.Drawing.Point(-1, 71);
            this.productbox.Name = "productbox";
            this.productbox.Size = new System.Drawing.Size(239, 46);
            this.productbox.TabIndex = 13;
            this.productbox.Paint += new System.Windows.Forms.PaintEventHandler(this.productbox_Paint);
            this.productbox.MouseLeave += new System.EventHandler(this.productbox_MouseLeave);
            this.productbox.MouseHover += new System.EventHandler(this.productbox_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Inventory_System.Properties.Resources.package_regular_24;
            this.pictureBox3.Location = new System.Drawing.Point(12, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // navLblProduct
            // 
            this.navLblProduct.AutoSize = true;
            this.navLblProduct.Font = new System.Drawing.Font("Arial", 14.25F);
            this.navLblProduct.ForeColor = System.Drawing.Color.White;
            this.navLblProduct.Location = new System.Drawing.Point(43, 12);
            this.navLblProduct.Name = "navLblProduct";
            this.navLblProduct.Size = new System.Drawing.Size(76, 22);
            this.navLblProduct.TabIndex = 12;
            this.navLblProduct.Text = "Product";
            this.navLblProduct.MouseLeave += new System.EventHandler(this.navLblProduct_MouseLeave);
            this.navLblProduct.MouseHover += new System.EventHandler(this.navLblProduct_MouseHover);
            // 
            // reportBox
            // 
            this.reportBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(191)))));
            this.reportBox.Controls.Add(this.pictureBox4);
            this.reportBox.Controls.Add(this.navLblReports);
            this.reportBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportBox.Location = new System.Drawing.Point(-1, 117);
            this.reportBox.Name = "reportBox";
            this.reportBox.Size = new System.Drawing.Size(239, 46);
            this.reportBox.TabIndex = 14;
            this.reportBox.MouseLeave += new System.EventHandler(this.reportBox_MouseLeave);
            this.reportBox.MouseHover += new System.EventHandler(this.reportBox_MouseHover);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Inventory_System.Properties.Resources.report_solid_24;
            this.pictureBox4.Location = new System.Drawing.Point(12, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // navLblReports
            // 
            this.navLblReports.AutoSize = true;
            this.navLblReports.Font = new System.Drawing.Font("Arial", 14.25F);
            this.navLblReports.ForeColor = System.Drawing.Color.White;
            this.navLblReports.Location = new System.Drawing.Point(43, 12);
            this.navLblReports.Name = "navLblReports";
            this.navLblReports.Size = new System.Drawing.Size(78, 22);
            this.navLblReports.TabIndex = 13;
            this.navLblReports.Text = "Reports";
            this.navLblReports.Click += new System.EventHandler(this.label13_Click);
            this.navLblReports.MouseLeave += new System.EventHandler(this.navLblReports_MouseLeave);
            this.navLblReports.MouseHover += new System.EventHandler(this.navLblReports_MouseHover);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(191)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(75, 637);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 29);
            this.button5.TabIndex = 13;
            this.button5.Text = "Log out";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(191)))));
            this.pictureBox1.Image = global::Inventory_System.Properties.Resources.no_bg_white_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // container
            // 
            this.container.Location = new System.Drawing.Point(239, 1);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1043, 699);
            this.container.TabIndex = 11;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.container);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DASHBOAD";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.transactionBox.ResumeLayout(false);
            this.transactionBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.dashboardBox.ResumeLayout(false);
            this.dashboardBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.userBox.ResumeLayout(false);
            this.userBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.productbox.ResumeLayout(false);
            this.productbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.reportBox.ResumeLayout(false);
            this.reportBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label navLbdashboard;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel transactionBox;
        private System.Windows.Forms.Panel dashboardBox;
        private System.Windows.Forms.Panel userBox;
        private System.Windows.Forms.Panel productbox;
        private System.Windows.Forms.Panel reportBox;
        private System.Windows.Forms.Label navLblTranscation;
        private System.Windows.Forms.Label navLblUsers;
        private System.Windows.Forms.Label navLblProduct;
        private System.Windows.Forms.Label navLblReports;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.TextBox AdminName;
        private System.Windows.Forms.Label txtUserId;
    }
}