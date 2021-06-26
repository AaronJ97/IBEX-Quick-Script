using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* IBEXDesigns Website and Software Development Created By Aaron Judge on 25/06/2021.  IBEXDesigns@Copyright 2021. All rights reserved
   for support on this software please contact me directly at:
    *Email Address: AJDevelopment@programmer.net  
    *GitHub: https://github.com/AaronJ97?tab=repositories
    *Facebook: https://www.facebook.com/Aaron-Judge-Development-Portfolio-105617425105373*/

namespace IBEX_Quick_Script
{
    public partial class IBEXLogin : Form
    {
        public IBEXLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username_input.Text == "IBEXDesigns@Developer.net" && password_input.Text == "IbexAdmin00")
            {
                MessageBox.Show("Welcome Back! " + username_input.Text + "We're loading your work station for you");
                IBEXQuickScript f2 = new IBEXQuickScript();
                f2.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Sorry the username or password you have entered is incorrect please try again", "IBEXDesigns Login Credential Error");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("If you have lost your password please contact IBEXDesign Support at: AJDevelopment@programmer.net  ", "IBEXDesigns Help and Support");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}

/* IBEXDesigns Website and Software Development Created By Aaron Judge  on 25/06/2021.  IBEXDesigns@Copyright 2021. All rights reserved
   for support on this software please contact me directly at:
    *Email Address: AJDevelopment@programmer.net  
    *GitHub: https://github.com/AaronJ97?tab=repositories
    *Facebook: https://www.facebook.com/Aaron-Judge-Development-Portfolio-105617425105373*/
