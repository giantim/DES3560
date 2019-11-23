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
using DES3560.Curriculum._2014;
using DES3560.Subject;

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
        public Major2014 myMajor2014;
        public bool paperPass;

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
            string curriculumYear = pdfText.Substring(pdfText.IndexOf("교육과정 적용년도: ") + 11, 4);
            string studentClass = pdfText.Substring(pdfText.IndexOf(" 학번: ") - 3, 3);
            string studentId = pdfText.Substring(pdfText.IndexOf("학번: ") + 4, 10);
            string name = extractName();
            string major = extractMajor();
            string submajor = extractSubmajor();
            studentInfo = new Student
            {
                curriculumYear = curriculumYear,
                studentClass = studentClass,
                studentId = studentId,
                name = name,
                major = major,
                submajor = submajor,
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
            foreach(char c in majorString)
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
            int index = 0;
            foreach(char c in submajorString)
            {
                if (!(c >= 33 && c <= 126))
                    index = index + 1;
                else
                    break;
            }
            return submajorString.Substring(0, index);
        }
        private bool checkClassification()
        {
            if (pdfText.Substring(0, 13).Equals("취득교과목 영역별 분류표"))
                return true;
            return false;
        }
        private bool checkMajor()
        {
            if (studentInfo.major.Equals("컴퓨터공학전공") || studentInfo.submajor.Equals("컴퓨터공학전공"))
                return true;
            return false;
        }
        private void analysis()
        {
            analysisStudentInfo();
            analysisRGC();
            analysisBasic();
            analysisMSC();
            analysisMajor();
            analysisStandard();
        }
        private void analysisStudentInfo()
        {
            lblMyName.Text = studentInfo.name;
            lblMyStudentId.Text = studentInfo.studentId;
            lblMyClass.Text = studentInfo.studentClass;
            lblMySubMajor.Text = studentInfo.submajor == "" ? "x" : "o";

        }
        private void analysisRGC()
        {
            myRGC = new CommonRGC(pdfText);
            lblMyRGC.Text = myRGC.RGCGrade + " " + lblMyRGC.Text;
            foreach(string s in myRGC.unacquiredRGC)
                txtRGC.Text = txtRGC.Text + s + Environment.NewLine;
        }
        private void analysisBasic()
        {
            myBasic = new CommonBasic(pdfText);
            lblMyBasic.Text = myBasic.basicGrade + " " + lblMyBasic.Text;
            if (myBasic.unacquiredBasic.Count >= 3)
            {
                foreach(string s in myBasic.unacquiredBasic)
                    txtBasic.Text = txtBasic.Text + s + Environment.NewLine;
                txtBasic.Text = txtBasic.Text + "중 최소 " + (myBasic.unacquiredBasic.Count - 2).ToString()
                                + "과목을 수강 하십시오.";
            }
        }
        private void analysisMSC()
        {
            myMSC = new CommonMSC(pdfText, studentInfo.curriculumYear);
            if (Int32.Parse(studentInfo.curriculumYear) < 2017)
            {
                lblMyMath.Text = myMSC.mathGrade.ToString();
                lblMyScience.Text = myMSC.scienceGrade.ToString();
            }
            else
            {
                lblMyMath.Text = myMSC.mathGrade.ToString() + lblMyMath.Text;
                lblMyScience.Text = myMSC.scienceGrade.ToString() + lblMyScience.Text;
            }
            foreach (string s in myMSC.unacquiredList)
                txtMSC.Text = txtMSC.Text + s + Environment.NewLine;
        }
        private void analysisMajor()
        {
            paperPass = false;
            if (Int32.Parse(studentInfo.curriculumYear) < 2017)
            {
                myMajor2014 = new Major2014(pdfText, studentInfo.submajor);
                if (studentInfo.submajor.Equals(""))
                {
                    lblMyMajorSum.Text = myMajor2014.allGrade.ToString() + " " + lblMyMajorSum.Text;
                    lblMySpecial.Text = myMajor2014.specialGrade.ToString() + " " + lblMySpecial.Text;
                }
                else
                {
                    lblMyMajorSum.Text = myMajor2014.allGrade.ToString() + " " + "/ 51";
                    lblMySpecial.Text = myMajor2014.specialGrade.ToString() + " " + "/ 26";
                }
                lblMyDesign.Text = myMajor2014.designGrade.ToString() + " " + lblMyDesign.Text;
                foreach (string s in myMajor2014.unacquiredMajor)
                    txtMajor.Text = txtMajor.Text + s + Environment.NewLine;
                int designCount = countDesignMajor(myMajor2014.unacquiredMajor);
                if (designCount == 0)
                    paperPass = true;
            }
            else
            {

            }
        }
        private int countDesignMajor(List<string> list)
        {
            int count = 0;
            foreach(string s in list)
            {
                if (s.Equals(subjectMajor.CSE4066) || s.Equals(subjectMajor.CSE4067))
                    count = count + 1;
            }
            return count;
        }
        private void analysisStandard()
        {
            int allGrade = extractAllGrade();
            float gpa = float.Parse(pdfText.Substring(pdfText.IndexOf("평점평균:") + 5, 4));
            int majorEng = Int32.Parse(pdfText.Substring(pdfText.IndexOf("영어강의이수결과: ") + 14, 2));
            int subEngSum = Int32.Parse(pdfText.Substring(pdfText.IndexOf("영어강의이수결과: ") + 29, 2));
            string toeic = pdfText.Substring(pdfText.IndexOf("영어패스제(토익 등): ") + 18, 4);
            lblMyMajorEng.Text = majorEng.ToString() + lblMyMajorEng.Text;
            lblMyTotalEng.Text = subEngSum.ToString() + lblMyTotalEng.Text;
            lblMyToeic.Text = toeic.Equals("FAIL") ? "x" : "o";
            lblMyPaper.Text = paperPass ? "o" : "x";
        }
        private int extractAllGrade()
        {
            string gpaString = pdfText.Substring(pdfText.IndexOf("총취득학점:") + 6);
            int index = 0;
            foreach(char c in gpaString)
            {
                if (!c.Equals(' ') && c != 10)
                    index = index + 1;
                else 
                    break;
            }
            return Int32.Parse(gpaString.Substring(0, index));
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
                    MessageBox.Show("컴퓨터공학을 전공하고 있지 않은 학생입니다.", "오류", MessageBoxButtons.OK);
            }
        }
        #endregion
    }
}
