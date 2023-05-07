using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace park_mangment
{
    public partial class Home : Form
    {
        public class connect_with_sql
        {
            public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|park.mdf;Integrated Security=True");
            public SqlCommand cmd = new SqlCommand();

            public DataTable GetDataTable(string qurey = "")
            {
                con.Open();
                cmd = new SqlCommand(qurey, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                con.Close();
                return dt;
            }

            public void execut_qurey(string qurey, string message = "")
            {
                con.Open();
                cmd = new SqlCommand(qurey, con);
                cmd.ExecuteNonQuery();
                con.Close();
                if (message != "")
                    MessageBox.Show(message);
            }



        }
        public Home()
        {
            InitializeComponent();
        }

        private void btnpark_Click(object sender, EventArgs e)
        {
            park f=new park();
            f.ShowDialog();
        }

        private void btnworker_Click(object sender, EventArgs e)
        {
            woker f = new woker();
            f.ShowDialog();
        }

        private void btncar_Click(object sender, EventArgs e)
        {
            cars f = new cars();
            f.ShowDialog();
        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            users f = new users();
            f.ShowDialog();
        }
    }
}
