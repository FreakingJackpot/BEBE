﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace laba_
{
    public partial class Brands : Form
    {
        Form1 form1;
        public Brands(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            Update_db();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBrand addBrand = new AddBrand();
            addBrand.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                var text1 = dataGridView1.SelectedRows[0].Cells["Brand"].Value.ToString();
                var text2 = dataGridView1.SelectedRows[0].Cells["HeadCompany"].Value.ToString();
                ChangeBrand changeBrand = new ChangeBrand(Id, text1, text2);
                changeBrand.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var result = Messages.DeleteMessage();

                if (result == DialogResult.OK)
                {
                    var Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                    if (Id >= 0)
                    {
                        using (var context = new MYDBCONTEXT())
                        {
                            context.Brands.Remove(context.Brands.Find(Id));
                            context.SaveChanges();
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchBrands searchBrands = new SearchBrands(dataGridView1);
            searchBrands.ShowDialog();
        }

        private void Update_db()
        {

            using (var context = new MYDBCONTEXT())
            {
                var result = context.Brands.OrderBy(c => c.Id).ToList();

                GridFillers.Brands(dataGridView1, result);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }
    }
}
