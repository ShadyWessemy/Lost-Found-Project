using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_system_design
{
    public partial class Search : Form
    {
        public static string valuekind;
        public static string valuegov;
        public static string valuename;
        public static string valueno;



        public Search()
        {
            InitializeComponent();
        }

        private void searchbutton_Click(object sender, EventArgs e) // search button
        {
            valuekind = kind1combo.Text;
            valuegov = gov1combo.Text;
            valuename = name1text.Text;
            valueno = no1text.Text;
            
            if ((valuekind==admin.kind1 && valuegov==admin.gov1&&valuename==admin.name1)||valueno==admin.no1)
            {
                this.Hide();
                Preview f2 = new Preview();
                f2.ShowDialog();
                this.Close();
            }
            else if((valuekind == admin.kind2 && valuegov == admin.gov2 && valuename == admin.name2)||valueno == admin.no2)
            {
                MessageBox.Show(" تم تسليم المفقود برقم 0000 بتاريخ 1/1/2000 يمكن البحث عن هذا المفقود في الجهة الخاصة");
            }
            else
            {
                MessageBox.Show("لم يتم إيجاد هذا المفقود");
            }
            
        }

        private void button2_Click(object sender, EventArgs e) // back button
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
            this.Close();
        }
    }
}
