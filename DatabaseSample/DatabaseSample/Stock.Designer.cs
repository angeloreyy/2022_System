
namespace DatabaseSample
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseCoffeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveBeanType = new System.Windows.Forms.Button();
            this.btnRemoveCoffee = new System.Windows.Forms.Button();
            this.btnAddBeanType = new System.Windows.Forms.Button();
            this.btnAddCoffee = new System.Windows.Forms.Button();
            this.txtAddCoffee = new System.Windows.Forms.TextBox();
            this.txtAddBeanType = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.Label();
            this.cboBeanType = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblBeanType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCoffee = new System.Windows.Forms.Label();
            this.lblItemNo = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.cboCoffee = new System.Windows.Forms.ComboBox();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(41)))));
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenu,
            this.purchaseCoffeeToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 29);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenu
            // 
            this.mainMenuToolStripMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuToolStripMenu.ForeColor = System.Drawing.Color.White;
            this.mainMenuToolStripMenu.Name = "mainMenuToolStripMenu";
            this.mainMenuToolStripMenu.Size = new System.Drawing.Size(110, 25);
            this.mainMenuToolStripMenu.Text = "Main Menu";
            this.mainMenuToolStripMenu.Click += new System.EventHandler(this.mainMenuToolStripMenu_Click);
            // 
            // purchaseCoffeeToolStripMenuItem
            // 
            this.purchaseCoffeeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.purchaseCoffeeToolStripMenuItem.Name = "purchaseCoffeeToolStripMenuItem";
            this.purchaseCoffeeToolStripMenuItem.Size = new System.Drawing.Size(150, 25);
            this.purchaseCoffeeToolStripMenuItem.Text = "Purchase Coffee";
            this.purchaseCoffeeToolStripMenuItem.Click += new System.EventHandler(this.purchaseCoffeeToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(45)))), ((int)(((byte)(41)))));
            this.lblHeader.Location = new System.Drawing.Point(268, 43);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(652, 49);
            this.lblHeader.TabIndex = 28;
            this.lblHeader.Text = "TOP OF THE MORNING COFFEE";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToOrderColumns = true;
            this.dgvStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(221)))), ((int)(((byte)(15)))));
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(502, 105);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(544, 347);
            this.dgvStock.TabIndex = 27;
            this.dgvStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(221)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.btnRemoveBeanType);
            this.panel1.Controls.Add(this.btnRemoveCoffee);
            this.panel1.Controls.Add(this.btnAddBeanType);
            this.panel1.Controls.Add(this.btnAddCoffee);
            this.panel1.Controls.Add(this.txtAddCoffee);
            this.panel1.Controls.Add(this.txtAddBeanType);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.cboBeanType);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.lblStock);
            this.panel1.Controls.Add(this.lblBeanType);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblCoffee);
            this.panel1.Controls.Add(this.lblItemNo);
            this.panel1.Controls.Add(this.txtStock);
            this.panel1.Controls.Add(this.cboCoffee);
            this.panel1.Controls.Add(this.txtItemNo);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(25, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 493);
            this.panel1.TabIndex = 26;
            // 
            // btnRemoveBeanType
            // 
            this.btnRemoveBeanType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveBeanType.Location = new System.Drawing.Point(227, 447);
            this.btnRemoveBeanType.Name = "btnRemoveBeanType";
            this.btnRemoveBeanType.Size = new System.Drawing.Size(147, 35);
            this.btnRemoveBeanType.TabIndex = 26;
            this.btnRemoveBeanType.Text = "&Remove Bean Type";
            this.btnRemoveBeanType.UseVisualStyleBackColor = true;
            this.btnRemoveBeanType.Click += new System.EventHandler(this.btnRemoveBeanType_Click);
            // 
            // btnRemoveCoffee
            // 
            this.btnRemoveCoffee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCoffee.Location = new System.Drawing.Point(227, 362);
            this.btnRemoveCoffee.Name = "btnRemoveCoffee";
            this.btnRemoveCoffee.Size = new System.Drawing.Size(147, 35);
            this.btnRemoveCoffee.TabIndex = 25;
            this.btnRemoveCoffee.Text = "&Remove Coffee";
            this.btnRemoveCoffee.UseVisualStyleBackColor = true;
            this.btnRemoveCoffee.Click += new System.EventHandler(this.btnRemoveCoffee_Click);
            // 
            // btnAddBeanType
            // 
            this.btnAddBeanType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBeanType.Location = new System.Drawing.Point(74, 446);
            this.btnAddBeanType.Name = "btnAddBeanType";
            this.btnAddBeanType.Size = new System.Drawing.Size(150, 36);
            this.btnAddBeanType.TabIndex = 24;
            this.btnAddBeanType.Text = "&Add Bean Type";
            this.btnAddBeanType.UseVisualStyleBackColor = true;
            this.btnAddBeanType.Click += new System.EventHandler(this.btnAddBeanType_Click);
            // 
            // btnAddCoffee
            // 
            this.btnAddCoffee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCoffee.Location = new System.Drawing.Point(74, 362);
            this.btnAddCoffee.Name = "btnAddCoffee";
            this.btnAddCoffee.Size = new System.Drawing.Size(147, 35);
            this.btnAddCoffee.TabIndex = 23;
            this.btnAddCoffee.Text = "&Add Coffe";
            this.btnAddCoffee.UseVisualStyleBackColor = true;
            this.btnAddCoffee.Click += new System.EventHandler(this.btnAddCoffee_Click);
            // 
            // txtAddCoffee
            // 
            this.txtAddCoffee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCoffee.Location = new System.Drawing.Point(73, 329);
            this.txtAddCoffee.Name = "txtAddCoffee";
            this.txtAddCoffee.Size = new System.Drawing.Size(302, 27);
            this.txtAddCoffee.TabIndex = 22;
            // 
            // txtAddBeanType
            // 
            this.txtAddBeanType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddBeanType.Location = new System.Drawing.Point(73, 413);
            this.txtAddBeanType.Name = "txtAddBeanType";
            this.txtAddBeanType.Size = new System.Drawing.Size(302, 27);
            this.txtAddBeanType.TabIndex = 21;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(143, 186);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(273, 27);
            this.txtPrice.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(21, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(58, 21);
            this.txtName.TabIndex = 19;
            this.txtName.Text = "Name";
            // 
            // cboBeanType
            // 
            this.cboBeanType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBeanType.FormattingEnabled = true;
            this.cboBeanType.Items.AddRange(new object[] {
            "Pre-ground Beans",
            "Whole Beans"});
            this.cboBeanType.Location = new System.Drawing.Point(143, 151);
            this.cboBeanType.Name = "cboBeanType";
            this.cboBeanType.Size = new System.Drawing.Size(273, 29);
            this.cboBeanType.TabIndex = 18;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(324, 266);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(84, 37);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(233, 266);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 37);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(142, 266);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 37);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(49, 266);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 37);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(40, 222);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(53, 21);
            this.lblStock.TabIndex = 17;
            this.lblStock.Text = "Stock";
            // 
            // lblBeanType
            // 
            this.lblBeanType.AutoSize = true;
            this.lblBeanType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeanType.Location = new System.Drawing.Point(40, 154);
            this.lblBeanType.Name = "lblBeanType";
            this.lblBeanType.Size = new System.Drawing.Size(91, 21);
            this.lblBeanType.TabIndex = 14;
            this.lblBeanType.Text = "Bean Type";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(40, 189);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 21);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price";
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffee.Location = new System.Drawing.Point(40, 119);
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(63, 21);
            this.lblCoffee.TabIndex = 12;
            this.lblCoffee.Text = "Coffee";
            // 
            // lblItemNo
            // 
            this.lblItemNo.AutoSize = true;
            this.lblItemNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNo.Location = new System.Drawing.Point(40, 86);
            this.lblItemNo.Name = "lblItemNo";
            this.lblItemNo.Size = new System.Drawing.Size(77, 21);
            this.lblItemNo.TabIndex = 11;
            this.lblItemNo.Text = "Item No.";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(143, 219);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(274, 27);
            this.txtStock.TabIndex = 8;
            // 
            // cboCoffee
            // 
            this.cboCoffee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCoffee.FormattingEnabled = true;
            this.cboCoffee.Items.AddRange(new object[] {
            "Midnight Oil Dark Roast",
            "Twilight Medium Roast",
            "Golden Hour Medium Roast",
            "Morning Glory Light Roast"});
            this.cboCoffee.Location = new System.Drawing.Point(143, 116);
            this.cboCoffee.Name = "cboCoffee";
            this.cboCoffee.Size = new System.Drawing.Size(273, 29);
            this.cboCoffee.TabIndex = 6;
            // 
            // txtItemNo
            // 
            this.txtItemNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemNo.Location = new System.Drawing.Point(143, 83);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(273, 27);
            this.txtItemNo.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(89, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(135, 27);
            this.textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 111);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(179)))), ((int)(((byte)(5)))));
            this.ClientSize = new System.Drawing.Size(1069, 620);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dgvStock);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STOCK";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenu;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.ComboBox cboBeanType;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblBeanType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCoffee;
        private System.Windows.Forms.Label lblItemNo;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.ComboBox cboCoffee;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem purchaseCoffeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddBeanType;
        private System.Windows.Forms.Button btnAddCoffee;
        private System.Windows.Forms.TextBox txtAddCoffee;
        private System.Windows.Forms.TextBox txtAddBeanType;
        private System.Windows.Forms.Button btnRemoveBeanType;
        private System.Windows.Forms.Button btnRemoveCoffee;
    }
}