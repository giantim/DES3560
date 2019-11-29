using System.Collections.Generic;
using DES3560.Course;

namespace DES3560.Curriculum.RGC
{
    public class CommonRGC
    {
        public List<Subject> subjectList;
        public List<string> unacquiredList;
        public int RGCGrade;

        public CommonRGC(string text)
        {
            RGCGrade = 0;
            subjectList = new List<Subject>();
            unacquiredList = new List<string>();
        }
        public void checkRGC(List<Subject> list)
        {
            
        }
    }
}
