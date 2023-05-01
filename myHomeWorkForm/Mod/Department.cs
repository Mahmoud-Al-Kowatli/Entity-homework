using myhomework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHomeWorkForm.Mod
{
    public class Department
    {
        /*
        public int ID { get; set; }
        public string Name { get; set; }
        */
        public int ID { get; set; }
        public string Name { get; set; }

        public List<Student> Students { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
