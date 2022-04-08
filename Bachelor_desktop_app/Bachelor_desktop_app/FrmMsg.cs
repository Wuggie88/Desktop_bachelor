using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
namespace Bachelor_desktop_app
{
    public partial class FrmMsg : Form
    {
        //SQL connection
        MySqlConnection con = new MySqlConnection(@"server=localhost;userid=root;password='';database=bcslogin");

        public FrmMsg(String CU)
        {
            InitializeComponent();

            //opens connection to the SQL, finds the data and use the data reader to save the data of the current user.
            con.Open();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM login WHERE User = '" + CU + "'";
            MySqlDataReader reader = com.ExecuteReader();

            reader.Read();
            MsgLbl.Text = "this is the user password: " + reader["Password"];
        }
    }
}
