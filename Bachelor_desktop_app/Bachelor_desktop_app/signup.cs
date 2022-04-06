using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //needed for the dllimport
using MySql.Data.MySqlClient;

namespace Bachelor_desktop_app
{
    public partial class signup : Form
    {
        //sql connection, change server, user, password and database here
        MySqlConnection con = new MySqlConnection(@"server=localhost;userid=root;password='';database=logintest");
        int i;

        //dll for the window style
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        //setup of the window
        public signup()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void signup_Load(object sender, EventArgs e)
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

        //button that shuts down the window
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //controls what happens when clicking the accept button
        private void btnAccept_Click(object sender, EventArgs e)
        {
            //insert the whole SQL part before this, and only send it back to form 1 if success.
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }
        //controls what happens when clicking the Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
            */
            lblTest.Text = comboBox1.Text;
        }
    }
}
