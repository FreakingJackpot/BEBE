using System;
using System.Linq;
using System.Windows.Forms;

namespace laba_
{
    public partial class Engines : Form
    {
        Form1 form1;
        public Engines(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            ResetFields();
            Update_db();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEngine addEngine = new AddEngine();
            addEngine.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                var text1 = dataGridView1.SelectedRows[0].Cells["Engine"].Value.ToString();
                var text2 = dataGridView1.SelectedRows[0].Cells["FuelType"].Value.ToString();
                var float1 = dataGridView1.SelectedRows[0].Cells["FuelCapacity"].Value.ToString();
                var float2 = dataGridView1.SelectedRows[0].Cells["HorsePower"].Value.ToString();
                ChangeEngine changeEngine = new ChangeEngine(Id, text1, text2, float1, float2);
                changeEngine.ShowDialog();
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
                            context.Engines.Remove(context.Engines.Find(Id));
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

            dataGridView1.Rows.Clear();
            for (int i = 0; i < result.Count; i++)
            {
                dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells["id"].Value = result[i].Id;
                row.Cells["Engine"].Value = result[i].Name;
                row.Cells["FuelType"].Value = result[i].FuelType;
                row.Cells["FuelCapacity"].Value = result[i].FuelCapacity;
                row.Cells["HorsePower"].Value = result[i].HorsePower;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ResetFields();
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
    }
}
