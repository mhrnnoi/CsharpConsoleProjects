using System;
using System.Collections.Generic;

namespace stack
{
    public class Stack
    {
        public List<object> StackL { get; private set; }

        public Stack()
        {
            StackL = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new Exception();
            }
            StackL.Add(obj);
        }

        public object Pop()
        {
            object last;
            if (StackL == null)
                throw new Exception();
            last = StackL[StackL.Count - 1];
            StackL.RemoveAt(StackL.Count - 1);

            return last;
        }

        public void Clear()
        {
            if (StackL == null)
                throw new Exception();
            StackL.Clear();
        }
    }
}
