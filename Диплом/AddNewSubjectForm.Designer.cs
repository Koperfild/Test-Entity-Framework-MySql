namespace Диплом
{
    partial class AddNewSubjectForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxNeedSpecAuditorium = new System.Windows.Forms.CheckBox();
            this.Namelb = new System.Windows.Forms.Label();
            this.hourslb = new System.Windows.Forms.Label();
            this.comboHours = new System.Windows.Forms.ComboBox();
            this.comboAuditorium = new System.Windows.Forms.ComboBox();
            this.btnAllSubjects = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(264, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboName
            // 
            this.comboName.FormattingEnabled = true;
            this.comboName.Location = new System.Drawing.Point(30, 81);
            this.comboName.Name = "comboName";
            this.comboName.Size = new System.Drawing.Size(150, 24);
            this.comboName.TabIndex = 2;
            this.comboName.SelectedIndexChanged += new System.EventHandler(this.comboName_SelectedIndexChanged);
            this.comboName.TextUpdate += new System.EventHandler(this.comboName_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "type or choose subject";
            // 
            // checkBoxNeedSpecAuditorium
            // 
            this.checkBoxNeedSpecAuditorium.AutoSize = true;
            this.checkBoxNeedSpecAuditorium.Location = new System.Drawing.Point(30, 202);
            this.checkBoxNeedSpecAuditorium.Name = "checkBoxNeedSpecAuditorium";
            this.checkBoxNeedSpecAuditorium.Size = new System.Drawing.Size(198, 21);
            this.checkBoxNeedSpecAuditorium.TabIndex = 4;
            this.checkBoxNeedSpecAuditorium.Text = "Only in definite  auditorium";
            this.checkBoxNeedSpecAuditorium.UseVisualStyleBackColor = true;
            this.checkBoxNeedSpecAuditorium.CheckedChanged += new System.EventHandler(this.checkBoxNeedSpecAuditorium_CheckedChanged);
            this.checkBoxNeedSpecAuditorium.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // Namelb
            // 
            this.Namelb.AutoSize = true;
            this.Namelb.Location = new System.Drawing.Point(31, 61);
            this.Namelb.Name = "Namelb";
            this.Namelb.Size = new System.Drawing.Size(45, 17);
            this.Namelb.TabIndex = 6;
            this.Namelb.Text = "Name";
            // 
            // hourslb
            // 
            this.hourslb.AutoSize = true;
            this.hourslb.Location = new System.Drawing.Point(30, 142);
            this.hourslb.Name = "hourslb";
            this.hourslb.Size = new System.Drawing.Size(46, 17);
            this.hourslb.TabIndex = 7;
            this.hourslb.Text = "Hours";
            // 
            // comboHours
            // 
            this.comboHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHours.Location = new System.Drawing.Point(30, 162);
            this.comboHours.Name = "comboHours";
            this.comboHours.Size = new System.Drawing.Size(150, 24);
            this.comboHours.TabIndex = 8;
            // 
            // comboAuditorium
            // 
            this.comboAuditorium.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAuditorium.Enabled = false;
            this.comboAuditorium.FormattingEnabled = true;
            this.comboAuditorium.Location = new System.Drawing.Point(30, 229);
            this.comboAuditorium.Name = "comboAuditorium";
            this.comboAuditorium.Size = new System.Drawing.Size(150, 24);
            this.comboAuditorium.TabIndex = 9;
            // 
            // btnAllSubjects
            // 
            this.btnAllSubjects.Location = new System.Drawing.Point(250, 61);
            this.btnAllSubjects.Name = "btnAllSubjects";
            this.btnAllSubjects.Size = new System.Drawing.Size(108, 67);
            this.btnAllSubjects.TabIndex = 10;
            this.btnAllSubjects.Text = "View all subjects";
            this.btnAllSubjects.UseVisualStyleBackColor = true;
            this.btnAllSubjects.Click += new System.EventHandler(this.btnAllSubjects_Click);
            // 
            // AddNewSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 357);
            this.Controls.Add(this.btnAllSubjects);
            this.Controls.Add(this.comboAuditorium);
            this.Controls.Add(this.comboHours);
            this.Controls.Add(this.hourslb);
            this.Controls.Add(this.Namelb);
            this.Controls.Add(this.checkBoxNeedSpecAuditorium);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboName);
            this.Controls.Add(this.button1);
            this.Name = "AddNewSubjectForm";
            this.Text = "Add new subject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxNeedSpecAuditorium;
        private System.Windows.Forms.Label Namelb;
        private System.Windows.Forms.Label hourslb;
        private System.Windows.Forms.ComboBox comboHours;
        private System.Windows.Forms.ComboBox comboAuditorium;
        private System.Windows.Forms.Button btnAllSubjects;
    }
}

