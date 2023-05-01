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
    public partial class Form4 : Form
    {
        MyDbContext mm = new MyDbContext();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btn_showAllExam_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            List<Exam> list;
            using (var res = new MyDbContext())
            {
                list = res.exams1.ToList();

                foreach (var exam in list)
                {
                    richTextBox1.AppendText($"{exam.Id}\t{exam.Subject_id}\t{exam.Date}\t{exam.Term}\n===================================\n");
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_Term_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_SubjectID_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void txt_Year_TextChanged(object sender, EventArgs e)
        {
        }

        private void label16_Click(object sender, EventArgs e)
        {
        }

        private void btn_AddExam_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_SubjectID.Text == "" | txt_Term.Text == "" | txt_Date.Text == "" )
                    MessageBox.Show("Please Enter Your Data >> maybe forget some input feilds null ");
                else
                {
                    var exam = new Exam();
                    exam.Subject_id = int.Parse(txt_SubjectID.Text);
                    exam.Term = Convert.ToByte(txt_Term.Text);
                    exam.Date = Convert.ToDateTime(txt_Date.Text);

                    mm.exams1.Add(exam);
                    mm.SaveChanges();
                    txt_SubjectID.Text = "";
                    txt_Term.Text = "";
                    txt_Date.Text = "";
                    MessageBox.Show($"your Subject Id : {exam.Subject_id}\nyour exam term : {exam.Term}\nyour exam date: {exam.Date}\nyour Term : {exam.Term}\n=================================================================");
                }
            }
            catch (Exception exx)
            {
                MessageBox.Show($"Sorry The Id {Convert.ToInt32(txt_SubjectID.Text)} not found in the Entity Subjects");
            }
        }

        private void btn_findExamById_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(findExam.Text);
                Exam exam = mm.exams1.Find(id);

                if (exam == null)
                {
                    MessageBox.Show($"the exam not found in id : {id}");
                    findExam.Text = "";
                    return;
                }
                txt_show_subjectid.Text = Convert.ToString(exam.Subject_id);
                txt_show_term.Text = Convert.ToString(exam.Term);
                txt_show_date.Text = Convert.ToString(exam.Date);

                MessageBox.Show($"the exam found sccessful");
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

        private void btn_findExamById_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(findExam.Text);
                Exam exam = mm.exams1.Find(id);

                if (exam == null)
                {
                    MessageBox.Show($"the exam not found in id : {id}");
                    findExam.Text = "";
                    return;
                }
                txt_show_ExamtId.Text = Convert.ToString(exam.Subject_id);
                txt_show_term.Text = Convert.ToString(exam.Term);
                txt_show_date.Text = Convert.ToString(exam.Date);

                MessageBox.Show($"the subjects found sccessful");
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
                int id = int.Parse(findExam.Text);
                var exam = mm.exams1.Find(id);
                if (exam == null)
                {
                    MessageBox.Show($"the exam not found in id : {id}");
                    findExam.Text = "";
                    return;
                }
                mm.Remove(exam);
                mm.SaveChanges();
                richTextBox1.Text = "";
                MessageBox.Show($"the exam have id : {id} Deleted sccessful");
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
                if (txt_show_ExamtId.Text == "" | txt_show_term.Text == "" | txt_show_date.Text == "")
                    MessageBox.Show("Please Enter Your Data >> maybe forget some input feilds null ");
                else
                {
                    int id = int.Parse(findExam.Text);
                    var exam = mm.exams1.Find(id);
                    if (exam == null)
                    {
                        MessageBox.Show($"the exam not found in id : {id}");
                        findExam.Text = "";
                        return;
                    }
                    exam.Subject_id = int.Parse(txt_show_ExamtId.Text);
                    exam.Term = Convert.ToByte(txt_show_term.Text);
                    exam.Date = Convert.ToDateTime(txt_show_date.Text);

                    mm.SaveChanges();
                    MessageBox.Show($"information exam Updeted sccessful");
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
