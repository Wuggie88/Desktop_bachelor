using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bachelor_desktop_app
{
    public partial class FrmSet : Form
    {
        //SQL connection
        MySqlConnection con = new MySqlConnection(@"server=localhost;userid=root;password='';database=bcslogin");
        int i;
        string User;

        public FrmSet(string CU)
        {
            InitializeComponent();
            //opens connection to the SQL, find the user from the user that's logged in and saves it.
            con.Open();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM login WHERE User = '" + CU + "'";
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();

            User = CU.ToString();
            //fill out the form with the current data.
            UserBox.Text = reader["User"].ToString();
            FnameBox.Text = reader["FirstName"].ToString();
            LnameBox.Text = reader["LastName"].ToString();
            EmailBox.Text = reader["Email"].ToString();
            GEmailBox.Text = reader["GEmail"].ToString();
            GEmail2Box.Text = reader["GEmail2"].ToString();
            GEmail3Box.Text = reader["GEmail3"].ToString();
            GEmail4Box.Text = reader["GEmail4"].ToString();
            comboBox1.Text = reader["interest1"].ToString();
            comboBox2.Text = reader["interest2"].ToString();
            comboBox3.Text = reader["interest3"].ToString();
            comboBox4.Text = reader["interest4"].ToString();
            ClassBox.Text = reader["Klasse"].ToString();

            con.Close();

        }

        private void FrmSet_Load(object sender, EventArgs e)
        {
            //fills combobox2 with all items also in box1, next code does the same for other boxes.
            for (i = 0; i < comboBox1.Items.Count; i++)
            {
                comboBox2.Items.Add(comboBox1.Items[i]);
            }

            for (i = 0; i < comboBox1.Items.Count; i++)
            {
                comboBox3.Items.Add(comboBox1.Items[i]);
            }

            for (i = 0; i < comboBox1.Items.Count; i++)
            {
                comboBox4.Items.Add(comboBox1.Items[i]);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (PWBox.Text.Length <= 3)
            {
                //Sets the label when password is too short or not filled out.
                PWLLbl.Text = "Password needs to be at least 4 characters";
            }
            else
            {
                //Push to the database with the current data in the form.
                MySqlCommand com = con.CreateCommand();
                con.Open();

                //This is where the error is, It's because you don't update like this.. will have to rewrite this at some point to the whole "Set" thing, for more info check this: https://www.w3schools.com/sql/sql_update.asp
                com.CommandText = "UPDATE login (Password, FirstName, LastName, GEmail2, GEmail3, GEmail4, interest1, interest2, interest3, interest4, Klasse)" +
                    "VALUES('" + PWBox.Text + "'," +
                    "'" + FnameBox.Text + "'," +
                    "'" + LnameBox.Text + "'," +
                    "'" + GEmail2Box.Text + "'," +
                    "'" + GEmail3Box.Text + "'," +
                    "'" + GEmail4Box.Text + "'," +
                    "'" + comboBox1.Text + "'," +
                    "'" + comboBox2.Text + "'," +
                    "'" + comboBox3.Text + "'," +
                    "'" + comboBox4.Text + "'," +
                    "'" + ClassBox.Text + "')" +
                    "WHERE User = '" + User + "'";
                com.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
