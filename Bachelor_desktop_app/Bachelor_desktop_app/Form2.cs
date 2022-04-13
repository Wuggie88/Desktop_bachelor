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
    public partial class Index : Form
    {
        //SQL connection
        MySqlConnection con = new MySqlConnection(@"server=localhost;userid=root;password='';database=bcslogin");

        //used for the design of the window.
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        //used for moving the window around.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //makes a localDate variable with the current date and time.
        DateTime localDate = DateTime.Now;

        //makes a string that holds the current user.
        public string User;

        //the parameter put in here is the current user that it gets from the database, so it can be parsed into finding all the info of the user.
        public Index(string CU)
        {
            InitializeComponent();
            //sets the current user label to the CU from form 1. and sets the User string to the currenet user.
            CurrentUser.Text = CU;
            User = CU;

            //Makes the corners of the window rounded.
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            //opens connection to the SQL, finds the data and use the data reader to save the data of the current user.
            con.Open();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM login WHERE User = '" + CU + "'";
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();

            lblID.Text = "The id of the user is: " + reader["Id"];

            //closes the SQL connection.
            con.Close();

            // form loader loading the initial form here.
            this.LoaderPnl.Controls.Clear();
            FrmDash frmDash_Vrb = new FrmDash(User) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDash_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.LoaderPnl.Controls.Add(frmDash_Vrb);
            frmDash_Vrb.Show();

        }
        //code for moving the window around.
        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BtnDash_Click(object sender, EventArgs e)
        {
            //this part is what changes the formloader to what form it should be
            this.LoaderPnl.Controls.Clear();
            FrmDash frmDash_Vrb = new FrmDash(User) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDash_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.LoaderPnl.Controls.Add(frmDash_Vrb);
            frmDash_Vrb.Show();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            // formloader code
            this.LoaderPnl.Controls.Clear();
            FrmAbt frmAbt_Vrb = new FrmAbt() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAbt_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.LoaderPnl.Controls.Add(frmAbt_Vrb);
            frmAbt_Vrb.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // closes the application when the cross in the top right is pressed.
            Application.Exit();
        }

        //we can use this if we want anything else to happen when this form loads.
        private void Index_Load(object sender, EventArgs e)
        {

        }

        private void AssBtn_Click(object sender, EventArgs e)
        {
            // formloader code
            this.LoaderPnl.Controls.Clear();
            FrmAss frmAss_Vrb = new FrmAss(User) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAss_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.LoaderPnl.Controls.Add(frmAss_Vrb);
            frmAss_Vrb.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            //logs out and returns the user to the login screen.
            this.Hide();
            Form1 logoutForm = new Form1();
            logoutForm.Show();
        }

        private void MsgBtn_Click(object sender, EventArgs e)
        {
            // formloader code
            this.LoaderPnl.Controls.Clear();
            FrmMsg frmMsg_Vrb = new FrmMsg(User) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmMsg_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.LoaderPnl.Controls.Add(frmMsg_Vrb);
            frmMsg_Vrb.Show();
        }

        private void HWBtn_Click(object sender, EventArgs e)
        {
            // formloader code
            this.LoaderPnl.Controls.Clear();
            FrmHW frmHW_Vrb = new FrmHW() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmHW_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.LoaderPnl.Controls.Add(frmHW_Vrb);
            frmHW_Vrb.Show();
        }

        private void OptionBtn_Click(object sender, EventArgs e)
        {
            // formloader code
            this.LoaderPnl.Controls.Clear();
            FrmSet frmSet_Vrb = new FrmSet(User) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSet_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.LoaderPnl.Controls.Add(frmSet_Vrb);
            frmSet_Vrb.Show();
        }
    }
}
