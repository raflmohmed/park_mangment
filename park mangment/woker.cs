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
    public partial class woker : Form
    {
        public woker()
        {
            InitializeComponent();
        }
        connect_with_sql c = new connect_with_sql();

        private void btnrefrsh_Click(object sender, EventArgs e)
        {
           DataGridView1.DataSource = c.GetDataTable("select *from worker_park");
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
            textfirstname.Focus();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            c.execut_qurey("insert into worker_park values('"+textfirstname.Text+"', '"+textlastname.Text+"','"+textphone.Text+"')");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            c.execut_qurey("delete from worker_park where id="+textid.Text+"");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            c.execut_qurey("update worker_park set first_name='"+textfirstname.Text+ "' , last_name='"+textlastname.Text+ "', phone='"+textphone.Text+"' where id="+textid.Text+"");
        }

        private void btnserach_Click(object sender, EventArgs e)
        {

            if (textserah.Text != "")
            {
                DataGridView1.DataSource = c.GetDataTable("select *from worker_park where  id=" + textserah.Text + "");

            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textid.Text = DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textfirstname.Text = DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textlastname.Text = DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textphone.Text = DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
