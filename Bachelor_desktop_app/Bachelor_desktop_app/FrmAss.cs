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
        MySqlConnection con = new MySqlConnection(@"server=localhost;userid=root;password='';database=bcslogin");

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
            //Checks on the Class that the user is in, then hides all the buttons that they do not need and sets the enum to the correct enum
            switch (Klasse)
            {
                case 0:
                    AssLbl.Text = "Opgaver for 0. Klasse";
                    myClass = Classes.c0;
                    PhysBtn.Hide();
                    EngBtn.Hide();
                    JesusBtn.Hide();
                    HisBtn.Hide();
                    BioBtn.Hide();
                    GeoBtn.Hide();
                    SamfBtn.Hide();
                    FRBtn.Hide();
                    GerBtn.Hide();
                    NatBtn.Hide();
                    break;
                case 1:
                    AssLbl.Text = "Opgaver for 1. Klasse";
                    myClass = Classes.c1;
                    PhysBtn.Hide();
                    HisBtn.Hide();
                    BioBtn.Hide();
                    GeoBtn.Hide();
                    SamfBtn.Hide();
                    FRBtn.Hide();
                    GerBtn.Hide();
                    break;
                case 2:
                    AssLbl.Text = "Opgaver for 2. Klasse";
                    myClass = Classes.c2;
                    PhysBtn.Hide();
                    HisBtn.Hide();
                    BioBtn.Hide();
                    GeoBtn.Hide();
                    SamfBtn.Hide();
                    GerBtn.Hide();
                    FRBtn.Hide();
                    break;
                case 3:
                    AssLbl.Text = "Opgaver for 3. Klasse";
                    myClass = Classes.c3;
                    PhysBtn.Hide();
                    BioBtn.Hide();
                    GeoBtn.Hide();
                    SamfBtn.Hide();
                    FRBtn.Hide();
                    GerBtn.Hide();
                    break;
                case 4:
                    AssLbl.Text = "Opgaver for 4. Klasse";
                    myClass = Classes.c4;
                    PhysBtn.Hide();
                    BioBtn.Hide();
                    GeoBtn.Hide();
                    SamfBtn.Hide();
                    FRBtn.Hide();
                    GerBtn.Hide();
                    break;
                case 5:
                    AssLbl.Text = "Opgaver for 5. Klasse";
                    myClass = Classes.c5;
                    PhysBtn.Hide();
                    BioBtn.Hide();
                    GeoBtn.Hide();
                    SamfBtn.Hide();
                    break;
                case 6:
                    AssLbl.Text = "Opgaver for 6. Klasse";
                    myClass = Classes.c6;
                    PhysBtn.Hide();
                    BioBtn.Hide();
                    GeoBtn.Hide();
                    SamfBtn.Hide();
                    break;
                case 7:
                    AssLbl.Text = "Opgaver for 7. Klasse";
                    myClass = Classes.c7;
                    SamfBtn.Hide();
                    NatBtn.Hide();
                    break;
                case 8:
                    AssLbl.Text = "Opgaver for 8. Klasse";
                    myClass = Classes.c8;
                    NatBtn.Hide();
                    break;
                case 9:
                    AssLbl.Text = "Opgaver for 9. Klasse";
                    myClass = Classes.c9;
                    NatBtn.Hide();
                    break;
                case 10:
                    AssLbl.Text = "Opgaver for 10. Klasse";
                    myClass = Classes.c10;
                    NatBtn.Hide();
                    break;

                default:
                    break;

            }
        }

        //When clicking on the math button, checks the current enum for the class of the user, and directs them to the correct form (atm it just changes the label)
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
        //When clicking on the physics button, checks the current enum for the class of the user, and directs them to the correct form (atm it just changes the label)
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

        //When clicking on the Danish button, checks the current enum for the class of the user, and directs them to the correct form (atm it just changes the label)
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

        //When clicking on the English button, checks the current enum for the class of the user, and directs them to the correct form (atm it just changes the label)
        private void EngBtn_Click(object sender, EventArgs e)
        {
            switch (myClass)
            {
                case Classes.c1:
                    AssLbl.Text = "Du trykkede på knappen til Engelsk for 1. klasse";
                    break;
                case Classes.c2:
                    AssLbl.Text = "Du trykkede på knappen til Engelsk for 2. klasse";
                    break;
                case Classes.c3:
                    AssLbl.Text = "Du trykkede på knappen til Engelsk for 3. klasse";
                    break;
                case Classes.c4:
                    AssLbl.Text = "Du trykkede på knappen til Engelsk for 4. klasse";
                    break;
                case Classes.c5:
                    AssLbl.Text = "Du trykkede på knappen til Engelsk for 5. klasse";
                    break;
                case Classes.c6:
                    AssLbl.Text = "Du trykkede på knappen til Engelsk for 6. klasse";
                    break;
                case Classes.c7:
                    AssLbl.Text = "Du trykkede på knappen til Engelsk for 7. klasse";
                    break;
                case Classes.c8:
                    AssLbl.Text = "Du trykkede på knappen til Engelsk for 8. klasse";
                    break;
                case Classes.c9:
                    AssLbl.Text = "Du trykkede på knappen til Engelsk for 9. klasse";
                    break;
                case Classes.c10:
                    AssLbl.Text = "Du trykkede på knappen til Engelsk for 10. klasse";
                    break;

                default:
                    break;
            }
        }

        //When clicking on the Religion button, checks the current enum for the class of the user, and directs them to the correct form (atm it just changes the label)
        private void JesusBtn_Click(object sender, EventArgs e)
        {
            switch (myClass)
            {
                case Classes.c1:
                    AssLbl.Text = "Du trykkede på knappen til Kristendom for 1. klasse";
                    break;
                case Classes.c2:
                    AssLbl.Text = "Du trykkede på knappen til Kristendom for 2. klasse";
                    break;
                case Classes.c3:
                    AssLbl.Text = "Du trykkede på knappen til Kristendom for 3. klasse";
                    break;
                case Classes.c4:
                    AssLbl.Text = "Du trykkede på knappen til Kristendom for 4. klasse";
                    break;
                case Classes.c5:
                    AssLbl.Text = "Du trykkede på knappen til Kristendom for 5. klasse";
                    break;
                case Classes.c6:
                    AssLbl.Text = "Du trykkede på knappen til Kristendom for 6. klasse";
                    break;
                case Classes.c7:
                    AssLbl.Text = "Du trykkede på knappen til Kristendom for 7. klasse";
                    break;
                case Classes.c8:
                    AssLbl.Text = "Du trykkede på knappen til Kristendom for 8. klasse";
                    break;
                case Classes.c9:
                    AssLbl.Text = "Du trykkede på knappen til Kristendom for 9. klasse";
                    break;
                case Classes.c10:
                    AssLbl.Text = "Du trykkede på knappen til Kristendom for 10. klasse";
                    break;

                default:
                    break;
            }
        }

        //When clicking on the history button, checks the current enum for the class of the user, and directs them to the correct form (atm it just changes the label)
        private void HisBtn_Click(object sender, EventArgs e)
        {
            switch (myClass)
            {
                case Classes.c3:
                    AssLbl.Text = "Du trykkede på knappen til Historie for 3. klasse";
                    break;
                case Classes.c4:
                    AssLbl.Text = "Du trykkede på knappen til Historie for 4. klasse";
                    break;
                case Classes.c5:
                    AssLbl.Text = "Du trykkede på knappen til Historie for 5. klasse";
                    break;
                case Classes.c6:
                    AssLbl.Text = "Du trykkede på knappen til Historie for 6. klasse";
                    break;
                case Classes.c7:
                    AssLbl.Text = "Du trykkede på knappen til Historie for 7. klasse";
                    break;
                case Classes.c8:
                    AssLbl.Text = "Du trykkede på knappen til Historie for 8. klasse";
                    break;
                case Classes.c9:
                    AssLbl.Text = "Du trykkede på knappen til Historie for 9. klasse";
                    break;
                case Classes.c10:
                    AssLbl.Text = "Du trykkede på knappen til Historie for 10. klasse";
                    break;

                default:
                    break;
            }
        }

        //When clicking on the Biology button, checks the current enum for the class of the user, and directs them to the correct form (atm it just changes the label)
        private void BioBtn_Click(object sender, EventArgs e)
        {
            switch (myClass)
            {
                case Classes.c7:
                    AssLbl.Text = "Du trykkede på knappen til Biologi for 7. klasse";
                    break;
                case Classes.c8:
                    AssLbl.Text = "Du trykkede på knappen til Biologi for 8. klasse";
                    break;
                case Classes.c9:
                    AssLbl.Text = "Du trykkede på knappen til Biologi for 9. klasse";
                    break;
                case Classes.c10:
                    AssLbl.Text = "Du trykkede på knappen til Biologi for 10. klasse";
                    break;

                default:
                    break;
            }
        }

        //When clicking on the Geography button, checks the current enum for the class of the user, and directs them to the correct form (atm it just changes the label)
        private void GeoBtn_Click(object sender, EventArgs e)
        {
            switch (myClass)
            {
                case Classes.c7:
                    AssLbl.Text = "Du trykkede på knappen til Geografi for 7. klasse";
                    break;
                case Classes.c8:
                    AssLbl.Text = "Du trykkede på knappen til Geografi for 8. klasse";
                    break;
                case Classes.c9:
                    AssLbl.Text = "Du trykkede på knappen til Geografi for 9. klasse";
                    break;
                case Classes.c10:
                    AssLbl.Text = "Du trykkede på knappen til Geografi for 10. klasse";
                    break;

                default:
                    break;
            }
        }

        //When clicking on the Social studies button, checks the current enum for the class of the user, and directs them to the correct form (atm it just changes the label)
        private void SamfBtn_Click(object sender, EventArgs e)
        {
            switch (myClass)
            {
                case Classes.c8:
                    AssLbl.Text = "Du trykkede på knappen til Samfundsfag for 8. klasse";
                    break;
                case Classes.c9:
                    AssLbl.Text = "Du trykkede på knappen til Samfundsfag for 9. klasse";
                    break;
                case Classes.c10:
                    AssLbl.Text = "Du trykkede på knappen til Samfundsfag for 10. klasse";
                    break;

                default:
                    break;
            }
        }

        //When clicking on the French button, checks the current enum for the class of the user, and directs them to the correct form (atm it just changes the label)
        private void FRBtn_Click(object sender, EventArgs e)
        {
            switch (myClass)
            {
                case Classes.c5:
                    AssLbl.Text = "Du trykkede på knappen til Fransk for 5. klasse";
                    break;
                case Classes.c6:
                    AssLbl.Text = "Du trykkede på knappen til Fransk for 6. klasse";
                    break;
                case Classes.c7:
                    AssLbl.Text = "Du trykkede på knappen til Fransk for 7. klasse";
                    break;
                case Classes.c8:
                    AssLbl.Text = "Du trykkede på knappen til Fransk for 8. klasse";
                    break;
                case Classes.c9:
                    AssLbl.Text = "Du trykkede på knappen til Fransk for 9. klasse";
                    break;
                case Classes.c10:
                    AssLbl.Text = "Du trykkede på knappen til Fransk for 10. klasse";
                    break;

                default:
                    break;
            }
        }

        //When clicking on the German button, checks the current enum for the class of the user, and directs them to the correct form (atm it just changes the label)
        private void GerBtn_Click(object sender, EventArgs e)
        {
            switch (myClass)
            {
                case Classes.c5:
                    AssLbl.Text = "Du trykkede på knappen til Tysk for 5. klasse";
                    break;
                case Classes.c6:
                    AssLbl.Text = "Du trykkede på knappen til Tysk for 6. klasse";
                    break;
                case Classes.c7:
                    AssLbl.Text = "Du trykkede på knappen til Tysk for 7. klasse";
                    break;
                case Classes.c8:
                    AssLbl.Text = "Du trykkede på knappen til Tysk for 8. klasse";
                    break;
                case Classes.c9:
                    AssLbl.Text = "Du trykkede på knappen til Tysk for 9. klasse";
                    break;
                case Classes.c10:
                    AssLbl.Text = "Du trykkede på knappen til Tysk for 10. klasse";
                    break;

                default:
                    break;
            }
        }

        //When clicking on the Nature technology button, checks the current enum for the class of the user, and directs them to the correct form (atm it just changes the label)
        private void NatBtn_Click(object sender, EventArgs e)
        {
            switch (myClass)
            {
                case Classes.c1:
                    AssLbl.Text = "Du trykkede på knappen til Natur/Teknik for 1. klasse";
                    break;
                case Classes.c2:
                    AssLbl.Text = "Du trykkede på knappen til Natur/Teknik for 2. klasse";
                    break;
                case Classes.c3:
                    AssLbl.Text = "Du trykkede på knappen til Natur/Teknik for 3. klasse";
                    break;
                case Classes.c4:
                    AssLbl.Text = "Du trykkede på knappen til Natur/Teknik for 4. klasse";
                    break;
                case Classes.c5:
                    AssLbl.Text = "Du trykkede på knappen til Natur/Teknik for 5. klasse";
                    break;
                case Classes.c6:
                    AssLbl.Text = "Du trykkede på knappen til Natur/Teknik for 6. klasse";
                    break;
                default:
                    break;
            }
        }
    }
}
