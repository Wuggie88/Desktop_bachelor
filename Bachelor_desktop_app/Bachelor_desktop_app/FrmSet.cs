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

        public FrmSet(string CU)
        {
            InitializeComponent();
            //opens connection to the SQL, finds the data and use the data reader to save the data of the current user.
            con.Open();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM login WHERE User = '" + CU + "'";
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();
            con.Close();

            //fill out the form with the current data.
            UserBox.Text = "" + reader["User"];
            FnameBox.Text = "" + reader["FirstName"];
            LnameBox.Text = "" + reader["LastName"];
            EmailBox.Text = "" + reader["Email"];
            GEmailBox.Text = "" + reader["GEmail"];
            GEmail2Box.Text = "" + reader["GEmail2"];
            GEmail3Box.Text = "" + reader["GEmail3"];
            GEmail4Box.Text = "" + reader["GEmail4"];
            comboBox1.Text = "" + reader["interest1"];
            comboBox2.Text = "" + reader["interest2"];
            comboBox3.Text = "" + reader["interest3"];
            comboBox4.Text = "" + reader["interest4"];
            ClassBox.Text = "" + reader["Klasse"];
            

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (PWBox.Text.Length <= 3)
            {
                //make a label here for when password is not long enough.
            }
            else
            {
                //Push to the database with the current data in the form.
                con.Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "INSERT INTO login (User, Password, FirstName, LastName, Email, GEmail, GEmail2, GEmail3, GEmail4, interest1, interest2, interest3, interest4, Klasse)" +
                    "VALUES('" + UserBox.Text + "'," +
                    "'" + PWBox.Text + "'," +
                    "'" + FnameBox.Text + "'," +
                    "'" + LnameBox.Text + "'," +
                    "'" + EmailBox.Text + "'," +
                    "'" + GEmailBox.Text + "'," +
                    "'" + GEmail2Box.Text + "'," +
                    "'" + GEmail3Box.Text + "'," +
                    "'" + GEmail4Box.Text + "'," +
                    "'" + comboBox1.Text + "'," +
                    "'" + comboBox2.Text + "'," +
                    "'" + comboBox3.Text + "'," +
                    "'" + comboBox4.Text + "'," +
                    "'" + ClassBox.Text + "')";
                com.ExecuteNonQuery();

                con.Close();
            }
        }
    }
}
