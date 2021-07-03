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
    public partial class Friends : Form
    {
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = 'C:\\Users\\parth.bhatia\\OneDrive - Arden Anglican School\\VisualStudioProjects\\AT2.Final\\AT2Database.accdb'");
        public Friends()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();
            F5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 F6 = new Form6();
            F6.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Friends_Load(object sender, EventArgs e)
        {
            using (OleDbConnection cnn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = 'C:\\Users\\parth.bhatia\\OneDrive - Arden Anglican School\\VisualStudioProjects\\AT2.Final\\AT2Database.accdb'"))
            {
                string query = "SELECT selected_user.id, user_master.username from user_master, selected_user where user_master.id = selected_user.id";
                using (OleDbCommand cmd = new OleDbCommand(query, cnn))
                {
                    cnn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        int userIDOrdinal = reader.GetOrdinal("id");
                        int usernameOrdinal = reader.GetOrdinal("username");

                        while (reader.Read())
                        {
                            int userid = reader.GetInt32(userIDOrdinal);
                            string name = reader.GetString(usernameOrdinal);
                            dataGridView1.ColumnCount = 2;
                            dataGridView1.Columns[0].Name = "User Id";
                            dataGridView1.Columns[1].Name = "UserName";
                            string[] row = new string[] { "" + userid, name };
                            dataGridView1.Rows.Add(row);
                        }
                    }
                }
            }
        }
    }
}
