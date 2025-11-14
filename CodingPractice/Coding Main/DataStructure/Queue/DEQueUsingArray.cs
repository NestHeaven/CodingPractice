using System;

public class Deque
{
    private int[] arr;
    private int front;
    private int rear;
    private int size;
    private int capacity;

    public Deque(int capacity)
    {
        this.capacity = capacity;
        arr = new int[capacity];
        front = 0;
        rear = 0;
        size = 0;
    }

    // Add to the front of the deque
    public void AddFront(int value)
    {
        if (size == capacity)
        {
            Console.WriteLine("Deque is full");
            return;
        }

        front = (front - 1 + capacity) % capacity; // Move front backwards
        arr[front] = value;
        size++;
    }

    // Add to the rear of the deque
    public void AddRear(int value)
    {
        if (size == capacity)
        {
            Console.WriteLine("Deque is full");
            return;
        }

        arr[rear] = value;
        rear = (rear + 1) % capacity; // Move rear forwards
        size++;
    }

    // Remove from the front of the deque
    public int RemoveFront()
    {
        if (size == 0)
        {
            Console.WriteLine("Deque is empty");
            return -1; // or throw an exception
        }

        int removedValue = arr[front];
        front = (front + 1) % capacity; // Move front forwards
        size--;
        return removedValue;
    }

    // Remove from the rear of the deque
    public int RemoveRear()
    {
        if (size == 0)
        {
            Console.WriteLine("Deque is empty");
            return -1; // or throw an exception
        }

        rear = (rear - 1 + capacity) % capacity; // Move rear backwards
        int removedValue = arr[rear];
        size--;
        return removedValue;
    }

    // Peek the front of the deque
    public int PeekFront()
    {
        if (size == 0)
        {
            Console.WriteLine("Deque is empty");
            return -1; // or throw an exception
        }

        return arr[front];
    }

    // Peek the rear of the deque
    public int PeekRear()
    {
        if (size == 0)
        {
            Console.WriteLine("Deque is empty");
            return -1; // or throw an exception
        }

        // Note: rear points to the next empty position, so we need to subtract 1
        return arr[(rear - 1 + capacity) % capacity];
    }

    // Check if the deque is empty
    public bool IsEmpty()
    {
        return size == 0;
    }

    // Check if the deque is full
    public bool IsFull()
    {
        return size == capacity;
    }

    // Get the current size of the deque
    public int Size()
    {
        return size;
    }
}

partial class Program
{
    static void Main()
    {
        Deque deque = new Deque(5);

        // Adding elements to the rear
        deque.AddRear(10);
        deque.AddRear(20);
        deque.AddRear(30);
        deque.AddRear(40);

        // Adding elements to the front
        deque.AddFront(5);
        deque.AddFront(0);

        Console.WriteLine("Front of the deque: " + deque.PeekFront());  // Should print 0
        Console.WriteLine("Rear of the deque: " + deque.PeekRear());  // Should print 40

        // Removing elements from the front
        Console.WriteLine("Removed from front: " + deque.RemoveFront());  // Should print 0
        Console.WriteLine("Removed from front: " + deque.RemoveFront());  // Should print 5

        // Removing elements from the rear
        Console.WriteLine("Removed from rear: " + deque.RemoveRear());  // Should print 40
        Console.WriteLine("Removed from rear: " + deque.RemoveRear());  // Should print 30

        // Final size and state
        Console.WriteLine("Size of deque: " + deque.Size());  // Should print 2 (only 10 and 20 are left)
    }
}
