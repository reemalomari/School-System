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
    public partial class studentOptions : Form
    {
        public studentOptions()
        {
            InitializeComponent();
        }

        private void studentOptions_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmUpdateInfo UI = new frmUpdateInfo();
            UI.radioButton1.Checked = true;
            UI.label12.Text = "تفاصيل تعديل ملف طالب";

            UI.label2.Text = "ادخل اسم الطالب المراد التعديل عليه";
            UI.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmDeleteStudent Ds = new frmDeleteStudent();
            Ds.radioButton1.Checked = true;
            Ds.label12.Text = "تفاصيل ملف حذف طالب";
            Ds.label1.Text = "ادخل رقم الطالب المراد حذفه";
            Ds.label2.Text = "ادخل اسم الطالب المراد حذفه";
            Ds.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmViewStudentInfo Ds = new frmViewStudentInfo();
            Ds.radioButton1.Checked = true;
            Ds.label12.Text = "تفاصيل عرض ملف طالب";
            Ds.label1.Text = "ادخل رقم الطالب المراد عرض ملعوماته";

            Ds.Show();
        }
    }
}
