using System;
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
            Update_db();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            ComboboxesAutoAdders.ColorName(sender);
        }
        private void Update_db()
        {
            string tmp;
            string tmp2;
            tmp = combo1.SelectedItem == null ? "" : combo1.SelectedItem.ToString();
            tmp2 = combo2.SelectedItem == null ? "" : combo2.SelectedItem.ToString();

            SearchModels.ColorSearchModel type = new SearchModels.ColorSearchModel() { Name = tmp, Type = tmp2 };
            SearchingTools tools = new SearchingTools();
            var result = tools.SearchByColorAttributes(type);

            dataGridView1.Rows.Clear();
            for (int i = 0; i < result.Count; i++)
            {
                dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[i];
                row.Cells["id"].Value = result[i].Id;
                row.Cells["Color"].Value = result[i].Name;
                row.Cells["Type"].Value = result[i].Type;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }
    }
}
