namespace laba_
{
    partial class Engines
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
            this.Engine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorsePower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(680, 400);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 38);
            this.button5.TabIndex = 51;
            this.button5.Text = "Return";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 34);
            this.button4.TabIndex = 46;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 101);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 34);
            this.button3.TabIndex = 45;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 34);
            this.button2.TabIndex = 44;
            this.button2.Text = "Change";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 34);
            this.button1.TabIndex = 43;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Engine,
            this.FuelType,
            this.FuelCapacity,
            this.HorsePower});
            this.dataGridView1.Location = new System.Drawing.Point(204, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(547, 382);
            this.dataGridView1.TabIndex = 42;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // Engine
            // 
            this.Engine.HeaderText = "Engine";
            this.Engine.MinimumWidth = 6;
            this.Engine.Name = "Engine";
            this.Engine.ReadOnly = true;
            this.Engine.Width = 125;
            // 
            // FuelType
            // 
            this.FuelType.HeaderText = "Fuel Type";
            this.FuelType.MinimumWidth = 6;
            this.FuelType.Name = "FuelType";
            this.FuelType.ReadOnly = true;
            this.FuelType.Width = 125;
            // 
            // FuelCapacity
            // 
            this.FuelCapacity.HeaderText = "Fuel Capacity";
            this.FuelCapacity.MinimumWidth = 6;
            this.FuelCapacity.Name = "FuelCapacity";
            this.FuelCapacity.ReadOnly = true;
            this.FuelCapacity.Width = 125;
            // 
            // HorsePower
            // 
            this.HorsePower.HeaderText = "Horse Power";
            this.HorsePower.MinimumWidth = 6;
            this.HorsePower.Name = "HorsePower";
            this.HorsePower.ReadOnly = true;
            this.HorsePower.Width = 125;
            // 
            // Engines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Engines";
            this.Text = "Engines";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Engine;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorsePower;
    }
}
