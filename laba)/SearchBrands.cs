using System;
using System.Windows.Forms;

namespace laba_
{
    public partial class SearchBrands : Form
    {
        DataGridView dataGrid;
        public SearchBrands(DataGridView dataGrid)
        {
            InitializeComponent();
            this.dataGrid = dataGrid;
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

            GridFillers.Brands(dataGrid, result);

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_db();
        }
    }
}
