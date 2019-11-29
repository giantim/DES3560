using DES3560.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DES3560.Curriculum.Major
{
    public class MajorByCurri
    {
        public int curriYear;
        public List<Subject> subjectList;
        public List<string> unacquiredList;
        public int allGrade;
        public int designGrade;
        public int specialGrade;

        public MajorByCurri(int year)
        {
            curriYear = year < 2017 ? 2014 : 2017;
            subjectList = new List<Subject>();
            unacquiredList = new List<string>();
            allGrade = 0;
            designGrade = 0;
            specialGrade = 0;

            addSubject(curriYear);
        }
        private void addSubject(int year)
        {
            subjectList.Add(new Subject
            {
                subjectID = "CSE2016",
                subjectName = "창의적공학설계",
                subjectGrade = 3,
                subjectCategory = "기초",
            });
            subjectList.Add(new Subject
            {
                subjectID = "CSE4074",
                subjectName = "공개SW프로젝트",
                subjectGrade = 3,
                subjectCategory = "전문",
            });
            subjectList.Add(new Subject
            {
                subjectID = "CSE4066",
                subjectName = "컴퓨터공학종합설계1",
                subjectGrade = 3,
                subjectCategory = "전문",
            });
            subjectList.Add(new Subject
            {
                subjectID = "CSE4067",
                subjectName = "컴퓨터공학종합설계2",
                subjectGrade = 3,
                subjectCategory = "전문",
            });
            subjectList.Add(new Subject
            {
                subjectID = "CSE2017",
                subjectName = "자료구조와실습",
                subjectGrade = 3,
                subjectCategory = "기초",
            });
            subjectList.Add(new Subject
            {
                subjectID = "CSE2013",
                subjectName = "시스템소프트웨어와실습",
                subjectGrade = 3,
                subjectCategory = "기초",
            });
            subjectList.Add(new Subject
            {
                subjectID = "CSE2018",
                subjectName = "컴퓨터구성",
                subjectGrade = 3,
                subjectCategory = "기초",
            });
            if (year == 2017)
            {
                subjectList.Add(new Subject
                {
                    subjectID = "CSE2025",
                    subjectName = "계산적사고법",
                    subjectGrade = 3,
                    subjectCategory = "기초",
                });
                subjectList.Add(new Subject
                {
                    subjectID = "CSE2026",
                    subjectName = "이산구조",
                    subjectGrade = 3,
                    subjectCategory = "기초",
                });
            }
        }
        public void checkMajor(List<Subject> cseList, List<Subject> desList)
        {
            checkCSE(cseList);
            checkDES(desList);
            sumGrade(cseList, desList);
        }
        private void checkCSE(List<Subject> list)
        {
            int index = 0;
            while (index < subjectList.Count)
            {
                int i = 0;
                Subject s1 = subjectList[index];
                for (; i < list.Count; i++)
                {
                    if (s1.compare(list[i]))
                    {
                        subjectList.RemoveAt(index);
                        break;
                    }
                }
                if (i.Equals(list.Count))
                {
                    unacquiredList.Add(s1.subjectName);
                    index = index + 1;
                }
            }
        }
        private void checkDES(List<Subject> list)
        {
            for (int i = 2; i > list.Count; i--)
                unacquiredList.Add("개별연구" + i.ToString());
        }
        private void sumGrade(List<Subject> cseList, List<Subject> desList)
        {
            foreach (Subject s in cseList)
            {
                allGrade = allGrade + s.subjectGrade;
                if (s.subjectID.Equals("CSE2016") || s.subjectID.Equals("CSE4074")
                    || s.subjectID.Equals("CSE4066") || s.subjectID.Equals("CSE4067"))
                    designGrade = designGrade + s.subjectGrade;
                if (s.subjectCategory.Equals("전문"))
                    specialGrade = specialGrade + s.subjectGrade;
            }
            foreach (Subject s in desList)
            {
                allGrade = allGrade + s.subjectGrade;
                specialGrade = specialGrade + s.subjectGrade;
            }
        }
    }
}
