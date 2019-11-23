using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DES3560.Subject;

namespace DES3560.Curriculum._2014
{
    public class Major2014
    {
        public string pdfText;
        public string submajor;
        public List<string> subjectList;
        public List<string> unacquiredMajor;
        public int allGrade;
        public int designGrade;
        public int specialGrade;

        public Major2014(string text, string major)
        {
            pdfText = text;
            submajor = major;
            allGrade = 0;
            designGrade = 0;
            specialGrade = 0;

            subjectList = new List<string>();
            unacquiredMajor = new List<string>();

            subjectList.Add(subjectMajor.CSE2016);
            subjectList.Add(subjectMajor.CSE4074);
            subjectList.Add(subjectMajor.CSE4066);
            subjectList.Add(subjectMajor.CSE4067);
            subjectList.Add(subjectMajor.CSE2017);
            subjectList.Add(subjectMajor.CSE2018);
            subjectList.Add(subjectMajor.CSE2013);

            checkMajor();
        }
        private void checkMajor()
        {
            extractGrade();
            checkDesignSubject();
            checkAllMajor();
        }
        private void extractGrade()
        {
            if (submajor == "")
            {
                allGrade = Int32.Parse(pdfText.Substring(pdfText.IndexOf("제1전공: 총") + 7, 2));
                specialGrade = Int32.Parse(pdfText.Substring(pdfText.IndexOf("제1전공: 총") + 24, 2));
            }
            else
            {
                allGrade = Int32.Parse(pdfText.Substring(pdfText.IndexOf("복수1: 총") + 6, 2));
                specialGrade = Int32.Parse(pdfText.Substring(pdfText.IndexOf("복수1: 총") + 23, 2));
            }
        }
        private void checkDesignSubject()
        {
            for (int i = 0; i < 4; i++)
            {
                if (pdfText.Contains(subjectList[i]))
                    designGrade = designGrade + 3;
            }
        }
        private void checkAllMajor()
        {
            foreach (string s in subjectList)
            {
                if (!pdfText.Contains(s))
                    unacquiredMajor.Add(s);
            }
            int count = 0;
            while (pdfText.Contains("개별연구"))
            {
                pdfText = pdfText.Substring(pdfText.IndexOf("개별연구") + 4);
                count = count + 1;
            }
            for (int i = 2; i > count; i--)
                unacquiredMajor.Add("개별연구");
        }
    }
}
