using System.Collections.Generic;
using DES3560.Course;

namespace DES3560.Curriculum.RGC
{
    public class CommonRGC
    {
        public string pdfText;
        public List<string> subjectList;
        public List<string> unacquiredRGC;
        public string RGCGrade;

        public CommonRGC(string text)
        {
            pdfText = text;

            subjectList = new List<string>();
            unacquiredRGC = new List<string>();

            subjectList.Add(RGCCourse.RGC0017);
            subjectList.Add(RGCCourse.RGC0018);
            subjectList.Add(RGCCourse.RGC0003);
            subjectList.Add(RGCCourse.RGC1001);
            subjectList.Add(RGCCourse.RGC0005);
            subjectList.Add(RGCCourse.RGC1033);
            subjectList.Add(RGCCourse.RGC1034);

            checkRGC();
        }
        public void checkRGC()
        {
            foreach(string s in subjectList)
            {
                if (!pdfText.Contains(s))
                    unacquiredRGC.Add(s);
            }
            if (!(pdfText.Contains(RGCCourse.RGC1050) || pdfText.Contains(RGCCourse.RGC1051)
                || pdfText.Contains(RGCCourse.RGC1052)))
                unacquiredRGC.Add("리더십");
            RGCGrade = pdfText.Substring(pdfText.IndexOf("공통교양: 총") + 7, 2);
        }
    }
}
