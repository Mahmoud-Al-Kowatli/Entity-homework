using myhomework.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHomeWorkForm.Mod
{
    public class Exam
    {
        /*
        public int Id { get; set; }
        public int Subject_id { get; set; }
        public DateTime Date { get; set; }
        public byte Term { get; set; }
        */
        public int Id { get; set; }
        //===============================================
        [ForeignKey("Subject")]
        public int Subject_id { get; set; }
        public Subject Subject { get; set; }
        //===============================================
        public DateTime Date { get; set; }
        public byte Term { get; set; }
        //===============================================
        /*
        public List<StudentsMark> StudentsMarks { get; set; }
        public List<Student> Students { get; set; }
        */
        public ICollection<StudentsMark> StudentsMarks { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
