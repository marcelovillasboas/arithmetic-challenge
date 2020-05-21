using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace arithmetic_challenge
{
    class DoublyLinkedList : IDisposable
    {
        Node start;
        Node end;

        public DoublyLinkedList()
        {
            start = end = null;
        }

        public void insertToList(string value)
        {
            Node newNode = new Node(value);
            if (start == null)
            {
                start = end = newNode;
            }
            else if (start.Right == null)
            {
                start.Right = newNode;
                newNode.Left = end;
                end = newNode;
            }
            else
            {
                end.Right = newNode;
                newNode.Left = end;
                end = newNode;
            }
        }

        //reads list from start
        public List<string> readFromStart()
        {
            List<string> contents = new List<string>();
            Node temp = start;

            while(temp != null)
            {
                contents.Add(temp.Data);
                temp = temp.Right;
            }

            return contents;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        /*public void traverseFront(Node node)
        {
            if (node == null)
            {
                node = this;
            }
            while(node != null)
            {
                node.Data;
                node = node.Right;
            }
        }*/
    }

    public class Node : IDisposable
    {
        private string data;
        private Node left;
        private Node right;

        public Node(string value)
        {
            this.data = value;
            this.left = null;
            this.right = null;
        }

        public Node Left
        {
            get { return this.left; }
            set { this.left = value; }
        }

        public Node Right
        {
            get { return this.right; }
            set { this.right = value; }
        }

        public string Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
