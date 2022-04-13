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
    public partial class FrmDash : Form
    {
        //SQL connection
        MySqlConnection con = new MySqlConnection(@"server=localhost;userid=root;password='';database=bcslogin");
        public string User;

        public FrmDash(string CU)
        {
            InitializeComponent();

            //gets the current user from the database.
            con.Open();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM login WHERE User = '" + CU + "'";
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();

            User = CU;
            
            //prints a welcome message to the user with their name.
            DashLbl.Text = "Velkommen: " + reader["FirstName"] + " " + reader["LastName"];


            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonLbl.Text = "This should redirect to the message form";
        }
    }
}
