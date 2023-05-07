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
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }
        connect_with_sql c = new connect_with_sql();
        private void users_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.ResetText();
                }
            }
            textname.Focus();
        }

        private void btnserach_Click(object sender, EventArgs e)
        {
            if (textserah.Text != "")
            {
                DataGridView1.DataSource = c.GetDataTable("select *from users where  id=" + textserah.Text + "");

            }
        }

        private void btnrefrsh_Click(object sender, EventArgs e)
        {
            DataGridView1.DataSource = c.GetDataTable("select *from users");

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            c.execut_qurey("insert into users values('" + textname.Text + "','" + textusername.Text + "','" + textpassword.Text + "')");

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            c.execut_qurey("delete from users where id=" + textid.Text + "");

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            c.execut_qurey("update users set name='" + textname.Text + "' , username='" + textusername.Text + "', password='" + textpassword.Text + "' where id="+textid.Text+"");

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textid.Text = DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textname.Text = DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textusername.Text = DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textpassword.Text = DataGridView1.SelectedRows[0].Cells[3].Value.ToString();

        }
    }
}
