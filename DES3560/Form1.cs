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

namespace DES3560
{
    public partial class Form1 : Form
    {
        public string filePath;
        public string pdfText;
        public Student studentInfo;

        #region Functions
        public Form1()
        {
            InitializeComponent();
            txtFileName.Enabled = false;
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
            string studentId = pdfText.Substring(pdfText.IndexOf("학번: ") + 4, 10);
            string name = extractName();
            string major = extractMajor();
            string submajor = extractSubmajor();
            studentInfo = new Student
            {
                curriculumYear = curriculumYear,
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

                }
                else
                    MessageBox.Show("컴퓨터공학을 전공하고 있지 않은 학생입니다.", "오류", MessageBoxButtons.OK);
            }
        }
        #endregion
    }
}
