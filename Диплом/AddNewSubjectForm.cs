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
    public partial class AddNewSubjectForm : Form
    {
        public AddNewSubjectForm()
        {
            InitializeComponent();

            using (var mc = new Model1Container1())
            {
                try
                {
                    mc.Database.Connection.Open();
                    comboName.ValueMember = "subject_id";
                    comboName.DisplayMember = "name";
                    comboName.DataSource = mc.subjects.ToList();

                    comboHours.ValueMember = "quantity";
                    comboHours.DisplayMember = "quantity";
                    comboHours.DataSource = mc.hours.ToList();

                    comboAuditorium.ValueMember = "number";
                    comboAuditorium.DisplayMember = "number";
                    comboAuditorium.DataSource = mc.auditoriums.ToList();

                    mc.Database.Connection.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message + '\n' + ex.ToString());
                }

            }
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
                    subjects s = new subjects() { name = comboName.Text, hours = int.Parse(comboHours.Text), Need_special_auditorium = checkBoxNeedSpecAuditorium.Checked, need_full_semester = true };
                    if (checkBoxNeedSpecAuditorium.Checked)
                        s.special_auditorium = comboAuditorium.Text.Trim();
                    if (((IEnumerable<subjects>)mc.subjects).Contains<subjects>(s, new SubjectsComparer()))
                        MessageBox.Show("Such subject with the same hours already exists\nChange name or hours");
                    else
                    {
                        mc.subjects.Add(s);
                        mc.SaveChanges();
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
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxNeedSpecAuditorium.Checked)
                this.comboAuditorium.Enabled = true;

            else this.comboAuditorium.Enabled = false;
        }
        private void comboName_TextUpdate(object sender, EventArgs e)
        {
            if (comboName.Text.Length > 0 && comboHours.Text.Length > 0)
                button1.Enabled = true;
            else 
                button1.Enabled = false;
        }

        private void comboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboName.Text.Length > 0 && comboHours.Text.Length > 0)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void btnAllSubjects_Click(object sender, EventArgs e)
        {
            var subjWindow = new AllSubjects();
            subjWindow.Show();
            //using (var mc = new Model1Container1())
            //{
            var mc = new Model1Container1();
                try
                {
                    mc.Database.Connection.Open();
                    var q = from s in mc.subjects
                            select s;

                    subjWindow.dataGridView1.DataSource = q.ToList();// mc.subjects.ToList();// mc.subjects.Local.ToList();

                    mc.Database.Connection.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    Console.WriteLine(ex.Message + '\n' + ex.ToString());
                }
            //}
        }

        private void checkBoxNeedSpecAuditorium_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    
}
