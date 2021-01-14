using System;
using System.Windows.Forms;

namespace laba_
{
    public partial class SearchColors : Form
    {
        DataGridView view;
        public SearchColors(DataGridView view)
        {
            InitializeComponent();
            this.view = view;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_db();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            ComboboxesAutoAdders.ColorName(sender);
        }

        private void Update_db()
        {
            string tmp;
            string tmp2;
            tmp = combo1.SelectedItem == null ? "" : combo1.SelectedItem.ToString();
            tmp2 = combo2.SelectedItem == null ? "" : combo2.SelectedItem.ToString();

            SearchModels.ColorSearchModel type = new SearchModels.ColorSearchModel() { Name = tmp, Type = tmp2 };
            SearchingTools tools = new SearchingTools();
            var result = tools.SearchByColorAttributes(type);

            GridFillers.Colors(view, result);

            this.Close();
        }
    }
}
