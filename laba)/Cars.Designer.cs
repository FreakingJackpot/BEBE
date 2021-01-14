namespace laba_
{
    partial class Cars
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeadCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriveUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Body = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EngineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorsePower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            //
            // button5
            //
            this.button5.Location = new System.Drawing.Point(971, 611);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 38);
            this.button5.TabIndex = 91;
            this.button5.Text = "Return";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            //
            // button4
            //
            this.button4.Location = new System.Drawing.Point(12, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 34);
            this.button4.TabIndex = 89;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            //
            // button3
            //
            this.button3.Location = new System.Drawing.Point(12, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 34);
            this.button3.TabIndex = 88;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            //
            // button2
            //
            this.button2.Location = new System.Drawing.Point(12, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 34);
            this.button2.TabIndex = 87;
            this.button2.Text = "Change";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            //
            // button1
            //
            this.button1.Location = new System.Drawing.Point(12, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 34);
            this.button1.TabIndex = 86;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // dataGridView1
            //
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id, this.BrandName, this.HeadCompany, this.ModelName, this.DriveUnit, this.Body, this.Color, this.Type,
            this.EngineName, this.FuelType, this.Capacity, this.HorsePower, this.Tires, this.Width, this.Diameter,
            this.Year, this.Price
        });
            this.dataGridView1.Location = new System.Drawing.Point(205, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(836, 560);
            this.dataGridView1.TabIndex = 85;
            //
            // Id
            //
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            //
            // BrandName
            //
            this.BrandName.HeaderText = "Brand Name";
            this.BrandName.MinimumWidth = 6;
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            this.BrandName.Width = 125;
            //
            // HeadCompany
            //
            this.HeadCompany.HeaderText = "Brand Head Company";
            this.HeadCompany.MinimumWidth = 6;
            this.HeadCompany.Name = "HeadCompany";
            this.HeadCompany.ReadOnly = true;
            this.HeadCompany.Width = 125;
            //
            // ModelName
            //
            this.ModelName.HeaderText = "Model Name";
            this.ModelName.MinimumWidth = 6;
            this.ModelName.Name = "ModelName";
            this.ModelName.ReadOnly = true;
            this.ModelName.Width = 125;
            //
            // DriveUnit
            //
            this.DriveUnit.HeaderText = "Drive Unit";
            this.DriveUnit.MinimumWidth = 6;
            this.DriveUnit.Name = "DriveUnit";
            this.DriveUnit.ReadOnly = true;
            this.DriveUnit.Width = 125;
            //
            // Body
            //
            this.Body.HeaderText = "Car Body";
            this.Body.MinimumWidth = 6;
            this.Body.Name = "Body";
            this.Body.ReadOnly = true;
            this.Body.Width = 125;
            //
            // Color
            //
            this.Color.HeaderText = "Color";
            this.Color.MinimumWidth = 6;
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 125;
            //
            // Type
            //
            this.Type.HeaderText = "Type of Color";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 125;
            //
            // EngineName
            //
            this.EngineName.HeaderText = "Engine Name";
            this.EngineName.MinimumWidth = 6;
            this.EngineName.Name = "EngineName";
            this.EngineName.ReadOnly = true;
            this.EngineName.Width = 125;
            //
            // FuelType
            //
            this.FuelType.HeaderText = "FuelType";
            this.FuelType.MinimumWidth = 6;
            this.FuelType.Name = "FuelType";
            this.FuelType.ReadOnly = true;
            this.FuelType.Width = 125;
            //
            // Capacity
            //
            this.Capacity.HeaderText = "Engine Capacity";
            this.Capacity.MinimumWidth = 6;
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            this.Capacity.Width = 125;
            //
            // HorsePower
            //
            this.HorsePower.HeaderText = "HorsePower";
            this.HorsePower.MinimumWidth = 6;
            this.HorsePower.Name = "HorsePower";
            this.HorsePower.ReadOnly = true;
            this.HorsePower.Width = 125;
            //
            // Tires
            //
            this.Tires.HeaderText = "Tires Brand";
            this.Tires.MinimumWidth = 6;
            this.Tires.Name = "Tires";
            this.Tires.ReadOnly = true;
            this.Tires.Width = 125;
            //
            // Width
            //
            this.Width.HeaderText = "Tires Width";
            this.Width.MinimumWidth = 6;
            this.Width.Name = "Width";
            this.Width.ReadOnly = true;
            this.Width.Width = 125;
            //
            // Diameter
            //
            this.Diameter.HeaderText = "Tires Diameter";
            this.Diameter.MinimumWidth = 6;
            this.Diameter.Name = "Diameter";
            this.Diameter.ReadOnly = true;
            this.Diameter.Width = 125;
            //
            // Year
            //
            this.Year.HeaderText = "Year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 125;
            //
            // Price
            //
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            //
            // Cars
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 661);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Cars";
            this.Text = "Cars";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeadCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriveUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Body;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn EngineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorsePower;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tires;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}
