﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST1
{
    public class Stack
    {
        Entry top;
        public void push(object data)
        {
            top = new Entry(top,data);
        }
        public object Pop()
        {
            if (top == null) throw new InvalidOperationException();
            object result = top.data;
            top = top.next;
            return result;
        }

        class Entry
        {
            public object data;
            public Entry next;
            public Entry(Entry next,object data)
            {
                this.next = next;
                this.data = data;
            }
        }
    }
}
