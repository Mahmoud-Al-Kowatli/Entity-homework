using myhomework.Model;
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
    public partial class Form3 : Form
    {
        MyDbContext mm = new MyDbContext();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_showAllSubject_Click(object sender, EventArgs e)
        {

            richTextBox1.Text = "";
            List<Subject> list;
            using (var res = new MyDbContext())
            {
                list = res.subjects1.ToList();

                foreach (var sub in list)
                {
                    richTextBox1.AppendText($"{sub.Id}\t{sub.Department_id}\t{sub.Name}\t{sub.Minimumdegree}\t{sub.Term}\t{sub.Year}\n===================================\n");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_SubjectID.Text == "" | txt_Subjectname.Text == "" | txt_MinimumDegree.Text == "" | txt_Term.Text == "" | txt_Year.Text == "")
                MessageBox.Show("Please Enter Your Data >> maybe forget some input feilds null ");
            else
            {
                var sub = new Subject();
                sub.Department_id = int.Parse(txt_SubjectID.Text);
                sub.Name = txt_Subjectname.Text;
                sub.Minimumdegree = int.Parse(txt_MinimumDegree.Text);
                //sub.Term = int.Parse(txt_Term.Text);
                //sub.Year = int.Parse(txt_Year.Text);
                sub.Term = Convert.ToByte(txt_Term.Text);
                sub.Year = Convert.ToByte(txt_Year.Text);

                mm.subjects1.Add(sub);
                mm.SaveChanges();
                MessageBox.Show($"your subject Id : {sub.Department_id}\nyour subject name : {sub.Name}\nyour Minimum Degree: {sub.Minimumdegree}\nyour Term : {sub.Term}\nyour Year : {sub.Year}\n\n=================================================================");
            }
        }

        private void btn_findSubjectById_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(findSubject.Text);
                //Subject sub = mm.subjects1.Find(id);
                Subject sub = mm.subjects1.Find(id);

                if (sub == null)
                {
                    MessageBox.Show($"the subjects not found in id : {id}");
                    findSubject.Text = "";
                    return;
                }
                txt_show_subjectid.Text = Convert.ToString(sub.Department_id);
                txt_show_subjectName.Text = sub.Name;
                txt_show_subjectMinim.Text = Convert.ToString(sub.Minimumdegree);
                txt_show_subjectTerm.Text = Convert.ToString(sub.Term);
                txt_show_subjectYear.Text = Convert.ToString(sub.Year);

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

        private void btn_deleteSubjectById_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(findSubject.Text);
                var sub = mm.subjects1.Find(id);
                if (sub == null)
                {
                    MessageBox.Show($"the subjects not found in id : {id}");
                    findSubject.Text = "";
                    return;
                }
                mm.Remove(sub);
                mm.SaveChanges();
                richTextBox1.Text = "";
                MessageBox.Show($"the subjects have id : {id} Deleted sccessful");
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
                if (txt_show_subjectid.Text == "" | txt_show_subjectName.Text == "" | txt_show_subjectMinim.Text == "" | txt_show_subjectTerm.Text == "" | txt_show_subjectYear.Text == "")
                    MessageBox.Show("Please Enter Your Data >> maybe forget some input feilds null ");
                else
                {
                    int id = int.Parse(findSubject.Text);
                    var sub = mm.subjects1.Find(id);
                    if (sub == null)
                    {
                        MessageBox.Show($"the subjects not found in id : {id}");
                        findSubject.Text = "";
                        return;
                    }
                    sub.Department_id = int.Parse(txt_show_subjectid.Text);
                    sub.Name = txt_show_subjectName.Text;
                    sub.Minimumdegree = int.Parse(txt_show_subjectMinim.Text);
                    sub.Term = Convert.ToByte(txt_show_subjectTerm.Text);
                    sub.Year = Convert.ToByte(txt_show_subjectYear.Text);

                    mm.SaveChanges();
                    MessageBox.Show($"information subjects Updeted sccessful");
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