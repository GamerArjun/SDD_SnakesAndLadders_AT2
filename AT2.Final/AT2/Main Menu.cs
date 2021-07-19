using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

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
            this.Hide();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            int[] loadedGame = loadGame();
            Board f1;
            int numberOfPlayers = 1;
            if (loadedGame[0] > 0)
            {
                if (loadedGame[1] > 0)
                {
                    //2nd player also has a position, hence its a 2 player game
                    numberOfPlayers = 2;
                }
                f1 = new Board(numberOfPlayers, loadedGame[0], loadedGame[1], loadedGame[2]);
                f1.ShowDialog();
            }
            else
            {
                MessageBox.Show("No game is loaded...");
            }
        }

        private int[] loadGame()
        {
            using (OleDbConnection cnn = new OleDbConnection(Constants.connectionString))
            {
                using (OleDbCommand cmd = new OleDbCommand("Select * from game_save", cnn))
                {
                    cnn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        int player1_location = reader.GetOrdinal("Player_1_Location");
                        int player2_location = reader.GetOrdinal("Player_2_Location");
                        int player_turn = reader.GetOrdinal("Player_Turn");
                        int[] result = new int[3];
                        if (reader.Read())
                        {
                            int P1 = reader.GetInt32(player1_location);
                            int P2 = reader.GetInt32(player2_location);
                            int Turn = reader.GetInt32(player_turn);
                            result[0] = P1;
                            result[1] = P2;
                            result[2] = Turn;
                        }
                        return result;
                    }
                }
            }
        }

    }
}
