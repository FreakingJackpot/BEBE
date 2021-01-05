using System.Windows.Forms;

namespace laba_
{
    public partial class AddBrand : Form
    {
        public AddBrand()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                try
                {
                    var brand = new Brand() { Name = textBox1.Text, HeadCompany = textBox2.Text };
                    context.Brands.Add(brand);
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
