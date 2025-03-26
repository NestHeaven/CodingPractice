namespace Coding_Main.DataStructure.Stacks
{
    public class StackUsingLinkedList
    {
        private Node? Head { get; set; }

        private Node? Tail { get; set; }

        private int Size { get; set; }

        public StackUsingLinkedList()
        {
            Head = null;
            Tail = null;
            Size = 0;
        }

        public bool IsEmpty()
        {
            return Size == 0;
        }

        public int Length()
        {
            return Size;
        }


        public void push(int element)
        {
            Node neweast = new Node(element, null);

            if (!IsEmpty())
            {
                neweast.Next = Head;
            }

            Head = neweast;
            Size++;
        }

        public void pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Head = Head.Next;
            }
            Size--;
        }

        public void Display()
        {
            if (IsEmpty())
                Console.WriteLine("Stack is Empty");
            else
            {
                var p = Head;

                while (p != null)
                {
                    Console.Write($"{p.Element} ==>");
                    p = p.Next;
                }
                Console.WriteLine();
            }
        }
    }

    public class Node
    {
        public int Element { get; set; }

        public Node? Next { get; set; }

        public Node(int element, Node? next)
        {
            Element = element;
            Next = next;    
        }
    }
}
