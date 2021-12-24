using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project_system_design
{
    public partial class Estlam : Form
    {
        public Estlam()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // places
        {
            places p = new places();
            p.ShowDialog();
        }

        private void Estlam_Load(object sender, EventArgs e)
        {
            label1.Text = admin.gov1;
            label3.Text = "شارع محمد فريد-ميدان التحرير";
        }

        private void button1_Click(object sender, EventArgs e) // back button
        {
            this.Hide();
            Preview p = new Preview();
            p.ShowDialog();
            this.Close();
        }
    }
}
