using System;
using System.Windows.Forms;

namespace laba_
{
    public partial class AddEngine : Form
    {
        public AddEngine()
        {
            InitializeComponent();
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
                    context.Engines.Add(engine);
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
