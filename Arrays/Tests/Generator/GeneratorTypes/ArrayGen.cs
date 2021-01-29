using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Tests.Generator.GeneratorTypes
{
    // Use lists to create dynamically sized arrays.
    static class ArrayGen<G>
    {   
        // Random Number Generator
        // Notes about this is the issuance of
        // the random number generator with
        // types that are of variance; int, bool
        // and string in this instance.
        private static Random rand = new Random();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="DataType"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        static public G[] Selector(byte length)
        {
            List<G> arrayToBe = new List<G>();

            if (typeof(G) == typeof(int))
            {
                return intArrayGenerator(length);
            }else if (typeof(G) == typeof(string))
            {
                return stringArrayGenerator(length);
            }else if (typeof(G) == typeof(bool))
            {
                return boolArrayGenerator(length);
            }

            return arrayToBe.ToArray();
        }

        /// <summary>
        /// Generates an array of Integers with a dynamic array size
        /// and randomly generated values.
        /// </summary>
        /// <param name="length">Array Length</param>
        /// <returns>Internal array is returned as Generic <\G> Array</returns>
        public static G[] intArrayGenerator(byte length)
        {
            List<int> arrayToBe = new List<int>();

            Console.WriteLine("Integer Array Generator Debugger: ");
            for (int i = 0; i < length; i++)
            {
                arrayToBe.Add(rand.Next(1, length * length));   
                Console.WriteLine($"Value at index {i} is: {arrayToBe[i]}");
            }

            return arrayToBe.ToArray() as G[];
        }

        /// <summary>
        /// Generates an Array of curated words randomly chosen to populate
        /// The dynamic length of the entire array.
        /// </summary>
        /// <param name="length">Array Length</param>
        /// <returns>Internal array is returned as Generic <\G> Array</returns>
        static public G[] stringArrayGenerator(byte length)
        {
            List<string> arrayToBe = new List<string>();
            List<string> stringsList = new List<string>(){
                "alfa",
                "bravo",
                "charlie",
                "delta",
                "echo",
                "foxtrot",
                "golf",
                "hotel",
                "india",
                "juliett",
                "kilo",
                "lima",
                "mike",
                "november",
                "oscar",
                "papa",
                "quebec",
                "romeo",
                "sierra",
                "tango",
                "uniform",
                "victor",
                "whiskey",
                "xray",
                "yankee",
                "zulu",
            };

            Console.WriteLine("String Array Generator Debugger: ");
            for (int i = 0; i < length; i++)
            {
                arrayToBe.Add(stringsList[rand.Next(0, length)]);
                Console.WriteLine($"Value at index {i} is: {arrayToBe[i]}");
            }

            return arrayToBe.ToArray() as G[];
        }

        /// <summary>
        /// Generates an array of Booleans based on a Numbers being even or odd.
        /// </summary>
        /// <param name="length">Array Length</param>
        /// <returns>Internal array is returned as Generic <\G> Array</returns>
        static public G[] boolArrayGenerator(byte length)
        {
            List<bool> arrayToBe = new List<bool>();

            Console.WriteLine("Boolean Array Generator Debugger: ");
            for (int i = 0; i < length; i++) 
            {
                if (rand.Next(1, length) % 2 == 0)
                {
                    arrayToBe.Add(true);
                }
                else
                {
                    arrayToBe.Add(false);
                }

                Console.WriteLine($"Value at index {i} is: {arrayToBe[i]}");
            }

            return arrayToBe.ToArray() as G[];
        }
    }
}
