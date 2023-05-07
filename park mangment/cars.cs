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
    public partial class cars : Form
    {
        public cars()
        {
            InitializeComponent();
        }
        connect_with_sql c = new connect_with_sql();
        private void btnrefrsh_Click(object sender, EventArgs e)
        {
            DataGridView1.DataSource = c.GetDataTable("select *from car");
            DataTable dtsmall = c.GetDataTable("select *from car where type_car='small'");
            DataTable dtsbig = c.GetDataTable("select *from car where type_car='big'");
            if(dtsmall.Rows.Count>0)
            {
                lbcarsmall.Text ="Cars Small: "+ dtsmall.Rows.Count.ToString();
            }
            else
            {
                lbcarsmall.Text = "Cars Small: 0";
            }

            if (dtsbig.Rows.Count > 0)
            {
                lbbigcar.Text = "Cars Big: " + dtsbig.Rows.Count.ToString();
            }
            else
            {
                lbbigcar.Text = "Cars Big: 0";
            }

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
            text_num.Focus();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {

            c.execut_qurey("insert into car values('"+text_num.Text+"','"+text_type.Text+"','"+textphone.Text+"')");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            c.execut_qurey("delete from car where id=" + textid.Text + "");

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            c.execut_qurey("update car set car_num='" + text_num.Text + "' , type_car='" + text_type.Text + "', phone_person='" + textphone.Text + "' where id="+textid.Text+"");

        }

        private void btnserach_Click(object sender, EventArgs e)
        {
            if (textserah.Text != "")
            {
                DataGridView1.DataSource = c.GetDataTable("select *from car where  car_num=" + textserah.Text + "");

            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textid.Text= DataGridView1.SelectedRows[0].Cells[0].Value.ToString();             
            text_num.Text = DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            text_type.Text = DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textphone.Text = DataGridView1.SelectedRows[0].Cells[3].Value.ToString();

        }
    }
}
