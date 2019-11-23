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
            this.tableSubject = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableStandard = new System.Windows.Forms.TableLayoutPanel();
            this.lblMajorEng = new System.Windows.Forms.Label();
            this.lblTotalEng = new System.Windows.Forms.Label();
            this.lblToeic = new System.Windows.Forms.Label();
            this.lblMyMajorEng = new System.Windows.Forms.Label();
            this.lblMyTotalEng = new System.Windows.Forms.Label();
            this.lblMyToeic = new System.Windows.Forms.Label();
            this.lblPaper = new System.Windows.Forms.Label();
            this.lblEngineering = new System.Windows.Forms.Label();
            this.lblGraduate = new System.Windows.Forms.Label();
            this.lblMyPaper = new System.Windows.Forms.Label();
            this.lblMyEngineering = new System.Windows.Forms.Label();
            this.lblMyGraduate = new System.Windows.Forms.Label();
            this.tableStudentInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMyName = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblMyStudentId = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblMyClass = new System.Windows.Forms.Label();
            this.lblSubMajor = new System.Windows.Forms.Label();
            this.lblMySubMajor = new System.Windows.Forms.Label();
            this.tableSubject.SuspendLayout();
            this.tableStandard.SuspendLayout();
            this.tableStudentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDialog
            // 
            this.btnDialog.Location = new System.Drawing.Point(270, 98);
            this.btnDialog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDialog.Name = "btnDialog";
            this.btnDialog.Size = new System.Drawing.Size(86, 26);
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
            this.txtFileName.Size = new System.Drawing.Size(222, 21);
            this.txtFileName.TabIndex = 1;
            // 
            // btnExecution
            // 
            this.btnExecution.Location = new System.Drawing.Point(362, 98);
            this.btnExecution.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExecution.Name = "btnExecution";
            this.btnExecution.Size = new System.Drawing.Size(86, 26);
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
            this.lblInfo1.Size = new System.Drawing.Size(276, 12);
            this.lblInfo1.TabIndex = 3;
            this.lblInfo1.Text = "* 취득분류표는 uDrims > 학사정보 > 졸업 >\r\n";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblInfo2.Location = new System.Drawing.Point(51, 61);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(476, 12);
            this.lblInfo2.TabIndex = 4;
            this.lblInfo2.Text = "취득학점확인서조회(전학년) > 출력포함 - 수강신청포함 체크후 출력 하십시오.";
            // 
            // tableSubject
            // 
            this.tableSubject.ColumnCount = 8;
            this.tableSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableSubject.Controls.Add(this.lblCategory, 0, 0);
            this.tableSubject.Controls.Add(this.lblUnacquired, 7, 0);
            this.tableSubject.Controls.Add(this.lblRGC, 0, 1);
            this.tableSubject.Controls.Add(this.txtRGC, 7, 1);
            this.tableSubject.Controls.Add(this.txtBasic, 7, 2);
            this.tableSubject.Controls.Add(this.txtMSC, 7, 3);
            this.tableSubject.Controls.Add(this.txtMajor, 7, 5);
            this.tableSubject.Controls.Add(this.lblBasic, 0, 2);
            this.tableSubject.Controls.Add(this.lblMSC, 0, 3);
            this.tableSubject.Controls.Add(this.lblMajor, 0, 5);
            this.tableSubject.Controls.Add(this.lblGrade, 1, 0);
            this.tableSubject.Controls.Add(this.lblMSCMath, 1, 3);
            this.tableSubject.Controls.Add(this.lblMSCScience, 4, 3);
            this.tableSubject.Controls.Add(this.lblMajorSum, 1, 5);
            this.tableSubject.Controls.Add(this.lblMyMajorSum, 1, 6);
            this.tableSubject.Controls.Add(this.lblDesign, 3, 5);
            this.tableSubject.Controls.Add(this.lblSpecial, 5, 5);
            this.tableSubject.Controls.Add(this.lblMyDesign, 3, 6);
            this.tableSubject.Controls.Add(this.lblMySpecial, 5, 6);
            this.tableSubject.Controls.Add(this.lblMyRGC, 1, 1);
            this.tableSubject.Controls.Add(this.lblMyBasic, 1, 2);
            this.tableSubject.Controls.Add(this.lblMyMath, 1, 4);
            this.tableSubject.Controls.Add(this.lblMyScience, 4, 4);
            this.tableSubject.Location = new System.Drawing.Point(40, 161);
            this.tableSubject.Name = "tableSubject";
            this.tableSubject.RowCount = 7;
            this.tableSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableSubject.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSubject.Size = new System.Drawing.Size(812, 286);
            this.tableSubject.TabIndex = 5;
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
            this.lblRGC.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.txtMSC.Location = new System.Drawing.Point(333, 143);
            this.txtMSC.Multiline = true;
            this.txtMSC.Name = "txtMSC";
            this.tableSubject.SetRowSpan(this.txtMSC, 2);
            this.txtMSC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMSC.Size = new System.Drawing.Size(476, 64);
            this.txtMSC.TabIndex = 9;
            // 
            // txtMajor
            // 
            this.txtMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMajor.Location = new System.Drawing.Point(333, 213);
            this.txtMajor.Multiline = true;
            this.txtMajor.Name = "txtMajor";
            this.tableSubject.SetRowSpan(this.txtMajor, 2);
            this.txtMajor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMajor.Size = new System.Drawing.Size(476, 70);
            this.txtMajor.TabIndex = 10;
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBasic.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.lblMSC.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMSC.Location = new System.Drawing.Point(3, 140);
            this.lblMSC.Name = "lblMSC";
            this.tableSubject.SetRowSpan(this.lblMSC, 2);
            this.lblMSC.Size = new System.Drawing.Size(84, 70);
            this.lblMSC.TabIndex = 15;
            this.lblMSC.Text = "MSC";
            this.lblMSC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMajor.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMajor.Location = new System.Drawing.Point(3, 210);
            this.lblMajor.Name = "lblMajor";
            this.tableSubject.SetRowSpan(this.lblMajor, 2);
            this.lblMajor.Size = new System.Drawing.Size(84, 76);
            this.lblMajor.TabIndex = 16;
            this.lblMajor.Text = "전공필수";
            this.lblMajor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.tableSubject.SetColumnSpan(this.lblGrade, 6);
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
            this.tableSubject.SetColumnSpan(this.lblMSCMath, 3);
            this.lblMSCMath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMSCMath.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.tableSubject.SetColumnSpan(this.lblMSCScience, 3);
            this.lblMSCScience.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMSCScience.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.tableSubject.SetColumnSpan(this.lblMajorSum, 2);
            this.lblMajorSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMajorSum.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.tableSubject.SetColumnSpan(this.lblMyMajorSum, 2);
            this.lblMyMajorSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyMajorSum.Location = new System.Drawing.Point(93, 245);
            this.lblMyMajorSum.Name = "lblMyMajorSum";
            this.lblMyMajorSum.Size = new System.Drawing.Size(74, 41);
            this.lblMyMajorSum.TabIndex = 33;
            this.lblMyMajorSum.Text = "/ 84";
            this.lblMyMajorSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesign
            // 
            this.lblDesign.AutoSize = true;
            this.tableSubject.SetColumnSpan(this.lblDesign, 2);
            this.lblDesign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDesign.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.tableSubject.SetColumnSpan(this.lblSpecial, 2);
            this.lblSpecial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpecial.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.tableSubject.SetColumnSpan(this.lblMyDesign, 2);
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
            this.tableSubject.SetColumnSpan(this.lblMySpecial, 2);
            this.lblMySpecial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMySpecial.Location = new System.Drawing.Point(253, 245);
            this.lblMySpecial.Name = "lblMySpecial";
            this.lblMySpecial.Size = new System.Drawing.Size(74, 41);
            this.lblMySpecial.TabIndex = 37;
            this.lblMySpecial.Text = "/ 42";
            this.lblMySpecial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyRGC
            // 
            this.lblMyRGC.AutoSize = true;
            this.tableSubject.SetColumnSpan(this.lblMyRGC, 6);
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
            this.tableSubject.SetColumnSpan(this.lblMyBasic, 6);
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
            this.tableSubject.SetColumnSpan(this.lblMyMath, 3);
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
            this.tableSubject.SetColumnSpan(this.lblMyScience, 3);
            this.lblMyScience.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyScience.Location = new System.Drawing.Point(213, 175);
            this.lblMyScience.Name = "lblMyScience";
            this.lblMyScience.Size = new System.Drawing.Size(114, 35);
            this.lblMyScience.TabIndex = 41;
            this.lblMyScience.Text = "/ 16";
            this.lblMyScience.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableStandard
            // 
            this.tableStandard.ColumnCount = 4;
            this.tableStandard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableStandard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableStandard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableStandard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableStandard.Controls.Add(this.lblMajorEng, 0, 0);
            this.tableStandard.Controls.Add(this.lblTotalEng, 0, 1);
            this.tableStandard.Controls.Add(this.lblToeic, 0, 2);
            this.tableStandard.Controls.Add(this.lblMyMajorEng, 1, 0);
            this.tableStandard.Controls.Add(this.lblMyTotalEng, 1, 1);
            this.tableStandard.Controls.Add(this.lblMyToeic, 1, 2);
            this.tableStandard.Controls.Add(this.lblPaper, 2, 0);
            this.tableStandard.Controls.Add(this.lblEngineering, 2, 1);
            this.tableStandard.Controls.Add(this.lblGraduate, 2, 2);
            this.tableStandard.Controls.Add(this.lblMyPaper, 3, 0);
            this.tableStandard.Controls.Add(this.lblMyEngineering, 3, 1);
            this.tableStandard.Controls.Add(this.lblMyGraduate, 3, 2);
            this.tableStandard.Location = new System.Drawing.Point(40, 453);
            this.tableStandard.Name = "tableStandard";
            this.tableStandard.RowCount = 3;
            this.tableStandard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableStandard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableStandard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableStandard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableStandard.Size = new System.Drawing.Size(408, 151);
            this.tableStandard.TabIndex = 6;
            // 
            // lblMajorEng
            // 
            this.lblMajorEng.AutoSize = true;
            this.lblMajorEng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMajorEng.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMajorEng.Location = new System.Drawing.Point(3, 0);
            this.lblMajorEng.Name = "lblMajorEng";
            this.lblMajorEng.Size = new System.Drawing.Size(104, 50);
            this.lblMajorEng.TabIndex = 0;
            this.lblMajorEng.Text = "전공 영어 강의 수";
            this.lblMajorEng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalEng
            // 
            this.lblTotalEng.AutoSize = true;
            this.lblTotalEng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalEng.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalEng.Location = new System.Drawing.Point(3, 50);
            this.lblTotalEng.Name = "lblTotalEng";
            this.lblTotalEng.Size = new System.Drawing.Size(104, 50);
            this.lblTotalEng.TabIndex = 1;
            this.lblTotalEng.Text = "영어강의 전체 수";
            this.lblTotalEng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToeic
            // 
            this.lblToeic.AutoSize = true;
            this.lblToeic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToeic.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblToeic.Location = new System.Drawing.Point(3, 100);
            this.lblToeic.Name = "lblToeic";
            this.lblToeic.Size = new System.Drawing.Size(104, 51);
            this.lblToeic.TabIndex = 2;
            this.lblToeic.Text = "토익";
            this.lblToeic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyMajorEng
            // 
            this.lblMyMajorEng.AutoSize = true;
            this.lblMyMajorEng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyMajorEng.Location = new System.Drawing.Point(113, 0);
            this.lblMyMajorEng.Name = "lblMyMajorEng";
            this.lblMyMajorEng.Size = new System.Drawing.Size(104, 50);
            this.lblMyMajorEng.TabIndex = 3;
            this.lblMyMajorEng.Text = "/ 2";
            this.lblMyMajorEng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyTotalEng
            // 
            this.lblMyTotalEng.AutoSize = true;
            this.lblMyTotalEng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyTotalEng.Location = new System.Drawing.Point(113, 50);
            this.lblMyTotalEng.Name = "lblMyTotalEng";
            this.lblMyTotalEng.Size = new System.Drawing.Size(104, 50);
            this.lblMyTotalEng.TabIndex = 4;
            this.lblMyTotalEng.Text = "/ 4";
            this.lblMyTotalEng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyToeic
            // 
            this.lblMyToeic.AutoSize = true;
            this.lblMyToeic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyToeic.Location = new System.Drawing.Point(113, 100);
            this.lblMyToeic.Name = "lblMyToeic";
            this.lblMyToeic.Size = new System.Drawing.Size(104, 51);
            this.lblMyToeic.TabIndex = 5;
            this.lblMyToeic.Text = "o / x";
            this.lblMyToeic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaper
            // 
            this.lblPaper.AutoSize = true;
            this.lblPaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaper.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPaper.Location = new System.Drawing.Point(223, 0);
            this.lblPaper.Name = "lblPaper";
            this.lblPaper.Size = new System.Drawing.Size(104, 50);
            this.lblPaper.TabIndex = 6;
            this.lblPaper.Text = "논문";
            this.lblPaper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEngineering
            // 
            this.lblEngineering.AutoSize = true;
            this.lblEngineering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEngineering.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEngineering.Location = new System.Drawing.Point(223, 50);
            this.lblEngineering.Name = "lblEngineering";
            this.lblEngineering.Size = new System.Drawing.Size(104, 50);
            this.lblEngineering.TabIndex = 7;
            this.lblEngineering.Text = "공학인증";
            this.lblEngineering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGraduate
            // 
            this.lblGraduate.AutoSize = true;
            this.lblGraduate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGraduate.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGraduate.Location = new System.Drawing.Point(223, 100);
            this.lblGraduate.Name = "lblGraduate";
            this.lblGraduate.Size = new System.Drawing.Size(104, 51);
            this.lblGraduate.TabIndex = 8;
            this.lblGraduate.Text = "졸업";
            this.lblGraduate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyPaper
            // 
            this.lblMyPaper.AutoSize = true;
            this.lblMyPaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyPaper.Location = new System.Drawing.Point(333, 0);
            this.lblMyPaper.Name = "lblMyPaper";
            this.lblMyPaper.Size = new System.Drawing.Size(72, 50);
            this.lblMyPaper.TabIndex = 9;
            this.lblMyPaper.Text = "o / x";
            this.lblMyPaper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyEngineering
            // 
            this.lblMyEngineering.AutoSize = true;
            this.lblMyEngineering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyEngineering.Location = new System.Drawing.Point(333, 50);
            this.lblMyEngineering.Name = "lblMyEngineering";
            this.lblMyEngineering.Size = new System.Drawing.Size(72, 50);
            this.lblMyEngineering.TabIndex = 10;
            this.lblMyEngineering.Text = "x";
            this.lblMyEngineering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyGraduate
            // 
            this.lblMyGraduate.AutoSize = true;
            this.lblMyGraduate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyGraduate.Location = new System.Drawing.Point(333, 100);
            this.lblMyGraduate.Name = "lblMyGraduate";
            this.lblMyGraduate.Size = new System.Drawing.Size(72, 51);
            this.lblMyGraduate.TabIndex = 11;
            this.lblMyGraduate.Text = "x";
            this.lblMyGraduate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableStudentInfo
            // 
            this.tableStudentInfo.ColumnCount = 8;
            this.tableStudentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableStudentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableStudentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableStudentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableStudentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableStudentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableStudentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableStudentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableStudentInfo.Controls.Add(this.lblName, 0, 0);
            this.tableStudentInfo.Controls.Add(this.lblMyName, 1, 0);
            this.tableStudentInfo.Controls.Add(this.lblStudentId, 2, 0);
            this.tableStudentInfo.Controls.Add(this.lblMyStudentId, 3, 0);
            this.tableStudentInfo.Controls.Add(this.lblClass, 4, 0);
            this.tableStudentInfo.Controls.Add(this.lblMyClass, 5, 0);
            this.tableStudentInfo.Controls.Add(this.lblSubMajor, 6, 0);
            this.tableStudentInfo.Controls.Add(this.lblMySubMajor, 7, 0);
            this.tableStudentInfo.Location = new System.Drawing.Point(40, 127);
            this.tableStudentInfo.Name = "tableStudentInfo";
            this.tableStudentInfo.RowCount = 1;
            this.tableStudentInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableStudentInfo.Size = new System.Drawing.Size(516, 28);
            this.tableStudentInfo.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 28);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "이름";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyName
            // 
            this.lblMyName.AutoSize = true;
            this.lblMyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyName.Location = new System.Drawing.Point(53, 0);
            this.lblMyName.Name = "lblMyName";
            this.lblMyName.Size = new System.Drawing.Size(74, 28);
            this.lblMyName.TabIndex = 1;
            this.lblMyName.Text = "홍길동";
            this.lblMyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStudentId.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStudentId.Location = new System.Drawing.Point(133, 0);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(44, 28);
            this.lblStudentId.TabIndex = 2;
            this.lblStudentId.Text = "학번";
            this.lblStudentId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyStudentId
            // 
            this.lblMyStudentId.AutoSize = true;
            this.lblMyStudentId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyStudentId.Location = new System.Drawing.Point(183, 0);
            this.lblMyStudentId.Name = "lblMyStudentId";
            this.lblMyStudentId.Size = new System.Drawing.Size(114, 28);
            this.lblMyStudentId.TabIndex = 3;
            this.lblMyStudentId.Text = "2017000000";
            this.lblMyStudentId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClass.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClass.Location = new System.Drawing.Point(303, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(44, 28);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "학년";
            this.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyClass
            // 
            this.lblMyClass.AutoSize = true;
            this.lblMyClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyClass.Location = new System.Drawing.Point(353, 0);
            this.lblMyClass.Name = "lblMyClass";
            this.lblMyClass.Size = new System.Drawing.Size(44, 28);
            this.lblMyClass.TabIndex = 5;
            this.lblMyClass.Text = "1";
            this.lblMyClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubMajor
            // 
            this.lblSubMajor.AutoSize = true;
            this.lblSubMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubMajor.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSubMajor.Location = new System.Drawing.Point(403, 0);
            this.lblSubMajor.Name = "lblSubMajor";
            this.lblSubMajor.Size = new System.Drawing.Size(74, 28);
            this.lblSubMajor.TabIndex = 6;
            this.lblSubMajor.Text = "복수전공";
            this.lblSubMajor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMySubMajor
            // 
            this.lblMySubMajor.AutoSize = true;
            this.lblMySubMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMySubMajor.Location = new System.Drawing.Point(483, 0);
            this.lblMySubMajor.Name = "lblMySubMajor";
            this.lblMySubMajor.Size = new System.Drawing.Size(33, 28);
            this.lblMySubMajor.TabIndex = 7;
            this.lblMySubMajor.Text = "o / x";
            this.lblMySubMajor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(892, 628);
            this.Controls.Add(this.tableStudentInfo);
            this.Controls.Add(this.tableStandard);
            this.Controls.Add(this.tableSubject);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.btnExecution);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnDialog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "자동 졸업사정 시스템";
            this.tableSubject.ResumeLayout(false);
            this.tableSubject.PerformLayout();
            this.tableStandard.ResumeLayout(false);
            this.tableStandard.PerformLayout();
            this.tableStudentInfo.ResumeLayout(false);
            this.tableStudentInfo.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableSubject;
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
        private System.Windows.Forms.TableLayoutPanel tableStandard;
        private System.Windows.Forms.Label lblMajorEng;
        private System.Windows.Forms.Label lblTotalEng;
        private System.Windows.Forms.Label lblToeic;
        private System.Windows.Forms.Label lblMyMajorEng;
        private System.Windows.Forms.Label lblMyTotalEng;
        private System.Windows.Forms.Label lblMyToeic;
        private System.Windows.Forms.Label lblPaper;
        private System.Windows.Forms.Label lblEngineering;
        private System.Windows.Forms.Label lblGraduate;
        private System.Windows.Forms.Label lblMyPaper;
        private System.Windows.Forms.Label lblMyEngineering;
        private System.Windows.Forms.Label lblMyGraduate;
        private System.Windows.Forms.TableLayoutPanel tableStudentInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMyName;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblMyStudentId;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblMyClass;
        private System.Windows.Forms.Label lblSubMajor;
        private System.Windows.Forms.Label lblMySubMajor;
    }
}

