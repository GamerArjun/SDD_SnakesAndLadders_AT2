using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AT2
{
    public partial class Board : Form
    {
        private const bool V = true;
        int player1location = 1;
        int player2location = 1;
        int numberOfPlayers = 0;
        int whosTurn = 1;

        public Board(int numberOfPlayers)
        {
            this.numberOfPlayers = numberOfPlayers;
            InitializeComponent();
            Player1.Show();
            if (numberOfPlayers > 1)
            {
                Player2.Show();

            }
            else
            {
                Player2.Hide();
            }
            playerTurn.Text = Convert.ToString(whosTurn);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            RollDice();
        }

        //function to check for ladder and snake and move the player location
        private int checkLadderSnake(int playerlocation, PictureBox player)
        {
            label2.Text = "";
            #region snake 
            switch (playerlocation)
            {
                case 17:
                    label2.Text = Convert.ToString("You Got Bitten By Snake");
                    playerlocation = 7;
                    PlayerLocation.PlayerAtLocation(playerlocation, player);
                    break;
                case 54:
                    label2.Text = Convert.ToString("You Got Bitten By Snake");
                    playerlocation = 34;
                    PlayerLocation.PlayerAtLocation(playerlocation, player);
                    break;
                case 64:
                    label2.Text = Convert.ToString("You Got Bitten By Snake");
                    playerlocation = 60;
                    PlayerLocation.PlayerAtLocation(playerlocation, player);
                    break;
                case 87:
                    label2.Text = Convert.ToString("You Got Bitten By Snake");
                    playerlocation = 36;
                    PlayerLocation.PlayerAtLocation(playerlocation, player);
                    break;
                case 93:
                    label2.Text = Convert.ToString("You Got Bitten By Snake");
                    playerlocation = 73;
                    PlayerLocation.PlayerAtLocation(playerlocation, player);
                    break;
                case 95:
                    label2.Text = Convert.ToString("You Got Bitten By Snake");
                    playerlocation = 75;
                    PlayerLocation.PlayerAtLocation(playerlocation, player);
                    break;
                case 98:
                    label2.Text = Convert.ToString("You Got Bitten By Snake");
                    playerlocation = 79;
                    PlayerLocation.PlayerAtLocation(playerlocation, player);
                    break;
            }
            #endregion
            #region laddar
            switch (playerlocation)
            {
                case 4:
                    label2.Text = Convert.ToString("You have climbed a ladder");
                    playerlocation = 14;
                    PlayerLocation.PlayerAtLocation(playerlocation, player);
                    break;
                case 9:
                    label2.Text = Convert.ToString("You have climbed a ladder");
                    playerlocation = 31;
                    PlayerLocation.PlayerAtLocation(playerlocation, player);
                    break;
                case 21:
                    label2.Text = Convert.ToString("You have climbed a ladder");
                    playerlocation = 42;
                    PlayerLocation.PlayerAtLocation(playerlocation, player);
                    break;
                case 28:
                    label2.Text = Convert.ToString("You have climbed a ladder");
                    playerlocation = 84;
                    PlayerLocation.PlayerAtLocation(playerlocation, player);
                    break;
                case 51:
                    label2.Text = Convert.ToString("You have climbed a ladder");
                    playerlocation = 67;
                    PlayerLocation.PlayerAtLocation(playerlocation, player);
                    break;
                case 72:
                    label2.Text = Convert.ToString("You have climbed a ladder");
                    playerlocation = 91;
                    PlayerLocation.PlayerAtLocation(playerlocation, player);
                    break;
                case 80:
                    label2.Text = Convert.ToString("You have climbed a ladder");
                    playerlocation = 99;
                    PlayerLocation.PlayerAtLocation(playerlocation, player);
                    break;
            }

            #endregion
            #region Win
            if (playerlocation >= 100)
            {
                label2.Text = player.Name + " Has Won";
                button1.Enabled = false;
                closeGame.Enabled = true;

            }
            #endregion Win

            return playerlocation;
        }
        private void RollDice()
        {
            #region Dice
            //roll the dice
            Random rn = new Random(); // New Random Class
            int random1 = rn.Next(1, 7); // Parameter for random number
            Console.WriteLine(random1); // Show on screen
            label1.Text = Convert.ToString(random1); //text;
                                                     //find location of player
            #endregion Dice
            #region Location

            //find whos turn it is and then change the players location
            if (whosTurn == 1)
            {
                //add the dice number to the player
                player1location = random1 + player1location;
                //find new location of the player
                Console.WriteLine("location of player 1:" + player1location);
                PlayerLocation.PlayerAtLocation(player1location, Player1);
                player1location = checkLadderSnake(player1location, Player1);
            }
            else
            {
                //add the dice number to the player
                player2location = random1 + player2location;
                //find new location of the player
                Console.WriteLine("location of player 2:" + player2location);
                PlayerLocation.PlayerAtLocation(player2location, Player2);
                player2location = checkLadderSnake(player2location, Player2);
            }
            #endregion Location
            #region Turn
            ///change to next player turn
            whosTurn = whosTurn + 1;
            if (whosTurn > numberOfPlayers)
            {
                whosTurn = 1;
            }
            playerTurn.Text = Convert.ToString(whosTurn);
            #endregion Turn
        }
        private void Hide(Button button1)
        {
            throw new NotImplementedException();
        }

        private void Board_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               RollDice();
            }
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

        private void Player2_Click(object sender, EventArgs e)
        {

        }

        private void closeGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
