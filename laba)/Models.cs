using System;
using System.Windows.Forms;

namespace laba_ {
public partial class Models : Form {
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
        if (dataGridView1.SelectedRows.Count == 1) {
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
        if (dataGridView1.SelectedRows.Count == 1) {
            var result = Messages.DeleteMessage();

            if (result == DialogResult.OK) {
                var Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                if (Id >= 0) {
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
        Update_db();
    }

    private void Update_db()
    {
        string tmp;
        string tmp2;
        string tmp3;
        tmp = combo1.SelectedItem == null ? "" : combo1.SelectedItem.ToString();
        tmp2 = combo2.SelectedItem == null ? "" : combo2.SelectedItem.ToString();
        tmp3 = combo3.SelectedItem == null ? "" : combo3.SelectedItem.ToString();

        SearchModels.ModelSearchModel model = new SearchModels.ModelSearchModel() { Name = tmp, DriveUnit = tmp2, Body = tmp3 };
        SearchingTools tools = new SearchingTools();
        var result = tools.SearchByModelAttributes(model);

        dataGridView1.Rows.Clear();
        for (int i = 0; i < result.Count; i++) {
            dataGridView1.Rows.Add();
            var row = dataGridView1.Rows[i];
            row.Cells["id"].Value = result[i].Id;
            row.Cells["Model"].Value = result[i].Name;
            row.Cells["DriveUnit"].Value = result[i].DriveUnit;
            row.Cells["Body"].Value = result[i].Body;
        }
    }

    private void combo1_DropDown(object sender, EventArgs e)
    {
        ComboboxesAutoAdders.ModelName(sender);
    }

    private void button5_Click(object sender, EventArgs e)
    {
        this.Close();
        form1.Show();
    }
}
}
