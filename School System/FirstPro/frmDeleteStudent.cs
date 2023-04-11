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
    public partial class frmDeleteStudent : Form
    {
        public frmDeleteStudent()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-N3NBJUE\SQLEXPRESS;Initial Catalog=registrationSchool;Integrated Security=True");

        private void frmDeleteStudent_Load(object sender, EventArgs e)
        {


            if (radioButton1.Checked == true)
            {
                string querry = "select *from student";

                SqlDataAdapter sda = new SqlDataAdapter(querry, connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if(radioButton2.Checked==true)
            {
                string querry = "select *from employee";

                SqlDataAdapter sda = new SqlDataAdapter(querry, connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (radioButton1.Checked == true)
            {
                if (textBox1.Text.Equals(""))
                {
                    MessageBox.Show("الرجاء ادخال الرقم المراد البحث عنه");

                }
                else
                {
                    int id = int.Parse(textBox1.Text);


                    string deletequerry = "Delete from student where id= " + id + "";
                    SqlDataAdapter sda = new SqlDataAdapter(deletequerry, connect);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    string querry = "select *from student";

                    sda = new SqlDataAdapter(querry, connect);
                    dt = new DataTable();
                    sda.Fill(dt);
                    frmDeleteStudent_Load(sender, e);


                    MessageBox.Show("تم الحذف  بنجاح");
                }
            }
            else if(radioButton2.Checked==true)
            {
                if (textBox1.Text.Equals(""))
                {
                    MessageBox.Show("الرجاء ادخال الرقم المراد البحث عنه");

                }
                else
                {
                    int id = int.Parse(textBox1.Text);


                    string deletequerry = "Delete from employee where id= " + id + "";
                    SqlDataAdapter sda = new SqlDataAdapter(deletequerry, connect);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    string querry = "select *from employee";

                    sda = new SqlDataAdapter(querry, connect);
                    dt = new DataTable();
                    sda.Fill(dt);
                    frmDeleteStudent_Load(sender, e);


                    MessageBox.Show("تم الحذف  بنجاح");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                string name = textBox2.Text;
                if (name.Equals(""))
                {
                    MessageBox.Show("الرجاء ادخال الاسم المراد حذفه");

                }
                else
                {
                    string querry = "select *from student where ArabicName='" + name + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, connect);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    label1.Visible = true;
                    textBox1.Visible = true;
                    button1.Visible = true;
                }
            }
            else if (radioButton2.Checked == true)
            {
                string name = textBox2.Text;
                if (name.Equals(""))
                {
                    MessageBox.Show("الرجاء ادخال الاسم المراد حذفه");

                }
                else
                {
                    string querry = "select *from employee where EnglishName='" + name + "'";

                    SqlDataAdapter sda = new SqlDataAdapter(querry, connect);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;


                    label1.Visible = true;
                    textBox1.Visible = true;
                    button1.Visible = true;
                }

            }
            }

        private void اضافةطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void تعديلمعلوماتطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateInfo UI = new frmUpdateInfo();
            UI.Show();
        }

        private void عرضمعلوماتطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewStudentInfo Vs = new frmViewStudentInfo();
            Vs.Show();
        }

        private void حذفطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteStudent Ds = new frmDeleteStudent();
            Ds.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label12.Text = "تفاصيل حذف ملف طالب";

                label1.Text = "ادخل رقم الطالب المراد حذفه";
                label2.Text = "ادخل اسم الطالب المراد حذفه";
                frmDeleteStudent_Load( sender,  e);

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label12.Text = "تفاصيل حذف ملف موظف";

                label1.Text = "ادخل رقم الموظف المراد حذفه";
                label2.Text = "ادخل اسم الموظف المراد حذفه";
                frmDeleteStudent_Load(sender, e);
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label12.Text = "تفاصيل حذف ملف موظف";

                label1.Text = "ادخل رقم الموظف المراد حذفه";
                label2.Text = "ادخل اسم الموظف المراد حذفه";
                frmDeleteStudent_Load(sender, e);

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }

