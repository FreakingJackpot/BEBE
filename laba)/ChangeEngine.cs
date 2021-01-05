using System;
using System.Windows.Forms;

namespace laba_
{
    public partial class ChangeEngine : Form
    {
        private int Id;
        public ChangeEngine(int Id, string text1, string text2, string float1, string float2)
        {
            InitializeComponent();
            this.textBox1.Text = text1;
            this.comboBox1.SelectedItem = text2;
            this.numericUpDown1.Value = decimal.Parse(float1);
            this.numericUpDown2.Value = decimal.Parse(float2);
            this.Id = Id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                try
                {
                    var engine = new Engine()
                    {
                        Name = textBox1.Text,
                        FuelType = comboBox1.SelectedItem.ToString(),
                        FuelCapacity = float.Parse(numericUpDown1.Value.ToString()),
                        HorsePower = float.Parse(numericUpDown2.Value.ToString())
                    };
                    var change = context.Engines.Find(Id);
                    change.Name = engine.Name;
                    change.FuelType = engine.FuelType;
                    change.FuelCapacity = engine.FuelCapacity;
                    change.HorsePower = engine.HorsePower;
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
