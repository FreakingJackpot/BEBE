using System;
using System.Linq;
using System.Windows.Forms;

namespace laba_
{
    public partial class Cars : Form
    {
        Form1 form1;
        public Cars(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            Update_db();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCar add = new AddCar();
            add.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                var Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                ChangeCar change = new ChangeCar(Id);
                change.ShowDialog();
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
                        try
                        {
                            using (var context = new MYDBCONTEXT())
                            {
                                context.Cars.Remove(context.Cars.Find(Id));
                                context.SaveChanges();
                            }
                        }
                        catch
                        {
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchCars SearchCars = new SearchCars(dataGridView1);
            SearchCars.ShowDialog();
        }

        private void Update_db()
        {

            using (var context = new MYDBCONTEXT())
            {
                var result = context.Cars.OrderBy(c => c.Id).ToList();

                GridFillers.Cars(dataGridView1, result);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }
    }
}
