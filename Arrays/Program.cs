using System;

namespace Arrays
{
    class Program<T>
    {
        private T currentType { get; set; }

        static void Main(string[] args)
        {
            // TODO:
            // Test Variables DELETE AFTER**********

            int[] intArray = { 1, 2, 3 };
            string[] stringArray = { "ae", "be", "ce" };
            bool[] boolArray = { true, false, true };
            //---------------------------------------

            LearnArrays<int> learnArrayInt = new LearnArrays<int>(intArray);
            LearnArrays<string> learnArrayString = new LearnArrays<string>(stringArray);
            LearnArrays<bool> learnArrayBool = new LearnArrays<bool>(boolArray);


            learnArrayInt.getType();
            learnArrayString.getType();
            learnArrayBool.getType();
        }



        // When the Bot Gets a request
        // Decide Programmatically how to
        // handle and Parse the incoming UserSelection
        //static T TypeSwitcher(Type userSelection)
        //{
        //    switch()
        //}
    }
}
