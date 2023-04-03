using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class SingleLinkedList
    {
        public Node Head;
        public Node Tail;
        public int Size;

        public Node CreateLinkedList(int nodeValue)
        {
            Head = new Node();
            
            Node node = new Node(nodeValue);

            Head = node;
            Tail = node;
            Size = 1;

            return Head;
        }

        public void InserNode(int nodeValue, int location = 0)
        {
            Node node = new Node(nodeValue);

            if (Head == null)
            {
                CreateLinkedList(100);
                return;
            } 
            else if(location == 0)
            {
                node.Next = Head;
                Head = node;
            }
            else if(location >= Size)
            {
                Tail.Next = node;
                Tail = node;
            }
            else
            {
                Node tempNode = Head;
                int index = 0;
                while(index < location - 1)
                {
                    tempNode = tempNode.Next;
                    index++;
                }

                Node nextNode = tempNode.Next;
                tempNode.Next = node;
                node.Next = nextNode;                
            }

            Size++;
        }

        public void Travesrse()
        {
            if(Head != null)
            {
                Node tempNode = Head;
                int index = 0;  
                //while(index < Size)
                while(tempNode.Next != null)
                {
                    Console.Write(tempNode.Value);                    
                    if(index != Size)
                    {
                        Console.Write("->");
                    }
                    tempNode = tempNode.Next;

                    index++;
                }
            }
        }
    }
}

