using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D7_SD43_Task
{
    internal class Subject
    {
        public string subjectname { get; set; }
        public string subjectid { get; set; }

        public Exam subjectExam { get; set; }

        public Subject(string subjectname, string subjectid, Exam subjectExam)
        {
            this.subjectname = subjectname;
            this.subjectid = subjectid;
            this.subjectExam = subjectExam;
        }
    }
}
