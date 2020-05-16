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
        int counter = 0;
        public bool exitStatus = false;
        public const int BYTE_SYZE = 1024;
        public const int PORT_NUMBER = 8888;

        // new questions list
        List<Question> questions = new List<Question>();

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
                }
                
                // if text received is different than the answer displayed at the answer textbox
                else
                {
                    this.tbxIncorrect.Text += questions[counter - 1] + Environment.NewLine;
                    // display message with student's submition at the incorrect answer log
                    // this.tbxIncorrect.Text += this.questions.ToString();
                    this.tbxIncorrect.Text += "Student: " + text + Environment.NewLine;
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // gets first number and converts it into integer
            String firstNo = tbxFirstNumber.Text;
            int firstNumber = Int32.Parse(firstNo);

            // gets second number and converts it into integer
            String secondNo = tbxSecondNumber.Text;
            int secondNumber = Int32.Parse(secondNo);

            String mathOperator = cbxOperator.SelectedItem.ToString();
            String strQuestion = firstNumber + " " + mathOperator + " " + secondNumber + " = ";

            // validate fields
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

                // declares new Question object
                Question question = new Question(firstNumber, mathOperator, secondNumber, answer);

                // add to questions list
                questions.Add(question);

                // construct byte array to stream in write mode
                byte[] bytesQuestion = Encoding.ASCII.GetBytes(question.QuestionToSend());
                netStream.Write(bytesQuestion, 0, bytesQuestion.Length);

                // Environment.NewLine;
                tbxQuestionsAsked.Text += "Question: " + strQuestion + Environment.NewLine;

                // clear text boxes
                tbxFirstNumber.Text = "";
                tbxSecondNumber.Text = "";

            }

            counter++;

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
    }
}
