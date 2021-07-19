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
    public partial class Form6 : Form
    {
        OleDbConnection con = new OleDbConnection(Constants.connectionString);

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            //read value from the text box
            string searchstring = textBox1.Text;
            using (OleDbConnection cnn = new OleDbConnection(Constants.connectionString))
            {
                string query;
                //check if the search string is empty or not
                if (searchstring.Trim() == "")
                {
                    query = "SELECT * FROM user_master";
                }
                else
                {
                    query = "SELECT * FROM user_master where username like '%" + searchstring + "%'";
                }
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
                            string[] row = new string[] { ""+userid, name};
                            dataGridView1.Rows.Add(row);
                        }
                    }
                }
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = "";
            try
            {
                // statements causing exception
                OleDbCommand cmd = con.CreateCommand();
                con.Open();
                int userselected = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                cmd.CommandText = "Insert into selected_user(ID)Values("+userselected+")";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                label1.Text = Convert.ToString("Friend Added");
            }
            catch (Exception e1)
            {
                label1.Text = Convert.ToString("Friend Already Added");
                // error handling code
            }
            finally
            {
                con.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
