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
    public partial class assignSubjectsToGroupForm : Form
    {

        private List<Lesson> datagridview_DataSource;
        private List<Lesson> comboSubject_Datasource;

        /// <summary>
        /// group called this form to show
        /// </summary>
        private groups currentGroup;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentGroup">current group to view subjects</param>
        /// <param name="semesterAndGroup"></param>
        public assignSubjectsToGroupForm(groups currGroup)
        {
            InitializeComponent();

            

            this.currentGroup = currGroup;
            //Переделать
            this.grouplb.Text = "Group: " + currentGroup.semester_id.ToString()+" "+currentGroup.group_id;

            //May be required to delete using
            using (var mc = new Model1Container1())
            {
                //var mc = new Model1Container1();
                try
                {
                    mc.Database.Connection.Open();

                    mc.Configuration.LazyLoadingEnabled = false;
                    //subjectsDataGridView1
                    var ids = from s in mc.groupswithsubjects
                              where s.group_id == currentGroup.group_id
                              select s.subject_id;

                    var q = from s in mc.subjects
                            where ids.Contains(s.id)
                            select new Lesson { subject_id = s.id, Name = s.name, LessonType = s.type_of_lesson };

                    datagridview_DataSource = q.ToList();
                    this.subjectsDataGridView1.DataSource = datagridview_DataSource;

                    //comboSubject
                    var q2 = from s in mc.subjects
                             where !ids.Contains(s.id)
                             select new Lesson { subject_id = s.id, Name = s.name, LessonType = s.type_of_lesson, NamePlusType = s.name+" - " + s.type_of_lesson };
                    //TypeOfLesson
                    comboSubject_Datasource = q2.ToList();

                    //comboSubject.ValueMember = nameof(Lesson.Name);
                    comboSubject.DisplayMember = nameof(Lesson.NamePlusType);
                    comboSubject.DataSource = comboSubject_Datasource;

                    mc.Database.Connection.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    Console.WriteLine(ex.Message + '\n' + ex.ToString());
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Lesson l = comboSubject.SelectedValue as Lesson;
            if (l != null && !datagridview_DataSource.Contains(l,l))
                datagridview_DataSource.Add(l);
            this.subjectsDataGridView1.DataSource = typeof(List<int>);
            this.subjectsDataGridView1.DataSource = datagridview_DataSource;

            //remove from comboSubject as used
            comboSubject_Datasource.Remove(l);
            comboSubject.DataSource = null;// typeof(List<int>);
            comboSubject.DataSource = comboSubject_Datasource;
            //add row on server
            using (var mc = new Model1Container1())
            {
                //var mc = new Model1Container1();
                try
                {
                    mc.Database.Connection.Open();
                    mc.groupswithsubjects.Add(new groupswithsubjects { group_id = currentGroup.group_id, subject_id = l.subject_id });
                    mc.SaveChanges();
                    mc.Database.Connection.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    Console.WriteLine(ex.Message + '\n' + ex.ToString());
                }
            }
        }

        private void removeSubjectbtn_Click(object sender, EventArgs e)
        {
            //List of entities to delete on server
            List<groupswithsubjects> groupsWithSubjectsToDelete = new List<groupswithsubjects>();

            //Alter datasources of subjectsDataGridView1 and comboSubject
            foreach (DataGridViewRow row in this.subjectsDataGridView1.SelectedRows)
            {
                Lesson lessonToDelete = row.DataBoundItem as Lesson;
                groupsWithSubjectsToDelete.Add(new groupswithsubjects { group_id = currentGroup.group_id, subject_id = lessonToDelete.subject_id });
                datagridview_DataSource.Remove(lessonToDelete);
                comboSubject_Datasource.Add(lessonToDelete);
                //subjectsDataGridView1.Rows.Remove(row);
            }

            //add subjects to comboSubject
            comboSubject.DataSource = null;// typeof(List<int>);
            comboSubject.DisplayMember = nameof(Lesson.NamePlusType);
            comboSubject.DataSource = comboSubject_Datasource;

            //add subjects to subjectsDataGridView1
            this.subjectsDataGridView1.DataSource = null;
            this.subjectsDataGridView1.DataSource = datagridview_DataSource;

            //remove rows on server
            using (var mc = new Model1Container1())
            {
                //var mc = new Model1Container1();
                try
                {
                    mc.Database.Connection.Open();

                    //var q = mc.groupswithsubjects.Where(x => groupsWithSubjectsToDelete.Contains(x, new GroupsWithSubjectsComparer()));

                    var b = from a in groupsWithSubjectsToDelete
                            from raz in mc.groupswithsubjects
                            where a.group_id == raz.group_id && a.subject_id == raz.subject_id
                            select raz;
                    //var q = from g in mc.groupswithsubjects
                    //        where groupsWithSubjectsToDelete.Contains(g, new GroupsWithSubjectsComparer())
                    //        select g;
                    foreach (var row in b)
                        mc.Entry(row).State = System.Data.Entity.EntityState.Deleted;
                    //mc.groupswithsubjects.RemoveRange(q);
                    mc.SaveChanges();
                    mc.Database.Connection.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    Console.WriteLine(ex.Message + '\n' + ex.ToString());
                }
            }
        }

        private void comboSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public class Lesson : IEqualityComparer<Lesson>
    {

        [System.ComponentModel.Browsable(false)]
        public int subject_id { get; set; }

        public string Name { get; set; }

        public string LessonType { get; set; }

        public string NamePlusType { get; set; }

        public Lesson() { }
        public Lesson(string name, string lessonType)
        {
            this.Name = name;
            this.LessonType = lessonType;
        }

        public bool Equals(Lesson x, Lesson y)
        {
            return x.subject_id == y.subject_id;
        }

        public int GetHashCode(Lesson obj)
        {
            throw new NotImplementedException();
        }
    }
    public class GroupsWithSubjectsComparer : IEqualityComparer<groupswithsubjects>
    {
        public bool Equals(groupswithsubjects x, groupswithsubjects y)
        {
            return x.group_id == y.group_id && x.subject_id == y.subject_id;
        }

        public int GetHashCode(groupswithsubjects obj)
        {
            throw new NotImplementedException();
        }
    }
}
