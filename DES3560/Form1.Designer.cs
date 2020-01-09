namespace DES3560
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnDialog = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnExecution = new System.Windows.Forms.Button();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.tableSubject = new System.Windows.Forms.TableLayoutPanel();
            this.txtMSC = new System.Windows.Forms.TextBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.lblMSC = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblMSCMath = new System.Windows.Forms.Label();
            this.lblMSCScience = new System.Windows.Forms.Label();
            this.lblMajorSum = new System.Windows.Forms.Label();
            this.lblMyMajorSum = new System.Windows.Forms.Label();
            this.lblDesign = new System.Windows.Forms.Label();
            this.lblSpecial = new System.Windows.Forms.Label();
            this.lblMyDesign = new System.Windows.Forms.Label();
            this.lblMySpecial = new System.Windows.Forms.Label();
            this.lblMyMath = new System.Windows.Forms.Label();
            this.lblMyScience = new System.Windows.Forms.Label();
            this.lblIsMSCPass = new System.Windows.Forms.Label();
            this.lblIsMajorPass = new System.Windows.Forms.Label();
            this.tableStandard = new System.Windows.Forms.TableLayoutPanel();
            this.lblMyGraduate = new System.Windows.Forms.Label();
            this.lblGraduate = new System.Windows.Forms.Label();
            this.lblMyEngineering = new System.Windows.Forms.Label();
            this.lblEngineering = new System.Windows.Forms.Label();
            this.lblMajorEng = new System.Windows.Forms.Label();
            this.lblTotalEng = new System.Windows.Forms.Label();
            this.lblToeic = new System.Windows.Forms.Label();
            this.lblMyMajorEng = new System.Windows.Forms.Label();
            this.lblMyTotalEng = new System.Windows.Forms.Label();
            this.lblMyToeic = new System.Windows.Forms.Label();
            this.lblAllGrade = new System.Windows.Forms.Label();
            this.lblGPA = new System.Windows.Forms.Label();
            this.lblPaper = new System.Windows.Forms.Label();
            this.lblMyAllGrade = new System.Windows.Forms.Label();
            this.lblMyGPA = new System.Windows.Forms.Label();
            this.lblMyPaper = new System.Windows.Forms.Label();
            this.tableStudentInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMyName = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblMyStudentId = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblMyClass = new System.Windows.Forms.Label();
            this.lblMyMajor = new System.Windows.Forms.Label();
            this.lblMyMajor2 = new System.Windows.Forms.Label();
            this.lblCurriYear = new System.Windows.Forms.Label();
            this.lblMyCurriYear = new System.Windows.Forms.Label();
            this.lblIsEngineering = new System.Windows.Forms.Label();
            this.lblMyIsEngineering = new System.Windows.Forms.Label();
            this.tableStudentInfoException = new System.Windows.Forms.TableLayoutPanel();
            this.lblMinor = new System.Windows.Forms.Label();
            this.lblMyMinor = new System.Windows.Forms.Label();
            this.lblSubmajor = new System.Windows.Forms.Label();
            this.lblMySubmajor = new System.Windows.Forms.Label();
            this.lblCampusTransfer = new System.Windows.Forms.Label();
            this.lblMyCampusTransfer = new System.Windows.Forms.Label();
            this.lblFormalUniv = new System.Windows.Forms.Label();
            this.lblMyFormalUniv = new System.Windows.Forms.Label();
            this.lblPrevMajor = new System.Windows.Forms.Label();
            this.lblMyPrevMajor = new System.Windows.Forms.Label();
            this.tableHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblIsPass = new System.Windows.Forms.Label();
            this.lblUnacquired = new System.Windows.Forms.Label();
            this.tableRGC = new System.Windows.Forms.TableLayoutPanel();
            this.tableBasic = new System.Windows.Forms.TableLayoutPanel();
            this.lblRGC = new System.Windows.Forms.Label();
            this.lblMyRGC = new System.Windows.Forms.Label();
            this.lblRGCStandard = new System.Windows.Forms.Label();
            this.lblRGCPass = new System.Windows.Forms.Label();
            this.txtRGC = new System.Windows.Forms.TextBox();
            this.lblBasic = new System.Windows.Forms.Label();
            this.lblMyBasic = new System.Windows.Forms.Label();
            this.lblBasicStandard = new System.Windows.Forms.Label();
            this.lblBasicPass = new System.Windows.Forms.Label();
            this.txtBasic = new System.Windows.Forms.TextBox();
            this.tableSubject.SuspendLayout();
            this.tableStandard.SuspendLayout();
            this.tableStudentInfo.SuspendLayout();
            this.tableStudentInfoException.SuspendLayout();
            this.tableHeader.SuspendLayout();
            this.tableRGC.SuspendLayout();
            this.tableBasic.SuspendLayout();
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
            this.txtFileName.Size = new System.Drawing.Size(222, 25);
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
            this.lblInfo2.Size = new System.Drawing.Size(630, 15);
            this.lblInfo2.TabIndex = 4;
            this.lblInfo2.Text = "취득학점확인서조회(전학년) > 출력포함 - 수강신청포함 체크후 pdf로 출력 하십시오.";
            // 
            // tableSubject
            // 
            this.tableSubject.ColumnCount = 9;
            this.tableSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableSubject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableSubject.Controls.Add(this.txtMSC, 8, 2);
            this.tableSubject.Controls.Add(this.txtMajor, 8, 4);
            this.tableSubject.Controls.Add(this.lblMSC, 0, 2);
            this.tableSubject.Controls.Add(this.lblMajor, 0, 4);
            this.tableSubject.Controls.Add(this.lblMSCMath, 1, 2);
            this.tableSubject.Controls.Add(this.lblMSCScience, 4, 2);
            this.tableSubject.Controls.Add(this.lblMajorSum, 1, 4);
            this.tableSubject.Controls.Add(this.lblMyMajorSum, 1, 5);
            this.tableSubject.Controls.Add(this.lblDesign, 3, 4);
            this.tableSubject.Controls.Add(this.lblSpecial, 5, 4);
            this.tableSubject.Controls.Add(this.lblMyDesign, 3, 5);
            this.tableSubject.Controls.Add(this.lblMySpecial, 5, 5);
            this.tableSubject.Controls.Add(this.lblMyMath, 1, 3);
            this.tableSubject.Controls.Add(this.lblMyScience, 4, 3);
            this.tableSubject.Controls.Add(this.lblIsMSCPass, 7, 2);
            this.tableSubject.Controls.Add(this.lblIsMajorPass, 7, 4);
            this.tableSubject.Location = new System.Drawing.Point(40, 607);
            this.tableSubject.Name = "tableSubject";
            this.tableSubject.RowCount = 6;
            this.tableSubject.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSubject.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableSubject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableSubject.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableSubject.Size = new System.Drawing.Size(1084, 259);
            this.tableSubject.TabIndex = 5;
            // 
            // txtMSC
            // 
            this.txtMSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMSC.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMSC.Location = new System.Drawing.Point(453, 143);
            this.txtMSC.Multiline = true;
            this.txtMSC.Name = "txtMSC";
            this.tableSubject.SetRowSpan(this.txtMSC, 2);
            this.txtMSC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMSC.Size = new System.Drawing.Size(628, 64);
            this.txtMSC.TabIndex = 9;
            // 
            // txtMajor
            // 
            this.txtMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMajor.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMajor.Location = new System.Drawing.Point(453, 213);
            this.txtMajor.Multiline = true;
            this.txtMajor.Name = "txtMajor";
            this.tableSubject.SetRowSpan(this.txtMajor, 2);
            this.txtMajor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMajor.Size = new System.Drawing.Size(628, 70);
            this.txtMajor.TabIndex = 10;
            // 
            // lblMSC
            // 
            this.lblMSC.AutoSize = true;
            this.lblMSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMSC.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMSC.Location = new System.Drawing.Point(3, 140);
            this.lblMSC.Name = "lblMSC";
            this.tableSubject.SetRowSpan(this.lblMSC, 2);
            this.lblMSC.Size = new System.Drawing.Size(94, 70);
            this.lblMSC.TabIndex = 15;
            this.lblMSC.Text = "MSC";
            this.lblMSC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMajor.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMajor.Location = new System.Drawing.Point(3, 210);
            this.lblMajor.Name = "lblMajor";
            this.tableSubject.SetRowSpan(this.lblMajor, 2);
            this.lblMajor.Size = new System.Drawing.Size(94, 76);
            this.lblMajor.TabIndex = 16;
            this.lblMajor.Text = "전공필수";
            this.lblMajor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMSCMath
            // 
            this.lblMSCMath.AutoSize = true;
            this.tableSubject.SetColumnSpan(this.lblMSCMath, 3);
            this.lblMSCMath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMSCMath.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMSCMath.Location = new System.Drawing.Point(103, 140);
            this.lblMSCMath.Name = "lblMSCMath";
            this.lblMSCMath.Size = new System.Drawing.Size(144, 35);
            this.lblMSCMath.TabIndex = 24;
            this.lblMSCMath.Text = "수학";
            this.lblMSCMath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMSCScience
            // 
            this.lblMSCScience.AutoSize = true;
            this.tableSubject.SetColumnSpan(this.lblMSCScience, 3);
            this.lblMSCScience.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMSCScience.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMSCScience.Location = new System.Drawing.Point(253, 140);
            this.lblMSCScience.Name = "lblMSCScience";
            this.lblMSCScience.Size = new System.Drawing.Size(144, 35);
            this.lblMSCScience.TabIndex = 25;
            this.lblMSCScience.Text = "과학";
            this.lblMSCScience.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMajorSum
            // 
            this.lblMajorSum.AutoSize = true;
            this.tableSubject.SetColumnSpan(this.lblMajorSum, 2);
            this.lblMajorSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMajorSum.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMajorSum.Location = new System.Drawing.Point(103, 210);
            this.lblMajorSum.Name = "lblMajorSum";
            this.lblMajorSum.Size = new System.Drawing.Size(94, 35);
            this.lblMajorSum.TabIndex = 32;
            this.lblMajorSum.Text = "총 학점";
            this.lblMajorSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyMajorSum
            // 
            this.lblMyMajorSum.AutoSize = true;
            this.tableSubject.SetColumnSpan(this.lblMyMajorSum, 2);
            this.lblMyMajorSum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyMajorSum.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyMajorSum.Location = new System.Drawing.Point(103, 245);
            this.lblMyMajorSum.Name = "lblMyMajorSum";
            this.lblMyMajorSum.Size = new System.Drawing.Size(94, 41);
            this.lblMyMajorSum.TabIndex = 33;
            this.lblMyMajorSum.Text = "90 / 84";
            this.lblMyMajorSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesign
            // 
            this.lblDesign.AutoSize = true;
            this.tableSubject.SetColumnSpan(this.lblDesign, 2);
            this.lblDesign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDesign.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDesign.Location = new System.Drawing.Point(203, 210);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(94, 35);
            this.lblDesign.TabIndex = 34;
            this.lblDesign.Text = "설계";
            this.lblDesign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSpecial
            // 
            this.lblSpecial.AutoSize = true;
            this.tableSubject.SetColumnSpan(this.lblSpecial, 2);
            this.lblSpecial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpecial.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSpecial.Location = new System.Drawing.Point(303, 210);
            this.lblSpecial.Name = "lblSpecial";
            this.lblSpecial.Size = new System.Drawing.Size(94, 35);
            this.lblSpecial.TabIndex = 35;
            this.lblSpecial.Text = "전문";
            this.lblSpecial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyDesign
            // 
            this.lblMyDesign.AutoSize = true;
            this.tableSubject.SetColumnSpan(this.lblMyDesign, 2);
            this.lblMyDesign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyDesign.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyDesign.Location = new System.Drawing.Point(203, 245);
            this.lblMyDesign.Name = "lblMyDesign";
            this.lblMyDesign.Size = new System.Drawing.Size(94, 41);
            this.lblMyDesign.TabIndex = 36;
            this.lblMyDesign.Text = "15 / 12";
            this.lblMyDesign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMySpecial
            // 
            this.lblMySpecial.AutoSize = true;
            this.tableSubject.SetColumnSpan(this.lblMySpecial, 2);
            this.lblMySpecial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMySpecial.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMySpecial.Location = new System.Drawing.Point(303, 245);
            this.lblMySpecial.Name = "lblMySpecial";
            this.lblMySpecial.Size = new System.Drawing.Size(94, 41);
            this.lblMySpecial.TabIndex = 37;
            this.lblMySpecial.Text = "/ 42";
            this.lblMySpecial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyMath
            // 
            this.lblMyMath.AutoSize = true;
            this.tableSubject.SetColumnSpan(this.lblMyMath, 3);
            this.lblMyMath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyMath.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyMath.Location = new System.Drawing.Point(103, 175);
            this.lblMyMath.Name = "lblMyMath";
            this.lblMyMath.Size = new System.Drawing.Size(144, 35);
            this.lblMyMath.TabIndex = 40;
            this.lblMyMath.Text = "/ 12";
            this.lblMyMath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyScience
            // 
            this.lblMyScience.AutoSize = true;
            this.tableSubject.SetColumnSpan(this.lblMyScience, 3);
            this.lblMyScience.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyScience.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyScience.Location = new System.Drawing.Point(253, 175);
            this.lblMyScience.Name = "lblMyScience";
            this.lblMyScience.Size = new System.Drawing.Size(144, 35);
            this.lblMyScience.TabIndex = 41;
            this.lblMyScience.Text = "/ 16";
            this.lblMyScience.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIsMSCPass
            // 
            this.lblIsMSCPass.AutoSize = true;
            this.lblIsMSCPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIsMSCPass.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIsMSCPass.Location = new System.Drawing.Point(403, 140);
            this.lblIsMSCPass.Name = "lblIsMSCPass";
            this.tableSubject.SetRowSpan(this.lblIsMSCPass, 2);
            this.lblIsMSCPass.Size = new System.Drawing.Size(44, 70);
            this.lblIsMSCPass.TabIndex = 45;
            this.lblIsMSCPass.Text = "P";
            this.lblIsMSCPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIsMajorPass
            // 
            this.lblIsMajorPass.AutoSize = true;
            this.lblIsMajorPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIsMajorPass.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIsMajorPass.Location = new System.Drawing.Point(403, 210);
            this.lblIsMajorPass.Name = "lblIsMajorPass";
            this.tableSubject.SetRowSpan(this.lblIsMajorPass, 2);
            this.lblIsMajorPass.Size = new System.Drawing.Size(44, 76);
            this.lblIsMajorPass.TabIndex = 46;
            this.lblIsMajorPass.Text = "P";
            this.lblIsMajorPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableStandard
            // 
            this.tableStandard.ColumnCount = 6;
            this.tableStandard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableStandard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableStandard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableStandard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableStandard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableStandard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableStandard.Controls.Add(this.lblMyGraduate, 5, 1);
            this.tableStandard.Controls.Add(this.lblGraduate, 4, 1);
            this.tableStandard.Controls.Add(this.lblMyEngineering, 5, 0);
            this.tableStandard.Controls.Add(this.lblEngineering, 4, 0);
            this.tableStandard.Controls.Add(this.lblMajorEng, 0, 0);
            this.tableStandard.Controls.Add(this.lblTotalEng, 0, 1);
            this.tableStandard.Controls.Add(this.lblToeic, 0, 2);
            this.tableStandard.Controls.Add(this.lblMyMajorEng, 1, 0);
            this.tableStandard.Controls.Add(this.lblMyTotalEng, 1, 1);
            this.tableStandard.Controls.Add(this.lblMyToeic, 1, 2);
            this.tableStandard.Controls.Add(this.lblAllGrade, 2, 0);
            this.tableStandard.Controls.Add(this.lblGPA, 2, 1);
            this.tableStandard.Controls.Add(this.lblPaper, 2, 2);
            this.tableStandard.Controls.Add(this.lblMyAllGrade, 3, 0);
            this.tableStandard.Controls.Add(this.lblMyGPA, 3, 1);
            this.tableStandard.Controls.Add(this.lblMyPaper, 3, 2);
            this.tableStandard.Location = new System.Drawing.Point(41, 892);
            this.tableStandard.Name = "tableStandard";
            this.tableStandard.RowCount = 3;
            this.tableStandard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableStandard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableStandard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableStandard.Size = new System.Drawing.Size(649, 151);
            this.tableStandard.TabIndex = 6;
            // 
            // lblMyGraduate
            // 
            this.lblMyGraduate.AutoSize = true;
            this.lblMyGraduate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyGraduate.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyGraduate.Location = new System.Drawing.Point(553, 50);
            this.lblMyGraduate.Name = "lblMyGraduate";
            this.lblMyGraduate.Size = new System.Drawing.Size(93, 50);
            this.lblMyGraduate.TabIndex = 21;
            this.lblMyGraduate.Text = "S";
            this.lblMyGraduate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGraduate
            // 
            this.lblGraduate.AutoSize = true;
            this.lblGraduate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGraduate.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGraduate.Location = new System.Drawing.Point(443, 50);
            this.lblGraduate.Name = "lblGraduate";
            this.lblGraduate.Size = new System.Drawing.Size(104, 50);
            this.lblGraduate.TabIndex = 20;
            this.lblGraduate.Text = "졸업";
            this.lblGraduate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyEngineering
            // 
            this.lblMyEngineering.AutoSize = true;
            this.lblMyEngineering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyEngineering.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyEngineering.Location = new System.Drawing.Point(553, 0);
            this.lblMyEngineering.Name = "lblMyEngineering";
            this.lblMyEngineering.Size = new System.Drawing.Size(93, 50);
            this.lblMyEngineering.TabIndex = 19;
            this.lblMyEngineering.Text = "x";
            this.lblMyEngineering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEngineering
            // 
            this.lblEngineering.AutoSize = true;
            this.lblEngineering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEngineering.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblEngineering.Location = new System.Drawing.Point(443, 0);
            this.lblEngineering.Name = "lblEngineering";
            this.lblEngineering.Size = new System.Drawing.Size(104, 50);
            this.lblEngineering.TabIndex = 18;
            this.lblEngineering.Text = "공학인증";
            this.lblEngineering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMajorEng
            // 
            this.lblMajorEng.AutoSize = true;
            this.lblMajorEng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMajorEng.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMajorEng.Location = new System.Drawing.Point(3, 0);
            this.lblMajorEng.Name = "lblMajorEng";
            this.lblMajorEng.Size = new System.Drawing.Size(104, 50);
            this.lblMajorEng.TabIndex = 0;
            this.lblMajorEng.Text = "전공\r\n영어강의 수";
            this.lblMajorEng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalEng
            // 
            this.lblTotalEng.AutoSize = true;
            this.lblTotalEng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalEng.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalEng.Location = new System.Drawing.Point(3, 50);
            this.lblTotalEng.Name = "lblTotalEng";
            this.lblTotalEng.Size = new System.Drawing.Size(104, 50);
            this.lblTotalEng.TabIndex = 1;
            this.lblTotalEng.Text = "영어강의\r\n전체 수";
            this.lblTotalEng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToeic
            // 
            this.lblToeic.AutoSize = true;
            this.lblToeic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToeic.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.lblMyMajorEng.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.lblMyTotalEng.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
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
            this.lblMyToeic.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyToeic.Location = new System.Drawing.Point(113, 100);
            this.lblMyToeic.Name = "lblMyToeic";
            this.lblMyToeic.Size = new System.Drawing.Size(104, 51);
            this.lblMyToeic.TabIndex = 5;
            this.lblMyToeic.Text = "o / x";
            this.lblMyToeic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAllGrade
            // 
            this.lblAllGrade.AutoSize = true;
            this.lblAllGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAllGrade.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAllGrade.Location = new System.Drawing.Point(223, 0);
            this.lblAllGrade.Name = "lblAllGrade";
            this.lblAllGrade.Size = new System.Drawing.Size(104, 50);
            this.lblAllGrade.TabIndex = 12;
            this.lblAllGrade.Text = "총 취득학점";
            this.lblAllGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGPA.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGPA.Location = new System.Drawing.Point(223, 50);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(104, 50);
            this.lblGPA.TabIndex = 13;
            this.lblGPA.Text = "평균평점";
            this.lblGPA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaper
            // 
            this.lblPaper.AutoSize = true;
            this.lblPaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPaper.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPaper.Location = new System.Drawing.Point(223, 100);
            this.lblPaper.Name = "lblPaper";
            this.lblPaper.Size = new System.Drawing.Size(104, 51);
            this.lblPaper.TabIndex = 14;
            this.lblPaper.Text = "논문";
            this.lblPaper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyAllGrade
            // 
            this.lblMyAllGrade.AutoSize = true;
            this.lblMyAllGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyAllGrade.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyAllGrade.Location = new System.Drawing.Point(333, 0);
            this.lblMyAllGrade.Name = "lblMyAllGrade";
            this.lblMyAllGrade.Size = new System.Drawing.Size(104, 50);
            this.lblMyAllGrade.TabIndex = 15;
            this.lblMyAllGrade.Text = "/ 140";
            this.lblMyAllGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyGPA
            // 
            this.lblMyGPA.AutoSize = true;
            this.lblMyGPA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyGPA.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyGPA.Location = new System.Drawing.Point(333, 50);
            this.lblMyGPA.Name = "lblMyGPA";
            this.lblMyGPA.Size = new System.Drawing.Size(104, 50);
            this.lblMyGPA.TabIndex = 16;
            this.lblMyGPA.Text = "3.5";
            this.lblMyGPA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyPaper
            // 
            this.lblMyPaper.AutoSize = true;
            this.lblMyPaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyPaper.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyPaper.Location = new System.Drawing.Point(333, 100);
            this.lblMyPaper.Name = "lblMyPaper";
            this.lblMyPaper.Size = new System.Drawing.Size(104, 51);
            this.lblMyPaper.TabIndex = 17;
            this.lblMyPaper.Text = "o / x";
            this.lblMyPaper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableStudentInfo
            // 
            this.tableStudentInfo.ColumnCount = 8;
            this.tableStudentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableStudentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableStudentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableStudentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableStudentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableStudentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableStudentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableStudentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableStudentInfo.Controls.Add(this.lblName, 0, 0);
            this.tableStudentInfo.Controls.Add(this.lblMyName, 1, 0);
            this.tableStudentInfo.Controls.Add(this.lblStudentId, 2, 0);
            this.tableStudentInfo.Controls.Add(this.lblMyStudentId, 3, 0);
            this.tableStudentInfo.Controls.Add(this.lblClass, 4, 0);
            this.tableStudentInfo.Controls.Add(this.lblMyClass, 5, 0);
            this.tableStudentInfo.Controls.Add(this.lblMyMajor, 6, 0);
            this.tableStudentInfo.Controls.Add(this.lblMyMajor2, 7, 0);
            this.tableStudentInfo.Controls.Add(this.lblCurriYear, 0, 1);
            this.tableStudentInfo.Controls.Add(this.lblMyCurriYear, 3, 1);
            this.tableStudentInfo.Controls.Add(this.lblIsEngineering, 4, 1);
            this.tableStudentInfo.Controls.Add(this.lblMyIsEngineering, 7, 1);
            this.tableStudentInfo.Location = new System.Drawing.Point(40, 127);
            this.tableStudentInfo.Name = "tableStudentInfo";
            this.tableStudentInfo.RowCount = 2;
            this.tableStudentInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableStudentInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableStudentInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableStudentInfo.Size = new System.Drawing.Size(812, 91);
            this.tableStudentInfo.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 41);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "이름";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyName
            // 
            this.lblMyName.AutoSize = true;
            this.lblMyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyName.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyName.Location = new System.Drawing.Point(63, 0);
            this.lblMyName.Name = "lblMyName";
            this.lblMyName.Size = new System.Drawing.Size(74, 41);
            this.lblMyName.TabIndex = 1;
            this.lblMyName.Text = "홍길동";
            this.lblMyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStudentId.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStudentId.Location = new System.Drawing.Point(143, 0);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(54, 41);
            this.lblStudentId.TabIndex = 2;
            this.lblStudentId.Text = "학번";
            this.lblStudentId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyStudentId
            // 
            this.lblMyStudentId.AutoSize = true;
            this.lblMyStudentId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyStudentId.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyStudentId.Location = new System.Drawing.Point(203, 0);
            this.lblMyStudentId.Name = "lblMyStudentId";
            this.lblMyStudentId.Size = new System.Drawing.Size(144, 41);
            this.lblMyStudentId.TabIndex = 3;
            this.lblMyStudentId.Text = "2017000000";
            this.lblMyStudentId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClass.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblClass.Location = new System.Drawing.Point(353, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(54, 41);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "학년";
            this.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyClass
            // 
            this.lblMyClass.AutoSize = true;
            this.lblMyClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyClass.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyClass.Location = new System.Drawing.Point(413, 0);
            this.lblMyClass.Name = "lblMyClass";
            this.lblMyClass.Size = new System.Drawing.Size(44, 41);
            this.lblMyClass.TabIndex = 5;
            this.lblMyClass.Text = "1";
            this.lblMyClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyMajor
            // 
            this.lblMyMajor.AutoSize = true;
            this.lblMyMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyMajor.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyMajor.Location = new System.Drawing.Point(463, 0);
            this.lblMyMajor.Name = "lblMyMajor";
            this.lblMyMajor.Size = new System.Drawing.Size(54, 41);
            this.lblMyMajor.TabIndex = 6;
            this.lblMyMajor.Text = "학과";
            this.lblMyMajor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyMajor2
            // 
            this.lblMyMajor2.AutoSize = true;
            this.lblMyMajor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyMajor2.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyMajor2.Location = new System.Drawing.Point(523, 0);
            this.lblMyMajor2.Name = "lblMyMajor2";
            this.lblMyMajor2.Size = new System.Drawing.Size(286, 41);
            this.lblMyMajor2.TabIndex = 7;
            this.lblMyMajor2.Text = "컴퓨터공학과";
            this.lblMyMajor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurriYear
            // 
            this.lblCurriYear.AutoSize = true;
            this.tableStudentInfo.SetColumnSpan(this.lblCurriYear, 3);
            this.lblCurriYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurriYear.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCurriYear.Location = new System.Drawing.Point(3, 41);
            this.lblCurriYear.Name = "lblCurriYear";
            this.lblCurriYear.Size = new System.Drawing.Size(194, 50);
            this.lblCurriYear.TabIndex = 8;
            this.lblCurriYear.Text = "교육과정 적용년도";
            this.lblCurriYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyCurriYear
            // 
            this.lblMyCurriYear.AutoSize = true;
            this.lblMyCurriYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyCurriYear.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyCurriYear.Location = new System.Drawing.Point(203, 41);
            this.lblMyCurriYear.Name = "lblMyCurriYear";
            this.lblMyCurriYear.Size = new System.Drawing.Size(144, 50);
            this.lblMyCurriYear.TabIndex = 9;
            this.lblMyCurriYear.Text = "2017";
            this.lblMyCurriYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIsEngineering
            // 
            this.lblIsEngineering.AutoSize = true;
            this.tableStudentInfo.SetColumnSpan(this.lblIsEngineering, 3);
            this.lblIsEngineering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIsEngineering.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIsEngineering.Location = new System.Drawing.Point(353, 41);
            this.lblIsEngineering.Name = "lblIsEngineering";
            this.lblIsEngineering.Size = new System.Drawing.Size(164, 50);
            this.lblIsEngineering.TabIndex = 10;
            this.lblIsEngineering.Text = "공학인증심화대상";
            this.lblIsEngineering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyIsEngineering
            // 
            this.lblMyIsEngineering.AutoSize = true;
            this.lblMyIsEngineering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyIsEngineering.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyIsEngineering.Location = new System.Drawing.Point(523, 41);
            this.lblMyIsEngineering.Name = "lblMyIsEngineering";
            this.lblMyIsEngineering.Size = new System.Drawing.Size(286, 50);
            this.lblMyIsEngineering.TabIndex = 11;
            this.lblMyIsEngineering.Text = "Y / N";
            this.lblMyIsEngineering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableStudentInfoException
            // 
            this.tableStudentInfoException.ColumnCount = 8;
            this.tableStudentInfoException.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableStudentInfoException.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableStudentInfoException.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableStudentInfoException.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableStudentInfoException.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableStudentInfoException.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableStudentInfoException.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableStudentInfoException.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableStudentInfoException.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableStudentInfoException.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableStudentInfoException.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableStudentInfoException.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableStudentInfoException.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableStudentInfoException.Controls.Add(this.lblMinor, 0, 0);
            this.tableStudentInfoException.Controls.Add(this.lblMyMinor, 2, 0);
            this.tableStudentInfoException.Controls.Add(this.lblSubmajor, 4, 0);
            this.tableStudentInfoException.Controls.Add(this.lblMySubmajor, 6, 0);
            this.tableStudentInfoException.Controls.Add(this.lblCampusTransfer, 0, 1);
            this.tableStudentInfoException.Controls.Add(this.lblMyCampusTransfer, 2, 1);
            this.tableStudentInfoException.Controls.Add(this.lblFormalUniv, 4, 1);
            this.tableStudentInfoException.Controls.Add(this.lblMyFormalUniv, 6, 1);
            this.tableStudentInfoException.Controls.Add(this.lblPrevMajor, 0, 2);
            this.tableStudentInfoException.Controls.Add(this.lblMyPrevMajor, 2, 2);
            this.tableStudentInfoException.Location = new System.Drawing.Point(40, 221);
            this.tableStudentInfoException.Name = "tableStudentInfoException";
            this.tableStudentInfoException.RowCount = 3;
            this.tableStudentInfoException.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableStudentInfoException.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableStudentInfoException.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableStudentInfoException.Size = new System.Drawing.Size(811, 150);
            this.tableStudentInfoException.TabIndex = 8;
            // 
            // lblMinor
            // 
            this.lblMinor.AutoSize = true;
            this.tableStudentInfoException.SetColumnSpan(this.lblMinor, 2);
            this.lblMinor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMinor.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMinor.Location = new System.Drawing.Point(3, 0);
            this.lblMinor.Name = "lblMinor";
            this.lblMinor.Size = new System.Drawing.Size(134, 50);
            this.lblMinor.TabIndex = 0;
            this.lblMinor.Text = "부전공";
            this.lblMinor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyMinor
            // 
            this.lblMyMinor.AutoSize = true;
            this.tableStudentInfoException.SetColumnSpan(this.lblMyMinor, 2);
            this.lblMyMinor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyMinor.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyMinor.Location = new System.Drawing.Point(143, 0);
            this.lblMyMinor.Name = "lblMyMinor";
            this.lblMyMinor.Size = new System.Drawing.Size(204, 50);
            this.lblMyMinor.TabIndex = 1;
            this.lblMyMinor.Text = "컴퓨터공학전공(2017)";
            this.lblMyMinor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubmajor
            // 
            this.lblSubmajor.AutoSize = true;
            this.tableStudentInfoException.SetColumnSpan(this.lblSubmajor, 2);
            this.lblSubmajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubmajor.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSubmajor.Location = new System.Drawing.Point(353, 0);
            this.lblSubmajor.Name = "lblSubmajor";
            this.lblSubmajor.Size = new System.Drawing.Size(134, 50);
            this.lblSubmajor.TabIndex = 2;
            this.lblSubmajor.Text = "복수전공";
            this.lblSubmajor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMySubmajor
            // 
            this.lblMySubmajor.AutoSize = true;
            this.tableStudentInfoException.SetColumnSpan(this.lblMySubmajor, 2);
            this.lblMySubmajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMySubmajor.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMySubmajor.Location = new System.Drawing.Point(493, 0);
            this.lblMySubmajor.Name = "lblMySubmajor";
            this.lblMySubmajor.Size = new System.Drawing.Size(315, 50);
            this.lblMySubmajor.TabIndex = 3;
            this.lblMySubmajor.Text = "컴퓨터공학전공(2017)";
            this.lblMySubmajor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCampusTransfer
            // 
            this.lblCampusTransfer.AutoSize = true;
            this.tableStudentInfoException.SetColumnSpan(this.lblCampusTransfer, 2);
            this.lblCampusTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCampusTransfer.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCampusTransfer.Location = new System.Drawing.Point(3, 50);
            this.lblCampusTransfer.Name = "lblCampusTransfer";
            this.lblCampusTransfer.Size = new System.Drawing.Size(134, 50);
            this.lblCampusTransfer.TabIndex = 4;
            this.lblCampusTransfer.Text = "캠퍼스 전입여부";
            this.lblCampusTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyCampusTransfer
            // 
            this.lblMyCampusTransfer.AutoSize = true;
            this.tableStudentInfoException.SetColumnSpan(this.lblMyCampusTransfer, 2);
            this.lblMyCampusTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyCampusTransfer.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyCampusTransfer.Location = new System.Drawing.Point(143, 50);
            this.lblMyCampusTransfer.Name = "lblMyCampusTransfer";
            this.lblMyCampusTransfer.Size = new System.Drawing.Size(204, 50);
            this.lblMyCampusTransfer.TabIndex = 5;
            this.lblMyCampusTransfer.Text = "N / Y";
            this.lblMyCampusTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFormalUniv
            // 
            this.lblFormalUniv.AutoSize = true;
            this.tableStudentInfoException.SetColumnSpan(this.lblFormalUniv, 2);
            this.lblFormalUniv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFormalUniv.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblFormalUniv.Location = new System.Drawing.Point(353, 50);
            this.lblFormalUniv.Name = "lblFormalUniv";
            this.lblFormalUniv.Size = new System.Drawing.Size(134, 50);
            this.lblFormalUniv.TabIndex = 6;
            this.lblFormalUniv.Text = "전적대";
            this.lblFormalUniv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyFormalUniv
            // 
            this.lblMyFormalUniv.AutoSize = true;
            this.tableStudentInfoException.SetColumnSpan(this.lblMyFormalUniv, 2);
            this.lblMyFormalUniv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyFormalUniv.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyFormalUniv.Location = new System.Drawing.Point(493, 50);
            this.lblMyFormalUniv.Name = "lblMyFormalUniv";
            this.lblMyFormalUniv.Size = new System.Drawing.Size(315, 50);
            this.lblMyFormalUniv.TabIndex = 7;
            this.lblMyFormalUniv.Text = "학점은행제";
            this.lblMyFormalUniv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrevMajor
            // 
            this.lblPrevMajor.AutoSize = true;
            this.tableStudentInfoException.SetColumnSpan(this.lblPrevMajor, 2);
            this.lblPrevMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrevMajor.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPrevMajor.Location = new System.Drawing.Point(3, 100);
            this.lblPrevMajor.Name = "lblPrevMajor";
            this.lblPrevMajor.Size = new System.Drawing.Size(134, 50);
            this.lblPrevMajor.TabIndex = 8;
            this.lblPrevMajor.Text = "전과(학과)";
            this.lblPrevMajor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyPrevMajor
            // 
            this.lblMyPrevMajor.AutoSize = true;
            this.tableStudentInfoException.SetColumnSpan(this.lblMyPrevMajor, 6);
            this.lblMyPrevMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyPrevMajor.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyPrevMajor.Location = new System.Drawing.Point(143, 100);
            this.lblMyPrevMajor.Name = "lblMyPrevMajor";
            this.lblMyPrevMajor.Size = new System.Drawing.Size(665, 50);
            this.lblMyPrevMajor.TabIndex = 9;
            this.lblMyPrevMajor.Text = "정치행정학부 북한학전공 -> 컴퓨터정보통신공학부 컴퓨터공학전공";
            this.lblMyPrevMajor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableHeader
            // 
            this.tableHeader.ColumnCount = 4;
            this.tableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableHeader.Controls.Add(this.lblCategory, 0, 0);
            this.tableHeader.Controls.Add(this.lblGrade, 1, 0);
            this.tableHeader.Controls.Add(this.lblIsPass, 2, 0);
            this.tableHeader.Controls.Add(this.lblUnacquired, 3, 0);
            this.tableHeader.Location = new System.Drawing.Point(40, 377);
            this.tableHeader.Name = "tableHeader";
            this.tableHeader.RowCount = 1;
            this.tableHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableHeader.Size = new System.Drawing.Size(890, 40);
            this.tableHeader.TabIndex = 9;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategory.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCategory.Location = new System.Drawing.Point(3, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(94, 40);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "항목";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGrade.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGrade.Location = new System.Drawing.Point(103, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(294, 40);
            this.lblGrade.TabIndex = 1;
            this.lblGrade.Text = "학점";
            this.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIsPass
            // 
            this.lblIsPass.AutoSize = true;
            this.lblIsPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIsPass.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblIsPass.Location = new System.Drawing.Point(403, 0);
            this.lblIsPass.Name = "lblIsPass";
            this.lblIsPass.Size = new System.Drawing.Size(44, 40);
            this.lblIsPass.TabIndex = 2;
            this.lblIsPass.Text = "P/F";
            this.lblIsPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnacquired
            // 
            this.lblUnacquired.AutoSize = true;
            this.lblUnacquired.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnacquired.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUnacquired.Location = new System.Drawing.Point(453, 0);
            this.lblUnacquired.Name = "lblUnacquired";
            this.lblUnacquired.Size = new System.Drawing.Size(437, 40);
            this.lblUnacquired.TabIndex = 3;
            this.lblUnacquired.Text = "미취득 내역";
            this.lblUnacquired.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableRGC
            // 
            this.tableRGC.ColumnCount = 5;
            this.tableRGC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableRGC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableRGC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableRGC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableRGC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableRGC.Controls.Add(this.lblRGC, 0, 0);
            this.tableRGC.Controls.Add(this.lblMyRGC, 1, 0);
            this.tableRGC.Controls.Add(this.lblRGCStandard, 2, 0);
            this.tableRGC.Controls.Add(this.lblRGCPass, 3, 0);
            this.tableRGC.Controls.Add(this.txtRGC, 4, 0);
            this.tableRGC.Location = new System.Drawing.Point(40, 420);
            this.tableRGC.Name = "tableRGC";
            this.tableRGC.RowCount = 1;
            this.tableRGC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableRGC.Size = new System.Drawing.Size(890, 70);
            this.tableRGC.TabIndex = 10;
            // 
            // tableBasic
            // 
            this.tableBasic.ColumnCount = 5;
            this.tableBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableBasic.Controls.Add(this.lblBasic, 0, 0);
            this.tableBasic.Controls.Add(this.lblMyBasic, 1, 0);
            this.tableBasic.Controls.Add(this.lblBasicStandard, 2, 0);
            this.tableBasic.Controls.Add(this.lblBasicPass, 3, 0);
            this.tableBasic.Controls.Add(this.txtBasic, 4, 0);
            this.tableBasic.Location = new System.Drawing.Point(40, 493);
            this.tableBasic.Name = "tableBasic";
            this.tableBasic.RowCount = 1;
            this.tableBasic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableBasic.Size = new System.Drawing.Size(890, 70);
            this.tableBasic.TabIndex = 11;
            // 
            // lblRGC
            // 
            this.lblRGC.AutoSize = true;
            this.lblRGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRGC.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRGC.Location = new System.Drawing.Point(3, 0);
            this.lblRGC.Name = "lblRGC";
            this.lblRGC.Size = new System.Drawing.Size(94, 70);
            this.lblRGC.TabIndex = 0;
            this.lblRGC.Text = "공통교양";
            this.lblRGC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyRGC
            // 
            this.lblMyRGC.AutoSize = true;
            this.lblMyRGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyRGC.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyRGC.Location = new System.Drawing.Point(103, 0);
            this.lblMyRGC.Name = "lblMyRGC";
            this.lblMyRGC.Size = new System.Drawing.Size(94, 70);
            this.lblMyRGC.TabIndex = 1;
            this.lblMyRGC.Text = "16";
            this.lblMyRGC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRGCStandard
            // 
            this.lblRGCStandard.AutoSize = true;
            this.lblRGCStandard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRGCStandard.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRGCStandard.Location = new System.Drawing.Point(203, 0);
            this.lblRGCStandard.Name = "lblRGCStandard";
            this.lblRGCStandard.Size = new System.Drawing.Size(194, 70);
            this.lblRGCStandard.TabIndex = 2;
            this.lblRGCStandard.Text = "/ 16";
            this.lblRGCStandard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRGCPass
            // 
            this.lblRGCPass.AutoSize = true;
            this.lblRGCPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRGCPass.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRGCPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRGCPass.Location = new System.Drawing.Point(403, 0);
            this.lblRGCPass.Name = "lblRGCPass";
            this.lblRGCPass.Size = new System.Drawing.Size(44, 70);
            this.lblRGCPass.TabIndex = 3;
            this.lblRGCPass.Text = "P";
            this.lblRGCPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRGC
            // 
            this.txtRGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRGC.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRGC.Location = new System.Drawing.Point(453, 3);
            this.txtRGC.Multiline = true;
            this.txtRGC.Name = "txtRGC";
            this.txtRGC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRGC.Size = new System.Drawing.Size(436, 64);
            this.txtRGC.TabIndex = 4;
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBasic.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBasic.Location = new System.Drawing.Point(3, 0);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Size = new System.Drawing.Size(94, 70);
            this.lblBasic.TabIndex = 0;
            this.lblBasic.Text = "기본소양";
            this.lblBasic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyBasic
            // 
            this.lblMyBasic.AutoSize = true;
            this.lblMyBasic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyBasic.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMyBasic.Location = new System.Drawing.Point(103, 0);
            this.lblMyBasic.Name = "lblMyBasic";
            this.lblMyBasic.Size = new System.Drawing.Size(94, 70);
            this.lblMyBasic.TabIndex = 1;
            this.lblMyBasic.Text = "9";
            this.lblMyBasic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBasicStandard
            // 
            this.lblBasicStandard.AutoSize = true;
            this.lblBasicStandard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBasicStandard.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBasicStandard.Location = new System.Drawing.Point(203, 0);
            this.lblBasicStandard.Name = "lblBasicStandard";
            this.lblBasicStandard.Size = new System.Drawing.Size(194, 70);
            this.lblBasicStandard.TabIndex = 2;
            this.lblBasicStandard.Text = "/ 9";
            this.lblBasicStandard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBasicPass
            // 
            this.lblBasicPass.AutoSize = true;
            this.lblBasicPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBasicPass.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblBasicPass.Location = new System.Drawing.Point(403, 0);
            this.lblBasicPass.Name = "lblBasicPass";
            this.lblBasicPass.Size = new System.Drawing.Size(44, 70);
            this.lblBasicPass.TabIndex = 3;
            this.lblBasicPass.Text = "P";
            this.lblBasicPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBasic
            // 
            this.txtBasic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBasic.Location = new System.Drawing.Point(453, 3);
            this.txtBasic.Multiline = true;
            this.txtBasic.Name = "txtBasic";
            this.txtBasic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBasic.Size = new System.Drawing.Size(434, 64);
            this.txtBasic.TabIndex = 4;
            // 
            // form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1154, 1055);
            this.Controls.Add(this.tableBasic);
            this.Controls.Add(this.tableRGC);
            this.Controls.Add(this.tableHeader);
            this.Controls.Add(this.tableStudentInfoException);
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
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "자동 졸업사정 시스템";
            this.tableSubject.ResumeLayout(false);
            this.tableSubject.PerformLayout();
            this.tableStandard.ResumeLayout(false);
            this.tableStandard.PerformLayout();
            this.tableStudentInfo.ResumeLayout(false);
            this.tableStudentInfo.PerformLayout();
            this.tableStudentInfoException.ResumeLayout(false);
            this.tableStudentInfoException.PerformLayout();
            this.tableHeader.ResumeLayout(false);
            this.tableHeader.PerformLayout();
            this.tableRGC.ResumeLayout(false);
            this.tableRGC.PerformLayout();
            this.tableBasic.ResumeLayout(false);
            this.tableBasic.PerformLayout();
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
        private System.Windows.Forms.TextBox txtMSC;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.Label lblMSC;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblMSCMath;
        private System.Windows.Forms.Label lblMSCScience;
        private System.Windows.Forms.Label lblMajorSum;
        private System.Windows.Forms.Label lblMyMajorSum;
        private System.Windows.Forms.Label lblDesign;
        private System.Windows.Forms.Label lblSpecial;
        private System.Windows.Forms.Label lblMyDesign;
        private System.Windows.Forms.Label lblMySpecial;
        private System.Windows.Forms.Label lblMyMath;
        private System.Windows.Forms.Label lblMyScience;
        private System.Windows.Forms.TableLayoutPanel tableStandard;
        private System.Windows.Forms.Label lblMajorEng;
        private System.Windows.Forms.Label lblTotalEng;
        private System.Windows.Forms.Label lblToeic;
        private System.Windows.Forms.Label lblMyMajorEng;
        private System.Windows.Forms.Label lblMyTotalEng;
        private System.Windows.Forms.Label lblMyToeic;
        private System.Windows.Forms.TableLayoutPanel tableStudentInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMyName;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblMyStudentId;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblMyClass;
        private System.Windows.Forms.Label lblAllGrade;
        private System.Windows.Forms.Label lblGPA;
        private System.Windows.Forms.Label lblPaper;
        private System.Windows.Forms.Label lblMyAllGrade;
        private System.Windows.Forms.Label lblMyGPA;
        private System.Windows.Forms.Label lblMyPaper;
        private System.Windows.Forms.Label lblMyGraduate;
        private System.Windows.Forms.Label lblGraduate;
        private System.Windows.Forms.Label lblMyEngineering;
        private System.Windows.Forms.Label lblEngineering;
        private System.Windows.Forms.Label lblMyMajor;
        private System.Windows.Forms.Label lblMyMajor2;
        private System.Windows.Forms.Label lblCurriYear;
        private System.Windows.Forms.Label lblMyCurriYear;
        private System.Windows.Forms.Label lblIsEngineering;
        private System.Windows.Forms.Label lblMyIsEngineering;
        private System.Windows.Forms.Label lblIsMSCPass;
        private System.Windows.Forms.Label lblIsMajorPass;
        private System.Windows.Forms.TableLayoutPanel tableStudentInfoException;
        private System.Windows.Forms.Label lblMinor;
        private System.Windows.Forms.Label lblMyMinor;
        private System.Windows.Forms.Label lblSubmajor;
        private System.Windows.Forms.Label lblMySubmajor;
        private System.Windows.Forms.Label lblCampusTransfer;
        private System.Windows.Forms.Label lblMyCampusTransfer;
        private System.Windows.Forms.Label lblFormalUniv;
        private System.Windows.Forms.Label lblMyFormalUniv;
        private System.Windows.Forms.Label lblPrevMajor;
        private System.Windows.Forms.Label lblMyPrevMajor;
        private System.Windows.Forms.TableLayoutPanel tableHeader;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblIsPass;
        private System.Windows.Forms.Label lblUnacquired;
        private System.Windows.Forms.TableLayoutPanel tableRGC;
        private System.Windows.Forms.TableLayoutPanel tableBasic;
        private System.Windows.Forms.Label lblRGC;
        private System.Windows.Forms.Label lblMyRGC;
        private System.Windows.Forms.Label lblRGCStandard;
        private System.Windows.Forms.Label lblRGCPass;
        private System.Windows.Forms.TextBox txtRGC;
        private System.Windows.Forms.Label lblBasic;
        private System.Windows.Forms.Label lblMyBasic;
        private System.Windows.Forms.Label lblBasicStandard;
        private System.Windows.Forms.Label lblBasicPass;
        private System.Windows.Forms.TextBox txtBasic;
    }
}

