using System.Collections.Generic;
using DES3560.Subject;

namespace DES3560.Curriculum.RGC
{
    public class CommonRGC
    {
        public string pdfText;
        public List<string> subjectList;
        public List<string> unacquiredRGC;
        public string RGCGrade;

        #region Functions
        public CommonRGC(string text)
        {
            pdfText = text;

            subjectList = new List<string>();
            unacquiredRGC = new List<string>();

            subjectList.Add(subjectRGC.RGC0017);
            subjectList.Add(subjectRGC.RGC0018);
            subjectList.Add(subjectRGC.RGC0003);
            subjectList.Add(subjectRGC.RGC1001);
            subjectList.Add(subjectRGC.RGC0005);
            subjectList.Add(subjectRGC.RGC1033);
            subjectList.Add(subjectRGC.RGC1034);

            checkRGC();
        }
        public void checkRGC()
        {
            foreach(string s in subjectList)
            {
                if (!pdfText.Contains(s))
                    unacquiredRGC.Add(s);
            }
            if (!(pdfText.Contains(subjectRGC.RGC1050) || pdfText.Contains(subjectRGC.RGC1051)
                || pdfText.Contains(subjectRGC.RGC1052)))
                unacquiredRGC.Add("리더십");
            RGCGrade = pdfText.Substring(pdfText.IndexOf("공통교양: 총") + 7, 2);
        }
        #endregion
    }
}
