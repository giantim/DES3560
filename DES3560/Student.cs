using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DES3560
{
    public class Student
    {
        public int curriculumYear;
        public string studentClass;
        public string studentId;
        public string name;
        public string major;
        public bool submajor;

        public List<Subject> rgcList;
        public List<Subject> priList;
        public List<Subject> cseList;
        public List<Subject> desList;
    }
}
