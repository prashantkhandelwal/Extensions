using System;
using System.Collections.Generic;

namespace Extensions.CustomDataTypes
{

    /// <summary>
    /// Create a Queue with a specified length
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <remarks>As used in https://github.com/ShareX/ShareX</remarks>
    public class FixedSizeQueue<T> : Queue<T>
    {
        public int Size { get; set; }

        public FixedSizeQueue(int size)
        {
            Size = size;
        }

        public new void Enqueue(T obj)
        {
            base.Enqueue(obj);
            while (Count > Size) Dequeue();
        }
    }
}
