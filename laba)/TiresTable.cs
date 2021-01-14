using System;
using System.Linq;
using System.Windows.Forms;
namespace laba_
{
    public partial class TiresTable : Form
    {
        Form1 form1;
        public TiresTable(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            Update_db();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTires addTires = new AddTires();
            addTires.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                var text1 = dataGridView1.SelectedRows[0].Cells["Brand"].Value.ToString();
                var float1 = dataGridView1.SelectedRows[0].Cells["Width"].Value.ToString();
                var float2 = dataGridView1.SelectedRows[0].Cells["Diameter"].Value.ToString();
                ChangeTires changeEngine = new ChangeTires(Id, text1, float1, float2);
                changeEngine.ShowDialog();
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
                            try
                            {
                                context.Tires.Remove(context.Tires.Find(Id));
                                context.SaveChanges();
                            }
                            catch
                            {
                            }
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchTires search = new SearchTires(dataGridView1);
            search.ShowDialog();
        }

        private void Update_db()
        {
            using (var context = new MYDBCONTEXT())
            {
                var result = context.Tires.OrderBy(c => c.Id).ToList();
                GridFillers.Tires(dataGridView1, result);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }
    }
}
