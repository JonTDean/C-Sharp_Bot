using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class LearnLists<T>
    {
        public T[] GenericLists { get; private set; }

        public LearnLists(T[] GenericLists)
        {
            this.GenericLists = GenericLists;
        }
    }
}
