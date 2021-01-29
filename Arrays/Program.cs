using Arrays.Interfaces.CLI;
using System;


/*  TODO:
 *      Finish up the Generators and focus on API syntax.
 *      See if anyone will help with some random things,
 *      I hope this code isn't too hard to read. I'll 
 *      explain any part that needs to be explained though. 
 */

/*TODO:
 * For the interface I want to switch between 
 
 *      1. CLI Based Configuration
            I. De-Abstract from the other classes.
                your menu configurations shouldn't be
                housing shit that has to deal with 
                userInput, leave that to the Interface Classes.

            II. Abstract the CLI Interface and make sure it 
                can handle exceptions for users and Generics
                for dev work.

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
            "1",
            "2",
            "3",
        };

        static void Main(string[] args)
        {
            programConfigurationManager(args[0]);
        }

        private static void programConfigurationManager(string input)
        {

            while (!Array.Exists(configList, config => config == input.ToLower()))
            {
                Console.WriteLine("ERROR 101: Please give a proper Configuration.");
                Console.WriteLine("1.) CLI");
                Console.WriteLine("2.) Discord");
                Console.WriteLine("3.) Exposed");
                input = Console.ReadLine();
            }

            if (input == configList[0] || input == configList[3])
            {
                // Call on CLI Entry Point Here.
                TeachCli.EntryPoint();
            } else if (input == configList[1] || input == configList[4])
            {
                // Call on Discord Entry Point Here.
                throw new NotImplementedException(
                    "Need to implement the Entry Point for the Discord Bot"
                );

            } else if (input == configList[2] || input == configList[5])
            {
                // Call on Exposed API Entry Point Here.
                throw new NotImplementedException(
                    "Need to implement the Entry Point for the Exposed API"
                );
            }
        }
    }
}


// // // // ABSTRACT THIS NONSENSE ASAP MOFOCA
// TODO:
// Test Variables DELETE AFTER**********
// // THROW THESE IN THE INTERFACE CLASSES AFTER----

//  Generators<int> intArrayGenerator = new Generators<int>(1, 10);

//  Generators<string> stringArrayGenerator = new Generators<string>("a", 10);

//  Generators<bool> boolArrayGenerator = new Generators<bool>(true, 10);

//  int[] intArray = intArrayGenerator.Generate();
//  string[] stringArray = stringArrayGenerator.Generate();
//  bool[] boolArray = boolArrayGenerator.Generate();
//----------------------------------------------------

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