namespace Диплом
{
    partial class InputForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.assignSubjectsbtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboSemester = new System.Windows.Forms.ComboBox();
            this.grouplb = new System.Windows.Forms.Label();
            this.semesterlb = new System.Windows.Forms.Label();
            this.editGroupbtn = new System.Windows.Forms.Button();
            this.groupsDataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboTypeOfLesson = new System.Windows.Forms.ComboBox();
            this.lessonTypelb = new System.Windows.Forms.Label();
            this.hourslb = new System.Windows.Forms.Label();
            this.comboName = new System.Windows.Forms.ComboBox();
            this.comboAuditorium = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxNeedSpecAuditorium = new System.Windows.Forms.CheckBox();
            this.comboHours = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Namelb = new System.Windows.Forms.Label();
            this.subjectsDataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.removeLecturerbtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxLecturerEmail = new System.Windows.Forms.TextBox();
            this.textBoxLecturerPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxLecturerName = new System.Windows.Forms.TextBox();
            this.textBoxLecturerSurname = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.addbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboLecturerDepartment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.teachersDataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsDataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 578);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.assignSubjectsbtn);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.editGroupbtn);
            this.tabPage1.Controls.Add(this.groupsDataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(662, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Groups";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // assignSubjectsbtn
            // 
            this.assignSubjectsbtn.Enabled = false;
            this.assignSubjectsbtn.Location = new System.Drawing.Point(273, 366);
            this.assignSubjectsbtn.Name = "assignSubjectsbtn";
            this.assignSubjectsbtn.Size = new System.Drawing.Size(131, 23);
            this.assignSubjectsbtn.TabIndex = 10;
            this.assignSubjectsbtn.Text = "Assign Subjects";
            this.assignSubjectsbtn.UseVisualStyleBackColor = true;
            this.assignSubjectsbtn.Click += new System.EventHandler(this.assignSubjectsbtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboGroup);
            this.groupBox2.Controls.Add(this.btnAddGroup);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboSemester);
            this.groupBox2.Controls.Add(this.grouplb);
            this.groupBox2.Controls.Add(this.semesterlb);
            this.groupBox2.Location = new System.Drawing.Point(18, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 113);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add group";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // comboGroup
            // 
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Location = new System.Drawing.Point(159, 48);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(121, 24);
            this.comboGroup.TabIndex = 3;
            this.comboGroup.TextUpdate += new System.EventHandler(this.comboGroup_TextUpdate);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Enabled = false;
            this.btnAddGroup.Location = new System.Drawing.Point(448, 61);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(75, 23);
            this.btnAddGroup.TabIndex = 1;
            this.btnAddGroup.Text = "Add";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "type or select";
            // 
            // comboSemester
            // 
            this.comboSemester.Location = new System.Drawing.Point(19, 48);
            this.comboSemester.Name = "comboSemester";
            this.comboSemester.Size = new System.Drawing.Size(121, 24);
            this.comboSemester.TabIndex = 2;
            this.comboSemester.SelectedIndexChanged += new System.EventHandler(this.comboSemester_SelectedIndexChanged);
            // 
            // grouplb
            // 
            this.grouplb.AutoSize = true;
            this.grouplb.Location = new System.Drawing.Point(156, 26);
            this.grouplb.Name = "grouplb";
            this.grouplb.Size = new System.Drawing.Size(48, 17);
            this.grouplb.TabIndex = 6;
            this.grouplb.Text = "Group";
            // 
            // semesterlb
            // 
            this.semesterlb.AutoSize = true;
            this.semesterlb.Location = new System.Drawing.Point(16, 26);
            this.semesterlb.Name = "semesterlb";
            this.semesterlb.Size = new System.Drawing.Size(68, 17);
            this.semesterlb.TabIndex = 5;
            this.semesterlb.Text = "Semester";
            // 
            // editGroupbtn
            // 
            this.editGroupbtn.Enabled = false;
            this.editGroupbtn.Location = new System.Drawing.Point(410, 366);
            this.editGroupbtn.Name = "editGroupbtn";
            this.editGroupbtn.Size = new System.Drawing.Size(131, 23);
            this.editGroupbtn.TabIndex = 8;
            this.editGroupbtn.Text = "Edit group";
            this.editGroupbtn.UseVisualStyleBackColor = true;
            // 
            // groupsDataGridView1
            // 
            this.groupsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsDataGridView1.Location = new System.Drawing.Point(18, 41);
            this.groupsDataGridView1.Name = "groupsDataGridView1";
            this.groupsDataGridView1.RowTemplate.Height = 24;
            this.groupsDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupsDataGridView1.Size = new System.Drawing.Size(529, 319);
            this.groupsDataGridView1.TabIndex = 0;
            this.groupsDataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupsDataGridView1_CellDoubleClick);
            this.groupsDataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.groupsDataGridView1_CellMouseUp);
            this.groupsDataGridView1.DoubleClick += new System.EventHandler(this.groupsDataGridView1_DoubleClick_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.subjectsDataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(662, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Subjects";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboTypeOfLesson);
            this.groupBox1.Controls.Add(this.lessonTypelb);
            this.groupBox1.Controls.Add(this.hourslb);
            this.groupBox1.Controls.Add(this.comboName);
            this.groupBox1.Controls.Add(this.comboAuditorium);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBoxNeedSpecAuditorium);
            this.groupBox1.Controls.Add(this.comboHours);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Namelb);
            this.groupBox1.Location = new System.Drawing.Point(26, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 189);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New subject";
            // 
            // comboTypeOfLesson
            // 
            this.comboTypeOfLesson.CausesValidation = false;
            this.comboTypeOfLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTypeOfLesson.Location = new System.Drawing.Point(268, 57);
            this.comboTypeOfLesson.Name = "comboTypeOfLesson";
            this.comboTypeOfLesson.Size = new System.Drawing.Size(120, 24);
            this.comboTypeOfLesson.TabIndex = 20;
            // 
            // lessonTypelb
            // 
            this.lessonTypelb.AutoSize = true;
            this.lessonTypelb.Location = new System.Drawing.Point(265, 37);
            this.lessonTypelb.Name = "lessonTypelb";
            this.lessonTypelb.Size = new System.Drawing.Size(85, 17);
            this.lessonTypelb.TabIndex = 19;
            this.lessonTypelb.Text = "Lesson type";
            // 
            // hourslb
            // 
            this.hourslb.AutoSize = true;
            this.hourslb.Location = new System.Drawing.Point(181, 37);
            this.hourslb.Name = "hourslb";
            this.hourslb.Size = new System.Drawing.Size(46, 17);
            this.hourslb.TabIndex = 17;
            this.hourslb.Text = "Hours";
            // 
            // comboName
            // 
            this.comboName.FormattingEnabled = true;
            this.comboName.Location = new System.Drawing.Point(17, 57);
            this.comboName.Name = "comboName";
            this.comboName.Size = new System.Drawing.Size(150, 24);
            this.comboName.TabIndex = 11;
            this.comboName.SelectedIndexChanged += new System.EventHandler(this.comboName_SelectedIndexChanged);
            this.comboName.TextUpdate += new System.EventHandler(this.comboName_TextUpdate);
            // 
            // comboAuditorium
            // 
            this.comboAuditorium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAuditorium.Enabled = false;
            this.comboAuditorium.FormattingEnabled = true;
            this.comboAuditorium.Location = new System.Drawing.Point(17, 149);
            this.comboAuditorium.Name = "comboAuditorium";
            this.comboAuditorium.Size = new System.Drawing.Size(150, 24);
            this.comboAuditorium.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(457, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxNeedSpecAuditorium
            // 
            this.checkBoxNeedSpecAuditorium.AutoSize = true;
            this.checkBoxNeedSpecAuditorium.Location = new System.Drawing.Point(17, 122);
            this.checkBoxNeedSpecAuditorium.Name = "checkBoxNeedSpecAuditorium";
            this.checkBoxNeedSpecAuditorium.Size = new System.Drawing.Size(198, 21);
            this.checkBoxNeedSpecAuditorium.TabIndex = 13;
            this.checkBoxNeedSpecAuditorium.Text = "Only in definite  auditorium";
            this.checkBoxNeedSpecAuditorium.UseVisualStyleBackColor = true;
            this.checkBoxNeedSpecAuditorium.CheckStateChanged += new System.EventHandler(this.checkBoxNeedSpecAuditorium_CheckStateChanged);
            // 
            // comboHours
            // 
            this.comboHours.CausesValidation = false;
            this.comboHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHours.Location = new System.Drawing.Point(184, 57);
            this.comboHours.Name = "comboHours";
            this.comboHours.Size = new System.Drawing.Size(55, 24);
            this.comboHours.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "type or choose subject";
            // 
            // Namelb
            // 
            this.Namelb.AutoSize = true;
            this.Namelb.Location = new System.Drawing.Point(18, 37);
            this.Namelb.Name = "Namelb";
            this.Namelb.Size = new System.Drawing.Size(45, 17);
            this.Namelb.TabIndex = 14;
            this.Namelb.Text = "Name";
            // 
            // subjectsDataGridView1
            // 
            this.subjectsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectsDataGridView1.Location = new System.Drawing.Point(17, 30);
            this.subjectsDataGridView1.Name = "subjectsDataGridView1";
            this.subjectsDataGridView1.RowTemplate.Height = 24;
            this.subjectsDataGridView1.Size = new System.Drawing.Size(541, 272);
            this.subjectsDataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.removeLecturerbtn);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.teachersDataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(662, 549);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lecturers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // removeLecturerbtn
            // 
            this.removeLecturerbtn.Location = new System.Drawing.Point(459, 308);
            this.removeLecturerbtn.Name = "removeLecturerbtn";
            this.removeLecturerbtn.Size = new System.Drawing.Size(160, 23);
            this.removeLecturerbtn.TabIndex = 16;
            this.removeLecturerbtn.Text = "Remove lecturer";
            this.removeLecturerbtn.UseVisualStyleBackColor = true;
            this.removeLecturerbtn.Click += new System.EventHandler(this.removeLecturerbtn_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxPhone);
            this.groupBox3.Controls.Add(this.textBoxLecturerEmail);
            this.groupBox3.Controls.Add(this.textBoxLecturerPatronymic);
            this.groupBox3.Controls.Add(this.textBoxLecturerName);
            this.groupBox3.Controls.Add(this.textBoxLecturerSurname);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.addbtn);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboLecturerDepartment);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(19, 368);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(609, 175);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New lecturer";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(355, 52);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(132, 22);
            this.textBoxPhone.TabIndex = 21;
            // 
            // textBoxLecturerEmail
            // 
            this.textBoxLecturerEmail.Location = new System.Drawing.Point(355, 24);
            this.textBoxLecturerEmail.Name = "textBoxLecturerEmail";
            this.textBoxLecturerEmail.Size = new System.Drawing.Size(132, 22);
            this.textBoxLecturerEmail.TabIndex = 20;
            // 
            // textBoxLecturerPatronymic
            // 
            this.textBoxLecturerPatronymic.Location = new System.Drawing.Point(116, 81);
            this.textBoxLecturerPatronymic.Name = "textBoxLecturerPatronymic";
            this.textBoxLecturerPatronymic.Size = new System.Drawing.Size(121, 22);
            this.textBoxLecturerPatronymic.TabIndex = 19;
            // 
            // textBoxLecturerName
            // 
            this.textBoxLecturerName.Location = new System.Drawing.Point(116, 51);
            this.textBoxLecturerName.Name = "textBoxLecturerName";
            this.textBoxLecturerName.Size = new System.Drawing.Size(121, 22);
            this.textBoxLecturerName.TabIndex = 18;
            // 
            // textBoxLecturerSurname
            // 
            this.textBoxLecturerSurname.Location = new System.Drawing.Point(116, 21);
            this.textBoxLecturerSurname.Name = "textBoxLecturerSurname";
            this.textBoxLecturerSurname.Size = new System.Drawing.Size(121, 22);
            this.textBoxLecturerSurname.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 153);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(392, 135);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(123, 40);
            this.addbtn.TabIndex = 15;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Surname";
            // 
            // comboLecturerDepartment
            // 
            this.comboLecturerDepartment.FormattingEnabled = true;
            this.comboLecturerDepartment.Location = new System.Drawing.Point(116, 118);
            this.comboLecturerDepartment.Name = "comboLecturerDepartment";
            this.comboLecturerDepartment.Size = new System.Drawing.Size(121, 24);
            this.comboLecturerDepartment.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Patronymic";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(300, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Birth Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Phone";
            // 
            // teachersDataGridView1
            // 
            this.teachersDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersDataGridView1.Location = new System.Drawing.Point(19, 31);
            this.teachersDataGridView1.Name = "teachersDataGridView1";
            this.teachersDataGridView1.RowTemplate.Height = 24;
            this.teachersDataGridView1.Size = new System.Drawing.Size(600, 271);
            this.teachersDataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 608);
            this.Controls.Add(this.tabControl1);
            this.Name = "InputForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsDataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView groupsDataGridView1;
        private System.Windows.Forms.DataGridView subjectsDataGridView1;
        private System.Windows.Forms.DataGridView teachersDataGridView1;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.ComboBox comboGroup;
        private System.Windows.Forms.ComboBox comboSemester;
        private System.Windows.Forms.Label grouplb;
        private System.Windows.Forms.Label semesterlb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboName;
        private System.Windows.Forms.ComboBox comboAuditorium;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxNeedSpecAuditorium;
        private System.Windows.Forms.ComboBox comboHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Namelb;
        private System.Windows.Forms.Label hourslb;
        private System.Windows.Forms.Label lessonTypelb;
        private System.Windows.Forms.ComboBox comboTypeOfLesson;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button editGroupbtn;
        private System.Windows.Forms.Button assignSubjectsbtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboLecturerDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxLecturerEmail;
        private System.Windows.Forms.TextBox textBoxLecturerPatronymic;
        private System.Windows.Forms.TextBox textBoxLecturerName;
        private System.Windows.Forms.TextBox textBoxLecturerSurname;
        private System.Windows.Forms.Button removeLecturerbtn;
        private System.Windows.Forms.Button button2;
    }
}