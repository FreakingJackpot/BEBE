using System;
using System.Linq;
using System.Windows.Forms;

namespace laba_
{
    public partial class SearchTires : Form
    {
        DataGridView gridView;
        public SearchTires(DataGridView view)
        {
            InitializeComponent();
            this.gridView = view;
            ResetFields();
        }

        private void Update_db()
        {
            string tmp;
            float widthmax;
            float widthmin;
            float diametermax;
            float diametermin;

            tmp = combo1.SelectedItem == null ? "" : combo1.SelectedItem.ToString();
            widthmax = float.Parse(numericUpDown1.Value.ToString());
            widthmin = float.Parse(numericUpDown2.Value.ToString());
            diametermax = float.Parse(numericUpDown3.Value.ToString());
            diametermin = float.Parse(numericUpDown4.Value.ToString());

            SearchModels.TiresSearchModel type =
                new SearchModels.TiresSearchModel()
                {
                    Brand = tmp,
                    WidthMax = widthmax,
                    WidthMin = widthmin,
                    DiameterMax = diametermax,
                    DiameterMin = diametermin
                };

            SearchingTools tools = new SearchingTools();
            var result = tools.SearchByTiresAttributes(type);

            GridFillers.Tires(gridView, result);

            this.Close();
        }

        private void ResetFields()
        {
            try
            {
                using (var context = new MYDBCONTEXT())
                {

                    combo1.SelectedItem = " ";
                    numericUpDown1.Value = decimal.Parse(context.Tires.Max(p => p.Width).ToString());
                    numericUpDown2.Value = decimal.Parse(context.Tires.Min(p => p.Width).ToString());
                    numericUpDown3.Value = decimal.Parse(context.Tires.Max(p => p.Diameter).ToString());
                    numericUpDown4.Value = decimal.Parse(context.Tires.Min(p => p.Diameter).ToString());
                }
            }
            catch
            {
            }
        }
        private void comboBox7_DropDown(object sender, EventArgs e)
        {
            ComboboxesAutoAdders.TiresBrand(sender);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {

                numericUpDown1.Value = decimal.Parse(context.Tires.Max(p => p.Width).ToString());
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {

                numericUpDown2.Value = decimal.Parse(context.Tires.Min(p => p.Width).ToString());
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {

                numericUpDown3.Value = decimal.Parse(context.Tires.Max(p => p.Diameter).ToString());
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {

                numericUpDown4.Value = decimal.Parse(context.Tires.Min(p => p.Diameter).ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_db();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ResetFields();
        }
    }

}
