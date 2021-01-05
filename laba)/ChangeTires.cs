using System;
using System.Windows.Forms;

namespace laba_
{
    public partial class ChangeTires : Form
    {
        private int Id;
        public ChangeTires(int Id, string text1, string float1, string float2)
        {
            InitializeComponent();
            this.textBox1.Text = text1;
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
                    var tires = new Tires()
                    {
                        Brand = textBox1.Text,
                        Width = float.Parse(numericUpDown1.Value.ToString()),
                        Diameter = float.Parse(numericUpDown2.Value.ToString())
                    };
                    var change = context.Tires.Find(Id);
                    change.Brand = tires.Brand;
                    change.Width = tires.Width;
                    change.Diameter = tires.Diameter;
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
