using RMS.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS
{
    public partial class clientregistration : Form
    {
        public clientregistration()
        {
            InitializeComponent();
        }
        public string idgen()
        {
            string oid = "AB";
            Random rand = new Random();
            string no = rand.Next(0, 9999).ToString("D4");
            string nid = oid + no;
            return nid;
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BC_Click(object sender, EventArgs e)
        {
            CFN.Text = "";
            CLN.Text = "";
            CE.Text = "";
            radioButtonmale.Checked = false;
            radioButtonfemale.Checked = false;
             CUN.Text = "";
            CP.Text = "";
        }

        private void close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BB_Click(object sender, EventArgs e)
        {
            this.Close();
            userlogin l = new userlogin();
            l.Show();

        }

        private void BR_Click(object sender, EventArgs e)
        {
            bool isVal = true;
            //First Name
            if (string.IsNullOrEmpty(CFN.Text))
            {
                isVal = false;
                errorProviderFN.SetError(CFN, "Name is Required");
            }
            else
         
                errorProviderFN.Clear();
            //Last Name
            if (string.IsNullOrEmpty(CLN.Text))
            {
                isVal = false;
                errorProviderLN.SetError(CLN, "Name is Required");
            }
            else
                errorProviderLN.Clear();
            //Email
            if (string.IsNullOrEmpty(CE.Text))
            {
                isVal = false;
                errorProviderE.SetError(CE, "Email is Required");
            }
            else if (!Regex.IsMatch(CE.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {
                isVal = false;
                errorProviderE.SetError(CE, "Enter a valid Email");
            }
            else
                errorProviderE.Clear();
            //DoB
            if (string.IsNullOrEmpty(CDFB.Text))
            {
                isVal = false;
                errorProviderDFB.SetError(CDFB, "Dob is Required");
            }
            else if ((int)((DateTime.Now - CDFB.Value).TotalDays / 365.242199) < 18)
            {
                isVal = false;
                errorProviderDFB.SetError(CDFB, "Should be above 18 to register");
            }
            else
                errorProviderDFB.Clear();
            //Gender
            if (!radioButtonmale.Checked && !radioButtonfemale.Checked)
            {
                isVal = false;
                errorProviderG.SetError(radioButton2, "Choose Gender");
            }
            else
                errorProviderG.Clear();
            //User
            if (string.IsNullOrEmpty(CUN.Text))
            {
                isVal = false;
                errorProviderUN.SetError(CUN, "UserName Required");
            }
            else
            {
                errorProviderUN.Clear();
                try
                {
                    var Uname = User.findUser(CUN.Text);
                    if (Uname != null)
                    {
                        isVal = false;
                        errorProviderUN.SetError(CUN, "User Name already Exists");
                    }
                    else
                        errorProviderUN.Clear();
                }
                catch
                {
                    isVal = false;
                    errorProviderUN.SetError(CUN, "UserName Required");
                };
            }













        }
    }
}
