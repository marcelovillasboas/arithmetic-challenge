﻿using System;
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
        public bool exitStatus = false;
        public const int BYTE_SYZE = 1024;
        public const int PORT_NUMBER = 8888;

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
            tbxQuestionsAsked.Text = "All questions to be displayed here";
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
                this.tbxQuestionsAsked.Text += "Client: " + text + Environment.NewLine;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String firstNumber = tbxFirstNumber.Text;
            String secondNumber = tbxSecondNumber.Text;
            String mathOperator = cbxOperator.SelectedItem.ToString();
            String question = firstNumber + " " + mathOperator + " " + secondNumber + " = ";

            MessageBox.Show(question);
            // validate fields
            if (firstNumber.Length > 0 && secondNumber.Length > 0)
            {
                // construct byte array to stream in write mode
                byte[] bytesQuestion = Encoding.ASCII.GetBytes(question);
                netStream.Write(bytesQuestion, 0, bytesQuestion.Length);
                
                // Environment.NewLine;
                tbxQuestionsAsked.Text += "Question: " + question + Environment.NewLine;

                // clear text boxes
                tbxFirstNumber.Text = "";
                tbxSecondNumber.Text = "";

                int firstInt = Int32.Parse(firstNumber);
                int secondInt = Int32.Parse(secondNumber);
                int result;

                if (mathOperator == "+")
                {
                   result = firstInt + secondInt;
                }
                else if(mathOperator == "-")
                {
                    result = firstInt - secondInt;
                }
                else if (mathOperator == "x")
                {
                    result = firstInt * secondInt;
                }
                else if (mathOperator == "/")
                {
                    result = firstInt / secondInt;
                }
                else
                {
                    result = firstInt + secondInt;
                }

                tbxAnswer.Text = result.ToString();

            }
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
