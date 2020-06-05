/*********************************************************************************************************
Filename: Arithmetic Challenge - Math Quiz
Purpose: Connect student and teacher using a software in which the instructor is able to send math questions through 
a network to the student and check whether the responses are correct.
Author: Marcelo Villas Boas
Date: May/2020
Version: 1.0
Version 1.0 - basic functionality. Instructor is able to send math questions to the student using a client-server model 
network. Student receives the question and answers it. After that, the instructor receives the student's answer identifying 
whether it is correct or not. Questions can be sorted using three different sorting algorithms (insertion sort, quick sort 
and bubble sort). The questions are also stored in a Binary Tree, giving the user the ability to traverse the tree using 
three different methods (PreOrder, InOrder and PostOrder).
*********************************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arithmetic_challenge
{
    public partial class ServerForm : Form
    {
        
        int key = 0;
        int counter = 0;
        public bool exitStatus = false;
        public const int BYTE_SYZE = 1024;
        public const int PORT_NUMBER = 8888;

        // declare Binary Tree
        BinaryTree<string> btQuestions = new BinaryTree<string>();

        // new questions list
        List<Question> questions = new List<Question>();

        // declare hashset
        HashSet<string> questionStrHashSet = new HashSet<string>();

        // new linkedList
        DoublyLinkedList linkedList = new DoublyLinkedList();
        
        // counter to keep track of the list size
        int listSize;

        // listens for and accepts incoming connection requests
        private TcpListener serverListener;

        // TcpClient is used to connect with the TcoListener object
        private TcpClient serverSocket;

        // set up data stream object
        private NetworkStream netStream;

        // set up thread to run ReceiveStream() method
        private Thread serverThread = null;

        // set up delegate 
        // a delegate is a reference variable to a method
        // and used for a call back by the delegate object
        // delegate ref variable is declared in SetText() method below
        delegate void SetTextCallBack(string text);

        public ServerForm()
        {
            InitializeComponent();

            // display message
            tbxQuestionsAsked.Text = "All questions to be displayed here";

            // run server
            StartServer();
        }

        /// <summary>
        /// method representing the quick sort algorithm, along Partition and Swap
        /// </summary>
        /// <param name="questions">
        /// list of questions sent to students using the instructor form
        /// </param>
        /// <param name="left">
        /// parameter used to establish the beginning of the traverse through the list
        /// </param>
        /// <param name="right">
        /// parameter used to establish the finish of the traverse through the list
        /// </param> 

        static void QuickSort(List<Question> questions, int left, int right)
        {
            if (left < right)
            {
                int part = Partition(questions, left, right);
                QuickSort(questions, left, part - 1);
                QuickSort(questions, part + 1, right);
            }
        }

        static int Partition(List<Question> questions, int left, int right)
        {
            int pivot = questions[left].Answer;

            int x = left;

            for (int i = left; i < right; i++)
            {
                // if right is greater than left 
                if (pivot > questions[right].Answer)
                {
                    // swap
                    Swap(questions[x], questions[i]);

                    // move left pointer to next position
                    x++;
                }
            }

            // swap left with right
            Swap(questions[x], questions[right]);
            return x;

        }

        static void Swap(Question a, Question b)
        {
            Question temp = new Question(a.LeftOp, a.MathOp, a.RightOp, a.Answer);
            a.LeftOp = b.LeftOp;
            a.MathOp = b.MathOp;
            a.RightOp = b.RightOp;
            a.Answer = b.Answer;
            b.LeftOp = temp.LeftOp;
            b.MathOp = temp.MathOp;
            b.RightOp = temp.RightOp;
            b.Answer = temp.Answer;
        }

        /// <summary>
        /// method used to build the bubble sort algorithm 
        /// </summary>
        /// <param name="bubble">
        /// parametre used to implement the bubble sort algorithm
        /// </param>
        /// <param name="questions">
        /// list of questions sent to the student using the instructor form. This is the object to be sorted
        /// </param>
        static void BubbleSort(int bubble, List<Question> questions)
        {
            bool sorted;

            // full list to be bubbled
            bubble = questions.Count - 1;

            do
            {
                int i = 0;

                // assume array as sorted
                sorted = true;

                while (i < bubble)
                {
                    if (questions[i].Answer > questions[i + 1].Answer)
                    {
                        Swap(questions[i], questions[i + 1]);

                        // if there is a swap to be made, array is not sorted
                        sorted = false;
                    }

                    i++;

                }
                
                bubble--;

            } while (!sorted && bubble > 0);
        }

        /// <summary>
        /// method used to build the insertion sort algorithm
        /// </summary>
        /// <param name="questions">
        /// list of questions sent to the student through the instructor form. This is the object supposed to be sorted
        /// </param>
        static void InsertionSort(List<Question> questions)
        {
            int n = questions.Count;

            for(int i = 0; i < n; i++)
            {
                int key = questions[i].Answer;
                int j = i - 1;

                // move elements that are greater than the key to one position ahead of their current position
                while (j >= 0 && questions[j].Answer > key)
                {
                    questions[j + 1] = questions[j];
                    j--;
                }
                questions[j + 1].Answer = key;
            }
        }

        /// <summary>
        /// Initiates the server to establish the connection with the client
        /// </summary>
        private void StartServer()
        {
            try
            {
                // create listener and start
                serverListener = new TcpListener(IPAddress.Loopback, PORT_NUMBER);
                serverListener.Start();

                // create acceptance socket
                // this creates a socket connection to the server
                serverSocket = serverListener.AcceptTcpClient();

                // create stream
                netStream = serverSocket.GetStream();

                // set up thread to run ReceiveStream() method
                serverThread = new Thread(ReceiveStream);

                // start thread 
                serverThread.Start();
                tbxQuestionsAsked.Text = "Server started..." + Environment.NewLine;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        /// <summary>
        /// Observes connection to receive data whenever any message is sent
        /// </summary>
        public void ReceiveStream()
        {
            byte[] bytesReceived = new byte[BYTE_SYZE];

            // loop to read any incoming messages
            while(!exitStatus)
            {
                try
                {
                    int bytesRead = netStream.Read(bytesReceived, 0, bytesReceived.Length);
                    this.SetText(Encoding.ASCII.GetString(bytesReceived, 0, bytesRead));
                }
                catch (System.IO.IOException)
                {
                    Console.WriteLine("Client has exited.");
                    exitStatus = true;
                }
            }

        }

        /// <summary>
        /// This method transforms the data received from the student form in text
        /// </summary>
        /// <param name="text">
        /// The string text receives the data from the student form
        /// </param>
        public void SetText(string text)
        {
            // InvokeRequired compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // if these threads are different, it returns true.
            if (this.tbxQuestionsAsked.InvokeRequired)
            {
                // d is a Delegate reference to the SetText() method
                SetTextCallBack d = new SetTextCallBack(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                // if text received is equal the answer displayed at the answer textbox
                if(text == tbxAnswer.Text)
                {
                    // display message with student's submition at the answer log
                    this.tbxQuestionsAsked.Text += "Student: " + text + Environment.NewLine;

                    // re-enable send button
                    btnSend.Enabled = true;
                }
                
                // if text received is different than the answer displayed at the answer textbox
                else
                {
                    this.tbxIncorrect.Text += questions[counter - 1] + Environment.NewLine;
                    
                    // display message with student's submition at the incorrect answer log
                    this.tbxIncorrect.Text += "Student: " + text + Environment.NewLine;
                    linkedList.insertToList(text);
                    listSize++;

                    // re-enable send button
                    btnSend.Enabled = true;
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
            // gets first number and converts it into integer
            String firstNo = tbxFirstNumber.Text;

            // gets second number and converts it into integer
            String secondNo = tbxSecondNumber.Text;

            int firstNumber;
            int secondNumber;
            String mathOperator;
            String strQuestion;

            try
            {
                firstNumber = Int32.Parse(firstNo);
                secondNumber = Int32.Parse(secondNo);
                mathOperator = cbxOperator.SelectedItem.ToString();
                strQuestion = firstNumber + " " + mathOperator + " " + secondNumber + " = ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter numbers to the operation");
                return;
            }

            if (firstNumber != null && secondNumber != null)
            {
                int result;

                if (mathOperator == "+")
                {
                   result = firstNumber + secondNumber;
                }
                else if(mathOperator == "-")
                {
                    result = firstNumber - secondNumber;
                }
                else if (mathOperator == "x")
                {
                    result = firstNumber * secondNumber;
                }
                else if (mathOperator == "/")
                {
                    result = firstNumber / secondNumber;
                }
                else
                {
                    result = firstNumber + secondNumber;
                }

                tbxAnswer.Text = result.ToString();
                int answer = Int32.Parse(result.ToString());

                // creates new Question object
                Question question = new Question(firstNumber, mathOperator, secondNumber, answer);

                // adds to questions list
                questions.Add(question);

                // add to hashset
                questionStrHashSet.Add(question.ToString());

                // construct byte array to stream in write mode
                byte[] bytesQuestion = Encoding.ASCII.GetBytes(question.QuestionToSend());
                netStream.Write(bytesQuestion, 0, bytesQuestion.Length);

                // insert questions into Binary Tree
                btQuestions.Add(question.questionToSend(firstNumber, mathOperator, secondNumber, answer));

                // change key
                key++;

                // Environment.NewLine;
                tbxQuestionsAsked.Text += "Question: " + strQuestion + Environment.NewLine;

            }

            counter++;

            linkedList.readFromStart();

            btnSend.Enabled = false;

        }

        private void ServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // terminate thread if still running
            if(serverThread.IsAlive)
            {
                Console.WriteLine("Server thread is alive");
                serverThread.Interrupt();
                if(serverThread.IsAlive)
                {
                    Console.WriteLine("Server thread is now terminated");
                }
            }
            else
            {
                Console.WriteLine("Server thread is terminated");
            }

            // close the application
            Environment.Exit(0);
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            tbxSortedQuestions.Clear();

            try
            {
                QuickSort(questions, 0, questions.Count - 1);

                foreach (Question question in questions)
                {
                    tbxSortedQuestions.Text += question.ToString() + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sorting");
            }


        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            tbxSortedQuestions.Clear();

            try
            {
                BubbleSort(0, questions);

                foreach (Question question in questions)
                {
                    tbxSortedQuestions.Text += question.ToString() + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sorting.");
            }
        }

        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            tbxSortedQuestions.Clear();

            try
            {
                InsertionSort(questions);

                foreach (Question question in questions)
                {
                    tbxSortedQuestions.Text += question.ToString() + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sorting");
            }
        }

        private void btnFindIncorrect_Click(object sender, EventArgs e)
        {
            string questionToSearch = tbxFindIncorrect.Text;
                        
            if (questionToSearch == null)
            {
                MessageBox.Show("Enter a valid question to the search bar.");
            }
            else
            {
                string[] strElements = questionToSearch.Split(' ');
                
                if (strElements.Length == 5)
                {
                    try
                    {
                        int leftOp = Int32.Parse(strElements[0]);
                        string mathOp = strElements[1];
                        int rightOp = Int32.Parse(strElements[2]);
                        int answer = Int32.Parse(strElements[4]);
                        string questionToCompare = answer + "(" + leftOp + mathOp + rightOp + ")";

                        tbxIncorrect.Clear();
                        tbxIncorrect.Text += leftOp + " " + mathOp + " " + rightOp + " " + " " + answer + Environment.NewLine;
                        tbxIncorrect.Text += questionStrHashSet.ElementAt(0);

                        if (questionStrHashSet.Contains(questionToCompare))
                        {
                            tbxIncorrect.Text = questionToSearch + " found.";
                        }
                        else
                        {
                            tbxIncorrect.Text = questionToSearch + " not found.";
                        }
                    }
                    catch (Exception ex)
                    {
                        tbxIncorrect.Text = "Error. Review question format";
                    }
                }
            }
        }
            

        private void btnPreOrderDisplay_Click(object sender, EventArgs e)
        {
            tbxQuestionsAsked.Text = "";
            btQuestions.TraversalString = "";
            btQuestions.PreOrder(btQuestions.GetRoot());
            string tString = btQuestions.TraversalString;
            tbxQuestionsAsked.Text += tString;
            
            
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {

        }

        private void btnFindAllQuestions_Click(object sender, EventArgs e)
        {
            string questionToSearch = tbxFindAllQuestions.Text.ToString();
                        
            if (tbxFindAllQuestions.Text == null)
            {
                tbxQuestionsAsked.Text = "Enter a valid question to the search bar";
            }
            else
            {
                string[] strElements = questionToSearch.Split(' ');

                if (strElements.Length == 5)
                {
                    try
                    {
                        int leftOp = Int32.Parse(strElements[0]);
                        string mathOp = strElements[1];
                        int rightOp = Int32.Parse(strElements[2]);
                        int answer = Int32.Parse(strElements[4]);
                        tbxQuestionsAsked.Clear();
                        tbxQuestionsAsked.Text += leftOp.ToString() + " " + mathOp + " " + rightOp.ToString() + " = " + answer.ToString() + Environment.NewLine;
                        tbxQuestionsAsked.Text += questionStrHashSet.ElementAt(0);
                        string questionToCompare = answer + "(" + leftOp + mathOp + rightOp + ")";

                        if (questionStrHashSet.Contains(questionToCompare))
                        {
                            tbxQuestionsAsked.Text = questionToSearch + " found.";
                        }
                        else
                        {
                            tbxQuestionsAsked.Text = questionToSearch + " not found.";
                        }
                    }
                    catch (Exception ex)
                    {
                        tbxQuestionsAsked.Text = "Error. Review question format";
                    }
                }

            }
        }
            

        private void btnDisplayInOrder_Click(object sender, EventArgs e)
        {
            tbxQuestionsAsked.Text = "";
            btQuestions.TraversalString = "";
            btQuestions.InOrder(btQuestions.GetRoot());
            string tString = btQuestions.TraversalString;

            tbxQuestionsAsked.Text += tString;
        }

        private void btnDisplayPostOrder_Click(object sender, EventArgs e)
        {
            tbxQuestionsAsked.Text = "";
            btQuestions.TraversalString = "";
            btQuestions.PostOrder(btQuestions.GetRoot());
            string tString = btQuestions.TraversalString;

            tbxQuestionsAsked.Text += tString;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
