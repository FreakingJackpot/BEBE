﻿using System;
using System.Linq;
using System.Windows.Forms;
namespace laba_
{
    public partial class SearchCars : Form
    {

        DataGridView dataGrid;
        public SearchCars(DataGridView dataGrid)
        {
            InitializeComponent();
            ResetFields();
            this.dataGrid = dataGrid;
        }
        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            ComboboxesAutoAdders.BrandName(sender);
        }

        private void comboBox1_DropDown_1(object sender, EventArgs e)
        {
            ComboboxesAutoAdders.HeadCompany(sender);
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            ComboboxesAutoAdders.ModelName(sender);
        }

        private void comboBox3_DropDown(object sender, EventArgs e)
        {
            ComboboxesAutoAdders.ColorName(sender);
        }

        private void comboBox5_DropDown(object sender, EventArgs e)
        {
            ComboboxesAutoAdders.EngineName(sender);
        }

        private void comboBox7_DropDown(object sender, EventArgs e)
        {
            ComboboxesAutoAdders.TiresBrand(sender);
        }

        private void label19_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                numericUpDown8.Value = decimal.Parse(context.Engines.Max(c => c.FuelCapacity).ToString());
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                numericUpDown7.Value = decimal.Parse(context.Engines.Min(c => c.FuelCapacity).ToString());
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                numericUpDown6.Value = decimal.Parse(context.Engines.Max(c => c.HorsePower).ToString());
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                numericUpDown5.Value = decimal.Parse(context.Engines.Min(c => c.HorsePower).ToString());
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                numericUpDown1.Value = decimal.Parse(context.Tires.Max(c => c.Width).ToString());
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                numericUpDown2.Value = decimal.Parse(context.Tires.Min(c => c.Width).ToString());
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {

                numericUpDown3.Value = decimal.Parse(context.Tires.Max(c => c.Diameter).ToString());
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {

                numericUpDown4.Value = decimal.Parse(context.Tires.Min(c => c.Diameter).ToString());
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {

                numericUpDown12.Value = decimal.Parse(context.Cars.Max(c => c.Year).ToString());
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {

                numericUpDown11.Value = decimal.Parse(context.Cars.Min(c => c.Year).ToString());
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {

                numericUpDown10.Value = decimal.Parse(context.Cars.Max(c => c.Price).ToString());
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {

                numericUpDown9.Value = decimal.Parse(context.Cars.Min(c => c.Price).ToString());
            }
        }
        private void ResetFields()
        {
            try
            {
                using (var context = new MYDBCONTEXT())
                {
                    combo1.SelectedItem = "";
                    combo2.SelectedItem = "";
                    comboBox1.SelectedItem = "";
                    comboBox2.SelectedItem = "";
                    combo3.SelectedItem = "";
                    comboBox3.SelectedItem = "";
                    comboBox4.SelectedItem = "";
                    comboBox5.SelectedItem = "";
                    comboBox6.SelectedItem = "";
                    comboBox7.SelectedItem = "";

                    numericUpDown8.Value = decimal.Parse(context.Engines.Max(c => c.FuelCapacity).ToString());
                    numericUpDown7.Value = decimal.Parse(context.Engines.Min(c => c.FuelCapacity).ToString());
                    numericUpDown6.Value = decimal.Parse(context.Engines.Max(c => c.HorsePower).ToString());
                    numericUpDown5.Value = decimal.Parse(context.Engines.Min(c => c.HorsePower).ToString());

                    numericUpDown1.Value = decimal.Parse(context.Tires.Max(c => c.Width).ToString());
                    numericUpDown2.Value = decimal.Parse(context.Tires.Min(c => c.Width).ToString());
                    numericUpDown3.Value = decimal.Parse(context.Tires.Max(c => c.Diameter).ToString());
                    numericUpDown4.Value = decimal.Parse(context.Tires.Min(c => c.Diameter).ToString());

                    numericUpDown12.Value = decimal.Parse(context.Cars.Max(c => c.Year).ToString());
                    numericUpDown11.Value = decimal.Parse(context.Cars.Min(c => c.Year).ToString());

                    numericUpDown10.Value = decimal.Parse(context.Cars.Max(c => c.Price).ToString());
                    numericUpDown9.Value = decimal.Parse(context.Cars.Min(c => c.Price).ToString());
                }
            }
            catch
            {
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchModels.BrandSearchModel brand = new SearchModels.BrandSearchModel()
            {
                Name = combo1.SelectedItem == null ? "" : combo1.SelectedItem.ToString(),
                HeadCompany = comboBox1.SelectedItem == null ? "" : comboBox1.SelectedItem.ToString()
            };

            SearchModels.ModelSearchModel model = new SearchModels.ModelSearchModel()
            {
                Name = comboBox2.SelectedItem == null ? "" : comboBox2.SelectedItem.ToString(),
                DriveUnit = combo2.SelectedItem == null ? "" : combo2.SelectedItem.ToString(),
                Body = combo3.SelectedItem == null ? "" : combo3.SelectedItem.ToString()
            };

            SearchModels.ColorSearchModel color = new SearchModels.ColorSearchModel()
            {
                Name = comboBox3.SelectedItem == null ? "" : comboBox3.SelectedItem.ToString(),
                Type = comboBox4.SelectedItem == null ? "" : comboBox4.SelectedItem.ToString()
            };

            SearchModels.EngineSearchModel engine = new SearchModels.EngineSearchModel()
            {
                Name = comboBox5.SelectedItem == null ? "" : comboBox5.SelectedItem.ToString(),
                FuelType = comboBox6.SelectedItem == null ? "" : comboBox6.SelectedItem.ToString(),
                FuelCapacityMax = float.Parse(numericUpDown8.Value.ToString()),
                FuelCapacityMin = float.Parse(numericUpDown7.Value.ToString()),
                HorsePowerMax = float.Parse(numericUpDown6.Value.ToString()),
                HorsePowerMin = float.Parse(numericUpDown5.Value.ToString())

            };

            SearchModels.TiresSearchModel tires = new SearchModels.TiresSearchModel()
            {
                Brand = comboBox7.SelectedItem == null ? "" : comboBox7.SelectedItem.ToString(),
                WidthMax = float.Parse(numericUpDown1.Value.ToString()),
                WidthMin = float.Parse(numericUpDown2.Value.ToString()),
                DiameterMax = float.Parse(numericUpDown3.Value.ToString()),
                DiameterMin = float.Parse(numericUpDown4.Value.ToString())
            };

            var pricemax = float.Parse(numericUpDown10.Value.ToString());
            var pricemin = float.Parse(numericUpDown9.Value.ToString());

            var yearmax = int.Parse(numericUpDown12.Value.ToString());
            var yearmin = int.Parse(numericUpDown11.Value.ToString());

            using (var context = new MYDBCONTEXT())
            {
                SearchingTools tools = new SearchingTools();
                var result = tools.SearchByCarAttributes(brand, model, color, engine, tires, pricemax, pricemin, yearmax,
                                                         yearmin, context);
                GridFillers.Cars(dataGrid, result);
                this.Close();
            }
        }
    }
}
