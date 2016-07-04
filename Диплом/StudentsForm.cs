using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Диплом
{
    public partial class StudentsForm : Form
    {
        public StudentsForm(groups selectedGroup)
        {
            InitializeComponent();

            using (var mc = new Model1Container1())
            {
                try
                {
                    mc.Database.Connection.Open();

                    //var students = selectedGroup.students;
                    //this.studentsDataGridView1.DataSource = students;
                    var res = (from s in mc.students
                            where s.group_id == selectedGroup.group_id
                            select s).ToList();
                    this.studentsDataGridView1.DataSource = res;

                mc.Database.Connection.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message + '\n' + ex.ToString());
                }

            }
        }
    }
}
