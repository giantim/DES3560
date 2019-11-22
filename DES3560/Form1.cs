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
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("선택된 파일이 없습니다.", "오류", MessageBoxButtons.OK);
                return false;
            }
        }
        private void analysis()
        {
            if (checkClassification())
            {
                string curriculumYear = pdfText.Substring(pdfText.IndexOf("교육과정 적용년도: ") + 11, 4);
                string studentId = pdfText.Substring(pdfText.IndexOf("학번: ") + 4, 10);
                string name = pdfText.Substring(pdfText.IndexOf("성명: ") + 4, 3);
                //string major = pdfText.Substring(pdfText.IndexOf("학과 : ") + 5, )
            }
            else
            {
                MessageBox.Show("취득교과목 영역별 분류표를 선택해 주십시오.", "오류", MessageBoxButtons.OK);
                txtFileName.Clear();
            }
        }
        private bool checkClassification()
        {
            if (pdfText.Substring(0, 13).Equals("취득교과목 영역별 분류표"))
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
                analysis();
        }
        #endregion
    }
}
