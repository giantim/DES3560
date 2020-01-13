using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using DES3560.Curriculum.RGC;
using DES3560.Curriculum.Basic;
using DES3560.Curriculum.MSC;
using DES3560.Curriculum.Major;

namespace DES3560
{
    public partial class MainForm : Form
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
        public MainForm()
        {
            InitializeComponent();
            turnOffTable();
        }
        private void turnOffTable()
        {
            tableStudentInfo.Visible = false;
            tableStudentInfoException.Visible = false;
            tableHeader.Visible = false;
            tableRGC.Visible = false;
            tableBasic.Visible = false;
            tableMSC.Visible = false;
            tableMajor.Visible = false;
            tableStandard.Visible = false;
        }
        private void turnOnTable()
        {
            tableStudentInfo.Visible = true;
            tableStudentInfoException.Visible = true;
            tableHeader.Visible = true;
            tableRGC.Visible = true;
            tableBasic.Visible = true;
            tableMSC.Visible = true;
            tableMajor.Visible = true;
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
        private bool checkClassification()
        {
            if (pdfText.Substring(0, 13).Equals("취득교과목 영역별 분류표"))
                return true;
            return false;
        }
        private bool checkMajor()
        {
            if (studentInfo.major.Equals("컴퓨터공학전공"))
                return true;
            if (!studentInfo.minor.Equals("") && studentInfo.minor.Substring(0, 7).Equals("컴퓨터공학전공"))
                return true;
            if (!studentInfo.submajor.Equals("") && studentInfo.submajor.Substring(0, 7).Equals("컴퓨터공학전공"))
                return true;
            return false;
        }
        private void initStudentInfo()
        {
            studentInfo = new Student
            {
                curriculumYear = Convert.ToInt32(pdfText.Substring(pdfText.IndexOf("교육과정 적용년도: ") + 11, 4)),
                studentClass = pdfText.Substring(pdfText.IndexOf(" 학번: ") - 3, 3),
                studentId = pdfText.Substring(pdfText.IndexOf("학번: ") + 4, 10),
                name = extractName(),
                major = extractMajor(),
                minor = extractMinor(),
                submajor = extractSubmajor(),
                isEngineering = parseEngineering(),

                formalUniv = extractFormalUniv(),
                prevMajor = extractPrevMajor(),
                campusTransfer = extractCampusTransfer(),

                rgcList = parseRGC(),
                priList = parsePRI(),
                cseList = parseCSE(),
                desList = parseDES(),
            };
        }
        private string extractName()
        {
            string nameString = pdfText.Substring(pdfText.IndexOf("성명: ") + 4);
            return nameString.Substring(0, getSpaceIndex(nameString, 0));
        }
        private string extractMajor()
        {
            string majorString = pdfText.Substring(pdfText.IndexOf("학과 : ") + 5);
            return majorString.Substring(0, getSpaceIndex(majorString, 0));
        }
        private string extractMinor()
        {
            string minorString = pdfText.Substring(pdfText.IndexOf("부전공1: ") + 6);
            if (minorString.Substring(0, 4) == "부전공2")
                return String.Empty;
            return minorString.Substring(0, getSpaceIndex(minorString, 0));
        }
        private string extractSubmajor()
        {
            string submajorString = pdfText.Substring(pdfText.IndexOf("복수1: ") + 5);
            if (submajorString.Substring(0, 3) == "복수2")
                return String.Empty;
            return submajorString.Substring(0, getSpaceIndex(submajorString, 0));
        }
        private string extractFormalUniv()
        {
            string formalUnivString = pdfText.Substring(pdfText.IndexOf("전적대:") + 4);
            return formalUnivString.Substring(0, getSpaceIndex(formalUnivString, 0));
        }
        private string extractPrevMajor()
        {
            string prevMajorString = pdfText.Substring(pdfText.IndexOf("전과(학과):") + 7);
            if (prevMajorString.Substring(0, 1).Equals("\n"))
                return String.Empty;
            return prevMajorString.Substring(0, getNewLineIndex(prevMajorString, 0));
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
                                    getSpaceIndex(rgcText.Substring(rgcText.IndexOf(subjectID) + subjectID.Length + 1), 0));
                int subjectGrade = Convert.ToInt32(rgcText.Substring(rgcText.IndexOf(subjectName) + subjectName.Length
                                    + jumpNonSpace(rgcText.Substring(rgcText.IndexOf(subjectName) + subjectName.Length), 0), 1));
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
                                    getSpaceIndex(priText.Substring(priText.IndexOf(subjectID) + subjectID.Length + 1), 0));
                int subjectGrade = Convert.ToInt32(priText.Substring(priText.IndexOf(subjectName) + subjectName.Length
                                    + jumpNonSpace(priText.Substring(priText.IndexOf(subjectName) + subjectName.Length), 0), 1));
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
                                    getSpaceIndex(cseText.Substring(cseText.IndexOf(subjectID) + subjectID.Length + 1), 0));
                int subjectGrade = Convert.ToInt32(cseText.Substring(cseText.IndexOf(subjectName) + subjectName.Length
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
                temp = temp.Substring(temp.IndexOf(subjectID) + 8);
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
        private bool parseEngineering()
        {
            string engineeringString = pdfText.Substring(pdfText.IndexOf("공학인증심화대상:") + 9, 1);
            return engineeringString == "Y" ? true : false;
        }
        private int getSpaceIndex(string text, int index)
        {
            int i = 0;
            while (!text[index + i].Equals(' '))
                i = i + 1;
            return index + i;
        }
        private int getNewLineIndex(string text, int index)
        {
            int i = 0;
            while (!text[index + i].Equals('\n'))
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
            //analysisMajor();
            analysisStandard();
        }
        private void analysisStudentInfo()
        {
            lblMyName.Text = studentInfo.name;
            lblMyStudentId.Text = studentInfo.studentId;
            lblMyClass.Text = studentInfo.studentClass.Substring(0, 1);
            lblMyMajor2.Text = studentInfo.major;
            lblMyCurriYear.Text = studentInfo.curriculumYear.ToString();
            lblMyIsEngineering.Text = studentInfo.isEngineering == true ? "Y" : "N";
            lblMyMinor.Text = studentInfo.minor == "" ? "X" : studentInfo.minor;
            lblMySubmajor.Text = studentInfo.submajor == "" ? "X" : studentInfo.submajor;
            lblMyCampusTransfer.Text = studentInfo.campusTransfer;
            lblMyFormalUniv.Text = studentInfo.formalUniv == "" ? "X" : studentInfo.formalUniv;
            lblMyPrevMajor.Text = studentInfo.prevMajor == "" ? "X" : studentInfo.prevMajor;
        }
        private void analysisRGC()
        {
            myRGC = new CommonRGC(studentInfo.rgcList);
            lblMyRGC.Text = myRGC.RGCGrade.ToString();
            if (studentInfo.curriculumYear <= 2014)
            {
                lblRGCStandard.Text = "/ 12";
                if (myRGC.RGCGrade >= 12)
                {
                    lblRGCPass.ForeColor = Color.Blue;
                    lblRGCPass.Text = "P";
                    studentInfo.rgcPass = true;
                }
                else
                {
                    lblRGCPass.ForeColor = Color.Red;
                    lblRGCPass.Text = "F";
                    studentInfo.rgcPass = false;
                }
            }
            else
            {
                lblRGCStandard.Text = "/ 16";
                if (myRGC.RGCGrade >= 16)
                {
                    lblRGCPass.ForeColor = Color.Blue;
                    lblRGCPass.Text = "P";
                    studentInfo.rgcPass = true;
                }
                else
                {
                    lblRGCPass.ForeColor = Color.Red;
                    lblRGCPass.Text = "F";
                    studentInfo.rgcPass = false;
                }
            }
        }
        private void analysisBasic()
        {
            myBasic = new CommonBasic();
            myBasic.checkBasic(studentInfo.priList);
            lblMyBasic.Text = myBasic.basicGrade.ToString();
            txtBasic.Text = String.Join(Environment.NewLine, myBasic.unacquiredList);
            if (myBasic.unacquiredList.Count == 0)
            {
                lblBasicPass.ForeColor = Color.Blue;
                lblBasicPass.Text = "P";
                studentInfo.basicPass = true;
            }
            else
            {
                lblBasicPass.ForeColor = Color.Red;
                lblBasicPass.Text = "F";
                studentInfo.basicPass = false;
            }
        }
        private void analysisMSC()
        {
            myMSC = new CommonMSC(studentInfo.curriculumYear);
            myMSC.checkMSC(studentInfo.priList);
            if (studentInfo.curriculumYear < 2017)
            {
                lblMSCMyMath.Text = myMSC.mathGrade.ToString() + " / 9";
                lblMSCMyScience.Text = myMSC.scienceGrade.ToString() + " / 6";
                if (myMSC.mathGrade + myMSC.scienceGrade >= 28)
                {
                    lblMSCPass.ForeColor = Color.Blue;
                    lblMSCPass.Text = "P";
                    studentInfo.mscPass = true;
                }
                else
                {
                    lblMSCPass.ForeColor = Color.Red;
                    lblMSCPass.Text = "F";
                    studentInfo.mscPass = false;
                }
            }
            else
            {
                lblMSCMyMath.Text = myMSC.mathGrade.ToString() + " / 12";
                lblMSCMyScience.Text = myMSC.scienceGrade.ToString() + " / 6";
                if (myMSC.mathGrade + myMSC.scienceGrade >= 21)
                {
                    lblMSCPass.ForeColor = Color.Blue;
                    lblMSCPass.Text = "P";
                    studentInfo.mscPass = true;
                }
                else
                {
                    lblMSCPass.ForeColor = Color.Red;
                    lblMSCPass.Text = "F";
                    studentInfo.mscPass = false;
                }
            }
            txtMSC.Text = String.Join(Environment.NewLine, myMSC.unacquiredList);
        }
        //private void analysisMajor()
        //{
        //    paperPass = false;
        //    myMajor = new MajorByCurri(studentInfo.curriculumYear);
        //    myMajor.checkMajor(studentInfo.cseList, studentInfo.desList);
        //    if (studentInfo.submajor.Equals(false))
        //    {
        //        lblMyMajorSum.Text = myMajor.allGrade.ToString() + " / 84";
        //        lblMySpecial.Text = myMajor.specialGrade.ToString() + " / 52";
        //    }
        //    else
        //    {
        //        lblMyMajorSum.Text = myMajor.allGrade.ToString() + " / 51";
        //        lblMySpecial.Text = myMajor.specialGrade.ToString() + " / 26";
        //    }
        //    lblMyDesign.Text = myMajor.designGrade.ToString() + " / 12";
        //    txtMSC.Text = String.Join(Environment.NewLine, myMajor.unacquiredList);
        //    analysisPaper(myMajor.unacquiredList);
        //}
        private void analysisStandard()
        {
            setAllGradeText();
            setGPAText();
            setTeachingText();
            setEngResultText();
            setEngText();
            setToeicText();
            setPaperText();
            setEngineeringText();
            setGraduationText();
        }
        private int getSpaceOrNewLineIndex(string s)
        {
            int index = 0;
            foreach (char c in s)
            {
                if (!c.Equals(' ') && c != 10)
                    index = index + 1;
                else
                    break;
            }
            return index;
        }
        private void extractAllGrade()
        {
            string gradeString = pdfText.Substring(pdfText.IndexOf("총취득학점:") + 6);
            studentInfo.allGrade = gradeString.Substring(0, getSpaceOrNewLineIndex(gradeString));
        }
        private void setAllGradeText()
        {
            extractAllGrade();
            lblMyAllGrade.Text = studentInfo.allGrade;
            if (Convert.ToInt32(studentInfo.allGrade) >= 140)
            {
                lblAllGradePass.ForeColor = Color.Blue;
                lblAllGradePass.Text = "P";
                studentInfo.allGradePass = true;
            }
            else
            {
                lblAllGradePass.ForeColor = Color.Red;
                lblAllGradePass.Text = "F";
                studentInfo.allGradePass = false;
            }
        }
        private void extractGPA()
        {
            string gpaString = pdfText.Substring(pdfText.IndexOf("평점평균:") + 5);
            studentInfo.gpa = gpaString.Substring(0, getSpaceOrNewLineIndex(gpaString));
        }
        private void setGPAText()
        {
            extractGPA();
            lblMyGPA.Text = studentInfo.gpa;
            if (Convert.ToSingle(studentInfo.gpa) >= 2.0)
            {
                lblGPAPass.ForeColor = Color.Blue;
                lblGPAPass.Text = "P";
                studentInfo.gpaPass = true;
            }
            else
            {
                lblGPAPass.ForeColor = Color.Red;
                lblGPAPass.Text = "F";
                studentInfo.gpaPass = false;
            }
        }
        private void setTeachingText()
        {
            extractTeaching();
            lblMyTeaching.Text = studentInfo.teaching;
        }
        private void extractTeaching()
        {
            string teachingString = pdfText.Substring(pdfText.IndexOf("교직인적성 : ") + 8);
            studentInfo.teaching = teachingString.Substring(0, getSpaceOrNewLineIndex(teachingString));
        }
        private void setEngResultText()
        {
            countMajorEng();
            countOtherEng();
            lblMyMajorEng.Text = studentInfo.majorEng;
            lblMyOtherEng.Text = studentInfo.otherEng;
            if (Convert.ToInt32(studentInfo.majorEng) >= 2 &&
                Convert.ToInt32(studentInfo.majorEng) + Convert.ToInt32(studentInfo.otherEng) >= 4)
            {
                lblEngResultPass.ForeColor = Color.Blue;
                lblEngResultPass.Text = "P";
                studentInfo.engResultPass = true;
            }
            else
            {
                lblEngResultPass.ForeColor = Color.Red;
                lblEngResultPass.Text = "F";
                studentInfo.engResultPass = false;
            }
        }
        private void countMajorEng()
        {
            string majorEngString = pdfText.Substring(pdfText.IndexOf("(전공:") + 4);
            studentInfo.majorEng = majorEngString.Substring(0, getCommaIndex(majorEngString));
        }
        private int getCommaIndex(string s)
        {
            int index = 0;
            foreach (char c in s)
            {
                if (!c.Equals(','))
                    index = index + 1;
                else
                    break;
            }
            return index;
        }
        private void countOtherEng()
        {
            string otherEngString = pdfText.Substring(pdfText.IndexOf(" 전공외:") + 5);
            studentInfo.otherEng = otherEngString.Substring(0, getParenthesisIndex(otherEngString));
        }
        private int getParenthesisIndex(string s)
        {
            int index = 0;
            foreach (char c in s)
            {
                if (!c.Equals(')'))
                    index = index + 1;
                else
                    break;
            }
            return index;
        }
        private void setEngText()
        {
            extractEng();
            lblMyEng.Text = studentInfo.isEng;
            if (studentInfo.isEng.Equals("비대상"))
            {
                lblEngPass.Text = String.Empty;
                studentInfo.engPass = true;
            }
            else if (studentInfo.isEng.Equals("대상") && studentInfo.eng.Equals("PASS"))
            {
                lblEngPass.ForeColor = Color.Blue;
                lblEngPass.Text = "P";
                studentInfo.engPass = true;
            }
            else if (studentInfo.isEng.Equals("대상") && studentInfo.eng.Equals("FAIL"))
            {
                lblEngPass.ForeColor = Color.Red;
                lblEngPass.Text = "F";
                studentInfo.engPass = false;
            }
        }
        private void extractEng()
        {
            string engString = pdfText.Substring(pdfText.IndexOf("영어강의이수: ") + 8);
            studentInfo.isEng = engString.Substring(0, getSpaceOrNewLineIndex(engString));
            engString = engString.Substring(getSpaceOrNewLineIndex(engString) + 3);
            studentInfo.eng = engString.Substring(0, 4);
        }
        private void setToeicText()
        {
            extractToeic();
            lblMyToeic.Text = studentInfo.isToeic;
            if (studentInfo.isToeic.Equals("비대상"))
            {
                lblToeicPass.Text = String.Empty;
                studentInfo.toeicPass = true;
            }
            else if (studentInfo.isToeic.Equals("대상") && studentInfo.toeic.Equals("PASS"))
            {
                lblToeicPass.ForeColor = Color.Blue;
                lblToeicPass.Text = "P";
                studentInfo.toeicPass = true;
            }
            else if (studentInfo.isToeic.Equals("대상") && studentInfo.toeic.Equals("FAIL"))
            {
                lblToeicPass.ForeColor = Color.Red;
                lblToeicPass.Text = "F";
                studentInfo.toeicPass = false;
            }
        }
        private void extractToeic()
        {
            string toeicString = pdfText.Substring(pdfText.IndexOf("영어패스제(토익 등): ") + 13);
            studentInfo.isToeic = toeicString.Substring(0, getSpaceOrNewLineIndex(toeicString));
            toeicString = toeicString.Substring(getSpaceOrNewLineIndex(toeicString) + 3);
            studentInfo.toeic = toeicString.Substring(0, 4);
        }
        private void setPaperText()
        {
            extractPaper();
            if (studentInfo.paper)
            {
                lblPaperPass.ForeColor = Color.Blue;
                lblPaperPass.Text = "P";
            }
            else
            {
                lblPaperPass.ForeColor = Color.Red;
                lblPaperPass.Text = "F";
            }
        }
        private void extractPaper()
        {
            if (pdfText.Contains("졸업논문 심사"))
            {
                string paperString = pdfText.Substring(pdfText.IndexOf("졸업논문 심사") + 7);
                paperString = paperString.Substring(getSpaceIndex(paperString, 0) + 1);
                string paperPass = paperString.Substring(0, getSpaceOrNewLineIndex(paperString));
                studentInfo.paper = paperPass.Equals("합격") ? true : false;
            }
            else
            {
                studentInfo.paper = false;
            }
        }
        private bool checkCourse()
        {
            if (studentInfo.rgcPass && studentInfo.basicPass
                && studentInfo.mscPass && studentInfo.majorPass)
                return true;
            return false;
        }
        private bool checkStandardReq()
        {
            if (studentInfo.allGradePass && studentInfo.gpaPass
                && studentInfo.engResultPass && studentInfo.engPass && studentInfo.paper)
                return true;
            return false;
        }
        private void setEngineeringText()
        {
            if (studentInfo.isEngineering)
            {
                if (checkCourse() && checkStandardReq())
                {
                    lblEngineeringPass.ForeColor = Color.Blue;
                    lblEngineeringPass.Text = "P";
                }
                else
                {
                    lblEngineeringPass.ForeColor = Color.Red;
                    lblEngineeringPass.Text = "F";
                }
            }
            else
            {
                lblEngineeringPass.Text = "비대상";
            }
            studentInfo.engineeringPass = checkCourse() && checkStandardReq() ? true : false;
        }
        private void setGraduationText()
        {
            if (studentInfo.engineeringPass && studentInfo.toeicPass)
            {
                lblGraduationPass.ForeColor = Color.Blue;
                lblGraduationPass.Text = "P";
                studentInfo.graduationPass = true;
            }
            else
            {
                lblGraduationPass.ForeColor = Color.Red;
                lblGraduationPass.Text = "F";
                studentInfo.graduationPass = false;
            }
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
