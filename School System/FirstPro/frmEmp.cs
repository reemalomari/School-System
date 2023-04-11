using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    public partial class frmEmp : Form
    {
        public int ID =0;
        public frmEmp()
        {
            InitializeComponent();
        }
        public frmEmp(int id)
        {
            InitializeComponent();
            this.ID = id;
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-N3NBJUE\SQLEXPRESS;Initial Catalog=registrationSchool;Integrated Security=True");
        private void frmEmp_Load(object sender, EventArgs e)
        {
                string q = "select PositionArabicName from position";
                SqlDataAdapter sda = new SqlDataAdapter(q, connect);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int i = dt.Rows.Count-1;
                while (i != 0)
                {
                    comboBox4.Items.Add(dt.Rows[i--][0]);
                }


        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string EnglishName=textBox1.Text;
            string ArabicFirstName =textBox2.Text;
            string ArabicSecondName =textBox3.Text;
            string ArabicThirdName=textBox4.Text;
            string ArabicLastName =textBox5.Text;
            string EmpNationalNumber= textBox6.Text;
            string EmpNationality = comboBox1.Text;
            string BirthPlace = comboBox3.Text;
            DateTime BirthDate = monthCalendar1.SelectionRange.Start;
            string EmpRelegion = comboBox2.Text;
            string Gender;
            
            if (radioButton1.Checked == true)
            {
                Gender = "female";

            }
            else
                Gender = "male";
            string EmpEmail = textBox7.Text;
            string EmpPhoneNumber = textBox8.Text;
            string Adress = textBox9.Text;
            string RelativeName = textBox11.Text;
            string RelativePhoneNumber = textBox10.Text;
            string username = textBox13.Text;
            string password = textBox12.Text;
            string q = "select id from position";
            SqlDataAdapter sdaa = new SqlDataAdapter(q, connect);
            DataTable dtt = new DataTable();
            sdaa.Fill(dtt);

            string Querry = "INSERT INTO employee " +
               "(EnglishName, ArabicFirstName, ArabicSecondName, ArabicThirdName, ArabicLastName, " +
               "EmpNationalNumber, EmpNationality, BirthPlace, BirthDate, EmpRelegion, Gender,EmpEmail," +
               "EmpPhoneNumber, Adress," +
               "RelativeName, RelativePhoneNumber , username,password,idd)" +
               "VALUES('" + EnglishName + "','" + ArabicFirstName + "','" + ArabicSecondName + "','" + ArabicThirdName + "','" + ArabicLastName + "','" +
               EmpNationalNumber + "','" + EmpNationality + "','" + BirthPlace + "','" + BirthDate + "','" + EmpRelegion + "','" + Gender + "','" + EmpEmail + "','" + EmpPhoneNumber + "','" + Adress + "','"
              + RelativeName + "','" + RelativePhoneNumber +  "','" + username +  "','" + password + "',"+dtt.Rows[dtt.Rows.Count][0]+ ")";
            SqlDataAdapter sda = new SqlDataAdapter(Querry, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 0)
            {

                 EnglishName = textBox1.Text;
                 ArabicFirstName = textBox2.Text;
                 ArabicSecondName = textBox3.Text;
                 ArabicThirdName = textBox4.Text;
                 ArabicLastName = textBox5.Text;
                 EmpNationalNumber = textBox6.Text;
                 EmpNationality = comboBox1.Text;
                 BirthPlace = comboBox3.Text;
                 BirthDate = monthCalendar1.SelectionRange.Start;
                 EmpRelegion = comboBox2.Text;
                 
                if (radioButton1.Checked == true)
                {
                    Gender = "female";

                }
                else
                    Gender = "male";
                 EmpEmail = textBox7.Text;
                 EmpPhoneNumber = textBox8.Text;
                 Adress = textBox9.Text;
                 RelativeName = textBox11.Text;
                 RelativePhoneNumber = textBox10.Text;
                username = textBox13.Text;
                password = textBox12.Text;
            }
                MessageBox.Show("تمت الاضافة بنجاح");
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gender;

            if (radioButton1.Checked == true)
            {
                gender = "female";

            }
            else
                gender = "male";

            string Querry = "UPDATE employee set  EnglishName ='" + textBox1.Text +
                                                 "',ArabicFirstName ='" + textBox2.Text +
                                                    "',ArabicSecondName ='"+textBox3.Text +
                                                    "',ArabicThirdName ='" + textBox4.Text +
                                                    "',ArabicLastName ='" + textBox5.Text +
                                                    "',EmpNationalNumber= '" + textBox6.Text +
                                                    "',EmpNationality = '" + comboBox1.Text +
                                                    "',BirthPlace = '" + comboBox3.Text +
                                                    "',BirthDate = '" + monthCalendar1.SelectionRange.Start +
                                                    "',EmpRelegion = '" + comboBox2.Text+
                                                    "',Gender='" + gender +
                                                    "',EmpEmail = '" + textBox7.Text+
                                                "',EmpPhoneNumber = '" + textBox8.Text+
                                               "', Adress = '" + textBox9.Text+
                                                "',RelativeName = '" + textBox11.Text+
                                                "',RelativePhoneNumber = '" + textBox10.Text+ "'where id='" + ID + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Querry, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            MessageBox.Show("تم التعديل بنجاح");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }
    }
}
