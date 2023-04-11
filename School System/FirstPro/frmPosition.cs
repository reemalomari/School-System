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
using System.Configuration;
namespace FirstPro
{
    public partial class frmPosition : Form
    {
        public frmPosition()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-N3NBJUE\SQLEXPRESS;Initial Catalog=registrationSchool;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string AP = textBox1.Text;
            string EP = textBox2.Text;
            string SP = textBox3.Text;
            if (AP.Equals(""))
            {
                MessageBox.Show("الرجاء ادخال المسمى الوظيفي باللغة العربية");
            }
            else
            {
                string querry = "INSERT INTO position " +
                "(PositionEnglishName, PositionArabicName)" +
                "VALUES('"+EP+"','"+AP+"')";


                SqlDataAdapter sda = new SqlDataAdapter(querry, connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                     AP = textBox1.Text;
                     EP = textBox2.Text;
                     SP = textBox3.Text;
                    MessageBox.Show("تمت الاضافة بنجاح");
                    frmPosition_Load(sender, e);
                }
            }
           
        }

        private void frmPosition_Load(object sender, EventArgs e)
        {
           
            string mainconn = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select *from position";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery,sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name = textBox3.Text;
            if(name.Equals(""))
            {
                MessageBox.Show("ارجو ادخال اسم المسمى الوظيفي المراد البحث عنه");
            }
            else
            {
                string querry = "select *from position where PositionArabicName like'" + name + "%' or PositionEnglishName like'"+name+"%'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string name = textBox3.Text;
            string mainconn = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select *from position where PositionArabicName like'" + name + "%' or PositionEnglishName like'" + name + "%'";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
