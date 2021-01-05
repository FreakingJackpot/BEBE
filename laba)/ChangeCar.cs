using System;
using System.Windows.Forms;
namespace laba_
{
    public partial class ChangeCar : Form
    {
        private int Id;

        public ChangeCar(int id)
        {
            this.Id = id;

            InitializeComponent();
            ComboboxesAutoAdders.FullBrandInf(comboBox1);
            ComboboxesAutoAdders.FullModelInf(comboBox2);
            ComboboxesAutoAdders.FullColorInf(comboBox3);
            ComboboxesAutoAdders.FullEnginesInf(comboBox4);
            ComboboxesAutoAdders.FullTiresInf(comboBox5);

            using (var context = new MYDBCONTEXT())
            {
                var car = context.Cars.Find(this.Id);
                comboBox1.SelectedItem = car.Brand.Id + " | " + car.Brand.Name + " | " + car.Brand.HeadCompany;
                comboBox2.SelectedItem =
                    car.Model.Id + " | " + car.Model.Name + " | " + car.Model.DriveUnit + " | " + car.Model.Body;
                comboBox3.SelectedItem = car.Color.Id + " | " + car.Color.Name + " | " + car.Color.Type;
                comboBox4.SelectedItem = car.Engine.Id + " | " + car.Engine.Name + " | " + car.Engine.FuelType + " | " +
                                         car.Engine.FuelCapacity + " | " + car.Engine.HorsePower;
                comboBox5.SelectedItem =
                    car.Tires.Id + " | " + car.Tires.Brand + " | " + car.Tires.Width + " | " + car.Tires.Diameter;
                numericUpDown1.Value = car.Year;
                numericUpDown2.Value = decimal.Parse(car.Price.ToString());
            }
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
                try
                {
                    char[] separator = { ' ', '|', ' ' };
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
                    var change = context.Cars.Find(Id);
                    change.BrandId = car.BrandId;
                    change.ModelId = car.ModelId;
                    change.ColorId = car.ColorId;
                    change.EngineId = car.EngineId;
                    change.TiresId = car.TiresId;
                    change.Year = car.Year;
                    change.Price = car.Price;

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
