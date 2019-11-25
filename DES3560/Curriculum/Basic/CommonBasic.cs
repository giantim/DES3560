using System.Collections.Generic;
using DES3560.Subject;

namespace DES3560.Curriculum.Basic
{
    public class CommonBasic
    {
        public string pdfText;
        public List<string> subjectList;
        public List<string> unacquiredBasic;
        public string basicGrade;

        public CommonBasic(string text)
        {
            pdfText = text;

            subjectList = new List<string>();
            unacquiredBasic = new List<string>();

            subjectList.Add(subjectCommon.PRI4040);
            subjectList.Add(subjectCommon.PRI4041);
            subjectList.Add(subjectCommon.PRI4043);
            subjectList.Add(subjectCommon.PRI4048);
            subjectList.Add(subjectCommon.EGC7026);

            checkBasic();
        }
        private void checkBasic()
        {
            int count = 0;
            foreach(string s in subjectList)
            {
                if (pdfText.Contains(s))
                    count = count + 1;
                else
                    unacquiredBasic.Add(s);
            }
            if (unacquiredBasic.Count >= 3)
                unacquiredBasic.Add("중 최소 " + (unacquiredBasic.Count - 2).ToString()
                                + "과목을 수강 하십시오.");
            basicGrade = (count * 3).ToString();
        }
    }
}
