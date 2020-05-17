namespace arithmetic_challenge
{
    partial class ServerForm
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
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.tbxFirstNumber = new System.Windows.Forms.TextBox();
            this.tbxSecondNumber = new System.Windows.Forms.TextBox();
            this.tbxAnswer = new System.Windows.Forms.TextBox();
            this.lblQuestionsAsked = new System.Windows.Forms.Label();
            this.lblWrongAnswers = new System.Windows.Forms.Label();
            this.tbxQuestionsAsked = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.cbxOperator = new System.Windows.Forms.ComboBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.tbxSortedQuestions = new System.Windows.Forms.TextBox();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.tbxIncorrect = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Location = new System.Drawing.Point(12, 50);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(67, 13);
            this.lblFirstNumber.TabIndex = 0;
            this.lblFirstNumber.Text = "First number:";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(12, 80);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(51, 13);
            this.lblOperator.TabIndex = 1;
            this.lblOperator.Text = "Operator:";
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Location = new System.Drawing.Point(12, 108);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(85, 13);
            this.lblSecondNumber.TabIndex = 2;
            this.lblSecondNumber.Text = "Second number:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(12, 138);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(45, 13);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "Answer:";
            // 
            // tbxFirstNumber
            // 
            this.tbxFirstNumber.Location = new System.Drawing.Point(126, 47);
            this.tbxFirstNumber.Name = "tbxFirstNumber";
            this.tbxFirstNumber.Size = new System.Drawing.Size(59, 20);
            this.tbxFirstNumber.TabIndex = 4;
            // 
            // tbxSecondNumber
            // 
            this.tbxSecondNumber.Location = new System.Drawing.Point(126, 105);
            this.tbxSecondNumber.Name = "tbxSecondNumber";
            this.tbxSecondNumber.Size = new System.Drawing.Size(59, 20);
            this.tbxSecondNumber.TabIndex = 6;
            // 
            // tbxAnswer
            // 
            this.tbxAnswer.Location = new System.Drawing.Point(126, 135);
            this.tbxAnswer.Name = "tbxAnswer";
            this.tbxAnswer.Size = new System.Drawing.Size(59, 20);
            this.tbxAnswer.TabIndex = 7;
            // 
            // lblQuestionsAsked
            // 
            this.lblQuestionsAsked.AutoSize = true;
            this.lblQuestionsAsked.Location = new System.Drawing.Point(310, 26);
            this.lblQuestionsAsked.Name = "lblQuestionsAsked";
            this.lblQuestionsAsked.Size = new System.Drawing.Size(89, 13);
            this.lblQuestionsAsked.TabIndex = 8;
            this.lblQuestionsAsked.Text = "Sorted questions:";
            // 
            // lblWrongAnswers
            // 
            this.lblWrongAnswers.AutoSize = true;
            this.lblWrongAnswers.Location = new System.Drawing.Point(12, 244);
            this.lblWrongAnswers.Name = "lblWrongAnswers";
            this.lblWrongAnswers.Size = new System.Drawing.Size(157, 13);
            this.lblWrongAnswers.TabIndex = 9;
            this.lblWrongAnswers.Text = "Questions answered incorrectly:";
            // 
            // tbxQuestionsAsked
            // 
            this.tbxQuestionsAsked.Location = new System.Drawing.Point(313, 276);
            this.tbxQuestionsAsked.Multiline = true;
            this.tbxQuestionsAsked.Name = "tbxQuestionsAsked";
            this.tbxQuestionsAsked.Size = new System.Drawing.Size(238, 73);
            this.tbxQuestionsAsked.TabIndex = 10;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(126, 184);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cbxOperator
            // 
            this.cbxOperator.FormattingEnabled = true;
            this.cbxOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "/"});
            this.cbxOperator.Location = new System.Drawing.Point(126, 77);
            this.cbxOperator.Name = "cbxOperator";
            this.cbxOperator.Size = new System.Drawing.Size(59, 21);
            this.cbxOperator.TabIndex = 12;
            this.cbxOperator.Text = "+";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(310, 244);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(85, 13);
            this.lblLog.TabIndex = 13;
            this.lblLog.Text = "Log of questions";
            // 
            // tbxSortedQuestions
            // 
            this.tbxSortedQuestions.Location = new System.Drawing.Point(313, 50);
            this.tbxSortedQuestions.Multiline = true;
            this.tbxSortedQuestions.Name = "tbxSortedQuestions";
            this.tbxSortedQuestions.Size = new System.Drawing.Size(238, 105);
            this.tbxSortedQuestions.TabIndex = 14;
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(313, 161);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(75, 23);
            this.btnQuickSort.TabIndex = 15;
            this.btnQuickSort.Text = "Quick Sort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // tbxIncorrect
            // 
            this.tbxIncorrect.Location = new System.Drawing.Point(15, 276);
            this.tbxIncorrect.Multiline = true;
            this.tbxIncorrect.Name = "tbxIncorrect";
            this.tbxIncorrect.Size = new System.Drawing.Size(242, 73);
            this.tbxIncorrect.TabIndex = 18;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tbxIncorrect);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.tbxSortedQuestions);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.cbxOperator);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbxQuestionsAsked);
            this.Controls.Add(this.lblWrongAnswers);
            this.Controls.Add(this.lblQuestionsAsked);
            this.Controls.Add(this.tbxAnswer);
            this.Controls.Add(this.tbxSecondNumber);
            this.Controls.Add(this.tbxFirstNumber);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblFirstNumber);
            this.Name = "ServerForm";
            this.Text = "Instructor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServerForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox tbxFirstNumber;
        private System.Windows.Forms.TextBox tbxSecondNumber;
        private System.Windows.Forms.TextBox tbxAnswer;
        private System.Windows.Forms.Label lblQuestionsAsked;
        private System.Windows.Forms.Label lblWrongAnswers;
        private System.Windows.Forms.TextBox tbxQuestionsAsked;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cbxOperator;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.TextBox tbxSortedQuestions;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.TextBox tbxIncorrect;
    }
}

