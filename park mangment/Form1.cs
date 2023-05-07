using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static park_mangment.Home;

namespace park_mangment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            connect_with_sql c=new connect_with_sql();
            DataTable dt=c.GetDataTable("select username,password from users where username='" + textusername.Text + "' and password='"+textpassword.Text +"'");
            if (dt.Rows.Count > 0)
            {
                
                    Home f = new Home();
                    this.Hide();
                    f.Show();


            }
            else
            {
                MessageBox.Show("Error..!");
            }
        }
    }
}
