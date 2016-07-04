namespace Диплом
{
    partial class assignSubjectsToGroupForm
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
            this.subjectsDataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboSubject = new System.Windows.Forms.ComboBox();
            this.subjectNamelb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.removeSubjectbtn = new System.Windows.Forms.Button();
            this.grouplb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectsDataGridView1
            // 
            this.subjectsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectsDataGridView1.Location = new System.Drawing.Point(12, 70);
            this.subjectsDataGridView1.Name = "subjectsDataGridView1";
            this.subjectsDataGridView1.RowTemplate.Height = 24;
            this.subjectsDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectsDataGridView1.Size = new System.Drawing.Size(575, 365);
            this.subjectsDataGridView1.TabIndex = 21;
            // 
            // comboSubject
            // 
            this.comboSubject.CausesValidation = false;
            this.comboSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSubject.Location = new System.Drawing.Point(12, 551);
            this.comboSubject.Name = "comboSubject";
            this.comboSubject.Size = new System.Drawing.Size(120, 24);
            this.comboSubject.TabIndex = 24;
            this.comboSubject.SelectedIndexChanged += new System.EventHandler(this.comboSubject_SelectedIndexChanged);
            // 
            // subjectNamelb
            // 
            this.subjectNamelb.AutoSize = true;
            this.subjectNamelb.Location = new System.Drawing.Point(12, 531);
            this.subjectNamelb.Name = "subjectNamelb";
            this.subjectNamelb.Size = new System.Drawing.Size(53, 17);
            this.subjectNamelb.TabIndex = 23;
            this.subjectNamelb.Text = "subject";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 44);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // removeSubjectbtn
            // 
            this.removeSubjectbtn.Location = new System.Drawing.Point(12, 441);
            this.removeSubjectbtn.Name = "removeSubjectbtn";
            this.removeSubjectbtn.Size = new System.Drawing.Size(155, 29);
            this.removeSubjectbtn.TabIndex = 25;
            this.removeSubjectbtn.Text = "Remove subject";
            this.removeSubjectbtn.UseVisualStyleBackColor = true;
            this.removeSubjectbtn.Click += new System.EventHandler(this.removeSubjectbtn_Click);
            // 
            // grouplb
            // 
            this.grouplb.AutoSize = true;
            this.grouplb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grouplb.Location = new System.Drawing.Point(26, 13);
            this.grouplb.Name = "grouplb";
            this.grouplb.Size = new System.Drawing.Size(0, 32);
            this.grouplb.TabIndex = 26;
            // 
            // assignSubjectsToGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 613);
            this.Controls.Add(this.grouplb);
            this.Controls.Add(this.removeSubjectbtn);
            this.Controls.Add(this.subjectsDataGridView1);
            this.Controls.Add(this.comboSubject);
            this.Controls.Add(this.subjectNamelb);
            this.Controls.Add(this.button1);
            this.Name = "assignSubjectsToGroupForm";
            this.Text = "assignSubjectsForm";
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView subjectsDataGridView1;
        private System.Windows.Forms.ComboBox comboSubject;
        private System.Windows.Forms.Label subjectNamelb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button removeSubjectbtn;
        private System.Windows.Forms.Label grouplb;
    }
}