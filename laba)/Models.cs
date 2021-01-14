using System;
using System.Linq;
using System.Windows.Forms;
namespace laba_
{
    public partial class Models : Form
    {
        Form1 form1;

        public Models(Form1 form)
        {
            form1 = form;
            InitializeComponent();
            Update_db();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddModel addModel = new AddModel();
            addModel.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                var text1 = dataGridView1.SelectedRows[0].Cells["Model"].Value.ToString();
                var cmb1 = dataGridView1.SelectedRows[0].Cells["DriveUnit"].Value.ToString();
                var cmb2 = dataGridView1.SelectedRows[0].Cells["Body"].Value.ToString();
                ChangeModel changeModel = new ChangeModel(Id, text1, cmb1, cmb2);
                changeModel.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var result = Messages.DeleteMessage();

                if (result == DialogResult.OK)
                {
                    var Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                    if (Id >= 0)
                    {
                        using (var context = new MYDBCONTEXT())
                        {
                            context.Models.Remove(context.Models.Find(Id));
                            context.SaveChanges();
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchModel search = new SearchModel(dataGridView1);
            search.ShowDialog();
        }

        private void Update_db()
        {

            using (var context = new MYDBCONTEXT())
            {
                var result = context.Models.OrderBy(c => c.Id).ToList();
                GridFillers.Model(dataGridView1, result);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }
    }
}
