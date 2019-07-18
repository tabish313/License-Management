#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace License_Management
{
    partial class MasterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.labelcopyright = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnValidate = new Syncfusion.WinForms.Controls.SfButton();
            this.labelresult = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.labelcopyright);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 74);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(348, 24);
            this.bunifuGradientPanel1.TabIndex = 12;
            // 
            // labelcopyright
            // 
            this.labelcopyright.BackColor = System.Drawing.Color.Transparent;
            this.labelcopyright.ForeColor = System.Drawing.Color.Gray;
            this.labelcopyright.Location = new System.Drawing.Point(31, 4);
            this.labelcopyright.Name = "labelcopyright";
            this.labelcopyright.Size = new System.Drawing.Size(307, 17);
            this.labelcopyright.TabIndex = 0;
            this.labelcopyright.Text = "Loading...";
            this.labelcopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::License_Management.Properties.Resources.Logo_png;
            this.pictureBox1.Location = new System.Drawing.Point(20, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.White;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(182)))));
            this.txtpass.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(182)))));
            this.txtpass.HintText = "Master Password";
            this.txtpass.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtpass.isPassword = false;
            this.txtpass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(182)))));
            this.txtpass.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(182)))));
            this.txtpass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(189)))), ((int)(((byte)(182)))));
            this.txtpass.LineThickness = 1;
            this.txtpass.Location = new System.Drawing.Point(70, 13);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(141, 28);
            this.txtpass.TabIndex = 15;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtpass.OnValueChanged += new System.EventHandler(this.txtpass_OnValueChanged);
            // 
            // btnValidate
            // 
            this.btnValidate.AccessibleName = "Button";
            this.btnValidate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnValidate.Location = new System.Drawing.Point(232, 16);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(96, 26);
            this.btnValidate.TabIndex = 16;
            this.btnValidate.Text = "Validate";
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // labelresult
            // 
            this.labelresult.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelresult.Location = new System.Drawing.Point(0, 48);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(348, 23);
            this.labelresult.TabIndex = 17;
            this.labelresult.Text = "label1";
            this.labelresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelresult.Visible = false;
            // 
            // MasterForm
            // 
            this.AcceptButton = this.btnValidate;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.BorderThickness = 2;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(348, 98);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.Name = "MasterForm";
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Password";
            this.Load += new System.EventHandler(this.MasterForm_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label labelcopyright;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtpass;
        private Syncfusion.WinForms.Controls.SfButton btnValidate;
        private System.Windows.Forms.Label labelresult;
    }
}

