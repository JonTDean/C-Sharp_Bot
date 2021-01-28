using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class LearnDictionaries<T, X>
    {
        public Dictionary<T, X> GenericDictionary { get; private set; }
       
        public LearnDictionaries(T[] GenericArray)
        {
            this.GenericDictionary = GenericDictionary;
        }
    }
}
