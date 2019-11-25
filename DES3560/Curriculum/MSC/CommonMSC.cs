using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DES3560.Subject;

namespace DES3560.Curriculum.MSC
{
    public class CommonMSC
    {
        public string pdfText;
        public int curriculumYear;
        public List<KeyValuePair<string, int>> subjectMath;
        public List<KeyValuePair<string, int>> subjectScience;
        public List<string> unacquiredList;
        public int scienceGrade;
        public int mathGrade;

        public CommonMSC(string text, int year)
        {
            pdfText = text;
            curriculumYear = year;
            scienceGrade = 0;
            mathGrade = 0;

            subjectMath = new List<KeyValuePair<string, int>>();
            subjectScience = new List<KeyValuePair<string, int>>();
            unacquiredList = new List<string>();

            subjectMath.Add(new KeyValuePair<string, int>("미적분학및연습1", 3));
            subjectMath.Add(new KeyValuePair<string, int>("미적분학및연습2", 3));
            subjectMath.Add(new KeyValuePair<string, int>("확률및통계학", 3));
            subjectMath.Add(new KeyValuePair<string, int>("공학선형대수학", 3));
            subjectMath.Add(new KeyValuePair<string, int>("공학수학1", 3));
            subjectMath.Add(new KeyValuePair<string, int>("공학수학2", 3));
            subjectMath.Add(new KeyValuePair<string, int>("이산수학", 3));
            subjectMath.Add(new KeyValuePair<string, int>("수치해석및실습", 3));

            subjectScience.Add(new KeyValuePair<string, int>("일반물리학및실험1", 4));
            subjectScience.Add(new KeyValuePair<string, int>("일반물리학및실험2", 4));
            subjectScience.Add(new KeyValuePair<string, int>("일반화학및실험1", 4));
            subjectScience.Add(new KeyValuePair<string, int>("일반화학및실험2", 4));
            subjectScience.Add(new KeyValuePair<string, int>("일반생물학및실험1", 3));
            subjectScience.Add(new KeyValuePair<string, int>("일반생물학및실험2", 3));
            subjectScience.Add(new KeyValuePair<string, int>("생물학개론", 3));
            subjectScience.Add(new KeyValuePair<string, int>("물리학개론", 3));
            subjectScience.Add(new KeyValuePair<string, int>("화학개론", 3));
            subjectScience.Add(new KeyValuePair<string, int>("지구환경과학", 3));

            checkMSC();
        }
        private void checkMSC()
        {
            switch (curriculumYear)
            {
                case 2014:
                case 2015:
                case 2016:
                    check2014Math();
                    checkScience();
                    addMathGrade();
                    if (mathGrade + scienceGrade < 28)
                        unacquiredList.Add("MSC학점이 28학점 이상이어야 합니다.");
                    break;
                case 2017:
                    check2017Math();
                    checkScience();
                    addMathGrade();
                    if (mathGrade + scienceGrade < 21)
                        unacquiredList.Add("MSC학점이 21학점 이상이어야 합니다.");
                    break;
                default:
                    break;
            }
        }
        private void check2014Math()
        {
            if (!pdfText.Contains("이산수학"))
                unacquiredList.Add("이산수학");
            if (!pdfText.Contains("미적분학및연습1"))
                unacquiredList.Add("미적분학및연습1");
            if (!pdfText.Contains("확률및통계학"))
                unacquiredList.Add("확률및통계학");
        }
        private void check2017Math()
        {
            if (!pdfText.Contains("공학선형대수학"))
                unacquiredList.Add("공학선형대수학");
            if (!pdfText.Contains("미적분학및연습1"))
                unacquiredList.Add("미적분학및연습1");
            if (!pdfText.Contains("확률및통계학"))
                unacquiredList.Add("확률및통계학");
        }
        private void checkScience()
        {
            foreach (KeyValuePair<string, int> keyPair in subjectScience)
            {
                if (pdfText.Contains(keyPair.Key))
                    scienceGrade = scienceGrade + keyPair.Value;
            }
            if (scienceGrade < 6)
                unacquiredList.Add("실험 과목을 6학점 이상 수강하십시오.");
        }
        private void addMathGrade()
        {
            foreach (KeyValuePair<string, int> keyPair in subjectMath)
            {
                if (pdfText.Contains(keyPair.Key))
                    mathGrade = mathGrade + keyPair.Value;
            }
            if (mathGrade < 12)
                unacquiredList.Add("수학 과목을 12학점 이상 수강하십시오.");
        }
    }
}
