#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace License_Management
{
    public partial class FormDashboard : Syncfusion.Windows.Forms.MetroForm
    {
        DbEntities db = new DbEntities();
        

        OpenFileDialog openFileDialog;
        string filepath = "";

        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {

            EmbedFont.LoadComfortaaFont();
            EmbedFont.LoadMicrossFont();
            EmbedFont.LoadRalewayFont();
            this.CaptionFont = new Font(EmbedFont.private_fonts.Families[2], 9);
            label1.Font = new Font(EmbedFont.private_fonts.Families[0], 16);

            btndashbaord.TextFont = new Font(EmbedFont.private_fonts.Families[0], 9);
            btnactivelic.TextFont = new Font(EmbedFont.private_fonts.Families[0], 9);
            btnexplic.TextFont = new Font(EmbedFont.private_fonts.Families[0], 9);
            btnlicreg.TextFont = new Font(EmbedFont.private_fonts.Families[0], 9);
            btnRequests.TextFont = new Font(EmbedFont.private_fonts.Families[0], 9);
            btnsetting.TextFont = new Font(EmbedFont.private_fonts.Families[0], 9);
            btnlogout.TextFont = new Font(EmbedFont.private_fonts.Families[0], 9);


            labeltotalusers.Font = new Font(EmbedFont.private_fonts.Families[0], 9);
            labelactlic.Font = new Font(EmbedFont.private_fonts.Families[0], 9);
            labelexplic.Font = new Font(EmbedFont.private_fonts.Families[0], 9);
            labeltotalcnt.Font = new Font(EmbedFont.private_fonts.Families[0], 9);
            labelactcnt.Font = new Font(EmbedFont.private_fonts.Families[0], 9);
            labelexpcnt.Font = new Font(EmbedFont.private_fonts.Families[0], 9);

            labelactlicmain.Font = new Font(EmbedFont.private_fonts.Families[0], 16);
            labelLicReg.Font = new Font(EmbedFont.private_fonts.Families[0], 16);
            

            labelcopyright.Text = "© Copyright - Powered by TabiSoft Solutions";
            labelcopyright.Font = new Font(EmbedFont.private_fonts.Families[0], 8);

        }

        private void btndashbaord_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                return;
            }
            else
            {
                tabControl1.SelectedIndex = 0;
            }
        }


        private void btnactivelic_Click(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 1)
            {
                return;
            }
            else
            {
                tabControl1.SelectedIndex = 1;

            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    this.btndashbaord.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(192)))), ((int)(((byte)(54)))));
                    this.btnactivelic.Normalcolor = Color.Transparent;
                    this.btnexplic.Normalcolor = Color.Transparent;
                    this.btnlicreg.Normalcolor = Color.Transparent;
                    this.btnRequests.Normalcolor = Color.Transparent;
                    this.btnsetting.Normalcolor = Color.Transparent;
                    this.btnlogout.Normalcolor = Color.Transparent;
                    break;
                case 1:
                    this.btndashbaord.Normalcolor = Color.Transparent;
                    this.btnactivelic.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(192)))), ((int)(((byte)(54)))));
                    this.btnexplic.Normalcolor = Color.Transparent;
                    this.btnlicreg.Normalcolor = Color.Transparent;
                    this.btnRequests.Normalcolor = Color.Transparent;
                    this.btnsetting.Normalcolor = Color.Transparent;
                    this.btnlogout.Normalcolor = Color.Transparent;
                    break;
                case 2:
                    this.btndashbaord.Normalcolor = Color.Transparent;
                    this.btnactivelic.Normalcolor = Color.Transparent;
                    this.btnexplic.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(192)))), ((int)(((byte)(54)))));
                    this.btnlicreg.Normalcolor = Color.Transparent;
                    this.btnRequests.Normalcolor = Color.Transparent;
                    this.btnsetting.Normalcolor = Color.Transparent;
                    this.btnlogout.Normalcolor = Color.Transparent;
                    break;
                case 3:
                    this.btndashbaord.Normalcolor = Color.Transparent;
                    this.btnactivelic.Normalcolor = Color.Transparent;
                    this.btnexplic.Normalcolor = Color.Transparent;
                    this.btnlicreg.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(192)))), ((int)(((byte)(54)))));
                    this.btnRequests.Normalcolor = Color.Transparent;
                    this.btnsetting.Normalcolor = Color.Transparent;
                    this.btnlogout.Normalcolor = Color.Transparent;
                    break;
                case 4:
                    this.btndashbaord.Normalcolor = Color.Transparent;
                    this.btnactivelic.Normalcolor = Color.Transparent;
                    this.btnexplic.Normalcolor = Color.Transparent;
                    this.btnlicreg.Normalcolor = Color.Transparent;
                    this.btnRequests.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(192)))), ((int)(((byte)(54)))));
                    this.btnsetting.Normalcolor = Color.Transparent;
                    this.btnlogout.Normalcolor = Color.Transparent;
                    break;
                case 5:
                    this.btndashbaord.Normalcolor = Color.Transparent;
                    this.btnactivelic.Normalcolor = Color.Transparent;
                    this.btnexplic.Normalcolor = Color.Transparent;
                    this.btnlicreg.Normalcolor = Color.Transparent;
                    this.btnRequests.Normalcolor = Color.Transparent;
                    this.btnsetting.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(192)))), ((int)(((byte)(54)))));
                    this.btnlogout.Normalcolor = Color.Transparent;
                    break;
            }
        }

        private void FormDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log Out - License Management", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                this.Hide();

                FormLogin lgn = new FormLogin();
                lgn.ShowDialog();
            }
        }

        private void btnlicreg_Click(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 3)
            {
                return;
            }
            else
            {
                tabControl1.SelectedIndex = 3;

            }
        }

        private void radioButtonDays_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDays.Checked)
            {
                tabControlextend.SelectedIndex = 0;
            }
        }

        private void radioButtonMonths_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMonths.Checked)
            {
                tabControlextend.SelectedIndex = 1;
            }
        }

        private void radioButtonYears_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonYears.Checked)
            {
                tabControlextend.SelectedIndex = 2;
            }
        }

        private void tabPageDefault_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonOfflineDays_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOfflineDays.Checked)
            {
                tabControloffline.SelectedIndex = 0;
            }
        }

        private void radioButtonfflineMonths_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonfflineMonths.Checked)
            {
                tabControloffline.SelectedIndex = 1;
            }
        }

        private void radioButtonOfflineYears_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOfflineYears.Checked)
            {
                tabControloffline.SelectedIndex = 2;
            }
        }

        bool done = false;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "license files (*.lic)|*.lic";
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;
                txtfilename.Text = Path.GetFileName(filepath);

                string[] lines = File.ReadAllLines(filepath);

                var arr = lines[7].Split(':');

                string dec = ClsTripleDES.DataDecrypt(arr[1].ToString());

                var licArr = dec.Split(',');

                txtofflicstarts.Text = licArr[0];

                txtofflicends.Text = licArr[1];

                txtoffsoftId.Text = licArr[2];

                txtoffownername.Text = licArr[3];

                txtoffschoolname.Text = licArr[4];

                done = true;
            }
        }

        string licends = "";
        private void btnoffupgrade_Click(object sender, EventArgs e)
        {
            DateTime dateTimeNow = DateTime.Now;


            if (done)
            {
                if (radioButtonOfflineDays.Checked)
                {
                    if (txtoffdays.Text != "")
                    {
                        int days;
                        bool intcheck = int.TryParse(txtoffdays.Text, out days);

                        if (intcheck)
                        {
                            if (days >= 1 && days <= 30)
                            {

                                licends = dateTimeNow.AddDays(days).ToString("dd/MM/yyyy");
                                UpdrageOffline();
                            }
                            else
                            {
                                MessageBox.Show("Please enter days between 1 to 30!", "License Management System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter days in a correct format!", "License Management System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter a days!", "License Management System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }

                if (radioButtonfflineMonths.Checked)
                {
                    if (txtoffmonths.Text != "")
                    {
                        int months;
                        bool intcheck = int.TryParse(txtoffmonths.Text, out months);

                        if (intcheck)
                        {
                            if (months >= 1 && months <= 30)
                            {
                                licends = dateTimeNow.AddMonths(months).ToString("dd/MM/yyyy");
                                UpdrageOffline();
                            }
                            else
                            {
                                MessageBox.Show("Please enter months between 1 to 12!", "License Management System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter months in a correct format!", "License Management System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter a Months!", "License Management System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }

                if (radioButtonOfflineYears.Checked)
                {
                    if (txtoffyear.Text != "")
                    {
                        int year;
                        bool intcheck = int.TryParse(txtoffyear.Text, out year);

                        if (intcheck)
                        {
                            if (year >= 1 && year <= 30)
                            {
                                licends = dateTimeNow.AddYears(year).ToString("dd/MM/yyyy");
                                UpdrageOffline();
                            }
                            else
                            {
                                MessageBox.Show("Please enter year between 1 to 5!", "License Management System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter year in a correct format!", "License Management System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter a Year(s)!", "License Management System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }

                
            }
        }

        public void UpdrageOffline()
        {
            if (MasterConfirm.Show() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(filepath);

                string licHash = DateTime.Now.ToString("dd/MM/yyyy") + "," + licends + "," + txtoffsoftId.Text.Substring(0, 18) + "," + txtoffownername.Text + "," + txtoffschoolname.Text + "," + "False";

                lines[7] = "License Hash:" + ClsTripleDES.DataEncrypt(licHash);

                File.WriteAllLines(filepath, lines);

                MessageBox.Show("Program Updated Successfully until " + licends + "!", "License Management System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                txtofflicstarts.Text = "";

                txtofflicends.Text = "";

                txtoffsoftId.Text = "";

                txtoffownername.Text = "";

                txtoffschoolname.Text = "";

                txtfilename.Text = "";

                done = false;

                txtoffdays.Text = "";

                txtoffmonths.Text = "";

                txtoffdays.Text = "";

                if (openFileDialog.FileName != null)
                {
                    openFileDialog.Dispose();
                }
            }
        }

        private void btnoffReset_Click(object sender, EventArgs e)
        {
            txtofflicstarts.Text = "";

            txtofflicends.Text = "";

            txtoffsoftId.Text = "";

            txtoffownername.Text = "";

            txtoffschoolname.Text = "";

            txtfilename.Text = "";

            done = false;

            txtoffdays.Text = "";

            txtoffmonths.Text = "";

            txtoffdays.Text = "";

            if (openFileDialog.FileName != null)
            {
                openFileDialog.Dispose();
            }
            
        }

        BackgroundWorker bwfetch;
        bool Op = false;
        string owner;
        string school;
        string email;
        string contact;
        string licstarts;
        string licend;
        string installdate;
        private void btnFetch_Click(object sender, EventArgs e)
        {

            bwfetch = new BackgroundWorker();
            bwfetch.DoWork += Bwfetch_DoWork;
            bwfetch.RunWorkerCompleted += Bwfetch_RunWorkerCompleted;

            if (txtonSoftId.Text != "")
            {
                if (IsConnectedToNetwork)
                {

                    if (!bwfetch.IsBusy)
                    {
                        btnFetch.Enabled = false;
                        pictureBoxFetchLoader.Visible = true;
                        bwfetch.RunWorkerAsync();
                    }
                }
                else
                {
                    MessageBox.Show("No Internet Availabe!", "License Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Software ID!", "License Management System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        

        private void Bwfetch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            btnFetch.Enabled = true;
            pictureBoxFetchLoader.Visible = false;
            if (!Op)
            {
                MessageBox.Show("No record found with this Software ID!", "License Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtonownername.Text = owner;
                txtonschoolname.Text = school;
                txtOnEmail.Text = email;
                txtOnContact.Text = contact;
                txtOnInstallation.Text = installdate;
                txtOnLicStarts.Text = licstarts;
                txtOnLicEnds.Text = licend;
            }
        }

        private void Bwfetch_DoWork(object sender, DoWorkEventArgs e)
        {
            LicenseEntity licdb = new LicenseEntity();

            var IDCheck = licdb.Licenses.Where(c => c.SoftwareID == txtonSoftId.Text).FirstOrDefault();
            if (IDCheck != null)
            {
                owner = IDCheck.OwnerName;
                school = IDCheck.SchoolName;
                email = IDCheck.SchoolEmail;
                contact = IDCheck.SchoolContact;
                installdate = IDCheck.IstallationDate;
                licstarts = IDCheck.LicenseStarts;
                licend = IDCheck.LicenseEnds;

                Op = true;
            }
            else
            {
                Op = false;
            }
        }


        BackgroundWorker bwsave;
        LicenseEntity licdb;
        private void btnOnlineSave_Click(object sender, EventArgs e)
        {
            bwsave = new BackgroundWorker();
            bwsave.DoWork += Bwsave_DoWork;
            bwsave.RunWorkerCompleted += Bwsave_RunWorkerCompleted;

            if (IsConnectedToNetwork)
            {
                if (!bwsave.IsBusy)
                {
                    btnOnlineSave.Enabled = false;
                    btnFetch.Enabled = false;
                    btnonlineReset.Enabled = false;
                    pictureBoxSave.Visible = true;
                    bwsave.RunWorkerAsync();
                }
            }
            else
            {
                MessageBox.Show("No Internet Availabe!", "License Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Bwsave_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBoxSave.Visible = false;
            btnOnlineSave.Enabled = true;
            btnFetch.Enabled = true;
            btnonlineReset.Enabled = true;
        }

        private void Bwsave_DoWork(object sender, DoWorkEventArgs e)
        {
             licdb = new LicenseEntity();

            var det = licdb.Licenses.Where(c => c.SoftwareID == txtonSoftId.Text).FirstOrDefault();

            det.LicenseStarts = DateTime.Now.ToString("dd/MM/yyyy");

            det.IsPayment = true;

            det.InProcess = false;


            if (radioButtonDays.Checked)
            {
                if (txtOnDays.Text != "")
                {
                    int days = Convert.ToInt32(txtOnDays.Text);
                    if (days >= 1 && days <= 30)
                    {
                        det.LicenseEnds = DateTime.Now.AddDays(days).ToString("dd/MM/yyyy");
                        licdb.Entry(det).State = System.Data.Entity.EntityState.Modified;
                        UpgradeOnline();
                    }
                    else
                    {
                        MessageBox.Show("Please enter days between 1 to 30!", "License Management System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter a days!", "License Management System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }

            if (radioButtonMonths.Checked)
            {
                if (txtonMonths.Text != "")
                {
                    int months = Convert.ToInt32(txtonMonths.Text);
                    if (months >= 1 && months <= 12)
                    {
                        det.LicenseEnds = DateTime.Now.AddMonths(months).ToString("dd/MM/yyyy");
                        licdb.Entry(det).State = System.Data.Entity.EntityState.Modified;
                        UpgradeOnline();
                    }
                    else
                    {
                        MessageBox.Show("Please enter months between 1 to 12!", "License Management System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter a months!", "License Management System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }

            if (radioButtonYears.Checked)
            {
                if (txtOnyears.Text != "")
                {
                    int years = Convert.ToInt32(txtOnyears.Text);
                    if (years >= 1 && years <= 5)
                    {
                        det.LicenseEnds = DateTime.Now.AddYears(years).ToString("dd/MM/yyyy");
                        licdb.Entry(det).State = System.Data.Entity.EntityState.Modified;
                        UpgradeOnline();
                    }
                    else
                    {
                        MessageBox.Show("Please enter years between 1 to 5!", "License Management System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter a Year(s)!", "License Management System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }


        }

        public void UpgradeOnline()
        {
            MasterConfirm.Show();
        }

        #region OnlyNumeric

        private void txtOnDays_OnValueChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtOnDays.Text, "  ^ [0-9]"))
            {
                txtOnDays.Text = "";
            }
        }

        private void txtOnDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public bool IsConnectedToNetwork
        {
            get
            {
                Network network = new Network();
                return network.IsAvailable;
            }
        }

        private void txtonMonths_OnValueChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtonMonths.Text, "  ^ [0-9]"))
            {
                txtonMonths.Text = "";
            }
        }

        private void txtonMonths_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtOnyears_OnValueChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtOnyears.Text, "  ^ [0-9]"))
            {
                txtOnyears.Text = "";
            }
        }

        private void txtOnyears_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}

