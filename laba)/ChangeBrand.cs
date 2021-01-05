using System.Windows.Forms;
namespace laba_
{
    public partial class ChangeBrand : Form
    {
        private int Id;
        public ChangeBrand()
        {
            InitializeComponent();
        }
        public ChangeBrand(int Id, string text1, string text2)
        {
            InitializeComponent();
            this.textBox1.Text = text1;
            this.textBox2.Text = text2;
            this.Id = Id;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            using (var context = new MYDBCONTEXT())
            {
                try
                {
                    var brand = new Brand() { Name = textBox1.Text, HeadCompany = textBox2.Text };
                    var change = context.Brands.Find(Id);
                    change.Name = brand.Name;
                    change.HeadCompany = brand.HeadCompany;
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
