using myHomeWorkForm.Mod;
using myHomeWorkForm.MyCont;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myHomeWorkForm
{
    public partial class Form6 : Form
    {
        MyDbContext mm = new MyDbContext();
        public Form6()
        {
            InitializeComponent();
        }
        private void btn_showAllSubjectLectures_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            List<SubjectLecture> list;
            using (var res = new MyDbContext())
            {
                list = res.subjectLectures1.ToList();

                foreach (var sublect in list)
                {
                    richTextBox1.AppendText($"{sublect.Id}\t{sublect.Subject_id}\t{sublect.Title}\t{sublect.Content}\n===================================\n");
                }
            }
        }

        private void btn_AddExam_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_SubjectID.Text == "" | txt_Title.Text == "" | txt_content.Text == "")
                    MessageBox.Show("Please Enter Your Data >> maybe forget some input feilds null ");
                else
                {
                    var sublect = new SubjectLecture();
                    sublect.Subject_id = int.Parse(txt_SubjectID.Text);
                    sublect.Title = txt_Title.Text;
                    sublect.Content = txt_content.Text;

                    mm.subjectLectures1.Add(sublect);
                    mm.SaveChanges();
                    txt_SubjectID.Text = "";
                    txt_Title.Text = "";
                    txt_content.Text = "";
                    MessageBox.Show($"your Subject Lecture Id : {sublect.Subject_id}\nyour Subject Lecture title : {sublect.Title}\nyour Subject Lecture content: {sublect.Content}\n=================================================================");
                }
            }catch (Exception exx) { 
            MessageBox.Show($"Sorry The Id {Convert.ToInt32(txt_SubjectID.Text)} not found in the Entity Subjects");   
            }

        }

        private void btn_findSubjectLecturesById_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(findSubjectLectures.Text);
                SubjectLecture sublect = mm.subjectLectures1.Find(id);

                if (sublect == null)
                {
                    MessageBox.Show($"the SubjectLecture not found in id : {id}");
                    findSubjectLectures.Text = "";
                    return;
                }
                txt_show_SubjectId.Text = Convert.ToString(sublect.Subject_id);
                txt_show_title.Text = Convert.ToString(sublect.Title);
                txt_show_content.Text = Convert.ToString(sublect.Content);

                MessageBox.Show($"the SubjectLecture found sccessful");
            }
            catch (FormatException f)
            {
                MessageBox.Show(f.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_deleteExamById_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(findSubjectLectures.Text);
                var sublect = mm.subjectLectures1.Find(id);
                if (sublect == null)
                {
                    MessageBox.Show($"the SubjectLecture not found in id : {id}");
                    findSubjectLectures.Text = "";
                    return;
                }
                mm.Remove(sublect);
                mm.SaveChanges();
                richTextBox1.Text = "";
                MessageBox.Show($"the SubjectLecture have id : {id} Deleted sccessful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_show_SubjectId.Text == "" | txt_show_title.Text == "" | txt_show_content.Text == "")
                    MessageBox.Show("Please Enter Your Data >> maybe forget some input feilds null ");
                else
                {
                    int id = int.Parse(findSubjectLectures.Text);
                    var sublect = mm.subjectLectures1.Find(id);
                    if (sublect == null)
                    {
                        MessageBox.Show($"the SubjectLecture not found in id : {id}");
                        findSubjectLectures.Text = "";
                        return;
                    }
                    sublect.Subject_id = int.Parse(txt_show_SubjectId.Text);
                    sublect.Title = (txt_show_title.Text);
                    sublect.Content = (txt_show_content.Text);

                    mm.SaveChanges();
                    MessageBox.Show($"information SubjectLecture Updeted sccessful");
                    richTextBox1.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
