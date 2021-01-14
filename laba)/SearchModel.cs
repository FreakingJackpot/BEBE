using System;
using System.Windows.Forms;

namespace laba_
{
    public partial class SearchModel : Form
    {
        DataGridView dataGrid;
        public SearchModel(DataGridView dataGrid)
        {
            InitializeComponent();
            this.dataGrid = dataGrid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_db();
        }

        private void Update_db()
        {
            string tmp;
            string tmp2;
            string tmp3;
            tmp = combo1.SelectedItem == null ? "" : combo1.SelectedItem.ToString();
            tmp2 = combo2.SelectedItem == null ? "" : combo2.SelectedItem.ToString();
            tmp3 = combo3.SelectedItem == null ? "" : combo3.SelectedItem.ToString();

            SearchModels.ModelSearchModel model =
                new SearchModels.ModelSearchModel() { Name = tmp, DriveUnit = tmp2, Body = tmp3 };
            SearchingTools tools = new SearchingTools();
            var result = tools.SearchByModelAttributes(model);

            GridFillers.Model(dataGrid, result);

            this.Close();
        }

        private void combo1_DropDown(object sender, EventArgs e)
        {
            ComboboxesAutoAdders.ModelName(sender);
        }
    }
}
