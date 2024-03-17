namespace CraigJ_C968_InventoryManagementSystem.model
{
    partial class ModifyParts
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
            this.Modify = new System.Windows.Forms.Label();
            this.InHouse = new System.Windows.Forms.RadioButton();
            this.OutSourced = new System.Windows.Forms.RadioButton();
            this.ID1 = new System.Windows.Forms.Label();
            this.Name2 = new System.Windows.Forms.Label();
            this.Instock3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Max5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Min7 = new System.Windows.Forms.Label();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxPartID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxInstock = new System.Windows.Forms.TextBox();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.SaveModifyParts = new System.Windows.Forms.Button();
            this.CancelModifyParts = new System.Windows.Forms.Button();
            this.textBoxMachineID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Modify
            // 
            this.Modify.AutoSize = true;
            this.Modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Modify.Location = new System.Drawing.Point(12, 18);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(88, 20);
            this.Modify.TabIndex = 0;
            this.Modify.Text = "Modify Part";
            // 
            // InHouse
            // 
            this.InHouse.AutoSize = true;
            this.InHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.InHouse.Location = new System.Drawing.Point(189, 20);
            this.InHouse.Name = "InHouse";
            this.InHouse.Size = new System.Drawing.Size(93, 24);
            this.InHouse.TabIndex = 1;
            this.InHouse.TabStop = true;
            this.InHouse.Text = "In-House";
            this.InHouse.UseVisualStyleBackColor = true;
            this.InHouse.CheckedChanged += new System.EventHandler(this.InHouse_CheckedChanged);
            // 
            // OutSourced
            // 
            this.OutSourced.AutoSize = true;
            this.OutSourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OutSourced.Location = new System.Drawing.Point(314, 20);
            this.OutSourced.Name = "OutSourced";
            this.OutSourced.Size = new System.Drawing.Size(110, 24);
            this.OutSourced.TabIndex = 2;
            this.OutSourced.TabStop = true;
            this.OutSourced.Text = "Outsourced";
            this.OutSourced.UseVisualStyleBackColor = true;
            this.OutSourced.CheckedChanged += new System.EventHandler(this.OutSourced_CheckedChanged);
            // 
            // ID1
            // 
            this.ID1.AutoSize = true;
            this.ID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ID1.Location = new System.Drawing.Point(211, 91);
            this.ID1.Name = "ID1";
            this.ID1.Size = new System.Drawing.Size(21, 17);
            this.ID1.TabIndex = 3;
            this.ID1.Text = "ID";
            // 
            // Name2
            // 
            this.Name2.AutoSize = true;
            this.Name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name2.Location = new System.Drawing.Point(187, 134);
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(45, 17);
            this.Name2.TabIndex = 4;
            this.Name2.Text = "Name";
            // 
            // Instock3
            // 
            this.Instock3.AutoSize = true;
            this.Instock3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Instock3.Location = new System.Drawing.Point(180, 230);
            this.Instock3.Name = "Instock3";
            this.Instock3.Size = new System.Drawing.Size(66, 17);
            this.Instock3.TabIndex = 5;
            this.Instock3.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(160, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price/Cost";
            // 
            // Max5
            // 
            this.Max5.AutoSize = true;
            this.Max5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Max5.Location = new System.Drawing.Point(199, 274);
            this.Max5.Name = "Max5";
            this.Max5.Size = new System.Drawing.Size(33, 17);
            this.Max5.TabIndex = 7;
            this.Max5.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(124, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Company Name";
            // 
            // Min7
            // 
            this.Min7.AutoSize = true;
            this.Min7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Min7.Location = new System.Drawing.Point(362, 275);
            this.Min7.Name = "Min7";
            this.Min7.Size = new System.Drawing.Size(30, 17);
            this.Min7.TabIndex = 9;
            this.Min7.Text = "Min";
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(256, 274);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxMax.TabIndex = 10;
            // 
            // textBoxPartID
            // 
            this.textBoxPartID.Location = new System.Drawing.Point(256, 90);
            this.textBoxPartID.Name = "textBoxPartID";
            this.textBoxPartID.ReadOnly = true;
            this.textBoxPartID.Size = new System.Drawing.Size(100, 20);
            this.textBoxPartID.TabIndex = 11;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(256, 134);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 12;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(256, 180);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 13;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(398, 275);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxMin.TabIndex = 14;
            // 
            // textBoxInstock
            // 
            this.textBoxInstock.Location = new System.Drawing.Point(256, 227);
            this.textBoxInstock.Name = "textBoxInstock";
            this.textBoxInstock.Size = new System.Drawing.Size(100, 20);
            this.textBoxInstock.TabIndex = 15;
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(256, 313);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompanyName.TabIndex = 16;
            // 
            // SaveModifyParts
            // 
            this.SaveModifyParts.Location = new System.Drawing.Point(632, 415);
            this.SaveModifyParts.Name = "SaveModifyParts";
            this.SaveModifyParts.Size = new System.Drawing.Size(75, 23);
            this.SaveModifyParts.TabIndex = 17;
            this.SaveModifyParts.Text = "Save";
            this.SaveModifyParts.UseVisualStyleBackColor = true;
            this.SaveModifyParts.Click += new System.EventHandler(this.SaveModifyParts_Click);
            // 
            // CancelModifyParts
            // 
            this.CancelModifyParts.Location = new System.Drawing.Point(713, 415);
            this.CancelModifyParts.Name = "CancelModifyParts";
            this.CancelModifyParts.Size = new System.Drawing.Size(75, 23);
            this.CancelModifyParts.TabIndex = 18;
            this.CancelModifyParts.Text = "Cancel";
            this.CancelModifyParts.UseVisualStyleBackColor = true;
            this.CancelModifyParts.Click += new System.EventHandler(this.CancelModifyParts_Click);
            // 
            // textBoxMachineID
            // 
            this.textBoxMachineID.Location = new System.Drawing.Point(256, 313);
            this.textBoxMachineID.Name = "textBoxMachineID";
            this.textBoxMachineID.Size = new System.Drawing.Size(100, 20);
            this.textBoxMachineID.TabIndex = 19;
            // 
            // ModifyParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMachineID);
            this.Controls.Add(this.CancelModifyParts);
            this.Controls.Add(this.SaveModifyParts);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.textBoxInstock);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPartID);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.Min7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Max5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Instock3);
            this.Controls.Add(this.Name2);
            this.Controls.Add(this.ID1);
            this.Controls.Add(this.OutSourced);
            this.Controls.Add(this.InHouse);
            this.Controls.Add(this.Modify);
            this.Name = "ModifyParts";
            this.Text = "Modify Parts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Modify;
        private System.Windows.Forms.RadioButton InHouse;
        private System.Windows.Forms.RadioButton OutSourced;
        private System.Windows.Forms.Label ID1;
        private System.Windows.Forms.Label Name2;
        private System.Windows.Forms.Label Instock3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Max5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Min7;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxPartID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxInstock;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.Button SaveModifyParts;
        private System.Windows.Forms.Button CancelModifyParts;
        private System.Windows.Forms.TextBox textBoxMachineID;
    }
}