using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstPro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDeleteStudent Ds = new frmDeleteStudent();
            Ds.radioButton1.Checked = true;
            Ds.label12.Text = "تفاصيل ملف حذف طالب";
            Ds.label1.Text = "ادخل رقم الطالب المراد حذفه";
            Ds.label2.Text = "ادخل اسم الطالب المراد حذفه";
            Ds.Show();



          
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmViewStudentInfo Ds = new frmViewStudentInfo();
            Ds.radioButton1.Checked = true;
            Ds.label12.Text = "تفاصيل عرض ملف طالب";
            Ds.label1.Text = "ادخل رقم الطالب المراد عرض ملعوماته";
            
            Ds.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUpdateInfo UI = new frmUpdateInfo();
            UI.radioButton1.Checked = true;
            UI.label12.Text = "تفاصيل تعديل ملف طالب";
          
            UI.label2.Text = "ادخل اسم الطالب المراد التعديل عليه";
            UI.Show();
        }
        int i = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            
     
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                linkLabel8.Visible = true;
                linkLabel7.Visible = true;
                linkLabel6.Visible = true;
                linkLabel5.Visible = true;
                i++;
            }
            else if (i == 1)
            {
                linkLabel8.Visible = false;
                linkLabel7.Visible = false;
                linkLabel6.Visible = false;
                linkLabel5.Visible = false;
                i--;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEmp emp = new frmEmp();
            emp.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUpdateInfo UI = new frmUpdateInfo();
            UI.label12.Text = "تفاصيل تعديل ملف موظف";
            UI.label2.Text = "ادخل اسم الموظف المراد التعديل عليه";
            UI.radioButton2.Checked = true;
            UI.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDeleteStudent D = new frmDeleteStudent();
            D.label12.Text = "تفاصيل حذف ملف موظف";
            D.label1.Text = "ادخل رقم الموظف المراد حذفه";
            D.label2.Text = "ادخل اسم الموظف المراد حذفه";
            D.radioButton2.Checked = true;
            D.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmViewStudentInfo Ds = new frmViewStudentInfo();
            Ds.radioButton2.Checked = true;
            Ds.label12.Text = "تفاصيل عرض ملف موظف";
          

            Ds.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            studentOptions studentOptions = new studentOptions();
            studentOptions.Show();
        }
    }
    }

