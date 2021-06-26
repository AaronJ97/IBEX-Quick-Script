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
    public partial class IBEXQuickScript : Form
    {
        public IBEXQuickScript()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://onedrive.live.com/");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter sr = new System.IO.StreamWriter(sfd.FileName, !checkBoxOverwrite.Checked))
                {
                    foreach (var line in richTextBox1.Lines)
                    {
                        sr.WriteLine(line);
                    }
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string srcView = @"https://www.google.com/search?q=";
            System.Diagnostics.Process.Start(srcView + urlBox1.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/AaronJ97?tab=repositories");
        }

        private void urlBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

/* IBEXDesigns Website and Software Development Created By Aaron Judge on 25/06/2021.  IBEXDesigns@Copyright 2021. All rights reserved
   for support on this software please contact me directly at:
    *Email Address: AJDevelopment@programmer.net  
    *GitHub: https://github.com/AaronJ97?tab=repositories
    *Facebook: https://www.facebook.com/Aaron-Judge-Development-Portfolio-105617425105373*/
