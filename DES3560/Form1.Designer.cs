namespace DES3560
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnDialog = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnExecution = new System.Windows.Forms.Button();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblUnacquired = new System.Windows.Forms.Label();
            this.lblRGC = new System.Windows.Forms.Label();
            this.txtRGC = new System.Windows.Forms.TextBox();
            this.txtBasic = new System.Windows.Forms.TextBox();
            this.txtMSC = new System.Windows.Forms.TextBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.lblBasic = new System.Windows.Forms.Label();
            this.lblMSC = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblMSCMath = new System.Windows.Forms.Label();
            this.lblMSCScience = new System.Windows.Forms.Label();
            this.lblMajorSum = new System.Windows.Forms.Label();
            this.lblMyMajorSum = new System.Windows.Forms.Label();
            this.lblDesign = new System.Windows.Forms.Label();
            this.lblSpecial = new System.Windows.Forms.Label();
            this.lblMyDesign = new System.Windows.Forms.Label();
            this.lblMySpecial = new System.Windows.Forms.Label();
            this.lblMyRGC = new System.Windows.Forms.Label();
            this.lblMyBasic = new System.Windows.Forms.Label();
            this.lblMyMath = new System.Windows.Forms.Label();
            this.lblMyScience = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDialog
            // 
            this.btnDialog.Location = new System.Drawing.Point(270, 99);
            this.btnDialog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDialog.Name = "btnDialog";
            this.btnDialog.Size = new System.Drawing.Size(86, 29);
            this.btnDialog.TabIndex = 0;
            this.btnDialog.Text = "찾아보기";
            this.btnDialog.UseVisualStyleBackColor = true;
            this.btnDialog.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(40, 99);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(222, 25);
            this.txtFileName.TabIndex = 1;
            // 
            // btnExecution
            // 
            this.btnExecution.Location = new System.Drawing.Point(362, 99);
            this.btnExecution.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExecution.Name = "btnExecution";
            this.btnExecution.Size = new System.Drawing.Size(86, 29);
            this.btnExecution.TabIndex = 2;
            this.btnExecution.Text = "분석";
            this.btnExecution.UseVisualStyleBackColor = true;
            this.btnExecution.Click += new System.EventHandler(this.btnExecution_Click);
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInfo1.Location = new System.Drawing.Point(38, 34);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(332, 15);
            this.lblInfo1.TabIndex = 3;
            this.lblInfo1.Text = "* 취득분류표는 uDrims > 학사정보 > 졸업 >\r\n";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInfo2.Location = new System.Drawing.Point(51, 61);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(585, 15);
            this.lblInfo2.TabIndex = 4;
            this.lblInfo2.Text = "취득학점확인서조회(전학년) > 출력포함 - 수강신청포함 체크후 출력 하십시오.";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblCategory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUnacquired, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRGC, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtRGC, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBasic, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtMSC, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtMajor, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblBasic, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMSC, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblMajor, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblGrade, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMSCMath, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblMSCScience, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblMajorSum, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblMyMajorSum, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblDesign, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSpecial, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblMyDesign, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblMySpecial, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblMyRGC, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMyBasic, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMyMath, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblMyScience, 4, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(41, 131);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(812, 286);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategory.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCategory.Location = new System.Drawing.Point(3, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(84, 40);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "항목";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnacquired
            // 
            this.lblUnacquired.AutoSize = true;
            this.lblUnacquired.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnacquired.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUnacquired.Location = new System.Drawing.Point(333, 0);
            this.lblUnacquired.Name = "lblUnacquired";
            this.lblUnacquired.Size = new System.Drawing.Size(476, 40);
            this.lblUnacquired.TabIndex = 2;
            this.lblUnacquired.Text = "미취득 내역";
            this.lblUnacquired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRGC
            // 
            this.lblRGC.AutoSize = true;
            this.lblRGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRGC.Location = new System.Drawing.Point(3, 40);
            this.lblRGC.Name = "lblRGC";
            this.lblRGC.Size = new System.Drawing.Size(84, 50);
            this.lblRGC.TabIndex = 3;
            this.lblRGC.Text = "공통교양";
            this.lblRGC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRGC
            // 
            this.txtRGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRGC.Enabled = false;
            this.txtRGC.Location = new System.Drawing.Point(333, 43);
            this.txtRGC.Multiline = true;
            this.txtRGC.Name = "txtRGC";
            this.txtRGC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRGC.Size = new System.Drawing.Size(476, 44);
            this.txtRGC.TabIndex = 7;
            // 
            // txtBasic
            // 
            this.txtBasic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBasic.Enabled = false;
            this.txtBasic.Location = new System.Drawing.Point(333, 93);
            this.txtBasic.Multiline = true;
            this.txtBasic.Name = "txtBasic";
            this.txtBasic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBasic.Size = new System.Drawing.Size(476, 44);
            this.txtBasic.TabIndex = 8;
            // 
            // txtMSC
            // 
            this.txtMSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMSC.Enabled = false;
            this.txtMSC.Location = new System.Drawing.Point(333, 143);
            this.txtMSC.Multiline = true;
            this.txtMSC.Name = "txtMSC";
            this.tableLayoutPanel1.SetRowSpan(this.txtMSC, 2);
            this.txtMSC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMSC.Size = new System.Drawing.Size(476, 64);
            this.txtMSC.TabIndex = 9;
            // 
            // txtMajor
            // 
            this.txtMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMajor.Enabled = false;
            this.txtMajor.Location = new System.Drawing.Point(333, 213);
            this.txtMajor.Multiline = true;
            this.txtMajor.Name = "txtMajor";
            this.tableLayoutPanel1.SetRowSpan(this.txtMajor, 2);
            this.txtMajor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMajor.Size = new System.Drawing.Size(476, 70);
            this.txtMajor.TabIndex = 10;
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBasic.Location = new System.Drawing.Point(3, 90);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Size = new System.Drawing.Size(84, 50);
            this.lblBasic.TabIndex = 11;
            this.lblBasic.Text = "기본소양";
            this.lblBasic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMSC
            // 
            this.lblMSC.AutoSize = true;
            this.lblMSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMSC.Location = new System.Drawing.Point(3, 140);
            this.lblMSC.Name = "lblMSC";
            this.tableLayoutPanel1.SetRowSpan(this.lblMSC, 2);
            this.lblMSC.Size = new System.Drawing.Size(84, 70);
            this.lblMSC.TabIndex = 15;
            this.lblMSC.Text = "MSC";
            this.lblMSC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMajor.Location = new System.Drawing.Point(3, 210);
            this.lblMajor.Name = "lblMajor";
            this.tableLayoutPanel1.SetRowSpan(this.lblMajor, 2);
            this.lblMajor.Size = new System.Drawing.Size(84, 76);
            this.lblMajor.TabIndex = 16;
            this.lblMajor.Text = "전공필수";
            this.lblMajor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblGrade, 6);
            this.lblGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGrade.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGrade.Location = new System.Drawing.Point(93, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(234, 40);
            this.lblGrade.TabIndex = 17;
            this.lblGrade.Text = "학점";
            this.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMSCMath
            // 
            this.lblMSCMath.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblMSCMath, 3);
            this.lblMSCMath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMSCMath.Location = new System.Drawing.Point(93, 140);
            this.lblMSCMath.Name = "lblMSCMath";
            this.lblMSCMath.Size = new System.Drawing.Size(114, 35);
            this.lblMSCMath.TabIndex = 24;
            this.lblMSCMath.Text = "수학";
            this.lblMSCMath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMSCScience
            // 
            this.lblMSCScience.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblMSCScience, 3);
            this.lblMSCScience.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMSCScience.Location = new System.Drawing.Point(213, 140);
            this.lblMSCScience.Name = "lblMSCScience";
            this.lblMSCScience.Size = new System.Drawing.Size(114, 35);
            this.lblMSCScience.TabIndex = 25;
            this.lblMSCScience.Text = "과학";
            this.lblMSCScience.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMajorSum
            // 
            this.lblMajorSum.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblMajorSum, 2);
            this.lblMajorSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMajorSum.Location = new System.Drawing.Point(93, 210);
            this.lblMajorSum.Name = "lblMajorSum";
            this.lblMajorSum.Size = new System.Drawing.Size(74, 35);
            this.lblMajorSum.TabIndex = 32;
            this.lblMajorSum.Text = "총 학점";
            this.lblMajorSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyMajorSum
            // 
            this.lblMyMajorSum.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblMyMajorSum, 2);
            this.lblMyMajorSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyMajorSum.Location = new System.Drawing.Point(93, 245);
            this.lblMyMajorSum.Name = "lblMyMajorSum";
            this.lblMyMajorSum.Size = new System.Drawing.Size(74, 41);
            this.lblMyMajorSum.TabIndex = 33;
            this.lblMyMajorSum.Text = "/ 140";
            this.lblMyMajorSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesign
            // 
            this.lblDesign.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblDesign, 2);
            this.lblDesign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDesign.Location = new System.Drawing.Point(173, 210);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(74, 35);
            this.lblDesign.TabIndex = 34;
            this.lblDesign.Text = "설계";
            this.lblDesign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpecial
            // 
            this.lblSpecial.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblSpecial, 2);
            this.lblSpecial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpecial.Location = new System.Drawing.Point(253, 210);
            this.lblSpecial.Name = "lblSpecial";
            this.lblSpecial.Size = new System.Drawing.Size(74, 35);
            this.lblSpecial.TabIndex = 35;
            this.lblSpecial.Text = "전문";
            this.lblSpecial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyDesign
            // 
            this.lblMyDesign.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblMyDesign, 2);
            this.lblMyDesign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyDesign.Location = new System.Drawing.Point(173, 245);
            this.lblMyDesign.Name = "lblMyDesign";
            this.lblMyDesign.Size = new System.Drawing.Size(74, 41);
            this.lblMyDesign.TabIndex = 36;
            this.lblMyDesign.Text = "/ 12";
            this.lblMyDesign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMySpecial
            // 
            this.lblMySpecial.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblMySpecial, 2);
            this.lblMySpecial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMySpecial.Location = new System.Drawing.Point(253, 245);
            this.lblMySpecial.Name = "lblMySpecial";
            this.lblMySpecial.Size = new System.Drawing.Size(74, 41);
            this.lblMySpecial.TabIndex = 37;
            this.lblMySpecial.Text = "/ 54";
            this.lblMySpecial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyRGC
            // 
            this.lblMyRGC.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblMyRGC, 6);
            this.lblMyRGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyRGC.Location = new System.Drawing.Point(93, 40);
            this.lblMyRGC.Name = "lblMyRGC";
            this.lblMyRGC.Size = new System.Drawing.Size(234, 50);
            this.lblMyRGC.TabIndex = 38;
            this.lblMyRGC.Text = "/ 16";
            this.lblMyRGC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyBasic
            // 
            this.lblMyBasic.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblMyBasic, 6);
            this.lblMyBasic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyBasic.Location = new System.Drawing.Point(93, 90);
            this.lblMyBasic.Name = "lblMyBasic";
            this.lblMyBasic.Size = new System.Drawing.Size(234, 50);
            this.lblMyBasic.TabIndex = 39;
            this.lblMyBasic.Text = "/ 9";
            this.lblMyBasic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyMath
            // 
            this.lblMyMath.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblMyMath, 3);
            this.lblMyMath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyMath.Location = new System.Drawing.Point(93, 175);
            this.lblMyMath.Name = "lblMyMath";
            this.lblMyMath.Size = new System.Drawing.Size(114, 35);
            this.lblMyMath.TabIndex = 40;
            this.lblMyMath.Text = "/ 12";
            this.lblMyMath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyScience
            // 
            this.lblMyScience.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblMyScience, 3);
            this.lblMyScience.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyScience.Location = new System.Drawing.Point(213, 175);
            this.lblMyScience.Name = "lblMyScience";
            this.lblMyScience.Size = new System.Drawing.Size(114, 35);
            this.lblMyScience.TabIndex = 41;
            this.lblMyScience.Text = "/ 16";
            this.lblMyScience.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(914, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.btnExecution);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnDialog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "자동 졸업사정 시스템";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button btnDialog;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnExecution;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblUnacquired;
        private System.Windows.Forms.Label lblRGC;
        private System.Windows.Forms.TextBox txtRGC;
        private System.Windows.Forms.TextBox txtBasic;
        private System.Windows.Forms.TextBox txtMSC;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.Label lblBasic;
        private System.Windows.Forms.Label lblMSC;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblMSCMath;
        private System.Windows.Forms.Label lblMSCScience;
        private System.Windows.Forms.Label lblMajorSum;
        private System.Windows.Forms.Label lblMyMajorSum;
        private System.Windows.Forms.Label lblDesign;
        private System.Windows.Forms.Label lblSpecial;
        private System.Windows.Forms.Label lblMyDesign;
        private System.Windows.Forms.Label lblMySpecial;
        private System.Windows.Forms.Label lblMyRGC;
        private System.Windows.Forms.Label lblMyBasic;
        private System.Windows.Forms.Label lblMyMath;
        private System.Windows.Forms.Label lblMyScience;
    }
}

