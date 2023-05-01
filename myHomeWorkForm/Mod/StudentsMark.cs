using myhomework.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHomeWorkForm.Mod
{
    public class StudentsMark
    {
        /*
        public int Id { get; set; }
        public int Student_id { get; set; }
        public int Exam_id { get; set; }
        public int Mark { get; set; }
        */
        public int Id { get; set; }
        //===============================================
        [ForeignKey("Student")]
        public int Student_id { get; set; }
        public Student Student { get; set; }
        //===============================================
        [ForeignKey("Exam")]
        public int Exam_id { get; set; }
        public Exam Exam { get; set; }
        //===============================================
        public int Mark { get; set; }
    }
}
