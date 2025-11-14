using System.Security.Cryptography;

namespace Coding_Main.DataStructure.Heap
{
    public class HeapUsingArray
    {
        public int[] heap;

        public int size;

        public HeapUsingArray(int size)
        {
            this.heap = new int[size+1];
            this.size = 0;
        }


        public void InsertIntoHeap(int value)
        {
            if(this.size == (this.heap.Length -1))
            {
                Console.WriteLine("Heap is full");
                return;
            }
            var hi = this.size + 1;
            while(value > heap[hi / 2] && hi >1)
            {
                this.heap[hi] = this.heap[hi/2];
                hi = hi / 2;
            }
            this.heap[hi] = value;
            this.size++;

            object a = 10;
            a = "ee";
            a = 10.345;
        }


        public void DeleteElementFromHeap()
        {
            if (this.size > 0)
            {
               
                this.heap[1] = this.heap[size];
                this.heap[size] = 0;
                var hi = 1;
                var j = hi * 2;

                while (j < this.heap.Length) {
                    if (this.heap[j]< this.heap[j+1])
                        j = j+1;
                    if (this.heap[hi] < this.heap[j])
                    {
                        var temp = this.heap[j];
                        this.heap[hi] = this.heap[j];
                        this.heap[j] = temp;
                        hi = j;
                        j = hi * 2;
                    }
                    else
                        break;
                }

                size--;

            }
            else
                Console.WriteLine("Heap is empty");
        }

    }
}
