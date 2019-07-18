using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace License_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*/
            string maspas = "Islamabad942";

            string gen = ClsTripleDES.LicEncrypt(ClsTripleDES.DataEncrypt(maspas));

            label1.Text = gen;

            DbEntities db = new DbEntities();

            Random rnd = new Random()
            {
                Key="Master Password",
                Text=gen
            };

            db.Randoms.Add(rnd);
            db.SaveChanges();/*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MasterConfirm.Show();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("done");
            }
            else
            {
                MessageBox.Show("none");
            }
        }
    }
}
