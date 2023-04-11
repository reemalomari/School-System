using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace FirstPro
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-N3NBJUE\SQLEXPRESS;Initial Catalog=registrationSchool;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string Querry = "select username , password from employee where username='" + username +
                "'and password='"+ password +"'";
            SqlDataAdapter sda = new SqlDataAdapter(Querry, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                username = textBox1.Text;
                password = textBox2.Text;
                MessageBox.Show("تم الدخول بنجاح");
                Form2 f2 = new Form2();
                f2.Show();
            }
        
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
