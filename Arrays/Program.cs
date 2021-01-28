using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3 };
            string[] stringArray = { "ae", "be", "ce" };
            bool[] boolArray = { true, false, true };

            LearnArrays<int> learnArrayInt = new LearnArrays<int>(intArray);
            LearnArrays<string> learnArrayString = new LearnArrays<string>(stringArray);
            LearnArrays<bool> learnArrayBool = new LearnArrays<bool>(boolArray);


            learnArrayInt.getType();
            learnArrayString.getType();
            learnArrayBool.getType();
        }
    }
}
