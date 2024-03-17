namespace CraigJ_C968_InventoryManagementSystem.model
{
    partial class Main
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
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.SearchParts = new System.Windows.Forms.Button();
            this.SearchProducts = new System.Windows.Forms.Button();
            this.AddParts = new System.Windows.Forms.Button();
            this.ModifyParts = new System.Windows.Forms.Button();
            this.Delete1 = new System.Windows.Forms.Button();
            this.AddProducts = new System.Windows.Forms.Button();
            this.ModifyProducts = new System.Windows.Forms.Button();
            this.DeleteProducts = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.textBoxParts = new System.Windows.Forms.TextBox();
            this.textBoxProducts = new System.Windows.Forms.TextBox();
            this.Parts = new System.Windows.Forms.Label();
            this.Products = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(12, 123);
            this.dgvParts.MultiSelect = false;
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParts.Size = new System.Drawing.Size(433, 298);
            this.dgvParts.TabIndex = 0;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(466, 123);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(468, 298);
            this.dgvProducts.TabIndex = 1;
            // 
            // SearchParts
            // 
            this.SearchParts.Enabled = false;
            this.SearchParts.Location = new System.Drawing.Point(198, 94);
            this.SearchParts.Name = "SearchParts";
            this.SearchParts.Size = new System.Drawing.Size(75, 23);
            this.SearchParts.TabIndex = 2;
            this.SearchParts.Text = "Search";
            this.SearchParts.UseVisualStyleBackColor = true;
            this.SearchParts.Click += new System.EventHandler(this.SearchParts_Click);
            // 
            // SearchProducts
            // 
            this.SearchProducts.Enabled = false;
            this.SearchProducts.Location = new System.Drawing.Point(654, 94);
            this.SearchProducts.Name = "SearchProducts";
            this.SearchProducts.Size = new System.Drawing.Size(75, 23);
            this.SearchProducts.TabIndex = 3;
            this.SearchProducts.Text = "Search";
            this.SearchProducts.UseVisualStyleBackColor = true;
            this.SearchProducts.Click += new System.EventHandler(this.SearchProducts_Click);
            // 
            // AddParts
            // 
            this.AddParts.Location = new System.Drawing.Point(198, 427);
            this.AddParts.Name = "AddParts";
            this.AddParts.Size = new System.Drawing.Size(75, 23);
            this.AddParts.TabIndex = 4;
            this.AddParts.Text = "Add";
            this.AddParts.UseVisualStyleBackColor = true;
            this.AddParts.Click += new System.EventHandler(this.AddParts_Click);
            // 
            // ModifyParts
            // 
            this.ModifyParts.Location = new System.Drawing.Point(279, 427);
            this.ModifyParts.Name = "ModifyParts";
            this.ModifyParts.Size = new System.Drawing.Size(75, 23);
            this.ModifyParts.TabIndex = 5;
            this.ModifyParts.Text = "Modify";
            this.ModifyParts.UseVisualStyleBackColor = true;
            this.ModifyParts.Click += new System.EventHandler(this.ModifyParts_Click);
            // 
            // Delete1
            // 
            this.Delete1.Location = new System.Drawing.Point(360, 427);
            this.Delete1.Name = "Delete1";
            this.Delete1.Size = new System.Drawing.Size(75, 23);
            this.Delete1.TabIndex = 6;
            this.Delete1.Text = "Delete";
            this.Delete1.UseVisualStyleBackColor = true;
            this.Delete1.Click += new System.EventHandler(this.DeleteParts_Click);
            // 
            // AddProducts
            // 
            this.AddProducts.Location = new System.Drawing.Point(654, 427);
            this.AddProducts.Name = "AddProducts";
            this.AddProducts.Size = new System.Drawing.Size(75, 23);
            this.AddProducts.TabIndex = 7;
            this.AddProducts.Text = "Add";
            this.AddProducts.UseVisualStyleBackColor = true;
            this.AddProducts.Click += new System.EventHandler(this.AddProducts_Click);
            // 
            // ModifyProducts
            // 
            this.ModifyProducts.Location = new System.Drawing.Point(735, 427);
            this.ModifyProducts.Name = "ModifyProducts";
            this.ModifyProducts.Size = new System.Drawing.Size(75, 23);
            this.ModifyProducts.TabIndex = 8;
            this.ModifyProducts.Text = "Modify";
            this.ModifyProducts.UseVisualStyleBackColor = true;
            this.ModifyProducts.Click += new System.EventHandler(this.ModifyProducts_Click);
            // 
            // DeleteProducts
            // 
            this.DeleteProducts.Location = new System.Drawing.Point(816, 427);
            this.DeleteProducts.Name = "DeleteProducts";
            this.DeleteProducts.Size = new System.Drawing.Size(75, 23);
            this.DeleteProducts.TabIndex = 9;
            this.DeleteProducts.Text = "Delete";
            this.DeleteProducts.UseVisualStyleBackColor = true;
            this.DeleteProducts.Click += new System.EventHandler(this.DeleteProducts_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(816, 484);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // textBoxParts
            // 
            this.textBoxParts.Location = new System.Drawing.Point(280, 96);
            this.textBoxParts.Name = "textBoxParts";
            this.textBoxParts.Size = new System.Drawing.Size(155, 20);
            this.textBoxParts.TabIndex = 11;
            this.textBoxParts.TextChanged += new System.EventHandler(this.textBoxParts_TextChanged);
            // 
            // textBoxProducts
            // 
            this.textBoxProducts.Location = new System.Drawing.Point(736, 97);
            this.textBoxProducts.Name = "textBoxProducts";
            this.textBoxProducts.Size = new System.Drawing.Size(155, 20);
            this.textBoxProducts.TabIndex = 12;
            this.textBoxProducts.TextChanged += new System.EventHandler(this.textBoxProducts_TextChanged);
            // 
            // Parts
            // 
            this.Parts.AutoSize = true;
            this.Parts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Parts.Location = new System.Drawing.Point(12, 100);
            this.Parts.Name = "Parts";
            this.Parts.Size = new System.Drawing.Size(46, 20);
            this.Parts.TabIndex = 13;
            this.Parts.Text = "Parts";
            // 
            // Products
            // 
            this.Products.AutoSize = true;
            this.Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Products.Location = new System.Drawing.Point(464, 100);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(72, 20);
            this.Products.TabIndex = 14;
            this.Products.Text = "Products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Inventory Management System";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.Parts);
            this.Controls.Add(this.textBoxProducts);
            this.Controls.Add(this.textBoxParts);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.DeleteProducts);
            this.Controls.Add(this.ModifyProducts);
            this.Controls.Add(this.AddProducts);
            this.Controls.Add(this.Delete1);
            this.Controls.Add(this.ModifyParts);
            this.Controls.Add(this.AddParts);
            this.Controls.Add(this.SearchProducts);
            this.Controls.Add(this.SearchParts);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.dgvParts);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button SearchParts;
        private System.Windows.Forms.Button SearchProducts;
        private System.Windows.Forms.Button AddParts;
        private System.Windows.Forms.Button ModifyParts;
        private System.Windows.Forms.Button Delete1;
        private System.Windows.Forms.Button AddProducts;
        private System.Windows.Forms.Button ModifyProducts;
        private System.Windows.Forms.Button DeleteProducts;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox textBoxParts;
        private System.Windows.Forms.TextBox textBoxProducts;
        private System.Windows.Forms.Label Parts;
        private System.Windows.Forms.Label Products;
        private System.Windows.Forms.Label label1;
    }
}

