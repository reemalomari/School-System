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
    public partial class frmViewStudentInfo : Form
    {
        public frmViewStudentInfo()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-N3NBJUE\SQLEXPRESS;Initial Catalog=registrationSchool;Integrated Security=True");
        private void frmViewStudentInfo_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
              
               
                if (textBox1.Text == "")
                {
                    MessageBox.Show("الرجاء ادخال الرقم المراد عرضه");
                }
                else
                {
                    int id = Convert.ToInt32(textBox1.Text);
                    string querry = "select *from student where id="+id;
                    SqlDataAdapter sda = new SqlDataAdapter(querry, connect);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                  
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("الرجاء ادخال الرقم المراد عرضه");
                }
                else
                {
                    int id = int.Parse(textBox1.Text);
                    string querry = "select *from employee where id="+id;
                    SqlDataAdapter sda = new SqlDataAdapter(querry, connect);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    dataGridView1.DataSource = dt;
                
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label12.Text = "تفاصيل عرض ملف طالب";

                label1.Text = "ادخل رقم الطالب المراد عرضه";
                frmViewStudentInfo_Load(sender, e);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked == true)
            {
                label12.Text = "تفاصيل عرض ملف موظف";

                label1.Text = "ادخل رقم الموظف المراد عرضه";
                frmViewStudentInfo_Load(sender, e);
            }
        }
    }
}
