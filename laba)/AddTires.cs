using System;
using System.Windows.Forms;

namespace laba_
{
    public partial class AddTires : Form
    {
        public AddTires()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                try
                {
                    var tires = new Tires()
                    {
                        Brand = textBox1.Text,
                        Width = float.Parse(numericUpDown1.Value.ToString()),
                        Diameter = float.Parse(numericUpDown2.Value.ToString())
                    };
                    context.Tires.Add(tires);
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
