using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal class FixedSizeList<T>
    {
        private T[] items;
        private int count;
        private readonly int capacity;
        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException("capacity must be Bigger than 0");

            this.capacity = capacity;
            items = new T[capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (count >= capacity)
                throw new InvalidOperationException("List Full cant Add More");

            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("index not vailble");

            return items[index];
        }
    }
}

