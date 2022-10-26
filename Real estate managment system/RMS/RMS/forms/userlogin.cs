using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS.forms
{
    public partial class userlogin : Form
    {
        public userlogin()
        {
            InitializeComponent();
        }

        private void Exit_MouseHover(object sender, EventArgs e)
        {
           this.Exit.BackColor = Color.Red;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            this.Exit.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Checkfilds();
            bool tf = Checkfilds();
            try {
                if (tf)
                {
                    string username, password;
                    username = usernametxt.Text;
                    password = passwordtxt.Text;
                    string query = "SELECT * FROM Customer WHERE Username = '" + usernametxt.Text + "' AND Pass ='" + passwordtxt.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, Datacon.con());

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        username = usernametxt.Text;
                        password = passwordtxt.Text;

                        // page needed to be loaded next
                        //create obj then .Show() it
                        //last this.Hide()
                        transfer t = new transfer
                        {
                            usern = usernametxt.Text,
                            pass = passwordtxt.Text,
                        };
                        t.trans();
                       Clientdashbord m = new Clientdashbord();
                       m.Show();
                       this.Close();
                    }
                    else
                    {
                        /*MessageBox.Show("Invalid login details","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        textBox1.Clear();
                        textBox2.Clear();
                        */
                        erroruname.SetError(usernametxt, "Invalid Login Detail");
                       errorpassword.SetError(passwordtxt, "Invalid Login Detail");
                        //to focus on username
                        usernametxt.Focus();
                        usernametxt.BackColor = Color.White;
                        passwordtxt.BackColor = SystemColors.ControlLight;
                    }
                }
                    
                        
                        
             }
            catch
            {
                MessageBox.Show("ERROR - No accounts found");
            }

       }
        bool Checkfilds()
        {
            
            
                erroruname.Clear();
                errorpassword.Clear();
                if (passwordtxt.Text == string.Empty && usernametxt.Text == string.Empty)
                {

                    usernametxt.Focus();
                    erroruname.SetError(usernametxt, "please enter your username");
                    passwordtxt.Focus();
                    errorpassword.SetError(passwordtxt, "please enter your password");
                    return false;
                }

                else if (usernametxt.Text == string.Empty)
                {
                    erroruname.Clear();
                    usernametxt.Focus();
                    erroruname.SetError(usernametxt, "please enter your username");
                    return false;
                }
                else if (passwordtxt.Text == string.Empty)
                {
                    errorpassword.Clear();
                    passwordtxt.Focus();
                    errorpassword.SetError(passwordtxt, "please enter your password");
                    return false;
                }

                else
                {
              
                    return true;
                    erroruname.SetError(usernametxt, null);
              

            }



            }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }

