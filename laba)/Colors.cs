using System;
using System.Linq;
using System.Windows.Forms;

namespace laba_
{
    public partial class Colors : Form
    {
        Form1 form1;
        public Colors(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            Update_db();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddColor addColor = new AddColor();
            addColor.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                var text1 = dataGridView1.SelectedRows[0].Cells["Color"].Value.ToString();
                var text2 = dataGridView1.SelectedRows[0].Cells["Type"].Value.ToString();
                ChangeColor changeColor = new ChangeColor(Id, text1, text2);
                changeColor.ShowDialog();
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
                            context.Colors.Remove(context.Colors.Find(Id));
                            context.SaveChanges();
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchColors search = new SearchColors(dataGridView1);
            search.ShowDialog();
        }

        private void Update_db()
        {
            using (var context = new MYDBCONTEXT())
            {
                var result = context.Colors.OrderBy(c => c.Id).ToList();
                GridFillers.Colors(dataGridView1, result);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }
    }
}
