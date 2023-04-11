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
    public partial class Form1 : Form
    {
        public int ID;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(int id)
        {
            InitializeComponent();
            this.ID = id;
        }
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-N3NBJUE\SQLEXPRESS;Initial Catalog=registrationSchool;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect.Open();
            //SqlCommand sqlcommand = new SqlCommand("select ArabicName,EnglishFirstName,EnglishSecondName," +
            //                                               "EnglishThirdName,EnglishLastName,StuNationalNumber," +
            //                                               "StuNationality,BirthPlace,BirthDate," +
            //                                               "StuRelegion,Gender,SpecialNeed," +
            //                                               "StuEmail,StuPhoneNumber,ParentName," +
            //                                               "RelationWithStu,ParNationalNumber,ParNationality," +
            //                                               "ParRelegion,EducationQualification,Address," +
            //                                               "MonthlyIncome,ParEmail,ParPhoneNumber from student where ID='" + ID + "'", connect);


            //SqlDataReader reader = sqlcommand.ExecuteReader();
            //while (reader.Read())
            //{
            //    this.textBox1.Text = reader.GetValue(0).ToString();
            //    this.textBox2.Text = reader.GetValue(1).ToString();
            //    this.textBox3.Text = reader.GetValue(2).ToString();
            //    this.textBox4.Text = reader.GetValue(3).ToString();
            //    this.textBox5.Text = reader.GetValue(4).ToString();
            //    this.textBox6.Text = reader.GetValue(5).ToString();

            //    this.comboBox1.Text = reader.GetValue(6).ToString();
            //    this.comboBox3.Text = reader.GetValue(7).ToString();


            //    this.monthCalendar1.SelectionStart = (DateTime)(reader.GetValue(8));

            //    this.comboBox2.Text = reader.GetValue(9).ToString();

            //    if (reader.GetValue(10).ToString() == "male")
            //    {
            //        this.radioButton2.Checked = true;
            //    }
            //    else
            //        this.radioButton1.Checked = true;


            //    if (reader.GetValue(11).ToString() == "No")
            //    {
            //        this.radioButton4.Checked = true;
            //    }
            //    else
            //        this.radioButton3.Checked = true;


            //    this.textBox7.Text = reader.GetValue(12).ToString();
            //    this.textBox8.Text = reader.GetValue(13).ToString();

            //    this.textBox16.Text = reader.GetValue(14).ToString();

            //    this.comboBox7.Text = reader.GetValue(15).ToString();
            //    this.textBox11.Text = reader.GetValue(16).ToString();

            //    this.comboBox6.Text = reader.GetValue(17).ToString();
            //    this.comboBox4.Text = reader.GetValue(18).ToString();

            //    if (reader.GetValue(19).ToString() == "Other")
            //    {
            //        radioButton5.Checked = true;
            //        textBox12.Visible = false;
            //    }
            //    else
            //    {
            //        this.textBox12.Text = reader.GetValue(19).ToString();
            //    }



            //    this.textBox14.Text = reader.GetValue(20).ToString();
            //    this.textBox13.Text = reader.GetValue(21).ToString();
            //    this.textBox10.Text = reader.GetValue(22).ToString();
            //    this.textBox9.Text = reader.GetValue(23).ToString();

                
            //}




            //connect.Close();





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }
  
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
           


        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string ArabicName=textBox1.Text;
            string EnglishFirstName=textBox2.Text;
            string EnglishSecondName = textBox3.Text; 
            string EnglishThirdName = textBox4.Text; 
            string EnglishLastName = textBox5.Text; 
            string StuNationalNumber = textBox6.Text; 
            string StuNationality = comboBox1.Text; 
            string BirthPlace = comboBox3.Text;
            DateTime BirthDate = monthCalendar1.SelectionRange.Start;
            string StuRelegion = comboBox2.Text;
            string Gender;
            if (radioButton1.Checked == true)
            {
                Gender = "female";

            }
            else
                Gender = "male";


            string SpecialNeed;

            if (radioButton3.Checked == true)
            {
                SpecialNeed = "YES";

            }
            else
                SpecialNeed = "NO";



            string StuEmail = textBox7.Text; 
            string StuPhoneNumber = textBox8.Text; 




            string ParentName = textBox16.Text; 
            string RelationWithStu =comboBox7.Text;
            string ParNationalNumber = textBox11.Text; 
            string ParNationality = comboBox6.Text; 
            string ParRelegion = comboBox4.Text;

            string EducationQualification;
            if(radioButton5.Checked==true)
                {
                EducationQualification="Other";
            }
            else 
             EducationQualification = textBox12.Text; 

            string Address = textBox14.Text;
            float MonthlyIncome =float.Parse(textBox13.Text);
            string ParEmail = textBox10.Text;
            string ParPhoneNumber = textBox9.Text;

            string Querry = "INSERT INTO student " +
                "(ArabicName, EnglishFirstName, EnglishSecondName, EnglishThirdName, EnglishLastName, " +
                "StuNationalNumber, StuNationality, BirthPlace, BirthDate, StuRelegion, Gender, SpecialNeed ," +
                "StuEmail, StuPhoneNumber," +
                "ParentName, RelationWithStu, ParNationalNumber, ParNationality, ParRelegion, EducationQualification, " +
                "Address, MonthlyIncome, ParEmail, ParPhoneNumber)"+
                "VALUES('"+ArabicName+"','" + EnglishFirstName+"','"+ EnglishSecondName+"','"+EnglishThirdName+"','"+ EnglishLastName+"','"+
                StuNationalNumber+"','"+StuNationality+"','"+BirthPlace+"','"+ BirthDate+"','"+ StuRelegion+"','"+ Gender+"','"+ SpecialNeed+"','"+ StuEmail+"','"+ StuPhoneNumber+"','"
               + ParentName+"','"+RelationWithStu+"','"+ ParNationalNumber+"','"+ParNationality+"','"+ ParRelegion+"','"+ EducationQualification+"','"+
               Address+"','"+ MonthlyIncome+"','"+ ParEmail+"','"+ ParPhoneNumber+"')";

            SqlDataAdapter sda = new SqlDataAdapter(Querry, connect);
            DataTable dt = new DataTable();
             sda.Fill(dt);

            if(dt.Rows.Count==0)
            {
                 ArabicName = textBox1.Text;
                 EnglishFirstName = textBox2.Text;
                 EnglishSecondName = textBox3.Text;
                 EnglishThirdName = textBox4.Text;
                 EnglishLastName = textBox5.Text;
                 StuNationalNumber = textBox6.Text;
                 StuNationality = comboBox1.Text;
                 BirthPlace = comboBox3.Text;
                 BirthDate = monthCalendar1.SelectionRange.Start;
                 StuRelegion = comboBox2.Text;
                 
                if (radioButton1.Checked == true)
                {
                    Gender = "female";

                }
                else
                    Gender = "male";


               

                if (radioButton3.Checked == true)
                {
                    SpecialNeed = "YES";

                }
                else
                    SpecialNeed = "NO";



                 StuEmail = textBox7.Text;
                 StuPhoneNumber = textBox8.Text;




                 ParentName = textBox16.Text;
                 RelationWithStu = comboBox7.Text;
                 ParNationalNumber = textBox11.Text;
                 ParNationality = comboBox6.Text;
                 ParRelegion = comboBox4.Text;

             
                if (radioButton5.Checked == true)
                {
                    textBox12.Visible = false;

                    EducationQualification = "Other";
                }
                else
                    EducationQualification = textBox12.Text;

                 Address = textBox14.Text;
                 MonthlyIncome = float.Parse(textBox13.Text);
                 ParEmail = textBox10.Text;
                 ParPhoneNumber = textBox9.Text;
            }










            MessageBox.Show("تمت الاضافة بنجاح");



        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        { }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string EducationQualification;
            if (radioButton5.Checked == true)
            {
                EducationQualification = "other";
            }
            else EducationQualification = textBox12.Text;

            string gender;

            if (radioButton1.Checked == true)
            {
                gender = "female";

            }
            else
                gender = "male";

            string SpecialNeed;
            if (radioButton3.Checked == true)
            {
                SpecialNeed = "YES";

            }
            else
                SpecialNeed = "NO";




            string Querry = "UPDATE student set  ArabicName= '" +textBox1.Text +
                                                "',EnglishFirstName = '" + textBox2.Text +
                                                "',EnglishSecondName = '" + textBox3.Text +
                                                "',EnglishThirdName = '" + textBox4.Text +
                                                "',EnglishLastName = '" + textBox5.Text +
                                                "',StuNationalNumber ='" + textBox6.Text +
                                                "',StuNationality ='" + comboBox1.Text +
                                                "',BirthPlace ='" + comboBox3.Text +
                                                "',BirthDate ='" + monthCalendar1.SelectionRange.Start +
                                                "',StuRelegion = '" + comboBox2.Text +
                                                "',Gender='" + gender+
                                                "',SpecialNeed= '" + SpecialNeed +
                                                "', StuEmail ='" + textBox7.Text +
                                                "', StuPhoneNumber ='" + textBox8.Text +
                                                "',ParentName ='" + textBox16.Text +
                                                "',RelationWithStu ='" + comboBox7.Text +
                                                "',ParNationalNumber ='" + textBox11.Text +
                                                "',ParNationality = '" + comboBox6.Text +
                                                "',ParRelegion ='" + comboBox4.Text +
                                                "',EducationQualification='" + EducationQualification +
                                                "',Address ='" + textBox14.Text +
                                                "',MonthlyIncome ='" + float.Parse(textBox13.Text) +
                                                "',ParEmail ='" + textBox10.Text +
                                                "',ParPhoneNumber ='" + textBox9.Text + "'where id='"+ID+"'";

            SqlDataAdapter sda = new SqlDataAdapter(Querry, connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            MessageBox.Show("تم التعديل بنجاح");

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
        int click = 0;
        private void radioButton5_Click(object sender, EventArgs e)
        {
            if (click == 0)
            {
                radioButton5.Checked = true;
                textBox12.Visible = false;
                click++;
            }
            else if(click==1)
            {

                radioButton5.Checked = false;
                textBox12.Visible = true;
                click--;
            }
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void تعديلمعلوماتطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateInfo UI = new frmUpdateInfo();
            UI.Show();
        }

        private void حذفطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeleteStudent Ds = new frmDeleteStudent();
            Ds.Show();
        }

        private void عرضمعلوماتطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewStudentInfo Vs = new frmViewStudentInfo();
            Vs.Show();
        }

        private void اضافةطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


