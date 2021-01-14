using System;
using System.Linq;
using System.Windows.Forms;

namespace laba_ {
public partial class TiresTable : Form {
    Form1 form1;
    public TiresTable(Form1 f)
    {
        InitializeComponent();
        form1 = f;
        ResetFields();
        Update_db();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        AddTires addTires = new AddTires();
        addTires.ShowDialog();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count == 1) {
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
        if (dataGridView1.SelectedRows.Count == 1) {
            var result = Messages.DeleteMessage();

            if (result == DialogResult.OK) {
                var Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                if (Id >= 0) {
                    using (var context = new MYDBCONTEXT())
                    {
                        try {
                            context.Tires.Remove(context.Tires.Find(Id));
                            context.SaveChanges();
                        } catch {
                        }
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
        float widthmax;
        float widthmin;
        float diametermax;
        float diametermin;

        tmp = combo1.SelectedItem == null ? "" : combo1.SelectedItem.ToString();
        widthmax = float.Parse(numericUpDown1.Value.ToString());
        widthmin = float.Parse(numericUpDown2.Value.ToString());
        diametermax = float.Parse(numericUpDown3.Value.ToString());
        diametermin = float.Parse(numericUpDown4.Value.ToString());

        SearchModels.TiresSearchModel type = new SearchModels.TiresSearchModel() {
            Brand = tmp,
            WidthMax = widthmax,
            WidthMin = widthmin,
            DiameterMax = diametermax,
            DiameterMin = diametermin
        };

        SearchingTools tools = new SearchingTools();
        var result = tools.SearchByTiresAttributes(type);

        dataGridView1.Rows.Clear();
        for (int i = 0; i < result.Count; i++) {
            dataGridView1.Rows.Add();
            var row = dataGridView1.Rows[i];
            row.Cells["id"].Value = result[i].Id;
            row.Cells["Brand"].Value = result[i].Brand;
            row.Cells["Width"].Value = result[i].Width;
            row.Cells["Diameter"].Value = result[i].Diameter;
        }
    }

    private void button5_Click(object sender, EventArgs e)
    {
        this.Close();
        form1.Show();
    }

    private void button6_Click(object sender, EventArgs e)
    {
        ResetFields();
    }
    private void ResetFields()
    {
        try {
            using (var context = new MYDBCONTEXT())
            {

                combo1.SelectedItem = " ";
                numericUpDown1.Value = decimal.Parse(context.Tires.Max(p => p.Width).ToString());
                numericUpDown2.Value = decimal.Parse(context.Tires.Min(p => p.Width).ToString());
                numericUpDown3.Value = decimal.Parse(context.Tires.Max(p => p.Diameter).ToString());
                numericUpDown4.Value = decimal.Parse(context.Tires.Min(p => p.Diameter).ToString());
            }
        } catch {
        }
    }

    private void comboBox7_DropDown(object sender, EventArgs e)
    {
        ComboboxesAutoAdders.TiresBrand(sender);
    }

    private void label5_Click(object sender, EventArgs e)
    {
        using (var context = new MYDBCONTEXT())
        {

            numericUpDown1.Value = decimal.Parse(context.Tires.Max(p => p.Width).ToString());
        }
    }

    private void label6_Click(object sender, EventArgs e)
    {
        using (var context = new MYDBCONTEXT())
        {

            numericUpDown2.Value = decimal.Parse(context.Tires.Min(p => p.Width).ToString());
        }
    }

    private void label7_Click(object sender, EventArgs e)
    {
        using (var context = new MYDBCONTEXT())
        {

            numericUpDown3.Value = decimal.Parse(context.Tires.Max(p => p.Diameter).ToString());
        }
    }

    private void label8_Click(object sender, EventArgs e)
    {
        using (var context = new MYDBCONTEXT())
        {

            numericUpDown4.Value = decimal.Parse(context.Tires.Min(p => p.Diameter).ToString());
        }
    }
}
}
