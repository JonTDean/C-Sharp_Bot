using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Tests.Generator.GeneratorTypes
{
    // Use lists to create dynamically sized arrays.
    static class ArrayGen<G>
    {
        /// <summary>
        /// 
        /// </summary>
        private static Random rand = new Random();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="DataType"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        static public G[] Selector(G DataType, byte length)
        {
            List<G> arrayToBe = new List<G>();

            return arrayToBe.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrayToBe"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        static public int[] intArrayGenerator(List<int> arrayToBe, byte length)
        {
            for (int i = 0; i < length; i++)
            {
                arrayToBe[i] = rand.Next(1, length);
            }

            return arrayToBe.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrayToBe"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        static public string[] stringArrayGenerator(List<string> arrayToBe, byte length)
        {
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

            for (int i = 0; i < length; i++)
            {
                arrayToBe[i] = stringsList[rand.Next(0, length)]; 
            }

            return arrayToBe.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrayToBe"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        static public bool[] boolArrayGenerator(List<bool> arrayToBe, byte length)
        {
            for(int i = 0; i < length; i++)
            {
                if (rand.Next(1, length) % 2 == 0)
                {
                    arrayToBe[i] = true;
                }
                else
                {
                    arrayToBe[i] = false;
                }
            }

            return arrayToBe.ToArray();
        }
    }
}
