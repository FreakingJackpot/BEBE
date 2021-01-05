using System;
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
            Update_db();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            ComboboxesAutoAdders.BrandName(sender);
        }
        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            ComboboxesAutoAdders.HeadCompany(sender);
        }
        private void Update_db()
        {
            string tmp;
            string tmp2;
            tmp = comboBox1.SelectedItem == null ? "" : comboBox1.SelectedItem.ToString();
            tmp2 = comboBox2.SelectedItem == null ? "" : comboBox2.SelectedItem.ToString();

            SearchModels.BrandSearchModel brand = new SearchModels.BrandSearchModel() { Name = tmp, HeadCompany = tmp2 };
            SearchingTools tools = new SearchingTools();
            var result = tools.SearchByBrandAttributes(brand);

            dataGridView1.Rows.Clear();
            for (int i = 0; i < result.Count; i++)
            {
                dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells["id"].Value = result[i].Id;
                row.Cells["Brand"].Value = result[i].Name;
                row.Cells["HeadCompany"].Value = result[i].HeadCompany;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }
    }
}
