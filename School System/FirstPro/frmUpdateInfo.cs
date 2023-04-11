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
    public partial class frmUpdateInfo : Form
    {
        public int ID;
        public frmUpdateInfo()
        {
            InitializeComponent();
        }
      

        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-N3NBJUE\SQLEXPRESS;Initial Catalog=registrationSchool;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                {

                string name = textBox2.Text;
                if (name.Equals(""))
                {
                    MessageBox.Show("الرجاء ادخال الاسم المراد البحث عنه");

                }
                else
                {
                    string querry = "select *from student where ArabicName='" + name + "'";

                    SqlDataAdapter sda = new SqlDataAdapter(querry, connect);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;


                    

                }
            }
           else if (radioButton2.Checked == true)
            {
                string name = textBox2.Text;
                if (name.Equals(""))
                {
                    MessageBox.Show("الرجاء ادخال الاسم المراد البحث عنه");

                }
                else
                {
                    string querry = "select *from employee where EnglishName='" + name + "'";

                    SqlDataAdapter sda = new SqlDataAdapter(querry, connect);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;


                }
            }
            
        }

        











        

        private void frmUpdateInfo_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                string name = textBox2.Text;
                string mainconn = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "select *from student where ArabicName like'" + name + "%'";
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
            if (radioButton2.Checked == true)
            {
                string name = textBox2.Text;
                string mainconn = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "select *from employee where EnglishName like'" + name + "%' or ArabicFirstName like'" + name + "%'";
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label12.Text = "تفاصيل تعديل ملف طالب";
                label2.Text = "ادخل اسم الطالب المراد التعديل عليه";
            }
            string mainconn = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select *from student";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label12.Text = "تفاصيل تعديل ملف موظف";
                label2.Text = "ادخل اسم الموظف المراد التعديل عليه";
            }
            string mainconn = ConfigurationManager.ConnectionStrings["myconn"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "select *from employee inner join position on employee.idd=position.id";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Form1 f1 = new Form1(ID);

                f1.textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                f1.textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                f1.textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                f1.textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                f1.textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                f1.textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                f1.comboBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                f1.comboBox3.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();


                f1.monthCalendar1.SelectionStart = (DateTime)dataGridView1.CurrentRow.Cells[9].Value;

                f1.comboBox2.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

                if (dataGridView1.CurrentRow.Cells[11].Value.ToString() == "male")
                {
                    f1.radioButton2.Checked = true;
                }
                else
                    f1.radioButton1.Checked = true;


                if (dataGridView1.CurrentRow.Cells[12].Value.ToString() == "No")
                {
                    f1.radioButton4.Checked = true;
                }
                else
                    f1.radioButton3.Checked = true;


                f1.textBox7.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                f1.textBox8.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();

                f1.textBox16.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();

                f1.comboBox7.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
                f1.textBox11.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();

                f1.comboBox6.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
                f1.comboBox4.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();

                if (dataGridView1.CurrentRow.Cells[20].Value.ToString() == "Other")
                {
                    f1.radioButton5.Checked = true;
                    f1.textBox12.Visible = false;
                }
                else
                {
                    f1.textBox12.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
                }



                f1.textBox14.Text = dataGridView1.CurrentRow.Cells[21].Value.ToString();
                f1.textBox13.Text = dataGridView1.CurrentRow.Cells[22].Value.ToString();
                f1.textBox10.Text = dataGridView1.CurrentRow.Cells[23].Value.ToString();
                f1.textBox9.Text = dataGridView1.CurrentRow.Cells[24].Value.ToString();




                f1.Show();
            }
            else if(radioButton2.Checked==true)
            {
                ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                frmEmp f1 = new frmEmp(ID);

                f1.textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                f1.textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                f1.textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                f1.textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                f1.textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                f1.textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                f1.comboBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                f1.comboBox3.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();


                f1.monthCalendar1.SelectionStart = (DateTime)dataGridView1.CurrentRow.Cells[9].Value;

                f1.comboBox2.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

                if (dataGridView1.CurrentRow.Cells[11].Value.ToString() == "male")
                {
                    f1.radioButton2.Checked = true;
                }
                else
                    f1.radioButton1.Checked = true;

                f1.textBox7.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                f1.textBox8.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                f1.textBox9.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();

                f1.textBox11.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
                f1.textBox10.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();

                f1.textBox13.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
                f1.textBox12.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();

                f1.comboBox4.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
                f1.Show();
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
