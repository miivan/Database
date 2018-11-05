namespace Database3
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.lstPop = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstOt = new System.Windows.Forms.ListBox();
            this.lstLab = new System.Windows.Forms.ListBox();
            this.cbClinic = new System.Windows.Forms.ComboBox();
            this.clinicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database3DataSet = new Database3.Database3DataSet();
            this.clinicTableAdapter = new Database3.Database3DataSetTableAdapters.ClinicTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstD = new System.Windows.Forms.ListBox();
            this.lstPatDP = new System.Windows.Forms.ListBox();
            this.lstPatBd = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lstPat = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lstB_date = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstDol = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstPers = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPop
            // 
            this.lstPop.BackColor = System.Drawing.SystemColors.Control;
            this.lstPop.FormattingEnabled = true;
            this.lstPop.Location = new System.Drawing.Point(3, 24);
            this.lstPop.Name = "lstPop";
            this.lstPop.Size = new System.Drawing.Size(231, 82);
            this.lstPop.TabIndex = 0;
            this.lstPop.SelectedIndexChanged += new System.EventHandler(this.lstPop_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Медицинские учреждения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Информация:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отделение:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Лаборатория:";
            // 
            // lstOt
            // 
            this.lstOt.BackColor = System.Drawing.SystemColors.Control;
            this.lstOt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstOt.FormattingEnabled = true;
            this.lstOt.Location = new System.Drawing.Point(341, 30);
            this.lstOt.Name = "lstOt";
            this.lstOt.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstOt.Size = new System.Drawing.Size(166, 13);
            this.lstOt.TabIndex = 5;
            // 
            // lstLab
            // 
            this.lstLab.BackColor = System.Drawing.SystemColors.Control;
            this.lstLab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLab.FormattingEnabled = true;
            this.lstLab.Location = new System.Drawing.Point(341, 53);
            this.lstLab.Name = "lstLab";
            this.lstLab.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstLab.Size = new System.Drawing.Size(166, 13);
            this.lstLab.TabIndex = 6;
            // 
            // cbClinic
            // 
            this.cbClinic.DataSource = this.clinicBindingSource;
            this.cbClinic.DisplayMember = "Name_clinic";
            this.cbClinic.FormattingEnabled = true;
            this.cbClinic.Location = new System.Drawing.Point(3, 3);
            this.cbClinic.Name = "cbClinic";
            this.cbClinic.Size = new System.Drawing.Size(320, 21);
            this.cbClinic.TabIndex = 7;
            this.cbClinic.ValueMember = "C_number";
            this.cbClinic.SelectedIndexChanged += new System.EventHandler(this.cbClinic_SelectedIndexChanged);
            // 
            // clinicBindingSource
            // 
            this.clinicBindingSource.DataMember = "Clinic";
            this.clinicBindingSource.DataSource = this.database3DataSet;
            // 
            // database3DataSet
            // 
            this.database3DataSet.DataSetName = "Database3DataSet";
            this.database3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clinicTableAdapter
            // 
            this.clinicTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "Просмотеть информацию по пациентам и персоналу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lstPop);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lstLab);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lstOt);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 127);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstD);
            this.panel2.Controls.Add(this.lstPatDP);
            this.panel2.Controls.Add(this.lstPatBd);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lstPat);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lstB_date);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lstDol);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lstPers);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.cbClinic);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 148);
            this.panel2.TabIndex = 11;
            this.panel2.Visible = false;
            // 
            // lstD
            // 
            this.lstD.BackColor = System.Drawing.SystemColors.Control;
            this.lstD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstD.FormattingEnabled = true;
            this.lstD.Location = new System.Drawing.Point(389, 122);
            this.lstD.Name = "lstD";
            this.lstD.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstD.Size = new System.Drawing.Size(118, 13);
            this.lstD.TabIndex = 24;
            // 
            // lstPatDP
            // 
            this.lstPatDP.BackColor = System.Drawing.SystemColors.Control;
            this.lstPatDP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPatDP.FormattingEnabled = true;
            this.lstPatDP.Location = new System.Drawing.Point(389, 103);
            this.lstPatDP.Name = "lstPatDP";
            this.lstPatDP.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstPatDP.Size = new System.Drawing.Size(118, 13);
            this.lstPatDP.TabIndex = 23;
            // 
            // lstPatBd
            // 
            this.lstPatBd.BackColor = System.Drawing.SystemColors.Control;
            this.lstPatBd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPatBd.FormattingEnabled = true;
            this.lstPatBd.Location = new System.Drawing.Point(389, 79);
            this.lstPatBd.Name = "lstPatBd";
            this.lstPatBd.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstPatBd.Size = new System.Drawing.Size(118, 13);
            this.lstPatBd.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(274, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Диагноз:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(276, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Дата поступления:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Дата рождения:";
            // 
            // lstPat
            // 
            this.lstPat.BackColor = System.Drawing.SystemColors.Control;
            this.lstPat.FormattingEnabled = true;
            this.lstPat.Location = new System.Drawing.Point(279, 43);
            this.lstPat.Name = "lstPat";
            this.lstPat.Size = new System.Drawing.Size(228, 30);
            this.lstPat.TabIndex = 18;
            this.lstPat.SelectedIndexChanged += new System.EventHandler(this.lstPat_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Больные";
            // 
            // lstB_date
            // 
            this.lstB_date.BackColor = System.Drawing.SystemColors.Control;
            this.lstB_date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstB_date.FormattingEnabled = true;
            this.lstB_date.Location = new System.Drawing.Point(116, 103);
            this.lstB_date.Name = "lstB_date";
            this.lstB_date.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstB_date.Size = new System.Drawing.Size(118, 13);
            this.lstB_date.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Дата рождения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Должность:";
            // 
            // lstDol
            // 
            this.lstDol.BackColor = System.Drawing.SystemColors.Control;
            this.lstDol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDol.FormattingEnabled = true;
            this.lstDol.Location = new System.Drawing.Point(116, 79);
            this.lstDol.Name = "lstDol";
            this.lstDol.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstDol.Size = new System.Drawing.Size(118, 13);
            this.lstDol.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Персонал";
            // 
            // lstPers
            // 
            this.lstPers.BackColor = System.Drawing.SystemColors.Control;
            this.lstPers.FormattingEnabled = true;
            this.lstPers.Location = new System.Drawing.Point(6, 43);
            this.lstPers.Name = "lstPers";
            this.lstPers.Size = new System.Drawing.Size(228, 30);
            this.lstPers.TabIndex = 11;
            this.lstPers.SelectedIndexChanged += new System.EventHandler(this.lstPers_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(553, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 60);
            this.button2.TabIndex = 10;
            this.button2.Text = "Вернуться к просмотру Мед. учреждений";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Мед. учреждения";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Лаборатории";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 290);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Отделения";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 319);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Пациенты";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 348);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(103, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "Персонал";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(161, 232);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(528, 139);
            this.panel3.TabIndex = 17;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(407, 44);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(63, 43);
            this.button8.TabIndex = 3;
            this.button8.Text = "Add";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(276, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(82, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Лаболатория";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Название";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Номер";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button9);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.textBox5);
            this.panel4.Controls.Add(this.textBox6);
            this.panel4.Location = new System.Drawing.Point(161, 232);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(528, 139);
            this.panel4.TabIndex = 18;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(406, 48);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(63, 43);
            this.button9.TabIndex = 7;
            this.button9.Text = "Add";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(275, 62);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(82, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Профиль";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(171, 62);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(82, 20);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "Название";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(60, 62);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(82, 20);
            this.textBox6.TabIndex = 4;
            this.textBox6.Text = "Номер";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button10);
            this.panel5.Controls.Add(this.textBox7);
            this.panel5.Controls.Add(this.textBox8);
            this.panel5.Controls.Add(this.textBox9);
            this.panel5.Location = new System.Drawing.Point(161, 232);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(528, 139);
            this.panel5.TabIndex = 19;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(406, 48);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(63, 43);
            this.button10.TabIndex = 11;
            this.button10.Text = "Add";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(275, 62);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(98, 20);
            this.textBox7.TabIndex = 10;
            this.textBox7.Text = "Мед. учреждение";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(171, 62);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(82, 20);
            this.textBox8.TabIndex = 9;
            this.textBox8.Text = "Название";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(60, 62);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(82, 20);
            this.textBox9.TabIndex = 8;
            this.textBox9.Text = "Номер";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox14);
            this.panel6.Controls.Add(this.textBox15);
            this.panel6.Controls.Add(this.textBox16);
            this.panel6.Controls.Add(this.textBox17);
            this.panel6.Controls.Add(this.textBox13);
            this.panel6.Controls.Add(this.textBox11);
            this.panel6.Controls.Add(this.textBox10);
            this.panel6.Controls.Add(this.textBox12);
            this.panel6.Controls.Add(this.button11);
            this.panel6.Location = new System.Drawing.Point(161, 232);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(528, 139);
            this.panel6.TabIndex = 20;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(54, 70);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(82, 20);
            this.textBox14.TabIndex = 23;
            this.textBox14.Text = "День поступления";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(142, 70);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(82, 20);
            this.textBox15.TabIndex = 22;
            this.textBox15.Text = "Персонал";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(230, 70);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(82, 20);
            this.textBox16.TabIndex = 21;
            this.textBox16.Text = "Отделение";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(318, 70);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(82, 20);
            this.textBox17.TabIndex = 20;
            this.textBox17.Text = "Диагноз";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(318, 44);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(82, 20);
            this.textBox13.TabIndex = 19;
            this.textBox13.Text = "Клиника";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(142, 44);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(82, 20);
            this.textBox11.TabIndex = 18;
            this.textBox11.Text = "ФИО";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(54, 44);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(82, 20);
            this.textBox10.TabIndex = 17;
            this.textBox10.Text = "Номер";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(230, 44);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(82, 20);
            this.textBox12.TabIndex = 16;
            this.textBox12.Text = "День Рожд";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(442, 44);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(63, 43);
            this.button11.TabIndex = 15;
            this.button11.Text = "Add";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBox18);
            this.panel7.Controls.Add(this.textBox19);
            this.panel7.Controls.Add(this.textBox20);
            this.panel7.Controls.Add(this.textBox21);
            this.panel7.Controls.Add(this.textBox22);
            this.panel7.Controls.Add(this.textBox23);
            this.panel7.Controls.Add(this.button12);
            this.panel7.Location = new System.Drawing.Point(161, 232);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(528, 139);
            this.panel7.TabIndex = 21;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(83, 48);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(82, 20);
            this.textBox18.TabIndex = 32;
            this.textBox18.Text = "Номер";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(171, 48);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(82, 20);
            this.textBox19.TabIndex = 31;
            this.textBox19.Text = "ФИО";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(259, 48);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(82, 20);
            this.textBox20.TabIndex = 30;
            this.textBox20.Text = "День Рождения";
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(83, 72);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(82, 20);
            this.textBox21.TabIndex = 29;
            this.textBox21.Text = "Должность";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(172, 71);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(82, 20);
            this.textBox22.TabIndex = 28;
            this.textBox22.Text = "Отделение";
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(260, 74);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(82, 20);
            this.textBox23.TabIndex = 27;
            this.textBox23.Text = "Мед. учреждение";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(427, 46);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(63, 43);
            this.button12.TabIndex = 24;
            this.button12.Text = "Add";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Заполнение таблиц";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 451);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clinicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstOt;
        private System.Windows.Forms.ListBox lstLab;
        private System.Windows.Forms.ComboBox cbClinic;
        private Database3DataSet database3DataSet;
        private System.Windows.Forms.BindingSource clinicBindingSource;
        private Database3DataSetTableAdapters.ClinicTableAdapter clinicTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lstPers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstB_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstDol;
        private System.Windows.Forms.ListBox lstPat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstD;
        private System.Windows.Forms.ListBox lstPatDP;
        private System.Windows.Forms.ListBox lstPatBd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label12;
    }
}

