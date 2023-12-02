namespace Inventory_System
{
    partial class AddItem
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
            this.btnSave = new System.Windows.Forms.Button();
            this.categoryBox = new System.Windows.Forms.Panel();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.Panel();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.productNameBox = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.numstock = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoryBox.SuspendLayout();
            this.priceBox.SuspendLayout();
            this.productNameBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numstock)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(232)))), ((int)(((byte)(254)))));
            this.btnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(775, 170);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 34);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.categoryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryBox.Controls.Add(this.txtcategory);
            this.categoryBox.Location = new System.Drawing.Point(383, 105);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(230, 29);
            this.categoryBox.TabIndex = 6;
            // 
            // txtcategory
            // 
            this.txtcategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcategory.Enabled = false;
            this.txtcategory.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategory.ForeColor = System.Drawing.Color.Silver;
            this.txtcategory.Location = new System.Drawing.Point(6, 5);
            this.txtcategory.Multiline = true;
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(222, 20);
            this.txtcategory.TabIndex = 1;
            this.txtcategory.Text = "Canned Goods";
            this.txtcategory.TextChanged += new System.EventHandler(this.txtcategory_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Product Name:";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(667, 84);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(49, 18);
            this.lblprice.TabIndex = 10;
            this.lblprice.Text = "Price:";
            this.lblprice.Click += new System.EventHandler(this.label3_Click);
            // 
            // priceBox
            // 
            this.priceBox.BackColor = System.Drawing.Color.White;
            this.priceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceBox.Controls.Add(this.txtprice);
            this.priceBox.Location = new System.Drawing.Point(670, 105);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(229, 29);
            this.priceBox.TabIndex = 9;
            this.priceBox.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtprice
            // 
            this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprice.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(5, 6);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(222, 15);
            this.txtprice.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(4, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 5);
            this.panel3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(112)))), ((int)(((byte)(191)))));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Add Item";
            // 
            // txtproductname
            // 
            this.txtproductname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtproductname.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductname.Location = new System.Drawing.Point(5, 6);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(222, 15);
            this.txtproductname.TabIndex = 1;
            // 
            // productNameBox
            // 
            this.productNameBox.BackColor = System.Drawing.Color.White;
            this.productNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productNameBox.Controls.Add(this.txtproductname);
            this.productNameBox.Location = new System.Drawing.Point(100, 105);
            this.productNameBox.Name = "productNameBox";
            this.productNameBox.Size = new System.Drawing.Size(231, 29);
            this.productNameBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Stock:";
            // 
            // numstock
            // 
            this.numstock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numstock.Location = new System.Drawing.Point(4, 6);
            this.numstock.Name = "numstock";
            this.numstock.Size = new System.Drawing.Size(222, 16);
            this.numstock.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numstock);
            this.panel1.Location = new System.Drawing.Point(100, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 29);
            this.panel1.TabIndex = 17;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 507);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productNameBox);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddItem";
            this.Text = "AddItem";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.categoryBox.ResumeLayout(false);
            this.categoryBox.PerformLayout();
            this.priceBox.ResumeLayout(false);
            this.priceBox.PerformLayout();
            this.productNameBox.ResumeLayout(false);
            this.productNameBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numstock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel categoryBox;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Panel priceBox;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.Panel productNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numstock;
        private System.Windows.Forms.Panel panel1;
    }
}