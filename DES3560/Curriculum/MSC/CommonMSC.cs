using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DES3560.Course;

namespace DES3560.Curriculum.MSC
{
    public class CommonMSC
    {
        public int curriculumYear;
        public List<Subject> subjectMathReq;
        public List<Subject> subjectMath;
        public List<Subject> subjectScience;
        public List<string> unacquiredList;
        public int scienceGrade;
        public int mathGrade;

        public CommonMSC(int year)
        {
            curriculumYear = year;
            scienceGrade = 0;
            mathGrade = 0;

            subjectMathReq = new List<Subject>();
            subjectMath = new List<Subject>();
            subjectScience = new List<Subject>();
            unacquiredList = new List<string>();

            addSubjectMathReq();
            addSubjectMath();
            addSubjectScience();
        }
        private void addSubjectMathReq()
        {
            subjectMathReq.Add(new Subject
            {
                subjectID = "PRI4001",
                subjectName = "미적분학및연습1",
                subjectGrade = 3,
            });
            subjectMathReq.Add(new Subject
            {
                subjectID = "PRI4023",
                subjectName = "확률및통계학",
                subjectGrade = 3,
            });
            switch (curriculumYear)
            {
                case 2014:
                case 2015:
                case 2016:
                    subjectMathReq.Add(new Subject
                    {
                        subjectID = "PRI4027",
                        subjectName = "이산수학",
                        subjectGrade = 3,
                    });
                    break;
                default:
                    subjectMathReq.Add(new Subject
                    {
                        subjectID = "PRI4024",
                        subjectName = "공학선형대수학",
                        subjectGrade = 3,
                    });
                    break;
            }
        }
        private void addSubjectMath()
        {
            subjectMath.Add(new Subject
            {
                subjectID = "PRI4012",
                subjectName = "미적분학및연습2",
                subjectGrade = 3,
            });
            subjectMath.Add(new Subject
            {
                subjectID = "PRI4025",
                subjectName = "공학수학1",
                subjectGrade = 3,
            });
            subjectMath.Add(new Subject
            {
                subjectID = "PRI4026",
                subjectName = "공학수학2",
                subjectGrade = 3,
            });
            subjectMath.Add(new Subject
            {
                subjectID = "PRI4036",
                subjectName = "수치해석및실습",
                subjectGrade = 3,
            });
            switch (curriculumYear)
            {
                case 2014:
                case 2015:
                case 2016:
                    subjectMath.Add(new Subject
                    {
                        subjectID = "PRI4024",
                        subjectName = "공학선형대수학",
                        subjectGrade = 3,
                    });
                    break;
                default:
                    subjectMath.Add(new Subject
                    {
                        subjectID = "PRI4027",
                        subjectName = "이산수학",
                        subjectGrade = 3,
                    });
                    break;
            }
        }
        private void addSubjectScience()
        {
            subjectScience.Add(new Subject
            {
                subjectID = "PRI4002",
                subjectName = "일반물리학및실험1",
                subjectGrade = 4,
            });
            subjectScience.Add(new Subject
            {
                subjectID = "PRI4013",
                subjectName = "일반물리학및실험2",
                subjectGrade = 4,
            });
            subjectScience.Add(new Subject
            {
                subjectID = "PRI4003",
                subjectName = "일반화학및실험1",
                subjectGrade = 4,
            });
            subjectScience.Add(new Subject
            {
                subjectID = "PRI4014",
                subjectName = "일반화학및실험2",
                subjectGrade = 4,
            });
            subjectScience.Add(new Subject
            {
                subjectID = "PRI4004",
                subjectName = "일반생물학및실험1",
                subjectGrade = 3,
            });
            subjectScience.Add(new Subject
            {
                subjectID = "PRI4015",
                subjectName = "일반생물학및실험2",
                subjectGrade = 3,
            });
            subjectScience.Add(new Subject
            {
                subjectID = "PRI4028",
                subjectName = "생물학개론",
                subjectGrade = 3,
            });
            subjectScience.Add(new Subject
            {
                subjectID = "PRI4029",
                subjectName = "물리학개론",
                subjectGrade = 3,
            });
            subjectScience.Add(new Subject
            {
                subjectID = "PRI4030",
                subjectName = "화학개론",
                subjectGrade = 3,
            });
            subjectScience.Add(new Subject
            {
                subjectID = "PRI4033",
                subjectName = "지구환경과학",
                subjectGrade = 3,
            });
        }
        public void checkMSC(List<Subject> list)
        {
            checkReqMath(list);
            checkMath(list);
            checkScience(list);
            sumGrade();
        }
        private void sumGrade()
        {
            switch (curriculumYear)
            {
                case 2014:
                case 2015:
                case 2016:
                    if (mathGrade + scienceGrade < 28)
                        unacquiredList.Add("MSC를 최소 28학점 이상 수강하십시오.");
                    break;
                default:
                    if (mathGrade + scienceGrade < 21)
                        unacquiredList.Add("MSC를 최소 28학점 이상 수강하십시오.");
                    break;
            }
        }
        private void checkReqMath(List<Subject> list)
        {
            foreach (Subject s1 in subjectMathReq)
            {
                int index = 0;
                foreach (Subject s2 in list)
                {
                    if (s1.compare(s2))
                        break;
                    index = index + 1;
                }
                if (index.Equals(list.Count))
                    unacquiredList.Add(s1.subjectName);
            }
            mathGrade = mathGrade + (9 - (unacquiredList.Count * 3));
        }
        private void checkMath(List<Subject> list)
        {
            int index = 0;
            while (index < subjectMath.Count)
            {
                int i = 0;
                for (; i < list.Count; i++)
                {
                    if (list[i].compare(subjectMath[index]))
                    {
                        subjectMath.RemoveAt(index);
                        break;
                    }
                }
                if (i.Equals(list.Count))
                    index = index + 1;
            }
            mathGrade = mathGrade + (15 - (subjectMath.Count * 3));
        }
        private void checkScience(List<Subject> list)
        {
            foreach (Subject s1 in subjectScience)
            {
                foreach (Subject s2 in list)
                {
                    if (s1.compare(s2))
                    {
                        scienceGrade = scienceGrade + s1.subjectGrade;
                        break;
                    }
                }
            }
        }
    }
}
