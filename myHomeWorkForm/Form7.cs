using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.IdentityModel.Tokens;
using myhomework.Model;
using myHomeWorkForm.Mod;
using myHomeWorkForm.MyCont;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace myHomeWorkForm
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            List<Student> list;
            using (var res = new MyDbContext())
            {
                list = res.students1.ToList();
                list = list.OrderBy(u => u.Department_id).ToList();

                foreach (var dep in list)
                {
                    richTextBox1.AppendText($"id : {dep.Id}\t\tname : {dep.Username}\t\t{dep.Department_id}\n");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_findStudentSameDept.Text == "")
                {
                    MessageBox.Show("the input is null >> Empty ");
                    txt_findStudentSameDept.Text = "";
                    return;
                }
                richTextBox1.Text = "";
                int dapt = int.Parse(txt_findStudentSameDept.Text);
                List<Student> list;
                using (var res = new MyDbContext())
                {
                    list = res.students1.Where(x => x.Department_id == dapt).ToList();
                    if (!list.IsNullOrEmpty())
                        foreach (var dep in list)
                            richTextBox1.AppendText($"id : {dep.Id}\t\tname : {dep.Username}\t\t{dep.Department_id}\n");
                    else
                        MessageBox.Show($"Sorry the department {dapt} is not Found");
                }
            }
            catch (FormatException ff)
            {
                MessageBox.Show(ff.Message);
            }
            catch (Exception ff)
            {
                MessageBox.Show(ff.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_findStudentGetExam.Text == "")
                {
                    MessageBox.Show("the input is Empty ?? please Enter id Exam");
                    txt_findStudentGetExam.Text = "";
                    return;
                }
                richTextBox1.Text = "";
                int exam = int.Parse(txt_findStudentGetExam.Text);
                List<int> IdStyd = new List<int>();
                using (var res = new MyDbContext())
                {
                    //int examId = 1 ; // sample exam ID
                    //var students = from se in res.studentmarks1 
                    //               join s in res.students1 on se.Student_id equals s.Id
                    //               //where se.Exam_id == examId
                    //               select s;
                    //var v = res.students1.Include(x => x.Exams).ToList();

                    var rr = res.studentmarks1.Where(x => x.Exam_id == exam).ToList();
                    if (rr.Count == 0)
                    {
                        MessageBox.Show($"Sorry The Exam id : {exam} Not Found >>> ");
                        return;
                    }
                    foreach (var dep in rr)
                    {
                        IdStyd.Add(dep.Student_id);
                        richTextBox1.AppendText($"id : {dep.Id}\tStudent_id : {dep.Student_id}\tExam_id: {dep.Exam_id} \tmark : {dep.Mark}\n");
                    }
                    richTextBox1.AppendText($"\n===========  The Student  ==========\n");
                    foreach (var id in IdStyd)
                    {
                        // list.Add( res.students1.Find( id ) );
                        // richTextBox1.AppendText($"id : {dep.Id}\t\tStudent_id : {dep.Student_id}\t\tExam_id: {dep.Exam_id} \tmark : {dep.Mark}\n");
                        Student dep = res.students1.Find(id);
                        richTextBox1.AppendText($"id : {dep.Id}\tusername : {dep.Username}\temail : {dep.Email}\t\tPhone : {dep.Phone} \n");
                    }

                    //list = res.students1.Where(x => x.Department_id == exam).ToList();


                    //if (!list.IsNullOrEmpty())
                    //{
                    //    foreach (var dep in list)
                    //    {
                    //        richTextBox1.AppendText($"id : {dep.Id}\t\tname : {dep.Username}\t\t{dep.Department_id}\n");
                    //    }
                    //}
                    //else
                    //    MessageBox.Show($"Sorry the Exam id : {exam} is not Found");

                }
            }
            catch (FormatException ff)
            {
                MessageBox.Show(ff.Message);
            }
            catch (Exception ff)
            {
                MessageBox.Show(ff.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_findStudentNotGetExam.Text == "")
                {
                    MessageBox.Show("the input is Empty ?? please Enter id Exam");
                    txt_findStudentNotGetExam.Text = "";
                    return;
                }
                richTextBox1.Text = "";
                int exam = int.Parse(txt_findStudentNotGetExam.Text);
                List<int> IdStyd = new List<int>();
                Student depp;
                using (var res = new MyDbContext())
                {
                    var rr = res.studentmarks1.Where(x => x.Exam_id != exam).ToList();

                    if (rr.Count == 0)
                    {
                        MessageBox.Show($"Sorry The Exam id : {exam} Not Found >>> ");
                        return;
                    }
                    foreach (var dep in rr)
                    {
                        IdStyd.Add(dep.Student_id);
                        richTextBox1.AppendText($"id : {dep.Id}\tStudent_id : {dep.Student_id}\tExam_id: {dep.Exam_id} \tmark : {dep.Mark}\n");
                    }
                    richTextBox1.AppendText($"\n===========  The Student  ==========\n");
                    foreach (var id in IdStyd)
                    {
                        depp = res.students1.Find(id);
                        richTextBox1.AppendText($"id : {depp.Id}\tusername : {depp.Username}\temail : {depp.Email}\t\tPhone : {depp.Phone} \n");
                    }
                }
            }
            catch (FormatException ff)
            {
                MessageBox.Show(ff.Message);
            }
            catch (Exception ff)
            {
                MessageBox.Show(ff.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //txt_findSubjectStudent
            try
            {
                int count = 0; double sum = 0;
                richTextBox1.Text = "";
                int idStud = int.Parse(txt_findSubjectStudent.Text);
                using (var res = new MyDbContext())
                {
                    Student stud = res.students1.Find(idStud);

                    if (txt_findSubjectStudent.Text == "" | stud == null)
                    {
                        MessageBox.Show("the input is Empty ?? please Enter id Student It really exists.");
                        txt_findSubjectStudent.Text = "";
                        return;
                    }

                    List<StudentsMark> Mark = res.studentmarks1.Where(x => x.Student_id == idStud).ToList();
                    List<int> idExam = new List<int>();//store id of exam
                    foreach (var v in Mark)
                    {
                        idExam.Add(v.Exam_id);
                        sum += v.Mark;
                        count++;
                    }


                    List<Exam> exam = new List<Exam>();
                    foreach (var idSubject in idExam)
                        exam.Add(res.exams1.Find(idSubject));

                    List<Subject> subId = new List<Subject>();
                    List<int> idSubj = new List<int>();
                    foreach (var v in exam)
                        idSubj.Add(v.Subject_id);

                    foreach (var idSubject in idSubj)
                        subId.Add(res.subjects1.Find(idSubject));

                    foreach (var vv in subId)
                    {
                        richTextBox1.AppendText($"id : {vv.Id}\tname subject: {vv.Name}\tterm subject : {vv.Term}\t\tyear subject: {vv.Year} \n");
                    }
                    richTextBox1.AppendText($"the Avg Is  : {sum / count}");
                    //if (rr.Count == 0)
                    //{
                    //    MessageBox.Show($"Sorry The Exam id : {exam} Not Found >>> ");
                    //    return;
                    //}
                    //foreach (var dep in rr)
                    //{
                    //    IdStyd.Add(dep.Student_id);
                    //    richTextBox1.AppendText($"id : {dep.Id}\tStudent_id : {dep.Student_id}\tExam_id: {dep.Exam_id} \tmark : {dep.Mark}\n");
                    //}
                    //richTextBox1.AppendText($"\n===========  The Student  ==========\n");
                    //foreach (var id in IdStyd)
                    //{
                    //    depp = res.students1.Find(id);
                    //    richTextBox1.AppendText($"id : {depp.Id}\tusername : {depp.Username}\temail : {depp.Email}\t\tPhone : {depp.Phone} \n");
                    //}
                }
            }
            catch (FormatException ff)
            {
                MessageBox.Show(ff.Message);
            }
            catch (Exception ff)
            {
                MessageBox.Show(ff.Message);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string email = textBox1.Text;

            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (expr.IsMatch(email)) ;
            else
            {
                textBox1.Text = "";
                MessageBox.Show("invalid Email >> Please Enter Email");
            }
        }
    }
}
