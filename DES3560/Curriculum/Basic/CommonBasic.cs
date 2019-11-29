﻿using System.Collections.Generic;
using DES3560.Course;

namespace DES3560.Curriculum.Basic
{
    public class CommonBasic
    {
        public List<Subject> subjectList;
        public List<string> unacquiredList;
        public int basicGrade;

        public CommonBasic()
        {
            basicGrade = 0;
            subjectList = new List<Subject>();
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
            subjectList.Add(new Subject
            {
                subjectID = "EGC7026",
                subjectName = "기술창조와특허",
                subjectGrade = 3,
            });
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
            basicGrade = 15 - (subjectList.Count * 3);
            if (unacquiredList.Count > 2)
                unacquiredList.Add("중 최소 " + (unacquiredList.Count - 2).ToString() + "과목을 수강 하십시오.");
        }
    }
}