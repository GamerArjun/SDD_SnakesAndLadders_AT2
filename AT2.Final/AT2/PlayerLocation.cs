using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace AT2
{
    class PlayerLocation
    {
        public static void PlayerAtLocation(int playerLocation, PictureBox playerIcon)
        {
            int y1 = 619;
            int x1 = 18;
            int x_increment = 70;
            int y_increment = -67;
            if (playerIcon.Name == "Player1")
            {
                y1 = 619;
            }
            else
            {
                y1 = 650;
            }
            switch (playerLocation)
            {
                case 1:
                    playerIcon.Location = new Point(x1, y1);
                    break;
                case 2:
                    playerIcon.Location = new Point(x1 + x_increment, y1);
                    break;
                case 3:
                    playerIcon.Location = new Point(x1 + 2*x_increment, y1);
                    break;
                case 4:
                    playerIcon.Location = new Point(x1 + 3 * x_increment, y1);
                    break;
                case 5:
                    playerIcon.Location = new Point(x1 + 4 * x_increment, y1);
                    break;
                case 6:
                    playerIcon.Location = new Point(x1 + 5 * x_increment, y1);
                    break;
                case 7:
                    playerIcon.Location = new Point(x1 + 6 * x_increment, y1);
                    break;
                case 8:
                    playerIcon.Location = new Point(x1 + 7 * x_increment, y1);
                    break;
                case 9:
                    playerIcon.Location = new Point(x1 + 8 * x_increment, y1);
                    break;
                case 10:
                    playerIcon.Location = new Point(x1 + 9 * x_increment, y1);
                    break;
                case 11:
                    playerIcon.Location = new Point(x1 + 9 * x_increment, y1 + y_increment);
                    break;
                case 12:
                    playerIcon.Location = new Point(x1 + 8 * x_increment, y1 + y_increment);
                    break;
                case 13:
                    playerIcon.Location = new Point(x1 + 7 * x_increment, y1 + y_increment);
                    break;
                case 14:
                    playerIcon.Location = new Point(x1 + 6 * x_increment, y1 + y_increment);
                    break;
                case 15:
                    playerIcon.Location = new Point(x1 + 5 * x_increment, y1 + y_increment);
                    break;
                case 16:
                    playerIcon.Location = new Point(x1 + 4 * x_increment, y1 + y_increment);
                    break;
                case 17:
                    playerIcon.Location = new Point(x1 + 3 * x_increment, y1 + y_increment);
                    break;
                case 18:
                    playerIcon.Location = new Point(x1 + 2 * x_increment, y1 + y_increment);
                    break;
                case 19:
                    playerIcon.Location = new Point(x1 + 1 * x_increment, y1 + y_increment);
                    break;
                case 20:
                    playerIcon.Location = new Point(x1 + x_increment, y1 + y_increment);
                    break;
                case 21:
                    playerIcon.Location = new Point(x1, y1 +2 * y_increment);
                    break;
                case 22:
                    playerIcon.Location = new Point(x1 + x_increment, y1 + 2 * y_increment);
                    break;
                case 23:
                    playerIcon.Location = new Point(x1 + 2 * x_increment, y1 + 2 * y_increment);
                    break;
                case 24:
                    playerIcon.Location = new Point(x1 + 3 * x_increment, y1 + 2 * y_increment);
                    break;
                case 25:
                    playerIcon.Location = new Point(x1 + 4 * x_increment, y1 + 2 * y_increment);
                    break;
                case 26:
                    playerIcon.Location = new Point(x1 + 5 * x_increment, y1 + 2 * y_increment);
                    break;
                case 27:
                    playerIcon.Location = new Point(x1 + 6 * x_increment, y1 + 2 * y_increment);
                    break;
                case 28:
                    playerIcon.Location = new Point(x1 + 7 * x_increment, y1 + 2 * y_increment);
                    break;
                case 29:
                    playerIcon.Location = new Point(x1 + 8 * x_increment, y1 + 2 * y_increment);
                    break;
                case 30:
                    playerIcon.Location = new Point(x1 + 9 * x_increment, y1 + 2 * y_increment);
                    break;
                case 31:
                    playerIcon.Location = new Point(x1 + 9 * x_increment, y1 + 3 * y_increment);
                    break;
                case 32:
                    playerIcon.Location = new Point(x1 + 8 * x_increment, y1 + 3 * y_increment);
                    break;
                case 33:
                    playerIcon.Location = new Point(x1 + 7 * x_increment, y1 + 3 * y_increment);
                    break;
                case 34:
                    playerIcon.Location = new Point(x1 + 6 * x_increment, y1 + 3 * y_increment);
                    break;
                case 35:
                    playerIcon.Location = new Point(x1 + 5 * x_increment, y1 + 3 * y_increment);
                    break;
                case 36:
                    playerIcon.Location = new Point(x1 + 4 * x_increment, y1 + 3 * y_increment);
                    break;
                case 37:
                    playerIcon.Location = new Point(x1 + 3 * x_increment, y1 + 3 * y_increment);
                    break;
                case 38:
                    playerIcon.Location = new Point(x1 + 2 * x_increment, y1 + 3 * y_increment);
                    break;
                case 39:
                    playerIcon.Location = new Point(x1 + x_increment, y1 + 3 * y_increment);
                    break;
                case 40:
                    playerIcon.Location = new Point(x1, y1 + 3 * y_increment);
                    break;
                case 41:
                    playerIcon.Location = new Point(x1, y1 + 4 * y_increment);
                    break;
                case 42:
                    playerIcon.Location = new Point(x1 + x_increment, y1 + 4 * y_increment);
                    break;
                case 43:
                    playerIcon.Location = new Point(x1 + 2 * x_increment, y1 + 4 * y_increment);
                    break;
                case 44:
                    playerIcon.Location = new Point(x1 + 3 * x_increment, y1 + 4 * y_increment);
                    break;
                case 45:
                    playerIcon.Location = new Point(x1 + 4 * x_increment, y1 + 4 * y_increment);
                    break;
                case 46:
                    playerIcon.Location = new Point(x1 + 5 * x_increment, y1 + 4 * y_increment);
                    break;
                case 47:
                    playerIcon.Location = new Point(x1 + 6 * x_increment, y1 + 4 * y_increment);
                    break;
                case 48:
                    playerIcon.Location = new Point(x1 +7 * x_increment, y1 + 4 * y_increment);
                    break;
                case 49:
                    playerIcon.Location = new Point(x1 + 8 * x_increment, y1 + 4 * y_increment);
                    break;
                case 50:
                    playerIcon.Location = new Point(x1 + 9 * x_increment, y1 + 4 * y_increment);
                    break;
                case 51:
                    playerIcon.Location = new Point(x1 + 9 * x_increment, y1 + 5 * y_increment);
                    break;
                case 52:
                    playerIcon.Location = new Point(x1 + 8 * x_increment, y1 + 5 * y_increment);
                    break;
                case 53:
                    playerIcon.Location = new Point(x1 + 7 * x_increment, y1 + 5 * y_increment);
                    break;
                case 54:
                    playerIcon.Location = new Point(x1 + 6 * x_increment, y1 + 5 * y_increment);
                    break;
                case 55:
                    playerIcon.Location = new Point(x1 + 5 * x_increment, y1 + 5 * y_increment);
                    break;
                case 56:
                    playerIcon.Location = new Point(x1 + 4 * x_increment, y1 + 5 * y_increment);
                    break;
                case 57:
                    playerIcon.Location = new Point(x1 + 3 * x_increment, y1 + 5 * y_increment);
                    break;
                case 58:
                    playerIcon.Location = new Point(x1 + 2 * x_increment, y1 + 5 * y_increment);
                    break;
                case 59:
                    playerIcon.Location = new Point(x1 + x_increment, y1 + 5 * y_increment);
                    break;
                case 60:
                    playerIcon.Location = new Point(x1, y1 + 5 * y_increment);
                    break;
                case 61:
                    playerIcon.Location = new Point(x1, y1 + 6 * y_increment);
                    break;
                case 62:
                    playerIcon.Location = new Point(x1 + x_increment, y1 + 6 * y_increment);
                    break;
                case 63:
                    playerIcon.Location = new Point(x1 + 2 * x_increment, y1 + 6 * y_increment);
                    break;
                case 64:
                    playerIcon.Location = new Point(x1 + 3 * x_increment, y1 + 6 * y_increment);
                    break;
                case 65:
                    playerIcon.Location = new Point(x1 + 4 * x_increment, y1 + 6 * y_increment);
                    break;
                case 66:
                    playerIcon.Location = new Point(x1 + 5 * x_increment, y1 + 6 * y_increment);
                    break;
                case 67:
                    playerIcon.Location = new Point(x1 + 6 * x_increment, y1 + 6 * y_increment);
                    break;
                case 68:
                    playerIcon.Location = new Point(x1 + 7 * x_increment, y1 + 6 * y_increment);
                    break;
                case 69:
                    playerIcon.Location = new Point(x1 + 8 * x_increment, y1 + 6 * y_increment);
                    break;
                case 70:
                    playerIcon.Location = new Point(x1 + 9 * x_increment, y1 + 6 * y_increment);
                    break;
                case 71:
                    playerIcon.Location = new Point(x1 + 9 * x_increment, y1 + 7 * y_increment);
                    break;
                case 72:
                    playerIcon.Location = new Point(x1 + 8 * x_increment, y1 + 7 * y_increment);
                    break;
                case 73:
                    playerIcon.Location = new Point(x1 + 7 * x_increment, y1 + 7 * y_increment);
                    break;
                case 74:
                    playerIcon.Location = new Point(x1 + 6 * x_increment, y1 + 7 * y_increment);
                    break;
                case 75:
                    playerIcon.Location = new Point(x1 + 5 * x_increment, y1 + 7 * y_increment);
                    break;
                case 76:
                    playerIcon.Location = new Point(x1 + 4 * x_increment, y1 + 7 * y_increment);
                    break;
                case 77:
                    playerIcon.Location = new Point(x1 + 3 * x_increment, y1 + 7 * y_increment);
                    break;
                case 78:
                    playerIcon.Location = new Point(x1 + 2 * x_increment, y1 + 7 * y_increment);
                    break;
                case 79:
                    playerIcon.Location = new Point(x1 + x_increment, y1 + 7 * y_increment);
                    break;
                case 80:
                    playerIcon.Location = new Point(x1, y1 + 7 * y_increment);
                    break;
                case 81:
                    playerIcon.Location = new Point(x1, y1 + 8 * y_increment);
                    break;
                case 82:
                    playerIcon.Location = new Point(x1 + x_increment, y1 + 8 * y_increment);
                    break;
                case 83:
                    playerIcon.Location = new Point(x1 + 2 * x_increment, y1 + 8 * y_increment);
                    break;
                case 84:
                    playerIcon.Location = new Point(x1 + 3 * x_increment, y1 + 8 * y_increment);
                    break;
                case 85:
                    playerIcon.Location = new Point(x1 + 4 * x_increment, y1 + 8 * y_increment);
                    break;
                case 86:
                    playerIcon.Location = new Point(x1 + 5 * x_increment, y1 + 8 * y_increment);
                    break;
                case 87:
                    playerIcon.Location = new Point(x1 + 6 * x_increment, y1 + 8 * y_increment);
                    break;
                case 88:
                    playerIcon.Location = new Point(x1 + 7 * x_increment, y1 + 8 * y_increment);
                    break;
                case 89:
                    playerIcon.Location = new Point(x1 + 8 * x_increment, y1 + 8 * y_increment);
                    break;
                case 90:
                    playerIcon.Location = new Point(x1 + 9 * x_increment, y1 + 8 * y_increment);
                    break;
                case 91:
                    playerIcon.Location = new Point(x1 + 9 * x_increment, y1 + 9 * y_increment);
                    break;
                case 92:
                    playerIcon.Location = new Point(x1 + 8 * x_increment, y1 + 9 * y_increment);
                    break;
                case 93:
                    playerIcon.Location = new Point(x1 + 7 * x_increment, y1 + 9 * y_increment);
                    break;
                case 94:
                    playerIcon.Location = new Point(x1 + 6 * x_increment, y1 + 9 * y_increment);
                    break;
                case 95:
                    playerIcon.Location = new Point(x1 + 5 * x_increment, y1 + 9 * y_increment);
                    break;
                case 96:
                    playerIcon.Location = new Point(x1 + 4 * x_increment, y1 + 9 * y_increment);
                    break;
                case 97:
                    playerIcon.Location = new Point(x1 + 3 * x_increment, y1 + 9 * y_increment);
                    break;
                case 98:
                    playerIcon.Location = new Point(x1 + 2 * x_increment, y1 + 9 * y_increment);
                    break;
                case 99:
                    playerIcon.Location = new Point(x1 + x_increment, y1 + 9 * y_increment);
                    break;
                case 100:
                    playerIcon.Location = new Point(x1, y1 + 9 * y_increment);
                    break;
                default:
                    playerIcon.Location = new Point(18, 6191);
                    break;

            }
        }
   
    }
}


