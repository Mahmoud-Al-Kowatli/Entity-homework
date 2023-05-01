using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHomeWorkForm.Mod
{
    public class Subject
    {
        /*
        public int Id { get; set; }
        public int Department_id { get; set; }
        public string Name { get; set; }
        public int Minimumdegree { get; set; }
        public byte Term { get; set; }
        public byte Year { get; set; }

        //public SqlInt16 Year { get; set; }
        */
        public int Id { get; set; }
        //===============================================
        [ForeignKey("Department")]
        public int Department_id { get; set; }
        public Department Department { get; set; }
        //===============================================
        public string Name { get; set; }
        public int Minimumdegree { get; set; }
        public byte Term { get; set; }
        public byte Year { get; set; }
        //===============================================
        public List<SubjectLecture> SubjectLectures { get; set; }
        //===============================================
        public List<Exam> Exams { get; set; }
    }
}
