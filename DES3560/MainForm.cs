using System;
using System.Collections.Generic;
using System.Data;
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

        public List<Student> studentList;
        public Student studentInfo;
        
        public CommonRGC myRGC;
        public CommonBasic myBasic;
        public CommonMSC myMSC;
        public MajorByCurri myMajor;

        #region Functions
        public MainForm()
        {
            InitializeComponent();
            studentList = new List<Student>();
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
        private void extractTextFromPdfTest()
        {
            try
            {
                using (PdfReader reader = new PdfReader(filePath))
                {
                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        StringBuilder text = new StringBuilder();
                        Student student = new Student();
                        text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                        string pageText = text.ToString();
                        if (checkClassification(pageText))
                        {
                            student.pdfText = pageText;
                            student.initStudentInfo();
                            studentList.Add(student);
                        }
                        else
                        {
                            MessageBox.Show("잘못된 파일을 선택했습니다.", "오류", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("선택된 파일이 없습니다.", "오류", MessageBoxButtons.OK);
            }
        }
        private bool checkClassification(string text)
        {
            if (text.Substring(0, 13).Equals("취득교과목 영역별 분류표"))
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
                    CommonFunctions.changePass(lblRGCPass);
                    studentInfo.rgcPass = true;
                }
                else
                {
                    CommonFunctions.changeFail(lblRGCPass);
                    studentInfo.rgcPass = false;
                }
            }
            else
            {
                lblRGCStandard.Text = "/ 16";
                if (myRGC.RGCGrade >= 16)
                {
                    CommonFunctions.changePass(lblRGCPass);
                    studentInfo.rgcPass = true;
                }
                else
                {
                    CommonFunctions.changeFail(lblRGCPass);
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
                CommonFunctions.changePass(lblBasicPass);
                studentInfo.basicPass = true;
            }
            else
            {
                CommonFunctions.changeFail(lblBasicPass);
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
                    CommonFunctions.changePass(lblMSCPass);
                    studentInfo.mscPass = true;
                }
                else
                {
                    CommonFunctions.changeFail(lblMSCPass);
                    studentInfo.mscPass = false;
                }
            }
            else
            {
                lblMSCMyMath.Text = myMSC.mathGrade.ToString() + " / 12";
                lblMSCMyScience.Text = myMSC.scienceGrade.ToString() + " / 6";
                if (myMSC.mathGrade + myMSC.scienceGrade >= 21)
                {
                    CommonFunctions.changePass(lblMSCPass);
                    studentInfo.mscPass = true;
                }
                else
                {
                    CommonFunctions.changeFail(lblMSCPass);
                    studentInfo.mscPass = false;
                }
            }
            txtMSC.Text = String.Join(Environment.NewLine, myMSC.unacquiredList);
        }
        private void analysisMajor()
        {
            myMajor = new MajorByCurri(studentInfo.curriculumYear);
            myMajor.checkMajor(studentInfo.cseList, studentInfo.desList);
            lblMyMajorSum.Text = myMajor.allGrade.ToString();
            lblMyMajorDesign.Text = myMajor.designGrade.ToString();
            lblMyMajorAdvanced.Text = myMajor.advancedGrade.ToString();
            txtMajor.Text = String.Join(Environment.NewLine, myMajor.unacquiredList);
            if (studentInfo.isEngineering)
            {
                lblMajorSumStandard.Text = "/84";
                lblMajorAdvancedStandard.Text = "/42";
                if (myMajor.allGrade >= 84 && myMajor.advancedGrade >= 42
                    && myMajor.designGrade >= 12 && myMajor.unacquiredList.Count == 0)
                {
                    CommonFunctions.changePass(lblMajorPass);
                    studentInfo.majorPass = true;
                }
                else
                {
                    CommonFunctions.changeFail(lblMajorPass);
                    studentInfo.majorPass = true;
                }
            }
            else
            {
                if (studentInfo.submajor.Contains("컴퓨터공학전공") && studentInfo.curriculumYear >= 2019)
                {
                    lblMajorSumStandard.Text = "/45";
                    lblMajorAdvancedStandard.Text = "/23";
                    if (myMajor.allGrade >= 45 && myMajor.designGrade >= 12
                        && myMajor.advancedGrade >= 23 && myMajor.unacquiredList.Count == 0)
                    {
                        CommonFunctions.changePass(lblMajorPass);
                        studentInfo.majorPass = true;
                    }
                    else
                    {
                        CommonFunctions.changeFail(lblMajorPass);
                        studentInfo.majorPass = false;
                    }
                }
                else
                {
                    lblMajorSumStandard.Text = "/51";
                    lblMajorAdvancedStandard.Text = "/26";
                    if (myMajor.allGrade >= 51 && myMajor.designGrade >= 12
                        && myMajor.advancedGrade >= 26 && myMajor.unacquiredList.Count == 0)
                    {
                        CommonFunctions.changePass(lblMajorPass);
                        studentInfo.majorPass = true;
                    }
                    else
                    {
                        CommonFunctions.changeFail(lblMajorPass);
                        studentInfo.majorPass = false;
                    }
                }
            }
        }
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
        private void extractAllGrade()
        {
            string gradeString = studentInfo.pdfText.Substring(studentInfo.pdfText.IndexOf("총취득학점:") + 6);
            studentInfo.allGrade = gradeString.Substring(0, CommonFunctions.getSpaceOrNewLineIndex(gradeString));
        }
        private void setAllGradeText()
        {
            extractAllGrade();
            lblMyAllGrade.Text = studentInfo.allGrade;
            if (Convert.ToInt32(studentInfo.allGrade) >= 140)
            {
                CommonFunctions.changePass(lblAllGradePass);
                studentInfo.allGradePass = true;
            }
            else
            {
                CommonFunctions.changeFail(lblAllGradePass);
                studentInfo.allGradePass = false;
            }
        }
        private void extractGPA()
        {
            string gpaString = studentInfo.pdfText.Substring(studentInfo.pdfText.IndexOf("평점평균:") + 5);
            studentInfo.gpa = gpaString.Substring(0, CommonFunctions.getSpaceOrNewLineIndex(gpaString));
        }
        private void setGPAText()
        {
            extractGPA();
            lblMyGPA.Text = studentInfo.gpa;
            if (Convert.ToSingle(studentInfo.gpa) >= 2.0)
            {
                CommonFunctions.changePass(lblGPAPass);
                studentInfo.gpaPass = true;
            }
            else
            {
                CommonFunctions.changeFail(lblGPAPass);
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
            string teachingString = studentInfo.pdfText.Substring(studentInfo.pdfText.IndexOf("교직인적성 : ") + 8);
            studentInfo.teaching = teachingString.Substring(0, CommonFunctions.getSpaceOrNewLineIndex(teachingString));
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
                CommonFunctions.changePass(lblEngResultPass);
                studentInfo.engResultPass = true;
            }
            else
            {
                CommonFunctions.changeFail(lblEngResultPass);
                studentInfo.engResultPass = false;
            }
        }
        private void countMajorEng()
        {
            string majorEngString = studentInfo.pdfText.Substring(studentInfo.pdfText.IndexOf("(전공:") + 4);
            studentInfo.majorEng = majorEngString.Substring(0, CommonFunctions.getCommaIndex(majorEngString));
        }
        private void countOtherEng()
        {
            string otherEngString = studentInfo.pdfText.Substring(studentInfo.pdfText.IndexOf(" 전공외:") + 5);
            studentInfo.otherEng = otherEngString.Substring(0, CommonFunctions.getParenthesisIndex(otherEngString));
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
                CommonFunctions.changePass(lblEngPass);
                studentInfo.engPass = true;
            }
            else if (studentInfo.isEng.Equals("대상") && studentInfo.eng.Equals("FAIL"))
            {
                CommonFunctions.changeFail(lblEngResultPass);
                studentInfo.engPass = false;
            }
        }
        private void extractEng()
        {
            string engString = studentInfo.pdfText.Substring(studentInfo.pdfText.IndexOf("영어강의이수: ") + 8);
            studentInfo.isEng = engString.Substring(0, CommonFunctions.getSpaceOrNewLineIndex(engString));
            engString = engString.Substring(CommonFunctions.getSpaceOrNewLineIndex(engString) + 3);
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
                CommonFunctions.changePass(lblToeicPass);
                studentInfo.toeicPass = true;
            }
            else if (studentInfo.isToeic.Equals("대상") && studentInfo.toeic.Equals("FAIL"))
            {
                CommonFunctions.changeFail(lblToeicPass);
                studentInfo.toeicPass = false;
            }
        }
        private void extractToeic()
        {
            string toeicString = studentInfo.pdfText.Substring(studentInfo.pdfText.IndexOf("영어패스제(토익 등): ") + 13);
            studentInfo.isToeic = toeicString.Substring(0, CommonFunctions.getSpaceOrNewLineIndex(toeicString));
            toeicString = toeicString.Substring(CommonFunctions.getSpaceOrNewLineIndex(toeicString) + 3);
            studentInfo.toeic = toeicString.Substring(0, 4);
        }
        private void setPaperText()
        {
            extractPaper();
            if (studentInfo.paper)
            {
                CommonFunctions.changePass(lblPaperPass);
            }
            else
            {
                CommonFunctions.changeFail(lblPaperPass);
            }
        }
        private void extractPaper()
        {
            if (studentInfo.pdfText.Contains("졸업논문 심사"))
            {
                string paperString = studentInfo.pdfText.Substring(studentInfo.pdfText.IndexOf("졸업논문 심사") + 7);
                paperString = paperString.Substring(CommonFunctions.getSpaceIndex(paperString, 0) + 1);
                string paperPass = paperString.Substring(0, CommonFunctions.getSpaceOrNewLineIndex(paperString));
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
                    CommonFunctions.changePass(lblEngineeringPass);
                }
                else
                {
                    CommonFunctions.changeFail(lblEngineeringPass);
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
                CommonFunctions.changePass(lblGraduationPass);
                studentInfo.graduationPass = true;
            }
            else
            {
                CommonFunctions.changeFail(lblGraduationPass);
                studentInfo.graduationPass = false;
            }
        }
        private void addDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("번호", typeof(int));
            table.Columns.Add("이름", typeof(string));
            table.Columns.Add("학번", typeof(string));
            int index = 1;
            foreach (Student student in studentList)
            {
                table.Rows.Add(index, student.name, student.studentId);
                index = index + 1;
            }
            gridViewStudent.DataSource = table;
        }
        private void runAnalysis()
        {
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
            studentList.Clear();
            extractTextFromPdfTest();
            if (studentList.Count > 0)
            {
                addDataTable();
                studentInfo = studentList[0];
                runAnalysis();
            }
        }
        private void gridViewStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            studentInfo = studentList[e.RowIndex];
            runAnalysis();
        }
        #endregion
    }
}
