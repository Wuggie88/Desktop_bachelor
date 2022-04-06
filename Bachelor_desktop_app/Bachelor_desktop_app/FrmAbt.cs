using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Bachelor_desktop_app
{
    public partial class FrmAbt : Form
    {
        public FrmAbt()
        {
            InitializeComponent();
            Process[] processes = Process.GetProcessesByName("Discord");

            if (processes.Length == 0)
            {
                abtLbl.Text = "Discord isn't running";
            }
            else
            {
                abtLbl.Text = "Discord is running";
            }
        }
    }
}
