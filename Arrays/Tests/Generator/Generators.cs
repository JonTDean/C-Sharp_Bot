using System;
using System.Collections.Generic;
using Arrays.Tests.Generator.GeneratorTypes;

namespace Arrays.Tests
{
    class Generators<G>
    {
        public G dataType {get; private set;}

        public Generators(byte length, string collectionType = "array")
        {

            switch (dataType)
            {
                case "int":
                    Arrays.intArrayGenerator(dataType, length);
                    break;
                case "string":
                    Arrays.stringArrayGenerator(dataType, length);
                    break;
                case "bool":
                    Arrays.boolArrayGenerator(dataType, length);
                    break;
                default:
                    break;
            }
        }
        
       

    }
}
