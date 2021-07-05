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
        int player1location = 1;

        public Board()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //roll the dice
            Random rn = new Random(); // New Random Class
            int random1 = rn.Next(1, 7); // Parameter for random number
            Console.WriteLine(random1); // Show on screen
            label1.Text = Convert.ToString(random1); //text;
            //find location of player

            //add the dice number to the player
            player1location = random1 + player1location;
            //find new location of the player
            Console.WriteLine("location of player 1:" + player1location);
            PlayerLocation.Player1Location(player1location, Player1);
            player1location = checkLadderSnake(player1location, Player1);
        }
        //function to check for ladder and snake and move the player location
        private int checkLadderSnake(int playerlocation, PictureBox player)
        {
            #region snake 
            switch (playerlocation)
            {
                case 17:
                    MessageBox.Show("You Got Bitten By Snake");
                    playerlocation = 7;
                    PlayerLocation.Player1Location(playerlocation, player);
                    break;
                case 64:
                    MessageBox.Show("You Got Bitten By Snake");
                    playerlocation = 60;
                    PlayerLocation.Player1Location(playerlocation, player);
                    break;
                case 87:
                    MessageBox.Show("You Got Bitten By Snake");
                    playerlocation = 36;
                    PlayerLocation.Player1Location(playerlocation, player);
                    break;
                case 93:
                    MessageBox.Show("You Got Bitten By Snake");
                    playerlocation = 73;
                    PlayerLocation.Player1Location(playerlocation, player);
                    break;
                case 95:
                    MessageBox.Show("You Got Bitten By Snake");
                    playerlocation = 75;
                    PlayerLocation.Player1Location(playerlocation, player);
                    break;
                case 98:
                    MessageBox.Show("You Got Bitten By Snake");
                    playerlocation = 79;
                    PlayerLocation.Player1Location(playerlocation, player);
                    break;
            }
            #endregion
            #region laddar
            switch (playerlocation)
            {
                case 4:
                    MessageBox.Show("You have climbed a ladder");
                    playerlocation = 14;
                    PlayerLocation.Player1Location(playerlocation, player);
                    break;
                case 9:
                    MessageBox.Show("You have climbed a ladder");
                    playerlocation = 31;
                    PlayerLocation.Player1Location(playerlocation, player);
                    break;
                case 21:
                    MessageBox.Show("You have climbed a ladder");
                    playerlocation = 42;
                    PlayerLocation.Player1Location(playerlocation, player);
                    break;
                case 28:
                    MessageBox.Show("You have climbed a ladder");
                    playerlocation = 84;
                    PlayerLocation.Player1Location(playerlocation, player);
                    break;
                case 51:
                    MessageBox.Show("You have climbed a ladder");
                    playerlocation = 67;
                    PlayerLocation.Player1Location(playerlocation, player);
                    break;
                case 72:
                    MessageBox.Show("You have climbed a ladder");
                    playerlocation = 91;
                    PlayerLocation.Player1Location(playerlocation, player);
                    break;
                case 80:
                    MessageBox.Show("You have climbed a ladder");
                    playerlocation = 99;
                    PlayerLocation.Player1Location(playerlocation, player);
                    break;
            }
            #endregion
            return playerlocation;
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
