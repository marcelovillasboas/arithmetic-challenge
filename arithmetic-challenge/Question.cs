using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic_challenge
{
        public class Question : IComparable<Question>
    {
        private int leftOp;
        private string mathOp;
        private int rightOp;
        private int answer;

        public Question(int leftOp, string mathOp, int rightOp, int answer)
        {
            this.leftOp = leftOp;
            this.mathOp = mathOp;
            this.rightOp = rightOp;
            this.answer = answer;
        }

        public string questionToSend(int leftOp, string mathOp, int rightOp, int answer)
        {
            return this.LeftOp + " " + this.MathOp + " " + this.RightOp + " = " + this.Answer;
        }

        public string stringToSave()
        {
            return leftOp + " " + mathOp + " " + rightOp + " = " + answer + ", ";
        }

        public override string ToString()
        {
            return leftOp + "\t" + mathOp + "\t" + rightOp + "\t = \t" + answer;
        }

        public string QuestionToSend()
        {
            return leftOp + " " + mathOp + " " + rightOp;
        }

        public int CompareTo(Question other)
        {
            // 0 means both are the same
            // -1 means this.answer is less than other answer
            // 1 means this.anser is greater than other answer
            return this.answer.CompareTo(other.answer);
        }

        public int Answer
        {
            get { return this.answer; }
            set { this.answer = value; }
        }

        public int LeftOp
        {
            get { return this.leftOp; }
            set { this.leftOp = value; }
        }

        public int RightOp
        {
            get { return this.rightOp; }
            set { this.rightOp = value; }
        }

        public string MathOp
        {
            get { return this.mathOp; }
            set { this.mathOp = value; }
        }
    }
}
