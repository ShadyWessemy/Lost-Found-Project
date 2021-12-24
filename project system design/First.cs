using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project_system_design
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void searchbutton_Click(object sender, EventArgs e) // admin button
        { 
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) // user button
        {
            this.Hide();
            Search s = new Search();
            s.ShowDialog();
            this.Close();
        }
    }
}
