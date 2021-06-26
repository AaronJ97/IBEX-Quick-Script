$IBEX-Quick-Script
-------------------
Username: IBEXDesigns@Developer.net
Password: IbexAdmin00 

a simple code/text editor C# Beginner Portfolio Project.IBEXDesigns Website and Software Development Created By Aaron Judge on 25/06/2021.
IBEXDesigns@Copyright 2021. All rights reserved. For support on this software please contact me directly at:
   *Email Address: AJDevelopment@programmer.net 


$Features
----------
    1*simple password login system to use the software the username is IBEXDesigns@Developer.net and the Password is IbexAdmin00 
     this is a test email and password it doesn't go anywhere. Here is a sample of the password login code:
    
        if (username_input.Text == "IBEXDesigns@Developer.net" && password_input.Text == "IbexAdmin00")
            {
                MessageBox.Show("Welcome Back! " + username_input.Text + "We're loading your work station for you");
            }
    2*Google search capability (just use a '+' rather than spaces. contributions, help and advice is welcomed.
    
        private void button3_Click(object sender, EventArgs e)
        {
            string srcView = @"https://www.google.com/search?q=";
            System.Diagnostics.Process.Start(srcView + urlBox1.Text);
        }
        
   3*Uses StreamReader and StreamWriter for opening and saving files.
        //Opening a File using the OpenFIleDialog.
        OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
            }
        
        //Saving a file using the SaveFIleFDialog.
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
            
$Usage Instructions
--------------------
It's fairly simple to use simply type in the email and password (shown above) and edit your simple python, js, css, html or text files. 
everything else is fairly easy to use if you want to open onedrive.live theres a button that opens it.
            
   
   
   
$Support And Contributions
---------------------------
   IBEXDesigns Website and Software Development Created By Aaron Judge on 25/06/2021.  IBEXDesigns@Copyright 2021. All rights reserved
   for support on this software please contact me directly at:
    *Email Address: AJDevelopment@programmer.net  
    *GitHub: https://github.com/AaronJ97?tab=repositories
    *Facebook: https://www.facebook.com/Aaron-Judge-Development-Portfolio-105617425105373*/
    *Pull Requests: https://github.com/AaronJ97/IBEX-Quick-Script/pulls
    *Source Code: https://github.com/AaronJ97/IBEX-Quick-Script
    
    
Licensing
---------
 
 BSD 2-Clause License

Copyright (c) 2021, AaronJ97
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:

1. Redistributions of source code must retain the above copyright notice, this
   list of conditions and the following disclaimer.

2. Redistributions in binary form must reproduce the above copyright notice,
   this list of conditions and the following disclaimer in the documentation
   and/or other materials provided with the distribution.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
