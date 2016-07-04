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
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();

            //May be required to delete using
            using (var mc = new Model1Container1())
            {
                //var mc = new Model1Container1();
                try
                {
                    mc.Database.Connection.Open();

                    mc.Configuration.LazyLoadingEnabled = false;

                    //////////////////////////////////////////////////////////////////////////
                    //!!!!!!!!!!!!!!!!!!!!!TAB GROUPS!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    ///////////////////////////////////////////////////////////////////////
                    
                    //groupsDataGridView1
                    //var q = from g in mc.groups
                    //        select g;
                    //this.groupsDataGridView1.DataSource = q.ToList();// mc.subjects.ToList();// mc.subjects.Local.ToList();
                    this.groupsDataGridView1.DataSource = mc.groups.Include("students").ToList();//Include(g => g.students).ToList();
                                                          
                    //comboCourse
                    this.comboSemester.ValueMember = "number";
                    this.comboSemester.DisplayMember = "number";
                    this.comboSemester.DataSource = mc.semesters.ToList();

                    //comboGroup
                    this.comboGroup.ValueMember = "group_id";
                    this.comboGroup.DisplayMember = "group_id";
                    this.comboGroup.DataSource = mc.groups.ToList();

                    //////////////////////////////////////////////////////////////////////////
                    //!!!!!!!!!!!!!!!!!!!!!TAB SUBJECTS!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    ///////////////////////////////////////////////////////////////////////

                    //subjectsDataGridView1
                    this.subjectsDataGridView1.DataSource = mc.subjects.ToList();

                    comboName.ValueMember = "subject_id";
                    comboName.DisplayMember = "name";
                    comboName.DataSource = mc.subjects.ToList();

                    comboHours.ValueMember = "quantity";
                    comboHours.DisplayMember = "quantity";
                    comboHours.DataSource = mc.hours.ToList();

                    comboAuditorium.ValueMember = "number";
                    comboAuditorium.DisplayMember = "number";
                    comboAuditorium.DataSource = mc.auditoriums.ToList();

                    comboTypeOfLesson.ValueMember = "type";
                    comboTypeOfLesson.DisplayMember = "type";
                    comboTypeOfLesson.DataSource = mc.type_of_lesson.ToList();

                    //////////////////////////////////////////////////////////////////////////
                    //!!!!!!!!!!!!!!!!!!!!!TAB LECTURERS!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    ///////////////////////////////////////////////////////////////////////

                    //teachersDataGridView1
                    this.teachersDataGridView1.DataSource = mc.teachers.ToList();


                    mc.Database.Connection.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    Console.WriteLine(ex.Message + '\n' + ex.ToString());
                }
            }
        }
        private void groupsDataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            var row = groupsDataGridView1.CurrentRow;
            groups group = row.DataBoundItem as groups;
            if (group != null)
            {
                var studentsForm = new StudentsForm(group);
                studentsForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewSubjectForm form = new AddNewSubjectForm();
            form.Show();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            using (var mc = new Model1Container1())
            {
                try
                {
                    mc.Database.Connection.Open();
                    //subjects s = new subjects();
                    //s.name = comboName.Text;s.hours = Convert.ToInt32(num)
                    groups g = new groups() { group_id = comboGroup.Text, semester_id = int.Parse(comboSemester.Text) };
                    if (((IEnumerable<groups>)mc.groups).Contains<groups>(g, new GroupsComparer()))
                        MessageBox.Show("Such group with the same name already exists\nChange name");
                    else
                    {
                        mc.groups.Add(g);
                        mc.SaveChanges();
                        MessageBox.Show("Successfully added:\nGroup: " + this.comboSemester.Text + " group: " + comboGroup.Text);
                    }
                    mc.Database.Connection.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message + '\n' + ex.ToString());
                }

            }
        }
        public class GroupsComparer : IEqualityComparer<groups>
        {
            public bool Equals(groups x, groups y)
            {
                return (x.group_id.ToLower() == y.group_id.ToLower());
            }

            public int GetHashCode(groups obj)
            {
                throw new NotImplementedException();
            }
        }

        private void comboGroup_TextUpdate(object sender, EventArgs e)
        {
            if (comboGroup.Text.Length > 0 && comboSemester.Text.Length>0)
                btnAddGroup.Enabled = true;
            else
                btnAddGroup.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var mc = new Model1Container1())
            {
                try
                {
                    mc.Database.Connection.Open();
                    //subjects s = new subjects();
                    //s.name = comboName.Text;s.hours = Convert.ToInt32(num)
                    subjects s = new subjects() { name = comboName.Text, hours = int.Parse(comboHours.Text), Need_special_auditorium = checkBoxNeedSpecAuditorium.Checked, type_of_lesson = comboTypeOfLesson.Text }; //,need_full_semester = true };
                    if (checkBoxNeedSpecAuditorium.Checked)
                        s.special_auditorium = comboAuditorium.Text.Trim();
                    if (((IEnumerable<subjects>)mc.subjects).Contains<subjects>(s, new SubjectsComparer()))
                        MessageBox.Show("Such subject with the same hours already exists\nChange name or hours");
                    else
                    {
                        mc.subjects.Add(s);
                        mc.SaveChanges();
                        subjectsDataGridView1.DataSource = typeof(List<int>);
                        subjectsDataGridView1.DataSource = mc.subjects.ToList();
                        MessageBox.Show("Successfully added:\nSubject: " + this.comboName.Text + "hours: " + comboHours.Text);
                    }
                    mc.Database.Connection.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message + '\n' + ex.ToString());
                }

            }
        }

        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboName.Text.Length > 0 && comboHours.Text.Length > 0)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void comboName_TextUpdate(object sender, EventArgs e)
        {
            if (comboName.Text.Length > 0 && comboHours.Text.Length > 0)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void comboTypeOfLesson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxNeedSpecAuditorium_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxNeedSpecAuditorium.Checked)
                this.comboAuditorium.Enabled = true;

            else this.comboAuditorium.Enabled = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupsDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = groupsDataGridView1.CurrentRow;
            groups group = row.DataBoundItem as groups;
            if (group != null)
            {
                var studentsForm = new StudentsForm(group);
                studentsForm.Show();
            }
        }

        private void groupsDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupsDataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            assignSubjectsbtn.Enabled = true;
            editGroupbtn.Enabled = true;
        }

        private void assignSubjectsbtn_Click(object sender, EventArgs e)
        {
            //if (this.groupsDataGridView1.SelectedRows.Count == 1)
            var g = this.groupsDataGridView1.SelectedRows[groupsDataGridView1.CurrentCellAddress.Y].DataBoundItem as groups;
            if (g != null)
            {
                assignSubjectsToGroupForm f = new assignSubjectsToGroupForm(g);
                f.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            using (var mc = new Model1Container1())
            {
                try
                {
                    teachers teacherToAdd;
                    if (this.textBoxLecturerSurname.Text.Length > 0 && this.textBoxLecturerName.Text.Length > 0 && this.textBoxLecturerPatronymic.Text.Length > 0)
                    {
                        teacherToAdd = new teachers { Surname = this.textBoxLecturerSurname.Text, Name = this.textBoxLecturerName.Text, Patronymic = this.textBoxLecturerPatronymic.Text, department = this.comboLecturerDepartment.Text, Birth_Date = this.dateTimePicker1.Value.Date, email = this.textBoxLecturerEmail.Text, phone_number = this.textBoxPhone.Text };
                    }
                    else
                    {
                        MessageBox.Show("Surname, Name and Patronymic are mandatory");
                        return;
                    }

                    var q = (from lecturer in mc.teachers
                             where lecturer.Surname == teacherToAdd.Surname && lecturer.Name == teacherToAdd.Name && lecturer.Patronymic == teacherToAdd.Patronymic && lecturer.Birth_Date == teacherToAdd.Birth_Date.Date
                             select lecturer).FirstOrDefault();
                    if (q != null)
                    {
                        MessageBox.Show("This lecturer is already in database");
                        return;
                    }
                    else
                    {
                        mc.teachers.Add(teacherToAdd);                        
                        mc.SaveChanges();
                        this.teachersDataGridView1.DataSource = null;
                        this.teachersDataGridView1.DataSource = mc.teachers.ToList();
                    }

                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message + '\n' + ex.ToString());
                }
            }
        }

        private void comboSemester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeLecturerbtn_Click_1(object sender, EventArgs e)
        {
            //List of entities to delete on server
            List<teachers> groupsWithSubjectsToDelete = new List<teachers>();

            using (var mc = new Model1Container1())
            {
                //var mc = new Model1Container1();
                try
                {
                    //Alter datasources of subjectsDataGridView1 and comboSubject
                    foreach (DataGridViewRow row in this.teachersDataGridView1.SelectedRows)
                    {

                        teachers lessonToDelete = row.DataBoundItem as teachers;
                        mc.teachers.Attach(lessonToDelete);
                        //mc.teachers.Remove(lessonToDelete);
                        mc.Entry(lessonToDelete).State = System.Data.Entity.EntityState.Deleted;

                    }
                    mc.SaveChanges();
                    this.teachersDataGridView1.DataSource = null;
                    this.teachersDataGridView1.DataSource = mc.teachers.ToList();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    Console.WriteLine(ex.Message + '\n' + ex.ToString());
                }
            }
        }           
    }
    public class SubjectsComparer : IEqualityComparer<subjects>
    {
        public bool Equals(subjects x, subjects y)
        {
            return (x.name.ToLower() == y.name.ToLower() && x.hours == y.hours && x.type_of_lesson == y.type_of_lesson);
        }

        public int GetHashCode(subjects obj)
        {
            throw new NotImplementedException();
        }
    }


}
