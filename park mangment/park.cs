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
    public partial class park : Form
    {
        public park()
        {
            InitializeComponent();
        }
        connect_with_sql c = new connect_with_sql();
        private void btnadd_Click(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
            {
                if( control is TextBox )
                {
                    control.ResetText();
                }
            }
            textid_car.Focus();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            DataTable dt = c.GetDataTable("select type_car from car where id="+textid_car.Text+"");
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                string timelogin=string.Empty;
                if (dr[0].ToString()=="small")
                {
                    timelogin = "5:00AM";
                }
                else
                {
                    timelogin = "10:00PM";
                }
                c.execut_qurey("insert into parking values(" + textid_car.Text + ",'" + textnum_car.Text + "', '" + textposition.Text + "','" + timelogin + "', '" + textlogout_time.Text + "'," + textidworker.Text + ",'" + textnameworkerr.Text + "')");
            }
            else
            {
                MessageBox.Show("this car is not Register.");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            c.execut_qurey("delete from parking where id="+textid.Text+"");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            DataTable dt = c.GetDataTable("select type_car from car where id=" + textid_car.Text + "");
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                string timelogin = string.Empty;
                if (dr[0].ToString() == "small")
                {
                    timelogin = "5:00AM";
                }
                else
                {
                    timelogin = "10:00PM";
                }
                c.execut_qurey("update parking  set id_car=" + textid_car.Text + ", num_car='" + textnum_car.Text + "' ,num_position='" + textposition.Text + "',login_time='" + timelogin + "', logout_time='" + textlogout_time.Text + "', responsible_worker=" + textidworker.Text + " , name_worker='" + textnameworkerr.Text + "' where id=" + textid.Text + "");
            }
            else
            {
                MessageBox.Show("this car is not Register.");
            }
        }

        private void btnrefrsh_Click(object sender, EventArgs e)
        {
            DataGridView1.DataSource=c.GetDataTable("select *from parking");  
        }

        private void btnserach_Click(object sender, EventArgs e)
        {
            if(textserah.Text!="")
            {
                DataGridView1.DataSource = c.GetDataTable("select *from parking where  id="+textserah.Text+"");

            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textid.Text = DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textid_car.Text = DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textnum_car.Text = DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textposition.Text = DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textlogin_time.Text = DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textlogout_time.Text = DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textidworker.Text = DataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textnameworkerr.Text = DataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }
    }
}
