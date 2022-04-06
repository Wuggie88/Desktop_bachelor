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
    public partial class FrmAss : Form
    {
        //SQL connection
        MySqlConnection con = new MySqlConnection(@"server=localhost;userid=root;password='';database=logintest");

        public enum Classes { c0, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10 };
        public Classes myClass;

        public FrmAss(String CU)
        {
            InitializeComponent();
            //opens connection to the SQL, finds the data and use the data reader to save the data of the current user.
            con.Open();
            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM login WHERE User = '" + CU + "'";
            MySqlDataReader reader = com.ExecuteReader();
            reader.Read();

            CheckClass(reader["Klasse"]);

        }

        public void CheckClass(object Klasse)
        {
            switch (Klasse)
            {
                case 0:
                    AssLbl.Text = "Opgaver for 0. Klasse";
                    myClass = Classes.c0;
                    PhysBtn.Hide();
                    break;
                case 1:
                    AssLbl.Text = "Opgaver for 1. Klasse";
                    myClass = Classes.c1;
                    PhysBtn.Hide();
                    break;
                case 2:
                    AssLbl.Text = "Opgaver for 2. Klasse";
                    myClass = Classes.c2;
                    PhysBtn.Hide();
                    break;
                case 3:
                    AssLbl.Text = "Opgaver for 3. Klasse";
                    myClass = Classes.c3;
                    PhysBtn.Hide();
                    break;
                case 4:
                    AssLbl.Text = "Opgaver for 4. Klasse";
                    myClass = Classes.c4;
                    PhysBtn.Hide();
                    break;
                case 5:
                    AssLbl.Text = "Opgaver for 5. Klasse";
                    myClass = Classes.c5;
                    PhysBtn.Hide();
                    break;
                case 6:
                    AssLbl.Text = "Opgaver for 6. Klasse";
                    myClass = Classes.c6;
                    PhysBtn.Hide();
                    break;
                case 7:
                    AssLbl.Text = "Opgaver for 7. Klasse";
                    myClass = Classes.c7;
                    break;
                case 8:
                    AssLbl.Text = "Opgaver for 8. Klasse";
                    myClass = Classes.c8;
                    break;
                case 9:
                    AssLbl.Text = "Opgaver for 9. Klasse";
                    myClass = Classes.c9;
                    break;
                case 10:
                    AssLbl.Text = "Opgaver for 10. Klasse";
                    myClass = Classes.c10;
                    break;

                default:
                    AssLbl.Text = "This didn't work";
                    break;

            }
        }

        private void MatBtn_Click(object sender, EventArgs e)
        {
            switch (myClass)
            {
                case Classes.c0:
                    AssLbl.Text = "Du trykkede på knappen til Matematik for 0. klasse";
                    break;
                case Classes.c1:
                    AssLbl.Text = "Du trykkede på knappen til Matematik for 1. klasse";
                    break;
                case Classes.c2:
                    AssLbl.Text = "Du trykkede på knappen til Matematik for 2. klasse";
                    break;
                case Classes.c3:
                    AssLbl.Text = "Du trykkede på knappen til Matematik for 3. klasse";
                    break;
                case Classes.c4:
                    AssLbl.Text = "Du trykkede på knappen til Matematik for 4. klasse";
                    break;
                case Classes.c5:
                    AssLbl.Text = "Du trykkede på knappen til Matematik for 5. klasse";
                    break;
                case Classes.c6:
                    AssLbl.Text = "Du trykkede på knappen til Matematik for 6. klasse";
                    break;
                case Classes.c7:
                    AssLbl.Text = "Du trykkede på knappen til Matematik for 7. klasse";
                    break;
                case Classes.c8:
                    AssLbl.Text = "Du trykkede på knappen til Matematik for 8. klasse";
                    break;
                case Classes.c9:
                    AssLbl.Text = "Du trykkede på knappen til Matematik for 9. klasse";
                    break;
                case Classes.c10:
                    AssLbl.Text = "Du trykkede på knappen til Matematik for 10. klasse";
                    break;

                default:
                    break;
            }
        }

        private void PhysBtn_Click(object sender, EventArgs e)
        {
            switch (myClass)
            {
                case Classes.c7:
                    AssLbl.Text = "Du trykkede på knappen til Fysik for 7. klasse";
                    break;
                case Classes.c8:
                    AssLbl.Text = "Du trykkede på knappen til Fysik for 8. klasse";
                    break;
                case Classes.c9:
                    AssLbl.Text = "Du trykkede på knappen til Fysik for 9. klasse";
                    break;
                case Classes.c10:
                    AssLbl.Text = "Du trykkede på knappen til Fysik for 10. klasse";
                    break;

                default:
                    break;

            }
        }

        private void DKBtn_Click(object sender, EventArgs e)
        {
            switch (myClass)
            {
                case Classes.c0:
                    AssLbl.Text = "Du trykkede på knappen til Dansk for 0. klasse";
                    break;
                case Classes.c1:
                    AssLbl.Text = "Du trykkede på knappen til Dansk for 1. klasse";
                    break;
                case Classes.c2:
                    AssLbl.Text = "Du trykkede på knappen til Dansk for 2. klasse";
                    break;
                case Classes.c3:
                    AssLbl.Text = "Du trykkede på knappen til Dansk for 3. klasse";
                    break;
                case Classes.c4:
                    AssLbl.Text = "Du trykkede på knappen til Dansk for 4. klasse";
                    break;
                case Classes.c5:
                    AssLbl.Text = "Du trykkede på knappen til Dansk for 5. klasse";
                    break;
                case Classes.c6:
                    AssLbl.Text = "Du trykkede på knappen til Dansk for 6. klasse";
                    break;
                case Classes.c7:
                    AssLbl.Text = "Du trykkede på knappen til Dansk for 7. klasse";
                    break;
                case Classes.c8:
                    AssLbl.Text = "Du trykkede på knappen til Dansk for 8. klasse";
                    break;
                case Classes.c9:
                    AssLbl.Text = "Du trykkede på knappen til Dansk for 9. klasse";
                    break;
                case Classes.c10:
                    AssLbl.Text = "Du trykkede på knappen til Dansk for 10. klasse";
                    break;

                default:
                    break;
            }
        }
    }
}
