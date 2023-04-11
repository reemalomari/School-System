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
    public partial class frmCourse : Form
    {
        public int ID;
        public frmCourse()
        {
            InitializeComponent();
        }
        SqlConnection connect = new System.Data.SqlClient.SqlConnection(@"Data Source=DESKTOP-N3NBJUE\SQLEXPRESS;Initial Catalog=registrationSchool;Integrated Security=True");
        private void frmCourse_Load(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select *from course";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AC = textBox1.Text;
            string EC = textBox5.Text;
            string SC = textBox3.Text;
            if (AC.Equals(""))
            {
                MessageBox.Show("الرجاء ادخال اسم المادة المراد اضافتها باللغة العربية");
            }
            else if(EC.Equals(""))
            {
                MessageBox.Show("الرجاء ادخال اسم المادة المراد اضافتها باللغة الانجليزية");
            }
            else
            {
                string querry = "INSERT INTO course " +
                "(CourseArabicName, CourseEnglishName)" +
                "VALUES('" + AC + "','" + EC + "')";


                SqlDataAdapter sda = new SqlDataAdapter(querry, connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    AC = textBox1.Text;
                    EC = textBox5.Text;
                    SC = textBox3.Text;
                    MessageBox.Show("تمت الاضافة بنجاح");
                    frmCourse_Load(sender, e);
                    textBox1.Text = "";
                    textBox5.Text = "";
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string name = textBox3.Text;
            string mainconn = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select *from course where CourseArabicName like'%" + name + "%' or CourseEnglishName like'%" + name + "%'";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                if (textBox4.Text.Equals(""))
                {
                    MessageBox.Show("الرجاء ادخال اسم الماددة المراد حذفها");

                }
                else
                {
                string courseArabicName = textBox4.Text;

                string deletequerry = "Delete from course where CourseArabicName='" + courseArabicName+"'";
                SqlDataAdapter sda = new SqlDataAdapter(deletequerry, connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                string querry = "select *from course";

                sda = new SqlDataAdapter(querry, connect);
                dt = new DataTable();
                sda.Fill(dt);
                frmCourse_Load(sender, e);


                MessageBox.Show("تم الحذف  بنجاح");
                }
            }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string name = textBox4.Text;
            string mainconn = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select *from course where CourseArabicName like'%" + name + "%' or CourseEnglishName like'%" + name + "%'";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(textBox2.Text.Equals("") && textBox4.Text.Equals(""))
            {
                ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox2.Text = textBox1.Text;
                textBox4.Text = textBox1.Text;
            }
            else if (textBox2.Text != "")
            {
                ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            else if (textBox4.Text != "")
            {
                ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                textBox4.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            string mainconn = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select *from course where CourseArabicName like'%" + name + "%' or CourseEnglishName like'%" + name + "%'";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

        
    }

