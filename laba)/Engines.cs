using System;
using System.Linq;
using System.Windows.Forms;

namespace laba_
{
    public partial class Engines : Form
    {
        Form1 form1;
        public Engines(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            Update_db();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEngine addEngine = new AddEngine();
            addEngine.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                var text1 = dataGridView1.SelectedRows[0].Cells["Engine"].Value.ToString();
                var text2 = dataGridView1.SelectedRows[0].Cells["FuelType"].Value.ToString();
                var float1 = dataGridView1.SelectedRows[0].Cells["FuelCapacity"].Value.ToString();
                var float2 = dataGridView1.SelectedRows[0].Cells["HorsePower"].Value.ToString();

                ChangeEngine changeEngine = new ChangeEngine(Id, text1, text2, float1, float2);
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
                            context.Engines.Remove(context.Engines.Find(Id));
                            context.SaveChanges();
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchEngines search = new SearchEngines(dataGridView1);
            search.ShowDialog();
        }

        private void Update_db()
        {
            using (var context = new MYDBCONTEXT())
            {
                var result = context.Engines.OrderBy(c => c.Id).ToList();
                GridFillers.Engines(dataGridView1, result);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }
    }
}
