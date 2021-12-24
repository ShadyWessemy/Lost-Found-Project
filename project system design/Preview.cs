using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project_system_design
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            kind2res.Text = Search.valuekind;
            name2res.Text = Search.valuename;
        }

        private void button1_Click(object sender, EventArgs e) // estlam 
        {
            Estlam e1 = new Estlam();
            e1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) 
        {
       
        }

        private void deliverbutton_Click(object sender, EventArgs e) // button eltawseel
        {
            this.Hide();
            Tawseel t = new Tawseel();
            t.ShowDialog();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e) // back button
        {
            this.Hide();
            Search s = new Search();
            s.ShowDialog();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e) // button elrsoom
        {
            pricescs p = new pricescs();
            p.ShowDialog();     
        }
    }
}
