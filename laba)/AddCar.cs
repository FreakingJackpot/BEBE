using System;
using System.Windows.Forms;

namespace laba_
{
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void comboBox1_DropDown(object sender, System.EventArgs e)
        {
            ComboboxesAutoAdders.FullBrandInf(sender);
        }

        private void comboBox2_DropDown(object sender, System.EventArgs e)
        {
            ComboboxesAutoAdders.FullModelInf(sender);
        }

        private void comboBox3_DropDown(object sender, System.EventArgs e)
        {
            ComboboxesAutoAdders.FullColorInf(sender);
        }

        private void comboBox4_DropDown(object sender, System.EventArgs e)
        {
            ComboboxesAutoAdders.FullEnginesInf(sender);
        }

        private void comboBox5_DropDown(object sender, System.EventArgs e)
        {
            ComboboxesAutoAdders.FullTiresInf(sender);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                char[] separator = { ' ', '|', ' ' };
                try
                {
                    var BrandId = Convert.ToInt32(comboBox1.SelectedItem.ToString().Split(separator)[0]);
                    var ModelId = Convert.ToInt32(comboBox2.SelectedItem.ToString().Split(separator)[0]);
                    var ColorId = Convert.ToInt32(comboBox3.SelectedItem.ToString().Split(separator)[0]);
                    var EngineId = Convert.ToInt32(comboBox4.SelectedItem.ToString().Split(separator)[0]);
                    var TiresId = Convert.ToInt32(comboBox5.SelectedItem.ToString().Split(separator)[0]);

                    var car = new Car()
                    {
                        BrandId = BrandId,
                        ModelId = ModelId,
                        ColorId = ColorId,
                        EngineId = EngineId,
                        TiresId = TiresId,
                        Price = float.Parse(numericUpDown2.Value.ToString()),
                        Year = int.Parse(numericUpDown1.Value.ToString())

                    };
                    context.Cars.Add(car);
                    context.SaveChanges();
                }
                catch
                {
                    Messages.EmptyOrIncorrect();
                }
                finally
                {
                    context.Database.Connection.Close();
                    this.Close();
                }
            }
        }
    }
}
