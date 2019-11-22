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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDialog
            // 
            this.btnDialog.Location = new System.Drawing.Point(236, 79);
            this.btnDialog.Name = "btnDialog";
            this.btnDialog.Size = new System.Drawing.Size(75, 23);
            this.btnDialog.TabIndex = 0;
            this.btnDialog.Text = "찾아보기";
            this.btnDialog.UseVisualStyleBackColor = true;
            this.btnDialog.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(35, 79);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(195, 21);
            this.txtFileName.TabIndex = 1;
            // 
            // btnExecution
            // 
            this.btnExecution.Location = new System.Drawing.Point(317, 79);
            this.btnExecution.Name = "btnExecution";
            this.btnExecution.Size = new System.Drawing.Size(75, 23);
            this.btnExecution.TabIndex = 2;
            this.btnExecution.Text = "분석";
            this.btnExecution.UseVisualStyleBackColor = true;
            this.btnExecution.Click += new System.EventHandler(this.btnExecution_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "* 취득분류표는 uDrims > 학사정보 > 졸업 >\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(45, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(476, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "취득학점확인서조회(전학년) > 출력포함 - 수강신청포함 체크후 출력 하십시오.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExecution);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnDialog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "자동 졸업사정 시스템";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button btnDialog;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnExecution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

