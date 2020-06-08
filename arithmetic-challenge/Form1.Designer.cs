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
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.tbxFindIncorrect = new System.Windows.Forms.TextBox();
            this.btnFindIncorrect = new System.Windows.Forms.Button();
            this.lblPreOrder = new System.Windows.Forms.Label();
            this.lblInOrder = new System.Windows.Forms.Label();
            this.lblPostOrder = new System.Windows.Forms.Label();
            this.btnPreOrderDisplay = new System.Windows.Forms.Button();
            this.btnDisplayInOrder = new System.Windows.Forms.Button();
            this.btnDisplayPostOrder = new System.Windows.Forms.Button();
            this.btnFindAllQuestions = new System.Windows.Forms.Button();
            this.tbxFindAllQuestions = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
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
            this.lblQuestionsAsked.Size = new System.Drawing.Size(88, 13);
            this.lblQuestionsAsked.TabIndex = 8;
            this.lblQuestionsAsked.Text = "Log of questions:";
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
            this.tbxQuestionsAsked.Location = new System.Drawing.Point(312, 229);
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
            this.lblLog.Location = new System.Drawing.Point(310, 204);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(64, 13);
            this.lblLog.TabIndex = 13;
            this.lblLog.Text = "Binary Tree:";
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
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(394, 161);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(75, 23);
            this.btnBubbleSort.TabIndex = 19;
            this.btnBubbleSort.Text = "Bubble Sort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.Location = new System.Drawing.Point(475, 161);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(75, 23);
            this.btnInsertionSort.TabIndex = 20;
            this.btnInsertionSort.Text = "Insertion Sort";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // tbxFindIncorrect
            // 
            this.tbxFindIncorrect.Location = new System.Drawing.Point(175, 241);
            this.tbxFindIncorrect.Name = "tbxFindIncorrect";
            this.tbxFindIncorrect.Size = new System.Drawing.Size(55, 20);
            this.tbxFindIncorrect.TabIndex = 21;
            this.tbxFindIncorrect.Text = "a + b = c";
            // 
            // btnFindIncorrect
            // 
            this.btnFindIncorrect.Location = new System.Drawing.Point(236, 241);
            this.btnFindIncorrect.Name = "btnFindIncorrect";
            this.btnFindIncorrect.Size = new System.Drawing.Size(50, 23);
            this.btnFindIncorrect.TabIndex = 22;
            this.btnFindIncorrect.Text = "Find";
            this.btnFindIncorrect.UseVisualStyleBackColor = true;
            this.btnFindIncorrect.Click += new System.EventHandler(this.btnFindIncorrect_Click);
            // 
            // lblPreOrder
            // 
            this.lblPreOrder.AutoSize = true;
            this.lblPreOrder.Location = new System.Drawing.Point(310, 316);
            this.lblPreOrder.Name = "lblPreOrder";
            this.lblPreOrder.Size = new System.Drawing.Size(49, 13);
            this.lblPreOrder.TabIndex = 23;
            this.lblPreOrder.Text = "PreOrder";
            // 
            // lblInOrder
            // 
            this.lblInOrder.AutoSize = true;
            this.lblInOrder.Location = new System.Drawing.Point(411, 316);
            this.lblInOrder.Name = "lblInOrder";
            this.lblInOrder.Size = new System.Drawing.Size(42, 13);
            this.lblInOrder.TabIndex = 24;
            this.lblInOrder.Text = "InOrder";
            // 
            // lblPostOrder
            // 
            this.lblPostOrder.AutoSize = true;
            this.lblPostOrder.Location = new System.Drawing.Point(497, 316);
            this.lblPostOrder.Name = "lblPostOrder";
            this.lblPostOrder.Size = new System.Drawing.Size(54, 13);
            this.lblPostOrder.TabIndex = 25;
            this.lblPostOrder.Text = "PostOrder";
            // 
            // btnPreOrderDisplay
            // 
            this.btnPreOrderDisplay.Location = new System.Drawing.Point(310, 332);
            this.btnPreOrderDisplay.Name = "btnPreOrderDisplay";
            this.btnPreOrderDisplay.Size = new System.Drawing.Size(49, 23);
            this.btnPreOrderDisplay.TabIndex = 26;
            this.btnPreOrderDisplay.Text = "Display";
            this.btnPreOrderDisplay.UseVisualStyleBackColor = true;
            this.btnPreOrderDisplay.Click += new System.EventHandler(this.btnPreOrderDisplay_Click);
            // 
            // btnDisplayInOrder
            // 
            this.btnDisplayInOrder.Location = new System.Drawing.Point(404, 332);
            this.btnDisplayInOrder.Name = "btnDisplayInOrder";
            this.btnDisplayInOrder.Size = new System.Drawing.Size(49, 23);
            this.btnDisplayInOrder.TabIndex = 27;
            this.btnDisplayInOrder.Text = "Display";
            this.btnDisplayInOrder.UseVisualStyleBackColor = true;
            this.btnDisplayInOrder.Click += new System.EventHandler(this.btnDisplayInOrder_Click);
            // 
            // btnDisplayPostOrder
            // 
            this.btnDisplayPostOrder.Location = new System.Drawing.Point(500, 332);
            this.btnDisplayPostOrder.Name = "btnDisplayPostOrder";
            this.btnDisplayPostOrder.Size = new System.Drawing.Size(49, 23);
            this.btnDisplayPostOrder.TabIndex = 28;
            this.btnDisplayPostOrder.Text = "Display";
            this.btnDisplayPostOrder.UseVisualStyleBackColor = true;
            this.btnDisplayPostOrder.Click += new System.EventHandler(this.btnDisplayPostOrder_Click);
            // 
            // btnFindAllQuestions
            // 
            this.btnFindAllQuestions.Location = new System.Drawing.Point(432, 21);
            this.btnFindAllQuestions.Name = "btnFindAllQuestions";
            this.btnFindAllQuestions.Size = new System.Drawing.Size(38, 23);
            this.btnFindAllQuestions.TabIndex = 29;
            this.btnFindAllQuestions.Text = "Find";
            this.btnFindAllQuestions.UseVisualStyleBackColor = true;
            this.btnFindAllQuestions.Click += new System.EventHandler(this.btnFindAllQuestions_Click);
            // 
            // tbxFindAllQuestions
            // 
            this.tbxFindAllQuestions.Location = new System.Drawing.Point(476, 23);
            this.tbxFindAllQuestions.Name = "tbxFindAllQuestions";
            this.tbxFindAllQuestions.Size = new System.Drawing.Size(75, 20);
            this.tbxFindAllQuestions.TabIndex = 30;
            this.tbxFindAllQuestions.Text = "a + b = c";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(497, 361);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 394);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbxFindAllQuestions);
            this.Controls.Add(this.btnFindAllQuestions);
            this.Controls.Add(this.btnDisplayPostOrder);
            this.Controls.Add(this.btnDisplayInOrder);
            this.Controls.Add(this.btnPreOrderDisplay);
            this.Controls.Add(this.lblPostOrder);
            this.Controls.Add(this.lblInOrder);
            this.Controls.Add(this.lblPreOrder);
            this.Controls.Add(this.btnFindIncorrect);
            this.Controls.Add(this.tbxFindIncorrect);
            this.Controls.Add(this.btnInsertionSort);
            this.Controls.Add(this.btnBubbleSort);
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
            this.Load += new System.EventHandler(this.ServerForm_Load);
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
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.TextBox tbxFindIncorrect;
        private System.Windows.Forms.Button btnFindIncorrect;
        private System.Windows.Forms.Label lblPreOrder;
        private System.Windows.Forms.Label lblInOrder;
        private System.Windows.Forms.Label lblPostOrder;
        private System.Windows.Forms.Button btnPreOrderDisplay;
        private System.Windows.Forms.Button btnDisplayInOrder;
        private System.Windows.Forms.Button btnDisplayPostOrder;
        private System.Windows.Forms.Button btnFindAllQuestions;
        private System.Windows.Forms.TextBox tbxFindAllQuestions;
        private System.Windows.Forms.Button btnExit;
    }
}

