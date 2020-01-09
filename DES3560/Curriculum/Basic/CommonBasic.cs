using System.Collections.Generic;

namespace DES3560.Curriculum.Basic
{
    public class CommonBasic
    {
        public List<Subject> subjectList;
        public List<Subject> changeList;
        public List<string> unacquiredList;
        public int basicGrade;

        public CommonBasic()
        {
            basicGrade = 0;
            subjectList = new List<Subject>();
            changeList = new List<Subject>();
            unacquiredList = new List<string>();

            subjectList.Add(new Subject
            {
                subjectID = "PRI4040",
                subjectName = "기술과사회",
                subjectGrade = 3,
            });
            subjectList.Add(new Subject
            {
                subjectID = "PRI4041",
                subjectName = "공학경제",
                subjectGrade = 3,
            });
            subjectList.Add(new Subject
            {
                subjectID = "PRI4043",
                subjectName = "공학법제",
                subjectGrade = 3,
            });
            subjectList.Add(new Subject
            {
                subjectID = "PRI4048",
                subjectName = "지속가능한발전과인간",
                subjectGrade = 3,
            });

            changeList.Add(new Subject
            {
                subjectID = "DEV1042",
                subjectName = "기술창조와특허",
                subjectGrade = 3,
            });
            changeList.Add(new Subject
            {
                subjectID = "EGC7026",
                subjectName = "기술창조와특허",
                subjectGrade = 3,
            });
        }
        private void checkDEV(List<Subject> list)
        {
            foreach (Subject s1 in changeList)
            {
                foreach (Subject s2 in list)
                {
                    if (s1.compare(s2))
                    {
                        basicGrade = basicGrade + s1.subjectGrade;
                        return;
                    }
                }
            }
            unacquiredList.Add("기술창조와특허");
        }
        public void checkBasic(List<Subject> list)
        {
            int index = 0;
            while (index < subjectList.Count)
            {
                int i = 0;
                for (; i < list.Count; i++)
                {
                    if (list[i].compare(subjectList[index]))
                    {
                        basicGrade = basicGrade + subjectList[index].subjectGrade;
                        subjectList.RemoveAt(index);
                        break;
                    }
                }
                if (i.Equals(list.Count))
                {
                    unacquiredList.Add(subjectList[index].subjectName);
                    index = index + 1;
                }
            }
            if (basicGrade <= 6)
                checkDEV(list);
            if (unacquiredList.Count > 2)
                unacquiredList.Add("중 최소 " + (unacquiredList.Count - 2).ToString() + "과목을 수강 하십시오.");
            else
                unacquiredList.Clear();
        }
    }
}