namespace Coding_Main.DataStructure.LinkedList
{
    public class DoublyLinkedListMain
    {
        private DoublyLinkedList? Head;
        private DoublyLinkedList? Tail;
        private int Size;

        public DoublyLinkedListMain()
        {
            Head = null;
            Tail = null;
            Size = 0;
        }

        public bool IsEmpty()
        {
            return Size == 0;
        }

        public void InserAtTheEnd(int element)
        {
            DoublyLinkedList newest = new DoublyLinkedList(element, null, null);

            if (IsEmpty())
            {
                Head = newest;
            }
            else
            {
                newest.Previous = Tail;
                Tail.Next = newest; 
            }


            Tail = newest;
            Size++;

        }

        public void TraverseDoublyLinkedList()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty");
                return;
            }
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


        public void TraverseDoublyLinkedListFromTheEnd()
        {
            if (!IsEmpty())
            {

                var p = Tail;

                while (p != null)
                {
                    Console.Write($"{p.Element} ===>");
                    p = p.Previous;
                }
            }

            Console.WriteLine();
        }


        public void InsertElementInTheStarting(int e)
        {
            DoublyLinkedList newest = new DoublyLinkedList(e, null, null);

            if (IsEmpty())
            {
                Head = newest;
                Tail = newest;
            }
            else
            {
                newest.Next = Head;
                Head.Previous = newest;
                Head = newest;
            }
            Size++;
        }

        public void InsertAtParticularPosition(int value, int index)
        {
            DoublyLinkedList newest = new DoublyLinkedList(value, null, null);

            if (index > this.Size-1 || index <0)
            {
                Console.WriteLine("Position is out of bound");
            }
            else
            {

                if (index == 0)
                {
                    newest.Next = Head;
                    Head.Previous = newest;
                    Head = newest;
                }
                else
                {
                    var p = Head;
                    int i = 0;

                    while (i < index - 1)
                    {
                        p = p.Next;
                        i++;
                    }


                    newest.Next = p.Next;
                    newest.Previous = p.Previous;
                    p.Next = newest;
                }
            }

            Size++;
        }


        public void DeleteFromTheBegining()
        {
            if (!IsEmpty()) {

                Head.Next.Previous = null;
                Head = Head.Next;
                Size--;
            }
        }

        public void DeleteFromTheEnding() {
            if (!IsEmpty()) { 
                
                var p = Head;

                while(p.Next.Next != null)
                {
                    p = p.Next;
                }
                p.Next = null;

                Tail = p;

                Size--;

            }
        }

        public void DeleteAtSpecificIndex(int index)
        {
            if(index > this.Size-1 || index < 0)
            {
                Console.WriteLine("Index out of bound");
            }
            else
            {
                if(index == 0)
                {
                    Head.Next.Previous = null;
                    Head = Head.Next;
                }
                else
                {
                    var i = 0;
                    var  p = Head;
                    while (i < index-1)
                    {
                        p = p.Next;
                        i++;
                    }

                    p.Next = p.Next.Next;
                    p.Next.Previous = p;
                }

                Size--;
            }
        }
    }

    public class DoublyLinkedList
    {
        public int Element { get; set; }

        public DoublyLinkedList? Previous { get; set; }
        public DoublyLinkedList? Next { get; set; }


        public DoublyLinkedList(int e, DoublyLinkedList? prev, DoublyLinkedList? next)
        {
            Element = e;
            Previous = prev;
            Next = next;
        }
    }
}

