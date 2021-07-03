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
        bool PlayerTurn = true;
        int DiceNumber = 0;
        int Playerturncount = 0;
        int Player1Locat = 0;
        int Player2Locat = 0;
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
            DiceNumber = random1;
            Playerturncount++;
            if (Playerturncount % 2 == 0)

                if (PlayerTurn == true)
                {

                    Player1Locat = Player1Locat + random1;
                    PlayerLocation.Player1Location(Player1Locat, Player1);
                    #region snake 
                    switch (Player1Locat)
                    {
                        case 12:
                            Player1.Location = new Point(216, 510);
                            MessageBox.Show("You Bite By Snake");
                            Player1Locat = 2;
                            break;
                        case 20:
                            Player1.Location = new Point(483, 510);
                            MessageBox.Show("You Bite By Snake");
                            Player1Locat = 5;
                            break;
                        case 39:
                            Player1.Location = new Point(572, 353);
                            MessageBox.Show("You Bite By Snake");
                            Player1Locat = 22;
                            break;
                        case 44:
                            Player1.Location = new Point(36, 432);
                            MessageBox.Show("You Bite By Snake");
                            Player1Locat = 15;
                            break;
                        case 47:
                            Player1.Location = new Point(129, 272);
                            MessageBox.Show("You Bite By Snake");
                            Player1Locat = 30;
                            break;
                        case 54:
                            Player1.Location = new Point(306, 353);
                            MessageBox.Show("You Bite By Snake");
                            Player1Locat = 19;
                            break;
                    }
                    #endregion
                    #region laddar
                    switch (Player1Locat)
                    {
                        case 3:
                            Player1.Location = new Point(483, 432);
                            MessageBox.Show("You Got Laddar");
                            Player1Locat = 10;
                            break;
                        case 9:
                            Player1.Location = new Point(483, 353);
                            MessageBox.Show("You Got Laddar");
                            Player1Locat = 21;
                            break;
                        case 18:
                            Player1.Location = new Point(306, 193);
                            MessageBox.Show("You Got Laddar");
                            Player1Locat = 35;
                            break;
                        case 13:
                            Player1.Location = new Point(36, 272);
                            MessageBox.Show("You Got Laddar");
                            Player1Locat = 31;
                            break;
                        case 25:
                            Player1.Location = new Point(663, 113);
                            MessageBox.Show("You Got Laddar");
                            Player1Locat = 40;
                            break;
                        case 36:
                            Player1.Location = new Point(306, 33);
                            MessageBox.Show("You Got Laddar");
                            Player1Locat = 51;
                            break;
                        case 48:
                            Player1.Location = new Point(216, 33);
                            MessageBox.Show("You Got Laddar");
                            Player1Locat = 50;
                            break;
                    }
                    #endregion
                    #region Winning
                    if (Player1Locat >= 55 && Player1Locat <= 65)
                    {
                        MessageBox.Show("Player1 Wins");
                        Player1Locat = 66;
                        Player2Locat = 66;

                    }
                    #endregion

                }
        }
            private void Form1_Load(object sender, EventArgs e)
        {
            Player1.Location = new Point(36, 510);
            Player2.Location = new Point(36, 510 + 46);
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
