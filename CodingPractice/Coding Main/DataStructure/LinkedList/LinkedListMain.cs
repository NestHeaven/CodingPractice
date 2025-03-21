namespace Coding_Main.DataStructure.LinkedList
{
    public class LinkedListMain
    {

        private Node? head;
        private Node? tail;
        private int size;

        public LinkedListMain()
        {
            head = null;
            tail = null;
            size = 0;

        }

        public int Size()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void AddNodeToLast(int value)
        {
            Node node = new Node(value, null);

            if (IsEmpty())
            {
                Console.WriteLine($"Linked List is Empty Creating a new List with element {value}");
                head = node;
            }
            else
            {
                Console.WriteLine($"Adding new node {value} to end");
                tail.Next = node;
            }

            tail = node;
            size++;

            TraverseLinkedList();
        }

        public void TraverseLinkedList()
        {
            Console.WriteLine();

            Console.WriteLine("Now Linklist looks like");

            Console.WriteLine();

            if (head != null)
            {

                var p = head;

                while (p != null)
                {
                    Console.Write(p.Element + "--->");
                    p = p.Next;
                }
                Console.Write("null");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        public void InsertElementAtTheBegining(int value)
        {
            Console.WriteLine($"Inserting a new Node {value} at begining");

            if (head != null)
            {
                Node newNode = new Node(value, head);
                head = newNode;

                size++;

                TraverseLinkedList();
            }
            else
            {
                AddNodeToLast(value);
            }
        }

        public void InsertElementAtSpecificPosition(int value, int index)
        {
            Console.WriteLine($"Inserting element {value} at {index} position");
            if (!IsEmpty() && (index <= size) && index > 0)
            {

                int size = 1;
                var p = head;
                while (size < index - 1)
                {
                    p = p.Next;
                    size++;

                }
                p.Next = new Node(value, p.Next);
                this.size++;
            }

            TraverseLinkedList();
        }


        public void RemoveFirstElementFromLinkedList()
        {
            Console.WriteLine("Removing first Element from the Linked List");
            if (!IsEmpty())
            {

                head = head.Next;
                size--;
            }

            if (IsEmpty())
            {
                tail = null;
            }

            TraverseLinkedList();
        }

        public void RemoveLastElementFromTheLinkedList()
        {

            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return;
            }
            Console.WriteLine("Deleted Node from the end");
            var p = head;

            int index = 1;
            while(index < size)
            {
                p = p.Next;
                index++;
            }

            p.Next = null;
            tail = p;
            size--;

            TraverseLinkedList();
        }


        public void DeleteAtSpecificLocation(int index)
        {

            if (IsEmpty() || index > size)
            {
                Console.WriteLine("Either List is Empty or Index is greater");
                return;

            }

            Console.WriteLine($"Deleting element at position {index}");
            int i = 1;
            var p = head;

            if (i + 1 < index)
            {
                p = p.Next;
                i++;
            }

            if (i == 1)
            {
                head = p.Next;
            }
            else
            {
                p.Next = p.Next.Next;
            }

            size--;

            TraverseLinkedList();
        }
    }

    public class Node
    {
        public int Element { get; set; }

        public Node? Next { get; set; }


        public Node(int e, Node? reference)
        {
            Element = e;
            Next = reference;
        }
    }

}
