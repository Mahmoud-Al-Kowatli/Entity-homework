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
    public partial class Form2 : Form
    {
        MyDbContext mm = new MyDbContext();
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_show_allDepartment_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            List<Department> list;
            using (var res = new MyDbContext())
            {
                list = res.departments1.ToList();

                foreach (var dep in list)
                {
                    richTextBox1.AppendText($"id : {dep.ID}\t\tname : {dep.Name}\n");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_addDepartment_Click(object sender, EventArgs e)
        {
            if ( txt_departmentname.Text == "")
                MessageBox.Show("Please Enter Your Data >> maybe forget some input feilds null ");
            else
            {
                var depart = new Department();
                depart.Name = txt_departmentname.Text;
                mm.departments1.Add(depart);
                mm.SaveChanges();
                txt_departmentname.Text = "";
                MessageBox.Show($"your ID : {depart.ID}\nyour Department name : {depart.Name}\n=================================================================");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_findId_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txt_idDepartment.Text);
                var dep = mm.departments1.Find(id);

                if (dep == null)
                {
                    MessageBox.Show($"the department not found in id : {id}");
                    txt_idDepartment.Text = "";
                    txt_show_idDepartment.Text = "";
                    txt_show_nameDepartment.Text = "";
                    return;
                }
                txt_show_idDepartment.Text = Convert.ToString(dep.ID);
                txt_show_nameDepartment.Text = dep.Name;
                MessageBox.Show($"the department found sccessful");
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

        private void btn_deleteDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txt_idDepartment.Text);
                var dep = mm.departments1.Find(id);
                if (dep == null)
                {
                    MessageBox.Show($"the departments not found in id : {id}");
                    txt_idDepartment.Text = "";
                    txt_show_idDepartment.Text = "";
                    txt_show_nameDepartment.Text = "";
                    return;
                }
                mm.Remove(dep);
                mm.SaveChanges();
                richTextBox1.Text = "";
                MessageBox.Show($"the departments have id : {id} Deleted sccessful");
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
                if ( txt_show_nameDepartment.Text == "" | txt_show_idDepartment.Text == "")
                    MessageBox.Show("Please Enter Your Data >> maybe forget some input feilds null ");
                else
                {
                    int id = int.Parse(txt_idDepartment.Text);
                    var dep = mm.departments1.Find(id);
                    if (dep == null)
                    {
                        MessageBox.Show($"the departments not found in id : {id}");
                        txt_idDepartment.Text = "";
                        txt_show_idDepartment.Text = "";
                        txt_show_nameDepartment.Text = "";
                        return;
                    }
                    dep.Name = txt_show_nameDepartment.Text;
                    mm.SaveChanges();
                    MessageBox.Show($"information departments Updeted sccessful");
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
