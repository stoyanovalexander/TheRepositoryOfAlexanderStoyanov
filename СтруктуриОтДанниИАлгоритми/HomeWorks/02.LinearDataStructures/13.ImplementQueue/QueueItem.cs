using System;
using System.Collections.Generic;
using System.Linq;

    class QueueItem<T>
    {
        public T Value { get; set; }
        public QueueItem<T> PreviousItem { get; set; }

        public QueueItem(T data)
        {
            this.Value = data;
        }
    }

