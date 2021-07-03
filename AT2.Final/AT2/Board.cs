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
    public partial class Board : Form    
    {

        public Board()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rn = new Random(); // New Random Class
            int random1 = rn.Next(1, 7); // Parameter for random number
            Console.WriteLine(random1); // Show on screen
            label1.Text = Convert.ToString(random1); //text;
        }
            private void Form1_Load(object sender, EventArgs e)
        {

        }

            private void label1_Click(object sender, EventArgs e)
        {

        }
            private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
            private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
            private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
