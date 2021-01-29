using System;
using Arrays.Tests;

namespace Arrays
{
    static class Program
    {
        static void Main(string[] args)
        {
            // TODO:
            // Test Variables DELETE AFTER**********
            Generators<int> intGenerator = new Generators<int>(1, 10);
            //Generators<string> stringGenerator = new Generators<string>("a", 10);
            //Generators<bool> boolGenerator = new Generators<bool>(true, 10);

            int[] intArray = intGenerator.Generate();
            //string[] stringArray = stringGenerator.Generate();
            //bool[] boolArray = boolGenerator.Generate();


            foreach (int num in intArray)
            {
                Console.WriteLine($"Integer is : {num}");
            }

            //foreach (string word in stringArray)
            //{
            //    Console.WriteLine($"Integer is : {word}");
            //}

            //foreach (bool truthy in boolArray)
            //{
            //    Console.WriteLine($"Boolean is : {truthy}");
            //}
            //int[] intArray = { 1, 2, 3 };
            //string[] stringArray = { "ae", "be", "ce" };
            //bool[] boolArray = { true, false, true };
            //---------------------------------------

            //LearnArrays<int> learnArrayInt = new LearnArrays<int>(intArray);
            //LearnArrays<string> learnArrayString = new LearnArrays<string>(stringArray);
            //LearnArrays<bool> learnArrayBool = new LearnArrays<bool>(boolArray);


            //learnArrayInt.getType();
            //learnArrayString.getType();
            //learnArrayBool.getType();
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
