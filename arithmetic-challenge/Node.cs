using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic_challenge
{
    class Node<T> where T : IComparable
    {
        public T data;

        public Node<T> leftChild;
        public Node<T> rightChild;

        public Node (T data)
        {
            this.data = data;
            rightChild = null;
            leftChild = null;
        }

        public bool Search(Node<T> node, T data)
        {
            if (node == null)
            {
                return false;
            }
            else
            {
                if(node.data.CompareTo(data) > 0)
                {
                    return Search(node.rightChild, data);
                }
                else if (node.data.CompareTo(data) < 0)
                {
                    return Search(node.leftChild, data);
                }
                else
                {
                    return true;
                }
            }
        }

    }
}
