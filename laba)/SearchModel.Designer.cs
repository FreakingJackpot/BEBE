namespace laba_
{
    partial class SearchModel
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
            this.label1 = new System.Windows.Forms.Label();
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.combo3 = new System.Windows.Forms.ComboBox();
            this.combo2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Model";
            // 
            // combo1
            // 
            this.combo1.FormattingEnabled = true;
            this.combo1.Location = new System.Drawing.Point(12, 30);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(208, 21);
            this.combo1.TabIndex = 33;
            this.combo1.DropDown += new System.EventHandler(this.combo1_DropDown);
            // 
            // combo3
            // 
            this.combo3.FormattingEnabled = true;
            this.combo3.Items.AddRange(new object[] {
            "",
            "SEDAN",
            "COUPE",
            "SPORTS CAR",
            "STATION WAGON",
            "HATCHBACK",
            "CONVERTIBLE",
            "SUV",
            "MINIVAN",
            "PICKUP TRUCK"});
            this.combo3.Location = new System.Drawing.Point(12, 120);
            this.combo3.Name = "combo3";
            this.combo3.Size = new System.Drawing.Size(208, 21);
            this.combo3.TabIndex = 32;
            // 
            // combo2
            // 
            this.combo2.FormattingEnabled = true;
            this.combo2.Items.AddRange(new object[] {
            "",
            "4WD",
            "Forward",
            "Backward"});
            this.combo2.Location = new System.Drawing.Point(12, 75);
            this.combo2.Name = "combo2";
            this.combo2.Size = new System.Drawing.Size(208, 21);
            this.combo2.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Body";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Drive Unit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 46);
            this.button1.TabIndex = 35;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo1);
            this.Controls.Add(this.combo3);
            this.Controls.Add(this.combo2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "SearchModel";
            this.Text = "SearchModel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo1;
        private System.Windows.Forms.ComboBox combo3;
        private System.Windows.Forms.ComboBox combo2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}