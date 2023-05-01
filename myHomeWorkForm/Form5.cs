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
    public partial class Form5 : Form
    {
        MyDbContext mm = new MyDbContext();
        public Form5()
        {
            InitializeComponent();
        }

        private void btn_showAllStudentMarks_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            List<StudentsMark> list;
            using (var res = new MyDbContext())
            {
                list = res.studentmarks1.ToList();

                foreach (var stmk in list)
                {
                    richTextBox1.AppendText($"{stmk.Id}\t{stmk.Student_id}\t{stmk.Exam_id}\t{stmk.Mark}\n===================================\n");
                }
            }
        }

        private void btn_AddStudentMark_Click(object sender, EventArgs e)
        {
            try {
                if (txt_StudentID.Text == "" | txt_ExamId.Text == "" | txt_Mark.Text == "" )
                    MessageBox.Show("Please Enter Your Data >> maybe forget some input feilds null ");
                else
                {
                    var stmk = new StudentsMark();
                    stmk.Student_id = int.Parse(txt_StudentID.Text);
                    stmk.Exam_id = int.Parse(txt_ExamId.Text);
                    stmk.Mark = int.Parse(txt_Mark.Text);

                    mm.studentmarks1.Add(stmk);
                    mm.SaveChanges();
                    txt_StudentID.Text = "";
                    txt_ExamId.Text = "";
                    txt_Mark.Text = "";
                    MessageBox.Show($"your StudentsMark Id : {stmk.Student_id}\nyour StudentsMark term : {stmk.Exam_id}\nyour StudentsMark date: {stmk.Mark}\n=================================================================");
                }
            }
            catch (Exception exx) { 
            MessageBox.Show($"Sorry The Id {Convert.ToInt32(txt_StudentID.Text)} OR  {Convert.ToInt32(txt_ExamId.Text)} not found in the Entity Subjects");   
            }
        
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btn_findStudentExamById_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(findStudentExam.Text);
                StudentsMark stmk = mm.studentmarks1.Find(id);

                if (stmk == null)
                {
                    MessageBox.Show($"the StudentsMark not found in id : {id}");
                    findStudentExam.Text = "";
                    return;
                }
                txt_show_ExamtId.Text = Convert.ToString(stmk.Exam_id);
                txt_show_StudentId.Text = Convert.ToString(stmk.Student_id);
                txt_show_mark.Text = Convert.ToString(stmk.Mark);

                MessageBox.Show($"the StudentsMark found sccessful");
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

        private void btn_deleteStudentExamById_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(findStudentExam.Text);
                var stmk = mm.studentmarks1.Find(id);
                if (stmk == null)
                {
                    MessageBox.Show($"the student marks not found in id : {id}");
                    findStudentExam.Text = "";
                    return;
                }
                mm.Remove(stmk);
                mm.SaveChanges();
                richTextBox1.Text = "";
                MessageBox.Show($"the student marks have id : {id} Deleted sccessful");
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
                if (txt_show_ExamtId.Text == "" | txt_show_StudentId.Text == "" | txt_show_mark.Text == "")
                    MessageBox.Show("Please Enter Your Data >> maybe forget some input feilds null ");
                else
                {
                    int id = int.Parse(findStudentExam.Text);
                    var stmk = mm.studentmarks1.Find(id);
                    if (stmk == null)
                    {
                        MessageBox.Show($"the student marks not found in id : {id}");
                        findStudentExam.Text = "";
                        return;
                    }
                    stmk.Exam_id = int.Parse(txt_show_ExamtId.Text);
                    stmk.Student_id = int.Parse(txt_show_StudentId.Text);
                    stmk.Mark = int.Parse(txt_show_mark.Text);

                    mm.SaveChanges();
                    MessageBox.Show($"information student marks  Updeted sccessful");
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
