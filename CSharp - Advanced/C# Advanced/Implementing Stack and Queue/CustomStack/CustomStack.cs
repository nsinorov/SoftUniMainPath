﻿
namespace CustomStackStructure
{
    public class CustomStack
    {
        private int[] items;
        private const int InitialCapacity = 4;

        public CustomStack()
        {
            items= new int[InitialCapacity];
        }
        public int Count { get; private set; }

        public void Push(int item)
        {
            if(items.Length == Count)
            {
                Resize();
            }

            items[Count] = item;    

            Count++;
        }

        public int Pop()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException("The stack is empty!");
            }

            int removedItem = items[Count - 1];

            Count--;

            return removedItem;
        }

        public int Peek()
        {
            if(Count == 0)
            {
                throw new InvalidOperationException("The stack is empty!");
            }

            return items[Count - 1];
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                int currentItem = items[i];

                action(currentItem);
            }
        }

        private void Resize()
        {
            int[] copy = new int[items.Length * 2];

            for (int i = 0; i < Count; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }
    }
}
