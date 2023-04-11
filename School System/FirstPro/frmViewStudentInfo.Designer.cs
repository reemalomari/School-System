
namespace FirstPro
{
    partial class frmViewStudentInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.اضافةطالبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلمعلوماتملفطالبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضمعلوماتملفطالبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفطاالبToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(77, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 373);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(870, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(984, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "ادخل رقم الطالب المراد عرض معلوماته\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(739, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "عرض";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافةطالبToolStripMenuItem,
            this.تعديلمعلوماتملفطالبToolStripMenuItem,
            this.عرضمعلوماتملفطالبToolStripMenuItem,
            this.حذفطاالبToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1273, 36);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // اضافةطالبToolStripMenuItem
            // 
            this.اضافةطالبToolStripMenuItem.Name = "اضافةطالبToolStripMenuItem";
            this.اضافةطالبToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.اضافةطالبToolStripMenuItem.Text = "اضافة طالب";
            // 
            // تعديلمعلوماتملفطالبToolStripMenuItem
            // 
            this.تعديلمعلوماتملفطالبToolStripMenuItem.Name = "تعديلمعلوماتملفطالبToolStripMenuItem";
            this.تعديلمعلوماتملفطالبToolStripMenuItem.Size = new System.Drawing.Size(235, 29);
            this.تعديلمعلوماتملفطالبToolStripMenuItem.Text = "تعديل معلومات ملف طالب";
            // 
            // عرضمعلوماتملفطالبToolStripMenuItem
            // 
            this.عرضمعلوماتملفطالبToolStripMenuItem.Name = "عرضمعلوماتملفطالبToolStripMenuItem";
            this.عرضمعلوماتملفطالبToolStripMenuItem.Size = new System.Drawing.Size(232, 29);
            this.عرضمعلوماتملفطالبToolStripMenuItem.Text = "عرض معلومات ملف طالب";
            // 
            // حذفطاالبToolStripMenuItem
            // 
            this.حذفطاالبToolStripMenuItem.Name = "حذفطاالبToolStripMenuItem";
            this.حذفطاالبToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.حذفطاالبToolStripMenuItem.Text = "حذف طاالب";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(850, 102);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(68, 24);
            this.radioButton2.TabIndex = 51;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "موظف";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(954, 100);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(61, 24);
            this.radioButton1.TabIndex = 50;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "طالب";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1079, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "على من تريد العرض";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.SteelBlue;
            this.panel12.Controls.Add(this.label12);
            this.panel12.ForeColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(0, 34);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1273, 42);
            this.panel12.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(549, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(284, 36);
            this.label12.TabIndex = 40;
            this.label12.Text = "تفاصيل عرض ملف طالب";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmViewStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1273, 750);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmViewStudentInfo";
            this.Text = "frmViewStudentInfo";
            this.Load += new System.EventHandler(this.frmViewStudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem اضافةطالبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تعديلمعلوماتملفطالبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضمعلوماتملفطالبToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفطاالبToolStripMenuItem;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel12;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label1;
    }
}