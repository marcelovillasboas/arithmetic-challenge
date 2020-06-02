namespace StudentForm
{
    partial class StudentForm
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
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.tbxQuestion = new System.Windows.Forms.TextBox();
            this.tbxAnswer = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblConnectionLog = new System.Windows.Forms.Label();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(12, 78);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(233, 13);
            this.lblSubtitle.TabIndex = 0;
            this.lblSubtitle.Text = "Enter your answer and click the SUBMIT button";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(12, 115);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(52, 13);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Question:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(12, 155);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(45, 13);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer:";
            // 
            // tbxQuestion
            // 
            this.tbxQuestion.Location = new System.Drawing.Point(70, 112);
            this.tbxQuestion.Name = "tbxQuestion";
            this.tbxQuestion.Size = new System.Drawing.Size(100, 20);
            this.tbxQuestion.TabIndex = 3;
            // 
            // tbxAnswer
            // 
            this.tbxAnswer.Location = new System.Drawing.Point(70, 152);
            this.tbxAnswer.Name = "tbxAnswer";
            this.tbxAnswer.Size = new System.Drawing.Size(100, 20);
            this.tbxAnswer.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(170, 196);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblConnectionLog
            // 
            this.lblConnectionLog.AutoSize = true;
            this.lblConnectionLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionLog.Location = new System.Drawing.Point(12, 238);
            this.lblConnectionLog.Name = "lblConnectionLog";
            this.lblConnectionLog.Size = new System.Drawing.Size(96, 13);
            this.lblConnectionLog.TabIndex = 6;
            this.lblConnectionLog.Text = "Connection log:";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(22, 264);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(52, 13);
            this.lblConnectionStatus.TabIndex = 7;
            this.lblConnectionStatus.Text = "Waiting...";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 276);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.lblConnectionLog);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbxAnswer);
            this.Controls.Add(this.tbxQuestion);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblSubtitle);
            this.Name = "StudentForm";
            this.Text = "Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox tbxQuestion;
        private System.Windows.Forms.TextBox tbxAnswer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblConnectionLog;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button btnExit;
    }
}

