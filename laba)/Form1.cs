using System;
using System.Windows.Forms;

namespace laba_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            Brands form = new Brands(this);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Models form = new Models(this);
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Colors form = new Colors(this);
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Engines form = new Engines(this);
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            TiresTable form = new TiresTable(this);
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Cars form = new Cars(this);
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Application.AllowQuit)
            {
                Application.Exit();
            }
        }
    }
}
