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

namespace License_Management
{
    public partial class MasterForm : Syncfusion.Windows.Forms.MetroForm
    {
        DbEntities db = new DbEntities();
        public MasterForm()
        {
            InitializeComponent();
        }
        private void MasterForm_Load(object sender, EventArgs e)
        {
            EmbedFont.LoadComfortaaFont();
            EmbedFont.LoadMicrossFont();
            EmbedFont.LoadRalewayFont();
            this.CaptionFont = new Font(EmbedFont.private_fonts.Families[2], 9);

            labelcopyright.Text = "© Copyright - Powered by TabiSoft Solutions";
            labelcopyright.Font = new Font(EmbedFont.private_fonts.Families[0], 8);
        }

        private void txtpass_OnValueChanged(object sender, EventArgs e)
        {
            txtpass.isPassword = true;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            var MasPas = db.Randoms.Where(c => c.ID == 3).FirstOrDefault();

            string fdec = ClsTripleDES.LicDecrypt(MasPas.Text.ToString());

            string Dec = ClsTripleDES.DataDecrypt(fdec);

            if(txtpass.Text==Dec)
            {
                btnValidate.DialogResult = DialogResult.OK;
                labelresult.Text = "Validated!";
                labelresult.ForeColor = Color.Green;
                labelresult.Visible = true;
            }
            else
            {
                btnValidate.DialogResult = DialogResult.Cancel;
                labelresult.Text = "Not Validated!";
                labelresult.ForeColor = Color.Red;
                labelresult.Visible = true;
            }
        }
    }
}
