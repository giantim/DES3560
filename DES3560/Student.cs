using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DES3560
{
    public class Student
    {
        public string pdfText;

        public int curriculumYear; // 교육과정 적용년도
        public string studentClass; // 학년
        public string studentId; // 학번
        public string name;
        public string major; // 학과
        public string minor; // 부전공
        public string submajor; // 복수전공
        public bool isEngineering; // 공학인증 심화대상

        public string formalUniv; // 전적대
        public string prevMajor; // 전과(학과)
        public string campusTransfer; // 캠퍼스 전입여부

        public List<Subject> rgcList;
        public List<Subject> priList;
        public List<Subject> cseList;
        public List<Subject> desList;

        public string allGrade;
        public string gpa;
        public string teaching;
        public string majorEng;
        public string otherEng;
        public string isEng;
        public string eng;
        public string isToeic;
        public string toeic;

        public bool rgcPass;
        public bool basicPass;
        public bool mscPass;
        public bool majorPass;
        public bool allGradePass;
        public bool gpaPass;
        public bool engResultPass;
        public bool engPass;
        public bool toeicPass;
        public bool paper;
        public bool engineeringPass;
        public bool graduationPass;

        public void initStudentInfo()
        {
            curriculumYear = Convert.ToInt32(pdfText.Substring(pdfText.IndexOf("교육과정 적용년도: ") + 11, 4));
            studentClass = pdfText.Substring(pdfText.IndexOf(" 학번: ") - 3, 3);
            studentId = pdfText.Substring(pdfText.IndexOf("학번: ") + 4, 10);
            name = extractName();
            major = extractMajor();
            minor = extractMinor();
            submajor = extractSubmajor();
            isEngineering = parseEngineering();

            formalUniv = extractFormalUniv();
            prevMajor = extractPrevMajor();
            campusTransfer = extractCampusTransfer();

            rgcList = parseRGC();
            priList = parsePRI();
            cseList = parseCSE();
            desList = parseDES();
        }
        private string extractName()
        {
            string nameString = pdfText.Substring(pdfText.IndexOf("성명: ") + 4);
            return nameString.Substring(0, CommonFunctions.getSpaceIndex(nameString, 0));
        }
        private string extractMajor()
        {
            string majorString = pdfText.Substring(pdfText.IndexOf("학과 : ") + 5);
            return majorString.Substring(0, CommonFunctions.getSpaceIndex(majorString, 0));
        }
        private string extractMinor()
        {
            string minorString = pdfText.Substring(pdfText.IndexOf("부전공1: ") + 6);
            if (minorString.Substring(0, 4) == "부전공2")
                return String.Empty;
            return minorString.Substring(0, CommonFunctions.getSpaceIndex(minorString, 0));
        }
        private string extractSubmajor()
        {
            string submajorString = pdfText.Substring(pdfText.IndexOf("복수1: ") + 5);
            if (submajorString.Substring(0, 3) == "복수2")
                return String.Empty;
            return submajorString.Substring(0, CommonFunctions.getSpaceIndex(submajorString, 0));
        }
        private string extractFormalUniv()
        {
            string formalUnivString = pdfText.Substring(pdfText.IndexOf("전적대:") + 4);
            return formalUnivString.Substring(0, CommonFunctions.getSpaceIndex(formalUnivString, 0));
        }
        private string extractPrevMajor()
        {
            string prevMajorString = pdfText.Substring(pdfText.IndexOf("전과(학과):") + 7);
            if (prevMajorString.Substring(0, 1).Equals("\n"))
                return String.Empty;
            return prevMajorString.Substring(0, CommonFunctions.getNewLineIndex(prevMajorString, 0));
        }
        private string extractCampusTransfer()
        {
            string campusTransferString = pdfText.Substring(pdfText.IndexOf("캠퍼스전입여부:") + 8);
            if (campusTransferString.Substring(0, 1).Equals("N"))
                return "N";
            return campusTransferString.Substring(0, 4);
        }
        private List<Subject> parseRGC()
        {
            List<Subject> rgcList = new List<Subject>();
            string temp = pdfText;
            while (temp.Contains("RGC"))
            {
                string rgcText = temp.Substring(temp.IndexOf("RGC"));
                string subjectID = rgcText.Substring(0, 7);
                string subjectName = rgcText.Substring(rgcText.IndexOf(subjectID) + subjectID.Length + 1,
                                    CommonFunctions.getSpaceIndex(rgcText.Substring(rgcText.IndexOf(subjectID) + subjectID.Length + 1), 0));
                int subjectGrade = Convert.ToInt32(rgcText.Substring(rgcText.IndexOf(subjectName) + subjectName.Length
                                    + CommonFunctions.jumpNonSpace(rgcText.Substring(rgcText.IndexOf(subjectName) + subjectName.Length), 0), 1));
                rgcList.Add(new Subject
                {
                    subjectID = subjectID,
                    subjectName = subjectName,
                    subjectGrade = subjectGrade,
                    subjectCategory = String.Empty,
                });
                temp = temp.Substring(temp.IndexOf(subjectName));
            }
            return rgcList;
        }
        private List<Subject> parsePRI()
        {
            List<Subject> priList = new List<Subject>();
            string temp = pdfText;
            while (temp.Contains("PRI"))
            {
                string priText = temp.Substring(temp.IndexOf("PRI"));
                string subjectID = priText.Substring(0, 7);
                string subjectName = priText.Substring(priText.IndexOf(subjectID) + subjectID.Length + 1,
                                    CommonFunctions.getSpaceIndex(priText.Substring(priText.IndexOf(subjectID) + subjectID.Length + 1), 0));
                int subjectGrade = Convert.ToInt32(priText.Substring(priText.IndexOf(subjectName) + subjectName.Length
                                    + CommonFunctions.jumpNonSpace(priText.Substring(priText.IndexOf(subjectName) + subjectName.Length), 0), 1));
                priList.Add(new Subject
                {
                    subjectID = subjectID,
                    subjectName = subjectName,
                    subjectGrade = subjectGrade,
                    subjectCategory = String.Empty,
                });
                temp = temp.Substring(temp.IndexOf(subjectName));
            }
            if (pdfText.Contains("DEV1042") || pdfText.Contains("EGC7026"))
            {
                string subjectID = pdfText.Contains("DEV1042") ? "DEV1042" : "EGC7026";
                priList.Add(new Subject
                {
                    subjectID = subjectID,
                    subjectName = "기술창조와특허",
                    subjectGrade = 3,
                    subjectCategory = String.Empty,
                });
            }
            return priList;
        }
        private List<Subject> parseCSE()
        {
            List<Subject> cseList = new List<Subject>();
            string temp = pdfText;
            while (temp.Contains("CSE"))
            {
                string cseText = temp.Substring(temp.IndexOf("CSE"));
                string subjectID = cseText.Substring(0, 7);
                string subjectName = cseText.Substring(cseText.IndexOf(subjectID) + subjectID.Length + 1,
                                    CommonFunctions.getSpaceIndex(cseText.Substring(cseText.IndexOf(subjectID) + subjectID.Length + 1), 0));
                int subjectGrade = Convert.ToInt32(cseText.Substring(cseText.IndexOf(subjectName) + subjectName.Length
                                    + CommonFunctions.jumpNonSpace(cseText.Substring(cseText.IndexOf(subjectName) + subjectName.Length), 0), 1));
                string categoryText = cseText.Substring(cseText.IndexOf(subjectName) + subjectName.Length
                                    + CommonFunctions.jumpNonSpace(cseText.Substring(cseText.IndexOf(subjectName) + subjectName.Length), 0) + 1);
                string subjectCategory = categoryText.Substring(CommonFunctions.jumpNonSpace(categoryText, 0), 2);
                if (!subjectCategory.Equals("기초") && !subjectCategory.Equals("전문"))
                    subjectCategory = categoryText.Substring(CommonFunctions.jumpNonSpace(categoryText, 0) + 3, 2);
                cseList.Add(new Subject
                {
                    subjectID = subjectID,
                    subjectName = subjectName,
                    subjectGrade = subjectGrade,
                    subjectCategory = subjectCategory,
                });
                temp = temp.Substring(temp.IndexOf(subjectID) + 8);
            }
            if (pdfText.Contains("CIC4003"))
            {
                cseList.Add(new Subject
                {
                    subjectID = "CIC4003",
                    subjectName = "인턴쉽",
                    subjectGrade = 3,
                    subjectCategory = "전문",
                });
            }
            if (pdfText.Contains("CIC2001"))
            {
                cseList.Add(new Subject
                {
                    subjectID = "CIC2001",
                    subjectName = "창의적공학설계",
                    subjectGrade = 3,
                    subjectCategory = "기초",
                });
            }
            return cseList;
        }
        private List<Subject> parseDES()
        {
            List<Subject> desList = new List<Subject>();
            string temp = pdfText;
            while (temp.Contains("DES"))
            {
                string desText = temp.Substring(temp.IndexOf("DES"));
                string subjectID = desText.Substring(0, 7);
                string subjectName = desText.Substring(desText.IndexOf(subjectID) + subjectID.Length + 1,
                                    CommonFunctions.getSpaceIndex(desText.Substring(desText.IndexOf(subjectID) + subjectID.Length + 1), 0));
                int subjectGrade;
                string subjectCategory;
                if (subjectName.Contains("개별연구"))
                {
                    subjectGrade = 1;
                    subjectCategory = "전문";
                }
                else
                {
                    subjectGrade = Convert.ToInt32(desText.Substring(desText.IndexOf(subjectName) + subjectName.Length
                                    + CommonFunctions.jumpNonSpace(desText.Substring(desText.IndexOf(subjectName) + subjectName.Length), 0), 1)); ;
                    string categoryText = desText.Substring(desText.IndexOf(subjectName) + subjectName.Length
                                    + CommonFunctions.jumpNonSpace(desText.Substring(desText.IndexOf(subjectName) + subjectName.Length), 0) + 1);
                    subjectCategory = categoryText.Substring(CommonFunctions.jumpNonSpace(categoryText, 0), 2);
                    if (!subjectCategory.Equals("기초") && !subjectCategory.Equals("전문"))
                        subjectCategory = categoryText.Substring(CommonFunctions.jumpNonSpace(categoryText, 0) + 3, 2);
                }
                desList.Add(new Subject
                {
                    subjectID = subjectID,
                    subjectName = subjectName,
                    subjectGrade = subjectGrade,
                    subjectCategory = subjectCategory,
                });
                temp = temp.Substring(temp.IndexOf(subjectName));
            }
            return desList;
        }
        private bool parseEngineering()
        {
            string engineeringString = pdfText.Substring(pdfText.IndexOf("공학인증심화대상:") + 9, 1);
            return engineeringString == "Y" ? true : false;
        }
    }
}
