namespace Диплом
{
    partial class StudentsForm
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
            this.studentsDataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsDataGridView1
            // 
            this.studentsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView1.Location = new System.Drawing.Point(12, 12);
            this.studentsDataGridView1.Name = "studentsDataGridView1";
            this.studentsDataGridView1.RowTemplate.Height = 24;
            this.studentsDataGridView1.Size = new System.Drawing.Size(492, 306);
            this.studentsDataGridView1.TabIndex = 0;
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 472);
            this.Controls.Add(this.studentsDataGridView1);
            this.Name = "StudentsForm";
            this.Text = "StudentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView studentsDataGridView1;
    }
}