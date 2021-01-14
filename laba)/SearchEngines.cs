using System;
using System.Linq;
using System.Windows.Forms;

namespace laba_
{
    public partial class SearchEngines : Form
    {
        DataGridView gridView;
        public SearchEngines(DataGridView gridView)
        {
            InitializeComponent();
            this.gridView = gridView;
            ResetFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_db();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            ComboboxesAutoAdders.EngineName(sender);
        }

        private void Update_db()
        {
            string tmp;
            string tmp2;
            float capacitymax;
            float capacitymin;
            float powermax;
            float powermin;

            tmp = combo1.SelectedItem == null ? "" : combo1.SelectedItem.ToString();
            tmp2 = combo2.SelectedItem == null ? "" : combo2.SelectedItem.ToString();
            capacitymax = float.Parse(numericUpDown1.Value.ToString());
            capacitymin = float.Parse(numericUpDown2.Value.ToString());
            powermax = float.Parse(numericUpDown3.Value.ToString());
            powermin = float.Parse(numericUpDown4.Value.ToString());

            SearchModels.EngineSearchModel type = new SearchModels.EngineSearchModel()
            {
                Name = tmp,
                FuelType = tmp2,
                FuelCapacityMax = capacitymax,
                FuelCapacityMin = capacitymin,
                HorsePowerMax = powermax,
                HorsePowerMin = powermin
            };

            SearchingTools tools = new SearchingTools();
            var result = tools.SearchByEngineAttributes(type);

            GridFillers.Engines(gridView, result);

            this.Close();
        }

        private void ResetFields()
        {
            try
            {
                using (var context = new MYDBCONTEXT())
                {
                    combo1.SelectedItem = " ";
                    combo2.SelectedItem = " ";
                    numericUpDown1.Value = decimal.Parse(context.Engines.Max(c => c.FuelCapacity).ToString());
                    numericUpDown2.Value = decimal.Parse(context.Engines.Min(c => c.FuelCapacity).ToString());
                    numericUpDown3.Value = decimal.Parse(context.Engines.Max(c => c.HorsePower).ToString());
                    numericUpDown4.Value = decimal.Parse(context.Engines.Min(c => c.HorsePower).ToString());
                }
            }
            catch
            {
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                numericUpDown1.Value = decimal.Parse(context.Engines.Max(c => c.FuelCapacity).ToString());
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {

                numericUpDown2.Value = decimal.Parse(context.Engines.Min(c => c.FuelCapacity).ToString());
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {

                numericUpDown3.Value = decimal.Parse(context.Engines.Max(c => c.HorsePower).ToString());
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                numericUpDown4.Value = decimal.Parse(context.Engines.Min(c => c.HorsePower).ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ResetFields();
        }
    }
}
