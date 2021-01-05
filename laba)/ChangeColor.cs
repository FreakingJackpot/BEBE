using System.Windows.Forms;

namespace laba_
{
    public partial class ChangeColor : Form
    {
        private int Id;
        public ChangeColor(int Id, string text1, string text2)
        {
            InitializeComponent();
            this.textBox1.Text = text1;
            this.comboBox1.SelectedItem = text2;
            this.Id = Id;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                try
                {
                    var color = new Color() { Name = textBox1.Text, Type = comboBox1.SelectedItem.ToString() };
                    var change = context.Colors.Find(Id);
                    change.Name = color.Name;
                    change.Type = color.Type;
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
