namespace Coding_Main.DataStructure.Queue
{
    public class QueueUsingLinkedList<T>
    {
        public Node<T>? Head;
        public Node<T>? Tail;
        public int Size;

        public QueueUsingLinkedList()
        {
            Head = null;
            Tail = null;
            Size = 0;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public void Enqueue(T value)
        {
            Node<T> newest = new Node<T>(value, null); 
            if (IsEmpty())
            {
                Head = newest;
            }
            else{
                Tail.Next = newest;
            }

            Tail = newest;
            Size++;
        }

        public void Dequeue()
        {
            if (!IsEmpty())
            {
                if(Size == 1)
                {
                    Head = null;
                    Tail = null;
                }
                else
                {
                    Head = Head.Next;
                }
                Size--;
            }
        }
    }

    public class Node<T>
    {
        public T Elemennt;
        public Node<T>? Next;

        public Node(T elemennt, Node<T>? next)
        {
            this.Elemennt = elemennt;
            this.Next = next;
        }
    }
}
