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
        MySqlConnection con = new MySqlConnection(@"server=localhost;userid=root;password='';database=logintest");
        int i;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

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
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            /*
            pnlNav.Height = BtnDash.Height;
            pnlNav.Top = BtnDash.Top;
            pnlNav.Left = BtnDash.Left;
            BtnDash.BackColor = Color.FromArgb(46, 51, 73); 
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM login WHERE User = '" + txtUser.Text + "' AND Password='" + txtPW.Text + "'";
            //cmd.BeginExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                lblWrong.Text = "invalid username or password";

            }
            else
            {
                this.Hide();
                Index fm = new Index(txtUser.Text);
                fm.Show();
            }
            con.Close();
        }

        private void btnLogin_Leave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(46, 51, 73);
        }

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
