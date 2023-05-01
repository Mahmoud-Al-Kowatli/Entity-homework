using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myHomeWorkForm.Mod
{
    public class SubjectLecture
    {
        /*
        public int Id { get; set; }
        public int Subject_id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        */
        public int Id { get; set; }
        //===============================================
        [ForeignKey("Subject")]
        public int Subject_id { get; set; }
        public Subject Subject { get; set; }
        //===============================================
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
