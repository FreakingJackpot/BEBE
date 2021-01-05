using System;
using System.Windows.Forms;

namespace laba_
{
    public partial class AddModel : Form
    {
        Messages messages = new Messages();
        public AddModel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                try
                {
                    var model = new Model()
                    {
                        Name = textBox1.Text,
                        DriveUnit = comboBox1.SelectedItem.ToString(),
                        Body = comboBox2.SelectedItem.ToString()
                    };
                    context.Models.Add(model);
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
