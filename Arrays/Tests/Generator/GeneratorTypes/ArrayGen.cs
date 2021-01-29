using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Tests.Generator.GeneratorTypes
{
    // Use lists to create dynamically sized arrays.
    static class ArrayGen<G>
    {
        private static Random rand = new Random();

        static public G Selector(Type dataType, byte length)
        {
            
            List<G> arrayToBe = new List<G>();

            return arrayToBe[0];
        }

        static public int[] intArrayGenerator(List<G> arrayToBe, byte length)
        {
            //List<int> arrayToBe = new List<int>();

            for (int i = 0; i < length; i++)
            {
                arrayToBe.Add(rand.Next(1, length));
            }

            return arrayToBe.ToArray();
        }

        static public string[] stringArrayGenerator(List<G> arrayToBe, byte length)
        {
            //List<string> arrayToBe = new List<string>();
            return arrayToBe.ToArray();
        }

        static public bool[] boolArrayGenerator(List<G> arrayToBe, byte length)
        {

            //List<bool> arrayToBe = new List<bool>();

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
            }

            return arrayToBe.ToArray();
        }
    }lock;kl;k
}
