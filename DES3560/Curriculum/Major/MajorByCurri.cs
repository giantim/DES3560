using System.Collections.Generic;
using System.Linq;

namespace DES3560.Curriculum.Major
{
    public class MajorByCurri
    {
        public int curriYear;
        public List<Subject> commonMajorList;
        public List<Subject> cse2016List;
        public List<Subject> cse4074List;
        public List<string> unacquiredList;
        public int desCount;
        public int allGrade;
        public int designGrade;
        public int advancedGrade;

        public MajorByCurri(int year)
        {
            curriYear = year;
            commonMajorList = new List<Subject>();
            cse2016List = new List<Subject>();
            cse4074List = new List<Subject>();
            unacquiredList = new List<string>();
            allGrade = 0;
            designGrade = 0;
            advancedGrade = 0;

            addSubject(curriYear);
        }
        private void addCommonMajor()
        {
            commonMajorList.Add(new Subject
            {
                subjectID = "CSE4066",
                subjectName = "컴퓨터공학종합설계1",
                subjectGrade = 3,
                subjectCategory = "전문",
            });
            commonMajorList.Add(new Subject
            {
                subjectID = "CSE4067",
                subjectName = "컴퓨터공학종합설계2",
                subjectGrade = 3,
                subjectCategory = "전문",
            });
            commonMajorList.Add(new Subject
            {
                subjectID = "CSE2017",
                subjectName = "자료구조와실습",
                subjectGrade = 3,
                subjectCategory = "기초",
            });
            commonMajorList.Add(new Subject
            {
                subjectID = "CSE2013",
                subjectName = "시스템소프트웨어와실습",
                subjectGrade = 3,
                subjectCategory = "기초",
            });
            commonMajorList.Add(new Subject
            {
                subjectID = "CSE2018",
                subjectName = "컴퓨터구성",
                subjectGrade = 3,
                subjectCategory = "기초",
            });
            if (curriYear >= 2017)
            {
                commonMajorList.Add(new Subject
                {
                    subjectID = "CSE2025",
                    subjectName = "계산적사고법",
                    subjectGrade = 3,
                    subjectCategory = "기초",
                });
                commonMajorList.Add(new Subject
                {
                    subjectID = "CSE2026",
                    subjectName = "이산구조",
                    subjectGrade = 3,
                    subjectCategory = "기초",
                });
            }
        }
        private void addCSE2016()
        {
            cse2016List.Add(new Subject
            {
                subjectID = "CIC2001",
                subjectName = "창의적공학설계",
                subjectGrade = 3,
                subjectCategory = "기초",
            });
            cse2016List.Add(new Subject
            {
                subjectID = "CSE2016",
                subjectName = "창의적공학설계",
                subjectGrade = 3,
                subjectCategory = "기초",
            });
        }
        private void addCSE4074()
        {
            cse4074List.Add(new Subject
            {
                subjectID = "CSE2020",
                subjectName = "주니어디자인프로젝트",
                subjectGrade = 3,
                subjectCategory = "전문",
            });
            cse4074List.Add(new Subject
            {
                subjectID = "CSE4074",
                subjectName = "공개SW프로젝트",
                subjectGrade = 3,
                subjectCategory = "전문",
            });
        }
        private void addSubject(int year)
        {
            addCommonMajor();
            addCSE2016();
            addCSE4074();
        }
        public void checkMajor(List<Subject> cseList, List<Subject> desList)
        {
            checkCommonMajor(cseList);
            checkCSE2016(cseList);
            checkCSE4074(cseList);
            desCount = checkDES(desList);
            sumGrade(cseList, desList);
        }
        private void checkCommonMajor(List<Subject> list)
        {
            foreach (Subject s1 in commonMajorList)
            {
                bool check = false;
                foreach (Subject s2 in list)
                {
                    if (s1.compare(s2))
                    {
                        check = true;
                    }
                }
                if (!check)
                {
                    unacquiredList.Add(s1.subjectName);
                }
            }
        }
        private void checkCSE2016(List<Subject> list)
        {
            int count = 0;
            foreach (Subject s1 in cse2016List)
            {
                foreach (Subject s2 in list)
                {
                    if (s1.compare(s2))
                    {
                        count = count + 1;
                        designGrade = designGrade + 3;
                    }
                }
            }
            if (count == 0)
            {
                unacquiredList.Add("창의적공학설계");
            }
        }
        private void checkCSE4074(List<Subject> list)
        {
            int count = 0;
            foreach (Subject s1 in cse4074List)
            {
                foreach (Subject s2 in list)
                {
                    if (s1.compare(s2))
                    {
                        count = count + 1;
                        designGrade = designGrade + 3;
                    }
                }
            }
            if (count == 0)
            {
                unacquiredList.Add("공개SW프로젝트");
            }
        }
        private int checkDES(List<Subject> list)
        {
            int count = 0;
            foreach (Subject s in list)
            {
                if (s.subjectName.Contains("개별연구"))
                {
                    count = count + 1;
                }
            }
            if (count < 2)
            {
                unacquiredList.Add("개별연구를 " + (2 - count).ToString() + "과목 더 수강해야합니다.");
            }
            return count;
        }
        private void sumGrade(List<Subject> cseList, List<Subject> desList)
        {
            sumMajor(cseList);
            sumDES(desList);
        }
        private void sumMajor(List<Subject> cseList)
        {
            foreach (Subject s in cseList)
            {
                allGrade = allGrade + s.subjectGrade;
                if (s.subjectID.Equals("CSE4066") || s.subjectID.Equals("CSE4067"))
                {
                    designGrade = designGrade + s.subjectGrade;
                }
                if (s.subjectCategory.Equals("전문"))
                {
                    advancedGrade = advancedGrade + s.subjectGrade;
                }
            }
        }
        private void sumDES(List<Subject> desList)
        {
            foreach (Subject s in desList)
            {
                allGrade = allGrade + s.subjectGrade;
                if (s.subjectCategory.Equals("전문"))
                {
                    advancedGrade = advancedGrade + s.subjectGrade;
                }
            }
        }
    }
}
