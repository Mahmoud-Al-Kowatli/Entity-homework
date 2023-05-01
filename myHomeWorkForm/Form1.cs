
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using System.Windows.Forms;

using myHomeWorkForm.MyCont;
using myhomework.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace myHomeWorkForm
{
    public partial class Form1 : Form
    {
        MyDbContext mm = new MyDbContext();
        public Form1()
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

                foreach (var student in list)
                {
                    richTextBox1.AppendText($"{student.Username}\t{student.Firstname}\t{student.Lastname}\t{student.Phone}\t{student.Email}\t{student.Registerdate}\t{student.Department_id}\n");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" | txt_firstname.Text == "" | txt_lastname.Text == "" | txt_email.Text == "" | txt_phone.Text == "" | txt_registeryear.Text == "" | txt_department.Text == "")
                MessageBox.Show("Please Enter Your Data >> maybe forget some input feilds null ");
            else
            {
                var student = new Student();
                student.Username = txt_username.Text;
                student.Firstname = txt_firstname.Text;
                student.Lastname = txt_lastname.Text;
                student.Email = txt_email.Text;
                student.Phone = txt_phone.Text;
                student.Registerdate = int.Parse(txt_registeryear.Text);
                student.Department_id = int.Parse(txt_department.Text);
                mm.students1.Add(student);
                mm.SaveChanges();
                MessageBox.Show($"your name : {student.Username}\nyour first name : {student.Firstname}\nyour last name : {student.Lastname}\nyour email : {student.Email}\nyour phone : {student.Phone}\nyour register year : {student.Registerdate}\nyour department : {student.Department_id}\n=================================================================");
            }

        }

        private void btn_findById_Click(object sender, EventArgs e)
        {
            try
            { 
                    int id = int.Parse(findStudent.Text);
                    var student = mm.students1.Find(id);

                    if (student == null)
                    {
                        MessageBox.Show($"the student not found in id : {id}");
                        findStudent.Text = "";
                        return;
                    }
                    txt_show_username.Text = student.Username;
                    txt_show_firstname.Text = student.Firstname;
                    txt_show_lastname.Text = student.Lastname;
                    txt_show_email.Text = student.Email;
                    txt_show_phone.Text = student.Phone;
                    txt_show_registeryear.Text = Convert.ToString(student.Registerdate);
                    txt_show_department.Text = Convert.ToString(student.Department_id);
                    MessageBox.Show($"the student found sccessful");
                
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_show_username.Text == "" | txt_show_firstname.Text == "" | txt_show_lastname.Text == "" | txt_show_email.Text == "" | txt_show_phone.Text == "" | txt_show_registeryear.Text == "" | txt_show_department.Text == "")
                    MessageBox.Show("Please Enter Your Data >> maybe forget some input feilds null ");
                else
                {
                    int id = int.Parse(findStudent.Text);
                    var student = mm.students1.Find(id);
                    if (student == null)
                    {
                        MessageBox.Show($"the student not found in id : {id}");
                        findStudent.Text = "";
                        return;
                    }
                    student.Username = txt_show_username.Text;
                    student.Firstname = txt_show_firstname.Text;
                    student.Lastname = txt_show_lastname.Text;
                    student.Email = txt_show_email.Text;
                    student.Phone = txt_show_phone.Text;
                    student.Registerdate = int.Parse(txt_show_registeryear.Text);
                    student.Department_id = int.Parse(txt_show_department.Text);
                    mm.SaveChanges();
                    MessageBox.Show($"information student Updeted sccessful");
                    richTextBox1.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(findStudent.Text);
                var student = mm.students1.Find(id);
                if (student == null)
                {
                    MessageBox.Show($"the student not found in id : {id}");
                    findStudent.Text = "";
                    return;
                }
                mm.Remove(student);
                mm.SaveChanges();
                richTextBox1.Text = "";
                MessageBox.Show($"the student have id : {id} Deleted sccessful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            string email = txt_email.Text;

            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (expr.IsMatch(email)) ;
            else
            {
                txt_email.Text = "";
                MessageBox.Show("invalid Email >> Please Enter Email");
            }
        }
        private void txt_show_email_Leave(object sender, EventArgs e)
        {
            string email = txt_show_email.Text;

            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (expr.IsMatch(email)) ;
            else
            {
                txt_show_email.Text = "";
                MessageBox.Show("invalid Email >> Please Enter Email");
            }
        }
    }
}