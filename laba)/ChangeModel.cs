using System.Windows.Forms;

namespace laba_
{
    public partial class ChangeModel : Form
    {
        private int Id;
        public ChangeModel(int Id, string text1, string cmb1, string cmb2)
        {
            InitializeComponent();
            this.textBox1.Text = text1;
            this.comboBox1.SelectedItem = cmb1;
            this.comboBox2.SelectedItem = cmb2;
            this.Id = Id;
        }

        private void button1_Click(object sender, System.EventArgs e)
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
                    var change = context.Models.Find(Id);
                    change.Name = model.Name;
                    change.DriveUnit = model.DriveUnit;
                    change.Body = model.Body;
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
