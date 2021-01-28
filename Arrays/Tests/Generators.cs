using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Tests
{
    class Generators
    {
        public Generators(string type)
        {
            switch (type)
            {
                case "int":

                    break;
                case "string":

                    break;
                case "bool":
                    break;

                default:
                    break;
            }
        }

        private int[] intArrayGenerator()
        {
            return new int[] { };
        }

        private string[] stringArrayGenerator()
        {
            return new string[] { };
        }

        private bool[] boolArrayGenerator()
        {
            return new bool[] { };
        }
    }
}
