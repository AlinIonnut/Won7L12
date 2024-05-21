using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Won7L12
{
    public class Queue<T>
    {
        private List<T> list;
        private int capacityOfQueue;

        public int Count { get { return list.Count; } }

        public Queue(int capacity)
        {
            if(capacity <= 0)
            {
                throw new ArgumentException("Capacity must be bigger than zero!");
            }

            list = new List<T>();
            capacityOfQueue = capacity;
        }

        public void Enqueue(T item)
        {
            if(list.Count >= capacityOfQueue)
            {
                throw new ArgumentException("Queue is full");
            }

            list.Add(item);
        }

        public T Dequeue()
        {
            if(list.Count == 0)
            {
                throw new ArgumentException("Queue is empty");
            }

            T item = list[0];
            list.RemoveAt(0);
            return item;
        }
    }
}
