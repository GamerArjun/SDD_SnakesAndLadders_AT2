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
        public static void Player1Location(int playerLocation, PictureBox playerIcon)
        {
            int y1 = 619;
            int x1 = 18;
            int x_increment = 70;
            int y_increment = -67;
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

                    break;
                case 57:

                    break;
                case 58:

                    break;
                case 59:

                    break;
                case 60:

                    break;
                case 61:

                    break;
                case 62:

                    break;
                case 63:

                    break;
                case 64:

                    break;
                case 65:

                    break;
                case 66:

                    break;
                case 67:

                    break;
                case 68:

                    break;
                case 69:

                    break;
                case 70:

                    break;
                case 71:

                    break;
                case 72:

                    break;
                case 73:

                    break;
                case 74:

                    break;
                case 75:

                    break;
                case 76:

                    break;
                case 77:

                    break;
                case 78:

                    break;
                case 79:

                    break;
                case 80:

                    break;
                case 81:

                    break;
                case 82:

                    break;
                case 83:

                    break;
                case 84:

                    break;
                case 85:

                    break;
                case 86:

                    break;
                case 87:

                    break;
                case 88:

                    break;
                case 89:

                    break;
                case 90:

                    break;
                case 91:

                    break;
                case 92:

                    break;
                case 93:

                    break;
                case 94:

                    break;
                case 95:

                    break;
                case 96:

                    break;
                case 97:

                    break;
                case 98:

                    break;
                case 99:

                    break;
                case 100:

                    break;
                default:
                    playerIcon.Location = new Point(663, 33);
                    break;

            }
        }
   
    }
}


