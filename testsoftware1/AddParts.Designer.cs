namespace CraigJ_C968_InventoryManagementSystem.model
{
    partial class AddParts
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
            this.AddPart = new System.Windows.Forms.Label();
            this.InHouse = new System.Windows.Forms.RadioButton();
            this.OutSourced = new System.Windows.Forms.RadioButton();
            this.SaveParts = new System.Windows.Forms.Button();
            this.CancelParts = new System.Windows.Forms.Button();
            this.ID1 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxPartID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxInstock = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.Name2 = new System.Windows.Forms.Label();
            this.Instock3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Max5 = new System.Windows.Forms.Label();
            this.Min7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMachineID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddPart
            // 
            this.AddPart.AutoSize = true;
            this.AddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddPart.Location = new System.Drawing.Point(12, 18);
            this.AddPart.Name = "AddPart";
            this.AddPart.Size = new System.Drawing.Size(71, 20);
            this.AddPart.TabIndex = 1;
            this.AddPart.Text = "Add Part";
            // 
            // InHouse
            // 
            this.InHouse.AutoSize = true;
            this.InHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.InHouse.Location = new System.Drawing.Point(180, 18);
            this.InHouse.Name = "InHouse";
            this.InHouse.Size = new System.Drawing.Size(93, 24);
            this.InHouse.TabIndex = 2;
            this.InHouse.TabStop = true;
            this.InHouse.Text = "In-House";
            this.InHouse.UseVisualStyleBackColor = true;
            this.InHouse.CheckedChanged += new System.EventHandler(this.InHouse_CheckedChanged);
            // 
            // OutSourced
            // 
            this.OutSourced.AutoSize = true;
            this.OutSourced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OutSourced.Location = new System.Drawing.Point(293, 18);
            this.OutSourced.Name = "OutSourced";
            this.OutSourced.Size = new System.Drawing.Size(110, 24);
            this.OutSourced.TabIndex = 3;
            this.OutSourced.TabStop = true;
            this.OutSourced.Text = "Outsourced";
            this.OutSourced.UseVisualStyleBackColor = true;
            this.OutSourced.CheckedChanged += new System.EventHandler(this.OutSourced_CheckedChanged);
            // 
            // SaveParts
            // 
            this.SaveParts.Location = new System.Drawing.Point(632, 415);
            this.SaveParts.Name = "SaveParts";
            this.SaveParts.Size = new System.Drawing.Size(75, 23);
            this.SaveParts.TabIndex = 18;
            this.SaveParts.Text = "Save";
            this.SaveParts.UseVisualStyleBackColor = true;
            this.SaveParts.Click += new System.EventHandler(this.SaveParts_Click);
            // 
            // CancelParts
            // 
            this.CancelParts.Location = new System.Drawing.Point(713, 415);
            this.CancelParts.Name = "CancelParts";
            this.CancelParts.Size = new System.Drawing.Size(75, 23);
            this.CancelParts.TabIndex = 19;
            this.CancelParts.Text = "Cancel";
            this.CancelParts.UseVisualStyleBackColor = true;
            this.CancelParts.Click += new System.EventHandler(this.CancelParts_Click);
            // 
            // ID1
            // 
            this.ID1.AutoSize = true;
            this.ID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ID1.Location = new System.Drawing.Point(201, 97);
            this.ID1.Name = "ID1";
            this.ID1.Size = new System.Drawing.Size(21, 17);
            this.ID1.TabIndex = 20;
            this.ID1.Text = "ID";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(236, 187);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 21;
            // 
            // textBoxPartID
            // 
            this.textBoxPartID.Location = new System.Drawing.Point(236, 94);
            this.textBoxPartID.Name = "textBoxPartID";
            this.textBoxPartID.ReadOnly = true;
            this.textBoxPartID.Size = new System.Drawing.Size(100, 20);
            this.textBoxPartID.TabIndex = 22;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(236, 139);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 23;
            // 
            // textBoxInstock
            // 
            this.textBoxInstock.Location = new System.Drawing.Point(236, 225);
            this.textBoxInstock.Name = "textBoxInstock";
            this.textBoxInstock.Size = new System.Drawing.Size(100, 20);
            this.textBoxInstock.TabIndex = 24;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(236, 263);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxMax.TabIndex = 25;
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(236, 306);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCompanyName.TabIndex = 26;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(378, 263);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxMin.TabIndex = 27;
            // 
            // Name2
            // 
            this.Name2.AutoSize = true;
            this.Name2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Name2.Location = new System.Drawing.Point(176, 139);
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(45, 17);
            this.Name2.TabIndex = 28;
            this.Name2.Text = "Name";
            // 
            // Instock3
            // 
            this.Instock3.AutoSize = true;
            this.Instock3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Instock3.Location = new System.Drawing.Point(169, 225);
            this.Instock3.Name = "Instock3";
            this.Instock3.Size = new System.Drawing.Size(66, 17);
            this.Instock3.TabIndex = 29;
            this.Instock3.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(150, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Price/Cost";
            // 
            // Max5
            // 
            this.Max5.AutoSize = true;
            this.Max5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Max5.Location = new System.Drawing.Point(188, 263);
            this.Max5.Name = "Max5";
            this.Max5.Size = new System.Drawing.Size(33, 17);
            this.Max5.TabIndex = 31;
            this.Max5.Text = "Max";
            // 
            // Min7
            // 
            this.Min7.AutoSize = true;
            this.Min7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Min7.Location = new System.Drawing.Point(342, 266);
            this.Min7.Name = "Min7";
            this.Min7.Size = new System.Drawing.Size(30, 17);
            this.Min7.TabIndex = 32;
            this.Min7.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(114, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Company Name";
            // 
            // textBoxMachineID
            // 
            this.textBoxMachineID.Location = new System.Drawing.Point(236, 306);
            this.textBoxMachineID.Name = "textBoxMachineID";
            this.textBoxMachineID.Size = new System.Drawing.Size(100, 20);
            this.textBoxMachineID.TabIndex = 34;
            // 
            // AddParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxMachineID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Min7);
            this.Controls.Add(this.Max5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Instock3);
            this.Controls.Add(this.Name2);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxInstock);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxPartID);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.ID1);
            this.Controls.Add(this.CancelParts);
            this.Controls.Add(this.SaveParts);
            this.Controls.Add(this.OutSourced);
            this.Controls.Add(this.InHouse);
            this.Controls.Add(this.AddPart);
            this.Name = "AddParts";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPart;
        private System.Windows.Forms.RadioButton InHouse;
        private System.Windows.Forms.RadioButton OutSourced;
        private System.Windows.Forms.Button SaveParts;
        private System.Windows.Forms.Button CancelParts;
        private System.Windows.Forms.Label ID1;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxPartID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxInstock;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Label Name2;
        private System.Windows.Forms.Label Instock3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Max5;
        private System.Windows.Forms.Label Min7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMachineID;
    }
}