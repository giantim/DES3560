using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using DES3560.Curriculum.RGC;
using DES3560.Curriculum.Basic;
using DES3560.Curriculum.MSC;
using DES3560.Curriculum.Major;
using DES3560.Course;

namespace DES3560
{
    public partial class Form1 : Form
    {
        public string filePath;
        public string pdfText;
        public Student studentInfo;
        public CommonRGC myRGC;
        public CommonBasic myBasic;
        public CommonMSC myMSC;
        public MajorByCurri myMajor;
        public bool paperPass;
        public int allGrade;
        public float gpa;
        public int majorEng;
        public int subEngSum;

        #region Functions
        public Form1()
        {
            InitializeComponent();
            txtFileName.Enabled = false;
            turnOffTable();
        }
        private void turnOffTable()
        {
            tableStudentInfo.Visible = false;
            tableSubject.Visible = false;
            tableStandard.Visible = false;
        }
        private void turnOnTable()
        {
            tableStudentInfo.Visible = true;
            tableSubject.Visible = true;
            tableStandard.Visible = true;
        }
        private bool extractTextFromPdf()
        {
            try
            {
                using (PdfReader reader = new PdfReader(filePath))
                {
                    StringBuilder text = new StringBuilder();
                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                    }
                    pdfText = text.ToString();
                    if (checkClassification())
                        return true;
                    else
                    {
                        MessageBox.Show("취득교과목 영역별 분류표를 선택해 주십시오.", "오류", MessageBoxButtons.OK);
                        txtFileName.Clear();
                        return false;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("선택된 파일이 없습니다.", "오류", MessageBoxButtons.OK);
                return false;
            }
        }
        private void initStudentInfo()
        {
            studentInfo = new Student
            {
                curriculumYear = Int32.Parse(pdfText.Substring(pdfText.IndexOf("교육과정 적용년도: ") + 11, 4)),
                studentClass = pdfText.Substring(pdfText.IndexOf(" 학번: ") - 3, 3),
                studentId = pdfText.Substring(pdfText.IndexOf("학번: ") + 4, 10),
                name = extractName(),
                major = extractMajor(),
                submajor = extractSubmajor() == "" ? false : true,
                rgcList = parseRGC(),
                priList = parsePRI(),
                cseList = parseCSE(),
                desList = parseDES(),
            };
        }
        private string extractName()
        {
            string nameString = pdfText.Substring(pdfText.IndexOf("성명: ") + 4);
            int index = 0;
            foreach (char c in nameString)
            {
                if (!c.Equals(' '))
                    index = index + 1;
                else
                    break;
            }
            return nameString.Substring(0, index);
        }
        private string extractMajor()
        {
            string majorString = pdfText.Substring(pdfText.IndexOf("학과 : ") + 5);
            int index = 0;
            foreach (char c in majorString)
            {
                if (!c.Equals(' '))
                    index = index + 1;
                else break;
            }
            return majorString.Substring(0, index);
        }
        private string extractSubmajor()
        {
            string submajorString = pdfText.Substring(pdfText.IndexOf("복수1: ") + 5);
            if (submajorString.Substring(0, 7) == "컴퓨터공학전공")
                return "컴퓨터공학전공";
            return String.Empty;
        }
        private bool checkClassification()
        {
            if (pdfText.Substring(0, 13).Equals("취득교과목 영역별 분류표"))
                return true;
            return false;
        }
        private bool checkMajor()
        {
            if (studentInfo.major.Equals("컴퓨터공학전공") || studentInfo.submajor.Equals(true))
                return true;
            return false;
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
                                    getSpaceIndex(rgcText.Substring(rgcText.IndexOf(subjectID) + subjectID.Length + 1), 0));
                int subjectGrade = Int32.Parse(rgcText.Substring(rgcText.IndexOf(subjectName) + subjectName.Length
                                    + jumpNonSpace(rgcText.Substring(rgcText.IndexOf(subjectName) + subjectName.Length), 0), 1));
                rgcList.Add(new Subject 
                {
                    subjectID = subjectID,
                    subjectName = subjectName,
                    subjectGrade = subjectGrade,
                    subjectCategory = "",
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
                                    getSpaceIndex(priText.Substring(priText.IndexOf(subjectID) + subjectID.Length + 1), 0));
                int subjectGrade = Int32.Parse(priText.Substring(priText.IndexOf(subjectName) + subjectName.Length
                                    + jumpNonSpace(priText.Substring(priText.IndexOf(subjectName) + subjectName.Length), 0), 1));
                priList.Add(new Subject 
                {
                    subjectID = subjectID,
                    subjectName = subjectName,
                    subjectGrade = subjectGrade,
                    subjectCategory = "",
                });
                temp = temp.Substring(temp.IndexOf(subjectName));
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
                                    getSpaceIndex(cseText.Substring(cseText.IndexOf(subjectID) + subjectID.Length + 1), 0));
                int subjectGrade = Int32.Parse(cseText.Substring(cseText.IndexOf(subjectName) + subjectName.Length
                                    + jumpNonSpace(cseText.Substring(cseText.IndexOf(subjectName) + subjectName.Length), 0), 1));
                string categoryText = cseText.Substring(cseText.IndexOf(subjectName) + subjectName.Length
                                    + jumpNonSpace(cseText.Substring(cseText.IndexOf(subjectName) + subjectName.Length), 0) + 1);
                string subjectCategory = categoryText.Substring(jumpNonSpace(categoryText, 0), 2);
                if (!subjectCategory.Equals("기초") && !subjectCategory.Equals("전문"))
                    subjectCategory = categoryText.Substring(jumpNonSpace(categoryText, 0) + 3, 2); 
                cseList.Add(new Subject 
                {
                    subjectID = subjectID,
                    subjectName = subjectName,
                    subjectGrade = subjectGrade,
                    subjectCategory = subjectCategory,
                });
                temp = temp.Substring(temp.IndexOf(subjectName));
            }
            if (temp.Contains("CIC4003"))
            {
                cseList.Add(new Subject
                {
                    subjectID = "CIC4003",
                    subjectName = "인턴쉽",
                    subjectGrade = 3,
                    subjectCategory = "전문",
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
                                    getSpaceIndex(desText.Substring(desText.IndexOf(subjectID) + subjectID.Length + 1), 0));
                int subjectGrade = 1;
                desList.Add(new Subject 
                {
                    subjectID = subjectID,
                    subjectName = subjectName,
                    subjectGrade = subjectGrade,
                    subjectCategory = "전문",
                });
                temp = temp.Substring(temp.IndexOf(subjectName));
            }
            return desList;
        }
        private int getSpaceIndex(string text, int index)
        {
            int i = 0;
            while (!text[index + i].Equals(' '))
                i = i + 1;
            return index + i;
        }
        private int jumpNonSpace(string text, int index)
        {
            int i = 0;
            while (text[index + i].Equals(' '))
                i = i + 1;
            return index + i;
        }
        private void analysis()
        {
            analysisStudentInfo();
            analysisRGC();
            analysisBasic();
            analysisMSC();
            analysisMajor();
        }
        private void analysisStudentInfo()
        {
            lblMyName.Text = studentInfo.name;
            lblMyStudentId.Text = studentInfo.studentId;
            lblMyClass.Text = studentInfo.studentClass;
            lblMySubMajor.Text = studentInfo.submajor == false ? "x" : "o";
        }
        private void analysisBasic()
        {
            myBasic = new CommonBasic();
            myBasic.checkBasic(studentInfo.priList);
            lblMyBasic.Text = myBasic.basicGrade.ToString() + " / 9";
            txtBasic.Text = String.Join(Environment.NewLine, myBasic.unacquiredList);
        }
        private void analysisRGC()
        {
            myRGC = new CommonRGC(studentInfo.rgcList);
            lblMyRGC.Text = myRGC.RGCGrade.ToString() + " / 16";
        }
        private void analysisMSC()
        {
            myMSC = new CommonMSC(studentInfo.curriculumYear);
            myMSC.checkMSC(studentInfo.priList);
            if (studentInfo.curriculumYear < 2017)
            {
                lblMyMath.Text = myMSC.mathGrade.ToString();
                lblMyScience.Text = myMSC.scienceGrade.ToString();
            }
            else
            {
                lblMyMath.Text = myMSC.mathGrade.ToString() + " / 12";
                lblMyScience.Text = myMSC.scienceGrade.ToString() + " / 6";
            }
            txtMSC.Text = String.Join(Environment.NewLine, myMSC.unacquiredList);
        }
        private void analysisMajor()
        {
            paperPass = false;
            myMajor = new MajorByCurri(studentInfo.curriculumYear);
            myMajor.checkMajor(studentInfo.cseList, studentInfo.desList);
            if (studentInfo.submajor.Equals(false))
            {
                lblMyMajorSum.Text = myMajor.allGrade.ToString() + " / 84";
                lblMySpecial.Text = myMajor.specialGrade.ToString() + " / 52";
            }
            else
            {
                lblMyMajorSum.Text = myMajor.allGrade.ToString() + " / 51";
                lblMySpecial.Text = myMajor.specialGrade.ToString() + " / 26";
            }
            lblMyDesign.Text = myMajor.designGrade.ToString() + " / 12";
            txtMajor.Text = String.Join(Environment.NewLine, myMajor.unacquiredList);
            analysisPaper(myMajor.unacquiredList);
        }
        private void analysisPaper(List<string> list)
        {
            paperPass = false;
            int count = 0;
            foreach (string s in list)
            {
                if (s.Equals("컴퓨터공학종합설계1") || s.Equals("컴퓨터공학종합설계2"))
                    count = count + 1;
            }
            if (count.Equals(0))
                paperPass = true;
        }
        private void analysisStandard()
        {
            allGrade = extractAllGrade();
            gpa = float.Parse(pdfText.Substring(pdfText.IndexOf("평점평균:") + 5, 4));
            majorEng = Int32.Parse(pdfText.Substring(pdfText.IndexOf("영어강의이수결과: ") + 14, 2));
            subEngSum = Int32.Parse(pdfText.Substring(pdfText.IndexOf("영어강의이수결과: ") + 29, 2));
            string toeic = pdfText.Substring(pdfText.IndexOf("영어패스제(토익 등): ") + 18, 4);
            lblMyMajorEng.Text = majorEng.ToString() + " / 2";
            lblMyTotalEng.Text = subEngSum.ToString() + " / 4";
            lblMyToeic.Text = toeic.Equals("FAIL") ? "x" : "o";
            lblMyPaper.Text = paperPass ? "o" : "x";
            lblMyAllGrade.Text = allGrade.ToString() + " / 140";
            lblMyGPA.Text = gpa.ToString();
            lblMyEngineering.Text = checkEngineering();
            lblMyGraduate.Text = checkGraduate();
        }
        private int extractAllGrade()
        {
            string gpaString = pdfText.Substring(pdfText.IndexOf("총취득학점:") + 6);
            int index = 0;
            foreach (char c in gpaString)
            {
                if (!c.Equals(' ') && c != 10)
                    index = index + 1;
                else
                    break;
            }
            return Int32.Parse(gpaString.Substring(0, index));
        }
        private string checkEngineering()
        {
            if (studentInfo.submajor == true)
            {
                if (myBasic.basicGrade >= 9 && myRGC.RGCGrade >= 16
                && myMSC.unacquiredList.Count == 0 && myMajor.unacquiredList.Count == 0
                && myMajor.allGrade >= 84 && myMajor.designGrade >= 12 && myMajor.specialGrade >= 42
                && allGrade >= 140 && gpa >= 2.0 && majorEng >= 2 && subEngSum >= 4
                && paperPass == true)
                    return "o";
                return "x";
            }
            else
            {
                if (myBasic.basicGrade >= 9 && myRGC.RGCGrade >= 16
                && myMSC.unacquiredList.Count == 0 && myMajor.unacquiredList.Count == 0
                && myMajor.allGrade >= 51 && myMajor.designGrade >= 12 && myMajor.specialGrade >= 26
                && allGrade >= 140 && gpa >= 2.0 && majorEng >= 2 && subEngSum >= 4
                && paperPass == true)
                    return "o";
                return "x";
            }
        }
        private string checkGraduate()
        {
            if (lblMyAllGrade.Text == "o" && lblMyToeic.Text == "o")
                return "o";
            return "x";
        }
        #endregion

        #region Events
        private void btnDialog_Click(object sender, EventArgs e)
        {
            txtFileName.Clear();
            fileDialog.InitialDirectory = "c:\\users\\" + Environment.UserName.ToString() + "\\desktop";
            fileDialog.Filter = "Pdf Files|*.pdf";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fileDialog.FileName;
                txtFileName.Text = filePath.Split('\\')[filePath.Split('\\').Length - 1];
            }
        }
        private void btnExecution_Click(object sender, EventArgs e)
        {
            if (extractTextFromPdf())
            {
                initStudentInfo();
                if (checkMajor())
                {
                    turnOnTable();
                    analysis();
                }
                else
                {
                    turnOffTable();
                    MessageBox.Show("컴퓨터공학을 전공하고 있지 않은 학생입니다.", "오류", MessageBoxButtons.OK);
                }
            }
        }
        #endregion
    }
}
