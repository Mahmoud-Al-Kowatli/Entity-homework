using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myHomeWorkForm.Mod;

namespace myhomework.Model
{
    public class Student
    {
        /*
        public int Id { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Registerdate { get; set; }
        public int Department_id { get; set; }
        */
        public int Id { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Registerdate { get; set; }
        //===============================================
        [ForeignKey("Department")]
        public int Department_id { get; set; }
        public Department Department { get; set; }
        //===============================================
        /*
        public List<StudentsMark> StudentsMarks { get; set; }
        public List<Exam> Exams { get; set; }
        */
        public ICollection <StudentsMark> StudentsMarks { get; set; }
        public ICollection<Exam> Exams { get; set; }

    }
}
