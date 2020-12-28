using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace laba_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox_Brand(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            senderComboBox.Items.Clear();
            using (var context = new MYDBCONTEXT())
            {
                var brands = (from Brand in context.Brands select Brand).ToList();
                foreach (var brand in brands)
                    senderComboBox.Items.Add(brand.Name);
            }
            label15.Text = "Status: OK";
        }

        private void comboBox_Model(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            senderComboBox.Items.Clear();
            using (var context = new MYDBCONTEXT())
            {
                var models = (from Model in context.Models select Model).ToList();
                foreach (var model in models)
                    senderComboBox.Items.Add(model.Name + "," + model.DriveUnit);
            }
            label15.Text = "Status: OK";
        }

        private void comboBox_Color(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            senderComboBox.Items.Clear();
            using (var context = new MYDBCONTEXT())
            {
                var colors = (from Color in context.Colors select Color).ToList();
                foreach (var color in colors)
                    senderComboBox.Items.Add(color.Name + "," + color.type);
            }
            label15.Text = "Status: OK";
        }
        private void comboBox_Colo2r(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            senderComboBox.Items.Clear();
            using (var context = new MYDBCONTEXT())
            {
                var colors = (from Color in context.Colors select Color).ToList();
                foreach (var color in colors)
                    senderComboBox.Items.Add(color.Name);
            }
            label15.Text = "Status: OK";
        }

        private void comboBox_Years(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            senderComboBox.Items.Clear();
            using (var context = new MYDBCONTEXT())
            {
                var years = (from Year in context.Years select Year).ToList();
                foreach (var year in years)
                    senderComboBox.Items.Add(year.Value);
            }
            label15.Text = "Status: OK";
        }

        private void comboBox_Engines(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            senderComboBox.Items.Clear();
            using (var context = new MYDBCONTEXT())
            {
                var engines = (from Engine in context.Engines select Engine).ToList();
                foreach (var engine in engines)
                    senderComboBox.Items.Add(engine.Name);
            }
            label15.Text = "Status: OK";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            using (var context = new MYDBCONTEXT())
            {
                try
                {
                    var car = CarFormer(comboBox3, comboBox4, comboBox5, comboBox6, comboBox7, textBox13, context);
                    context.Cars.Add(car);
                    context.SaveChanges();
                    label15.Text = "Status: OK";
                }
                catch
                {
                    label15.Text = "Status: ERROR";
                }
                finally
                {
                    context.Database.Connection.Close();
                }
            }
        }
        private void comboBox_Model2(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            senderComboBox.Items.Clear();
            using (var context = new MYDBCONTEXT())
            {
                var models = (from Model in context.Models select Model).ToList();
                foreach (var model in models)
                    senderComboBox.Items.Add(model.Name);
            }
            label15.Text = "Status: OK";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                try
                {
                    var brand = new Brand() { Name = textBox1.Text };
                    context.Brands.Add(brand);
                    context.SaveChanges();
                    label15.Text = "Status: OK";
                }
                catch
                {
                    label15.Text = "Status: ERROR";
                }
                finally
                {
                    context.Database.Connection.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                try
                {
                    var model = new Model() { Name = textBox2.Text, DriveUnit = comboBox1.SelectedItem.ToString() };
                    context.Models.Add(model);
                    context.SaveChanges();
                    label15.Text = "Status: OK";
                }
                catch
                {
                    label15.Text = "Status: ERROR";
                }
                finally
                {
                    context.Database.Connection.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                try
                {
                    var color = new Color() { Name = textBox3.Text, type = comboBox2.SelectedItem.ToString() };
                    context.Colors.Add(color);
                    context.SaveChanges();
                    label15.Text = "Status: OK";
                }
                catch
                {
                    label15.Text = "Status: ERROR";
                }
                finally
                {
                    context.Database.Connection.Close();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                try
                {
                    var year = new Year() { Value = Convert.ToInt32(textBox4.Text) };
                    context.Years.Add(year);
                    context.SaveChanges();
                    label15.Text = "Status: OK";
                }
                catch
                {
                    label15.Text = "Status: ERROR";
                }
                finally
                {
                    context.Database.Connection.Close();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            using (var context = new MYDBCONTEXT())
            {
                try
                {
                    var Engine = new Engine()
                    {
                        Name = textBox5.Text,
                        Capacity = (float)numericUpDown2.Value,
                        Power = (float)numericUpDown1.Value
                    };
                    context.Engines.Add(Engine);
                    context.SaveChanges();
                    label15.Text = "Status: OK";
                }
                catch
                {
                    label15.Text = "Status: ERROR";
                }
                finally
                {
                    context.Database.Connection.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                try
                {
                    var car = CarFormer(comboBox12, comboBox11, comboBox10, comboBox9, comboBox8, textBox6, context);
                    var cars =
                        (from Car in context.Cars
                         where (Car.BrandId == car.BrandId) && (Car.ModelId == car.ModelId) &&
(Car.ColorId == car.ColorId) && (Car.EngineId == car.EngineId) && (Car.Price == car.Price) &&
(Car.YearId == car.YearId)
                         select Car)
                            .ToList();

                    CarGridViewFormer(dataGridView2,
                                      new string[] { "Id", "Brand", "Model", "Drive unit", "Color", "Type Color", "Year",
                                                 "Price", "Engine", "Capacity", "Power" },
                                      cars);
                    label15.Text = "Status: OK";
                }

                catch
                {
                    label15.Text = "Status: ERROR";
                }
                finally
                {
                    context.Database.Connection.Close();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            List<int> ids = new List<int>();
            try
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[11].Value))
                    {
                        ids.Add(Convert.ToInt32(row.Cells[0].Value));
                    }
                }
            }
            catch
            {
                label15.Text = "Status: ERROR";
            }
            if (ids.Count != 0)
            {

                using (var context = new MYDBCONTEXT())
                {
                    try
                    {
                        var car = CarFormer(comboBox19, comboBox18, comboBox17, comboBox16, comboBox15, textBox12, context);

                        foreach (var id in ids)
                        {
                            var carchange = context.Cars.Find(id);
                            carchange.BrandId = car.BrandId;
                            carchange.ModelId = car.ModelId;
                            carchange.ColorId = car.ColorId;
                            carchange.YearId = car.YearId;
                            carchange.EngineId = car.EngineId;
                            carchange.Price = car.Price;
                            context.Entry(carchange).State = EntityState.Modified;
                            context.SaveChanges();
                        }
                    }
                    catch
                    {
                        label15.Text = "Status: ERROR";
                    }
                    finally
                    {
                    }
                }
            }
        }
        private Car CarFormer(ComboBox combo, ComboBox combo1, ComboBox combo2, ComboBox combo3, ComboBox combo4,
                              TextBox textBox, MYDBCONTEXT context)
        {
            try
            {
                var tmp = combo1.SelectedItem.ToString().Split(',')[0];
                var tmp2 = combo1.SelectedItem.ToString().Split(',')[1];
                var tmp3 = combo2.SelectedItem.ToString().Split(',')[0];
                var tmp4 = combo2.SelectedItem.ToString().Split(',')[1];
                var tmp5 = Convert.ToInt32(combo3.SelectedItem.ToString());
                var car = new Car()
                {
                    BrandId = (from Brand in context.Brands where Brand.Name == combo.SelectedItem.ToString() select Brand.Id).ToList()[0],
                    ModelId = (from Model in context.Models where (Model.Name == tmp) && (Model.DriveUnit == tmp2) select Model.Id).ToList()[0],
                    ColorId = (from Color in context.Colors where (Color.Name == tmp3) && (Color.type == tmp4) select Color.Id).ToList()[0],
                    YearId = (from Year in context.Years where Year.Value == tmp5 select Year.Id).ToList()[0],
                    EngineId = (from Engine in context.Engines where Engine.Name == combo4.SelectedItem.ToString() select Engine.Id).ToList()[0],
                    Price = float.Parse(textBox.Text)
                };
                return car;
            }
            catch
            {
                label15.Text = "Status:ERROR";
                return null;
            }
        }

        private void CarGridViewFormer(DataGridView dataGrid, string[] vs, List<Car> cars)
        {
            DataGridViewCleaner(dataGrid);
            var change = CheckBoxColumnFormer();
            foreach (var str in vs)
            {
                dataGrid.Columns.Add(str, str);
            }
            foreach (var item in cars)
            {
                dataGrid.Rows.Add(item.Id, item.Brand.Name, item.Model.Name, item.Model.DriveUnit, item.Color.Name,
                                  item.Color.type, item.Year.Value, item.Price, item.Engine.Name, item.Engine.Capacity,
                                  item.Engine.Power);
            }
            dataGrid.Columns.Insert(11, change);
        }
        private DataGridViewCheckBoxColumn CheckBoxColumnFormer()
        {
            DataGridViewCheckBoxColumn change = new DataGridViewCheckBoxColumn();
            change.HeaderText = "To change";
            change.ValueType = typeof(bool);
            change.Name = "Chk";
            return change;
        }
        private void DataGridViewCleaner(DataGridView dataGrid)
        {
            dataGrid.Columns.Clear();
            dataGrid.Rows.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            using (var context = new MYDBCONTEXT())
            {
                try
                {
                    int id = (from Brand in context.Brands where Brand.Name == comboBox20.SelectedItem.ToString() select Brand.Id).ToList()[0];
                    var brand = new Brand() { Name = textBox7.Text };
                    var brandchange = context.Brands.Find(id);
                    brandchange.Name = brand.Name;
                    context.Entry(brandchange).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch
                {
                    label15.Text = "Status: ERROR";
                }
                finally
                {
                    context.Database.Connection.Close();
                }
            }
        }
        private void ModelGridViewFormer(DataGridView dataGrid, string[] vs, List<Model> models)
        {
            DataGridViewCleaner(dataGrid);
            var change = CheckBoxColumnFormer();
            foreach (var str in vs)
            {
                dataGrid.Columns.Add(str, str);
            }
            foreach (var item in models)
            {
                dataGrid.Rows.Add(item.Id, item.Name, item.DriveUnit);
            }
            dataGrid.Columns.Insert(3, change);
        }

        private int GetModelId(ComboBox combo, MYDBCONTEXT context)
        {
            var tmp = combo.SelectedItem.ToString().Split(',')[0];
            var tmp2 = combo.SelectedItem.ToString().Split(',')[1];
            return (from Model in context.Models where Model.Name == tmp && Model.DriveUnit == tmp2 select Model.Id).ToList()[0];
        }

        private void button15_Click(object sender, EventArgs e)
        {

            using (var context = new MYDBCONTEXT())
            {
                try
                {
                    int id = GetModelId(comboBox22, context);

                    var model = new Model() { Name = textBox14.Text, DriveUnit = comboBox21.SelectedItem.ToString() };
                    var modelchange = context.Models.Find(id);
                    modelchange.Name = model.Name;
                    modelchange.DriveUnit = model.DriveUnit;
                    context.Entry(modelchange).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch
                {
                    label15.Text = "Status: ERROR";
                }
                finally
                {
                    context.Database.Connection.Close();
                }
            }
        }

        private int GetColorId(ComboBox combo, MYDBCONTEXT context)
        {
            var tmp = combo.SelectedItem.ToString().Split(',')[0];
            var tmp2 = combo.SelectedItem.ToString().Split(',')[1];
            return (from Color in context.Colors where Color.Name == tmp && Color.type == tmp2 select Color.Id).ToList()[0];
        }

        private void button16_Click(object sender, EventArgs e)
        {

            using (var context = new MYDBCONTEXT())
            {
                try
                {
                    int id = GetColorId(comboBox13, context);

                    var color = new Color() { Name = textBox8.Text, type = comboBox14.SelectedItem.ToString() };
                    var colorchange = context.Colors.Find(id);
                    colorchange.Name = color.Name;
                    colorchange.type = color.type;
                    context.Entry(colorchange).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch
                {
                    label15.Text = "Status: ERROR";
                }
                finally
                {
                    context.Database.Connection.Close();
                }
            }
        }

        private int GetYearId(ComboBox combo, MYDBCONTEXT context)
        {
            var tmp = Convert.ToInt32(combo.SelectedItem.ToString());
            return (from Year in context.Years where Year.Value == tmp select Year.Id).ToList()[0];
        }

        private void button17_Click(object sender, EventArgs e)
        {

            using (var context = new MYDBCONTEXT())
            {

                int id = GetYearId(comboBox23, context);
                try
                {

                    var year = new Year() { Value = Convert.ToInt32(textBox10.Text) };
                    var yearchange = context.Years.Find(id);
                    yearchange.Value = year.Value;
                    context.Entry(yearchange).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch
                {
                    label15.Text = "Status: ERROR";
                }
                finally
                {
                    context.Database.Connection.Close();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                var engines = EngineListFormer(comboBox24, context);
                EngineGridViewFormer(dataGridView6, new string[] { "Id", "Name", "Capacity", "Power" }, engines);
            }
        }
        private void EngineGridViewFormer(DataGridView dataGrid, string[] vs, List<Engine> models)
        {
            DataGridViewCleaner(dataGrid);
            var change = CheckBoxColumnFormer();
            foreach (var str in vs)
            {
                dataGrid.Columns.Add(str, str);
            }
            foreach (var item in models)
            {
                dataGrid.Rows.Add(item.Id, item.Name, item.Capacity, item.Power);
            }
            dataGrid.Columns.Insert(4, change);
        }

        private List<Engine> EngineListFormer(ComboBox combo, MYDBCONTEXT context)
        {
            var tmp = combo.SelectedItem.ToString();
            return (from Engine in context.Engines where Engine.Name == tmp select Engine).ToList();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int id = -1;
            try
            {
                if (Convert.ToBoolean(dataGridView6.Rows[0].Cells[4].Value))
                {
                    id = Convert.ToInt32(dataGridView6.Rows[0].Cells[0].Value);
                }
            }
            catch
            {
                label15.Text = "Status: ERROR";
            }

            if (id != -1)
            {
                using (var context = new MYDBCONTEXT())
                {
                    try
                    {

                        var engine = new Engine()
                        {
                            Name = textBox9.Text,
                            Capacity = float.Parse(numericUpDown5.Text),
                            Power = float.Parse(numericUpDown6.Text)
                        };
                        var enginechange = context.Engines.Find(id);
                        enginechange.Name = engine.Name;
                        enginechange.Capacity = engine.Capacity;
                        enginechange.Power = engine.Power;
                        context.Entry(enginechange).State = EntityState.Modified;
                        context.SaveChanges();
                    }
                    catch
                    {
                        label15.Text = "Status: ERROR";
                    }
                    finally
                    {
                        context.Database.Connection.Close();
                    }
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                try
                {
                    var car = CarFormer(comboBox34, comboBox33, comboBox32, comboBox31, comboBox30, textBox15, context);
                    var cars =
                        (from Car in context.Cars
                         where (Car.BrandId == car.BrandId) && (Car.ModelId == car.ModelId) &&
(Car.ColorId == car.ColorId) && (Car.EngineId == car.EngineId) && (Car.Price == car.Price) &&
(Car.YearId == car.YearId)
                         select Car)
                            .ToList();

                    CarGridViewFormer(dataGridView7,
                                      new string[] { "Id", "Brand", "Model", "Drive unit", "Color", "Type Color", "Year",
                                                 "Price", "Engine", "Capacity", "Power" },
                                      cars);
                    label15.Text = "Status: OK";
                }

                catch
                {
                    label15.Text = "Status: ERROR";
                }
                finally
                {
                    context.Database.Connection.Close();
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            try
            {
                foreach (DataGridViewRow row in dataGridView7.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[11].Value))
                    {
                        ids.Add(Convert.ToInt32(row.Cells[0].Value));
                    }
                }
            }
            catch
            {
                label15.Text = "Status: ERROR";
            }
            if (ids.Count != 0)
            {

                using (var context = new MYDBCONTEXT())
                {
                    try
                    {

                        foreach (var id in ids)
                        {
                            context.Cars.Remove(context.Cars.Find(id));
                            context.SaveChanges();
                        }
                    }
                    catch
                    {
                        label15.Text = "Status: ERROR";
                    }
                    finally
                    {
                    }
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                var brand = (from Brand in context.Brands where Brand.Name == comboBox35.SelectedItem.ToString() select Brand).ToList()[0];
                context.Brands.Remove(brand);
                context.SaveChanges();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                var tmp = comboBox36.SelectedItem.ToString().Split(',')[0];
                var tmp2 = comboBox36.SelectedItem.ToString().Split(',')[1];
                var model =
                    (from Model in context.Models where (Model.Name == tmp) && (Model.DriveUnit == tmp2) select Model)
                        .ToList()[0];
                context.Models.Remove(model);
                context.SaveChanges();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                var tmp3 = comboBox39.SelectedItem.ToString().Split(',')[0];
                var tmp4 = comboBox39.SelectedItem.ToString().Split(',')[1];
                var color = (from Color in context.Colors where (Color.Name == tmp3) && (Color.type == tmp4) select Color)
                                .ToList()[0];
                context.Colors.Remove(color);
                context.SaveChanges();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                var tmp5 = Convert.ToInt32(comboBox40.SelectedItem.ToString());
                var year = (from Year in context.Years where Year.Value == tmp5 select Year).ToList()[0];
                context.Years.Remove(year);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {

            using (var context = new MYDBCONTEXT())
            {
                var engine = (from Engine in context.Engines where Engine.Name == comboBox41.SelectedItem.ToString() select Engine).ToList()[0];
                context.Engines.Remove(engine);
            }
        }

        private void Updatedb(object sender, EventArgs e)
        {
            Search("!", dataGridView1);
        }

        private void SearchByBrand(object sender, EventArgs e)
        {
            Search("brand", dataGridView3);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Search("model", dataGridView4);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Search("color", dataGridView5);
        }

        private void Search(string typeofsearch, DataGridView dataGrid)
        {
            using (var context = new MYDBCONTEXT())
            {
                try
                {
                    List<Car> cars;
                    if (typeofsearch == "brand")
                    {
                        cars = (from Car in context.Cars where Car.Brand.Name == comboBox25.SelectedItem.ToString() select Car).ToList();
                    }
                    else if (typeofsearch == "model")
                    {
                        if (comboBox26.SelectedItem.ToString() == "ALL")
                        {
                            cars = (from Car in context.Cars where Car.Model.Name == comboBox27.SelectedItem.ToString() select Car).ToList();
                        }
                        else
                        {
                            cars = (from Car in context.Cars where Car.Model.Name == comboBox27.SelectedItem.ToString() && Car.Model.DriveUnit == comboBox26.SelectedItem.ToString() select Car).ToList();
                        }
                    }
                    else if (typeofsearch == "color")
                    {

                        if (comboBox28.SelectedItem.ToString() == "ALL")
                        {
                            cars = (from Car in context.Cars where Car.Color.Name == comboBox29.SelectedItem.ToString() select Car).ToList();
                        }
                        else
                        {
                            cars = (from Car in context.Cars where Car.Color.Name == comboBox29.SelectedItem.ToString() && Car.Color.type == comboBox28.SelectedItem.ToString() select Car).ToList();
                        }
                    }
                    else if (typeofsearch == "year")
                    {
                        int tmp = Convert.ToInt32(comboBox37.SelectedItem.ToString());
                        cars = (from Car in context.Cars where Car.Year.Value == tmp select Car).ToList();
                    }
                    else if (typeofsearch == "engine")
                    {
                        cars = (from Car in context.Cars where Car.Engine.Name == comboBox38.SelectedItem.ToString() select Car).ToList();
                    }
                    else if (typeofsearch == "capacity")
                    {
                        if (radioButton1.Checked)
                        {
                            float min = context.Engines.Min(c => c.Capacity);
                            cars = (from Car in context.Cars where Car.Engine.Capacity == min select Car).ToList();
                        }
                        else if (radioButton2.Checked)
                        {
                            float max = context.Engines.Max(c => c.Capacity);
                            cars = (from Car in context.Cars where Car.Engine.Capacity == max select Car).ToList();
                        }
                        else
                            return;
                    }
                    else if (typeofsearch == "power")
                    {
                        if (radioButton4.Checked)
                        {
                            float min = context.Engines.Min(c => c.Power);
                            cars = (from Car in context.Cars where Car.Engine.Power == min select Car).ToList();
                        }
                        else if (radioButton3.Checked)
                        {
                            float max = context.Engines.Max(c => c.Power);
                            cars = (from Car in context.Cars where Car.Engine.Power == max select Car).ToList();
                        }
                        else
                            return;
                    }
                    else if (typeofsearch == "price")
                    {
                        if (numericUpDown3.Value == 0 && numericUpDown4.Value != 0)
                        {
                            cars = (from Car in context.Cars where Car.Price <= (float)numericUpDown4.Value select Car).ToList();
                        }
                        else if (numericUpDown3.Value != 0 && numericUpDown4.Value == 0)
                        {
                            cars = (from Car in context.Cars where Car.Price >= (float)numericUpDown3.Value select Car).ToList();
                        }
                        else if (numericUpDown3.Value != 0 && numericUpDown4.Value != 0)
                        {
                            cars = (from Car in context.Cars where Car.Price >= (float)numericUpDown3.Value && Car.Price <= (float)numericUpDown4.Value select Car).ToList();
                        }
                        else
                            return;
                    }
                    else
                    {
                        cars = (from Car in context.Cars select Car).ToList();
                    }
                    CarGridViewFormer(dataGrid,
                                      new string[] { "Id", "Brand", "Model", "Drive unit", "Color", "Type Color", "Year",
                                                 "Price", "Engine", "Capacity", "Power" },
                                      cars);
                    label15.Text = "Status: OK";
                }
                catch
                {
                    label15.Text = "Status: ERROR";
                }
                finally
                {
                    context.Database.Connection.Close();
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Search("year", dataGridView8);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Search("engine", dataGridView9);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Search("capacity", dataGridView10);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Search("power", dataGridView11);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Search("price", dataGridView12);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
