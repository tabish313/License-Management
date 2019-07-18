#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace License_Management
{
    public partial class FormLogin : MetroForm
    {
        DbEntities db = new DbEntities();
        public FormLogin()
        {
            InitializeComponent();
            label1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            EmbedFont.LoadComfortaaFont();
            EmbedFont.LoadMicrossFont();
            EmbedFont.LoadRalewayFont();
            this.CaptionFont = new Font(EmbedFont.private_fonts.Families[2], 9);
            label1.Font = new Font(EmbedFont.private_fonts.Families[0], 16);

            labelcopyright.Text = "© Copyright - Powered by TabiSoft Solutions";
            labelcopyright.Font = new Font(EmbedFont.private_fonts.Families[0], 8);
            label1.Focus();
        }

        private void txtpass_OnValueChanged(object sender, EventArgs e)
        {
            txtpass.isPassword = true;
        }

        private void FormLogin_Activated(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "" && txtpass.Text != "")
            {
                var usercheck = db.Randoms.Where(c => c.ID == 1).FirstOrDefault();
                var passcheck = db.Randoms.Where(c => c.ID == 2).FirstOrDefault();
                if (usercheck != null)
                {

                    if (txtuser.Text == ClsTripleDES.LicDecrypt(usercheck.Text) && txtpass.Text == ClsTripleDES.LicDecrypt(passcheck.Text))
                    {
                        this.Hide();
                        FormDashboard dsh = new FormDashboard();
                        dsh.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Credientials!", "License Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Enter your Credientials!", "License Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
