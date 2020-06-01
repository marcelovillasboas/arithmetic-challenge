using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace arithmetic_challenge
{
    class BinaryTree<T> where T : IComparable
    {

        private Node<T> root;
        private int count;
        private String traversalString;

        public BinaryTree()
        {
            root = null;
            count = 0;
            traversalString = "";
        }

        public Node<T> GetRoot()
        {
            return root;
        }

        public int getCount()
        {
            return count;
        }

        public int GetHeight(Node<T> root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                int leftSideHeight = GetHeight(root.leftChild);
                int rightSideHeight = GetHeight(root.rightChild);

                if(leftSideHeight > rightSideHeight)
                {
                    return (leftSideHeight + 1);
                }
                else
                {
                    return (rightSideHeight + 1);
                }
            }
        }

        public void Add (T data)
        {
            Node<T> newNode = new Node<T>(data);

            if(root == null)
            {
                root = newNode;
                count++;
            }
            else
            {
                Node<T> current = root;
                Node<T> parent;

                while (true)
                {
                    parent = current;

                    if (data.CompareTo(current.data) == 0)
                    {
                        return;
                    }

                    if (data.CompareTo(current.data) == -1)
                    {
                        current = current.leftChild;
 
                        if(current == null)
                        {
                            parent.leftChild = newNode;
                            count++;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightChild;
                        if(current == null)
                        {
                            parent.rightChild = newNode;
                            count++;
                            return;
                        }
                    }
                }
            }
        }

        public String TraversalString
        {
            get { return this.traversalString; }
            set { this.traversalString = value; }

        }

        public bool Contains (T value)
        {
            return (this.Find(value) != null);
        }

        public Node<T> Find(T value)
        {
            Node<T> nodeToFind = GetRoot();

            while(nodeToFind != null)
            {
                if(value.CompareTo(nodeToFind.data) == 0)
                {
                    return nodeToFind;
                }
                else
                {
                    if (value.CompareTo(nodeToFind) == -1)
                    {
                        nodeToFind = nodeToFind.leftChild;  
                    }
                    else if (value.CompareTo(nodeToFind) == 1)
                    {
                        nodeToFind = nodeToFind.rightChild;
                    }
                }
            }
            
            return null;

        }

        public void PreOrder(Node<T> root)
        {
            if (root != null)
            {
                TraversalString += root.data.ToString() + ", ";
                PreOrder(root.leftChild);
                PreOrder(root.rightChild);
            }
            
        }

        public void PostOrder(Node<T> root)
        {
            if (root != null)
            {
                PostOrder(root.leftChild);
                PostOrder(root.rightChild);
                TraversalString += root.data.ToString() + ", ";
            }

        }

        public void InOrder(Node<T> root)
        {
            if(root != null)
            {
                InOrder(root.leftChild);
                TraversalString += root.data.ToString() + " ";       
                InOrder(root.rightChild);
            }

        }

        public void DisplayBreadthFirst()
        {
            Queue<Node<T>> q = new Queue<Node<T>>();
            q.Enqueue(this.root);

            while(q.Count > 0)
            {
                Node<T> n = q.Dequeue();
                // return n.data + " ";
                if(n.leftChild != null)
                {
                    q.Enqueue(n.leftChild);
                }
                if(n.rightChild != null)
                {
                    q.Enqueue(n.rightChild);
                }
            }
        }

        public void DisplayDepthFirst()
        {
            Stack<Node<T>> s = new Stack<Node<T>>();
            s.Push(this.root);
            while(s.Count > 0)
            {
                Node<T> n = s.Pop();
                // return n.data + " ";
                if(n.leftChild != null)
                {
                    s.Push(n.leftChild);
                }
                if(n.rightChild != null)
                {
                    s.Push(n.rightChild);
                }
            }
        }

        public string getDataString(T data)
        {
            return data.ToString();
        }
    }
}
