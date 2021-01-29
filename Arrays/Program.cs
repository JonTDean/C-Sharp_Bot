using System;
using Arrays.Tests;

/*  TODO:
 *      Finish up the Generators and focus on API syntax.
 *      See if anyone will help with some random things,
 *      I hope this code isn't too hard to read. I'll 
 *      explain any part that needs to be explained though. 
 */

/*TODO:
 * For the interface I want to switch between 
 
 *      1. CLI Based Configuration
 
 *      2. Discord Bot Configuration
 
 *      3. Exposed API Configuration
 
 */
namespace Arrays
{

    static class Program
    {
        private static string[] configList =
        {
            "cli",
            "discord",
            "exposed",
        };

        static void Main(string[] args)
        {

            foreach (var argument in args) 
            {
                Console.WriteLine(argument);
            }

            
            // TODO:
            // Test Variables DELETE AFTER**********
            //  Generators<int> intArrayGenerator = new Generators<int>(1, 10);
            //  Generators<string> stringArrayGenerator = new Generators<string>("a", 10);
            //  Generators<bool> boolArrayGenerator = new Generators<bool>(true, 10);

            //  int[] intArray = intArrayGenerator.Generate();
            //  string[] stringArray = stringArrayGenerator.Generate();
            //  bool[] boolArray = boolArrayGenerator.Generate();


            //  foreach (int num in intArray)
            //  {
            //      Console.WriteLine($"Integer is : {num}");
            //  }

            //  foreach (string word in stringArray)
            //  {
            //      Console.WriteLine($"Integer is : {word}");
            //  }

            //  foreach (bool truthy in boolArray)
            //  {
            //      Console.WriteLine($"Boolean is : {truthy}");
            //  }

            //  LearnArrays<int> learnArrayInt = new LearnArrays<int>(intArray);
            //  LearnArrays<string> learnArrayString = new LearnArrays<string>(stringArray);
            //  LearnArrays<bool> learnArrayBool = new LearnArrays<bool>(boolArray);


            //  learnArrayInt.getType();
            //  learnArrayString.getType();
            //  learnArrayBool.getType();
        }

        private static void programConfigurationManager(string input)
        {

            while (!Array.Exists(configList, config => config  == input)
            {
                Console.WriteLine("ERROR 102: Please give a proper String choice.");

            }
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
