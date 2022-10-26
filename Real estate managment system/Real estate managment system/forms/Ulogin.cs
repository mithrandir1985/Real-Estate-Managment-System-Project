using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_estate_managment_system.forms
{
    public partial class Ulogin : Form
    {
        public Ulogin()
        {
            InitializeComponent();
        }

        private void exit_MouseHover(object sender, EventArgs e)
        {
            exit.BackColor = Color.Red;
        }
    }
}
