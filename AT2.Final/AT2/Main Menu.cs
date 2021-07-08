using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Board f1 = new Board(3);
            f1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Board f1 = new Board(4);
            f1.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Board f1 = new Board(1);
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Board f1 = new Board(2);
            f1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Friends f3 = new Friends();
            f3.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 F7 = new Form7();
            F7.ShowDialog();
        }


    }
}
