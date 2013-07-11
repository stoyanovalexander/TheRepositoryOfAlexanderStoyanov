using System;
using System.Collections.Generic;
using System.Linq;

    class LinkedQueue<T>
    {
        QueueItem<T> firstItem;
        QueueItem<T> lastItem;
        int count;

        public int Count
        {
            get
            {
                return count;
            }
        }

        public T Peek()
        {
            return firstItem.Value;
        }

        public void Push(T value)
        {
            if (firstItem == null)
            {
                lastItem = new QueueItem<T>(value);
                firstItem = lastItem;
            }

            else
            {
                lastItem.PreviousItem = new QueueItem<T>(value);
                lastItem = lastItem.PreviousItem;
            }

            count++;
        }

        public T Pop()
        {
            if (firstItem == null)
            {
                throw new InvalidOperationException("Queue is without elements!");
            }
            T valueToReturn = firstItem.Value;
            firstItem = firstItem.PreviousItem;
            count--;
            return valueToReturn;
        }
    }

