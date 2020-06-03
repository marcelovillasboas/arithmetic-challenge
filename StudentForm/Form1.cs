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
using System.Text.RegularExpressions;

namespace StudentForm
{
    public partial class StudentForm : Form
    {
        public bool exitStatus = false;
        public const int BYTE_SYZE = 1024;
        public const string HOST_NAME = "localhost";
        public const int PORT_NUMBER = 8888;

        // set up a client connection for TCP network service
        private TcpClient clientSocket;

        // set up data stream object
        private NetworkStream netStream;

        // set up thread to run ReceiveStream() method
        private Thread clientThread = null;

        // set up delegate 
        delegate void SetTextCallback(string text);

        public StudentForm()
        {
            InitializeComponent();

            StartClient();

        }

        private void StartClient()
        {
            try
            {
                // create TCPClient object (as the socket)
                clientSocket = new TcpClient(HOST_NAME, PORT_NUMBER);

                // create stream
                netStream = clientSocket.GetStream();

                // set up thread to run ReceiveStream() method
                clientThread = new Thread(ReceiveStream);

                // start thread
                clientThread.Start();
                lblConnectionStatus.Text = "Client started..." + Environment.NewLine;
            }
            catch (Exception e)
            {
                // display exception message
                lblConnectionStatus.Text = e.StackTrace;
            }
        }

        public void ReceiveStream()
        {
            byte[] bytesReceived = new byte[BYTE_SYZE];
            // loop to read any incoming messages
            while (!exitStatus)
            {
                try
                {
                    int bytesRead = netStream.Read(bytesReceived, 0, bytesReceived.Length);
                    this.SetText(Encoding.ASCII.GetString(bytesReceived, 0, bytesRead));
                }
                catch (System.IO.IOException)
                {
                    Console.WriteLine("Server has exited!");
                    exitStatus = true;
                }
            }
        }

        private void SetText(string text)
        {
            // InvokeRequired compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // if these threads are different, it returns true.
            if (this.lblConnectionStatus.InvokeRequired)
            {
                // d is a Delegate reference to the SetText() method
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.tbxQuestion.Text += text;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string question = tbxQuestion.Text;
            string[] questionElements = question.Split(' ');

            string firstNumber = questionElements[0];
            string secondNumber = questionElements[2];
            string mathOp = questionElements[1];
            int correctAnswer;
            int studentAnswer;
            lblConnectionStatus.Text += Environment.NewLine + firstNumber + mathOp + secondNumber;

            try
            {
                // convert string into int
                studentAnswer = Int32.Parse(tbxAnswer.Text);

                // send answer typed in the textbox
                if (tbxAnswer.Text.Length > 0 && Regex.IsMatch(tbxAnswer.Text, @"^\d+$"))
                {
                    // construct byte array to stream in write mode
                    String answer = tbxAnswer.Text;
                    byte[] bytesToSend = Encoding.ASCII.GetBytes(answer);
                    netStream.Write(bytesToSend, 0, bytesToSend.Length);

                    tbxAnswer.Text = "";
                    tbxQuestion.Text = "";

                    lblConnectionStatus.Text = "Answer sent!" + Environment.NewLine;
                }
                else
                {
                    MessageBox.Show("Data not sent. Enter a valid answer.");
                    tbxAnswer.Text = "";
                }

                try
                {
                    int firstNo = Int32.Parse(firstNumber);
                    int secondNo = Int32.Parse(secondNumber);

                    if (mathOp == "+")
                    {
                        correctAnswer = firstNo + secondNo;
                        if (studentAnswer == correctAnswer)
                        {
                            MessageBox.Show("Correct answer");
                        }
                        else
                        {
                            MessageBox.Show("Incorrect answer");
                        }
                    }
                    else if (mathOp == "-")
                    {
                        correctAnswer = firstNo - secondNo;
                        if (studentAnswer == correctAnswer)
                        {
                            MessageBox.Show("Correct answer");
                        }
                        else
                        {
                            MessageBox.Show("Incorrect answer");
                        }
                    }
                    else if (mathOp == "*")
                    {
                        correctAnswer = firstNo * secondNo;
                        if (studentAnswer == correctAnswer)
                        {
                            MessageBox.Show("Correct answer");
                        }
                        else
                        {
                            MessageBox.Show("Incorrect answer");
                        }
                    }
                    else if (mathOp == "/")
                    {
                        correctAnswer = firstNo / secondNo;
                        if (studentAnswer == correctAnswer)
                        {
                            MessageBox.Show("Correct answer");
                        }
                        else
                        {
                            MessageBox.Show("Incorrect answer");
                        }
                    }
                                        
                }
                catch(Exception exc)
                {
                    MessageBox.Show("Error parsing question.");
                }

            }
            catch (Exception ex)
            {
                
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
