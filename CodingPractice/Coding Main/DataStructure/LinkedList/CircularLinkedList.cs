using System.Globalization;

namespace Coding_Main.DataStructure.LinkedList
{
    public class CircularLinkedList
    {
        private Node? Head;
        private Node? Tail;
        private int Size;

        public CircularLinkedList()
        {
            Head = null;
            Tail = null;
            Size = 0;
        }

        
        public bool IsEmpty()
        {
            return Size == 0;
        }


        public void InsertElementAtTheEnd(int value)
        {
            Node newest = new Node(value, null);

            if (IsEmpty()) { 
                Head = newest;
            }
            else
            {
                Tail.Next = newest;
            }

            Tail = newest;
            Tail.Next = Head;

            Size++;
        }

        public void TraverseCircularLinkedList()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty");
                return;
            }

            var p = Head;

            do
            {
                Console.Write($"{p.Element}");
                p = p.Next;
            }
            while (p != Head);

        }
        public void TraverseCircularLinkedListBySize()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty");
                return;
            }

            var p = Head;
            int i = 0;

            while (i < Size)
            {
                Console.Write($"{p.Element} --->");
                p = p.Next;
                i++;
            }
        }
    }
}
