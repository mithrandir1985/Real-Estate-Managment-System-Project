using RMS.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS
{
    public partial class Clientdashbord : Form
    {
        public Clientdashbord()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.DarkSlateGray;
            ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.DarkSeaGreen;
            ForeColor = Color.White;

        }

        private void baproperty_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.DarkSlateGray;
            ForeColor = Color.White;
        }

        private void baproperty_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.DarkSeaGreen;
            ForeColor = Color.White;

        }

        private void bsearchp_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.DarkSlateGray;
            ForeColor = Color.White;
        }

        private void bsearchp_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.DarkSeaGreen;
            ForeColor = Color.White;

        }

        private void bby_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.DarkSlateGray;
            ForeColor = Color.White;
        }

        private void bby_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.DarkSeaGreen;
            ForeColor = Color.White;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
            userlogin l = new userlogin();
            l.Show();

        }
    }
}
