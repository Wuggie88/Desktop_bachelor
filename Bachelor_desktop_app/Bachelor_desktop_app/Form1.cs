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
using System.Diagnostics;

namespace Bachelor_desktop_app
{
    public partial class Form1 : Form
    {
        //the SQL server and login info
        MySqlConnection con = new MySqlConnection(@"server=localhost;userid=root;password='';database=bcslogin");
        int i;

        //imports DLL for the rounded corners.
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //used to round the corners of a window.
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public Form1()
        {
            InitializeComponent();
            //rounds the corners of the window.
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //Closes the program
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //login function, checks if password an user exist in the same place in the database.
            i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM login WHERE User = '" + txtUser.Text + "' AND Password='" + txtPW.Text + "'";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            //i will remain 0 if no login fits with entered details, else it will be over 0.
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            //checks if i is 0, if it is we know no user has been found with the details 
            //and login fails, else it changes form and parse the user used to login with.
            if (i == 0)
            {
                lblWrong.Text = "invalid username or password";
            }
            else
            {
                this.Hide();
                // Sends a string to the new window that pops up, letting it use the info from the database
                Index fm = new Index(txtUser.Text);
                fm.Show();
            }
            con.Close();
        }

        private void btnLogin_Leave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(46, 51, 73);
        }

        //redirects to the signup form.
        private void btnSign_Click(object sender, EventArgs e)
        {
            this.Hide();
            signup sign = new signup();
            sign.Show();
        }

        private void btnSign_Leave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(46, 51, 73);
        }
    }
}
