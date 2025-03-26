using System.Runtime.ConstrainedExecution;

namespace Coding_Main.DataStructure.Queue
{
    class QueueUsingArray
    {
        public int[] Data;
        public int top;
        public int rear;
        public int Size;

        public QueueUsingArray(int size)
        {
            this.Data = new int[size];
            this.top = 0;
            this.rear = 0;
            this.Size = 0;
        }


        public bool IsEmpty()
        {
            return this.Size == 0;
        }

        public bool IsFull()
        {
            return this.Size == Data.Length;
        }

        public void Enqueue(int value)
        {
            if (this.IsFull()) {
                Console.WriteLine("Queue is full");
                return;
            }
            else
            {
                this.Data[this.rear] = value;
                this.rear++;
                this.Size++;
            }
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                var e = this.Data[this.top];
                top = (this.top+1) % this.Data.Length;
                rear = (this.rear +1) % this.Data.Length;
                this.Size--;
            }
        }

        public int FetchFirst()
        {
            if (!IsEmpty())
            {
                Console.WriteLine(this.Data[this.top]);
                return this.Data[this.top];
            }
            return -1;
        }

    }

}
