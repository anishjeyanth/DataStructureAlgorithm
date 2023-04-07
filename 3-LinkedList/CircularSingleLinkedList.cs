using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class CircularSingleLinkedList
    {
        public Node Head;
        public Node Tail;
        int Size;

        public Node CreateLinkedList(int data)
        {
            Node node = new Node(data);
            Head = node;
            Tail = node;
            Size = 1;

            return Head;
        }

        public void InsertNode(int data, int location = 0)
        {
            Node node = new Node(data);
            if (Head == null)
            {
                CreateLinkedList(100);
            }
            else if(location == 0)
            {
                node.Next = Head;
                Head = node;
                Tail.Next = Head;
            }
            else if(location >= Size)
            {
                Tail.Next = node;
                Tail = node;
                Tail.Next = Head;
            }   
            else
            {
                Node tempNode = Head;
                int index = 0;
                while (index < location -1)
                {
                    tempNode = tempNode.Next;
                    index++;
                }

                node.Next = tempNode.Next;
                tempNode.Next = node;
            }

            Size++;
        }

        public void DeleteNode(int location)
        {
            if(Size == 0)
            {
                Head.Next = null;
                Head = null;
                Tail = null;                
            }
            else if(location == 0)
            {
                Head = Head.Next;
                Tail.Next = Head;
            }
            else if (location >= Size)
            {
                Node tempNode = Head;
                for(int i=0;i < Size -1; i++)
                {
                    tempNode = tempNode.Next;
                }

                tempNode.Next = Head;
                Tail = tempNode;
            }
            else
            {
                Node tempNode = Head;
                for (int i = 0; i < location - 1; i++)
                {
                    tempNode = tempNode.Next;
                }

                tempNode.Next = tempNode.Next.Next;
            }

            Size--;
        }


        public void Traverse()
        {
            Node tempNode = Head;
            do
            {
                Console.Write(tempNode.Value);
                tempNode = tempNode.Next;
                Console.Write("->");
            } while (tempNode != Head);

            Console.WriteLine("");
        }
    }
}
