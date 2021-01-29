using System;
using System.Collections.Generic;
using Arrays.Tests.Generator.GeneratorTypes;

namespace Arrays.Tests
{
    class Generators<G>
    {
        //private Type dataType;
        public Type DataType { get; private set; } 
        public byte Length { get; private set; }
        public string CollectionType { get; private set; }
        
        // Takes in 
        // byte     length:         Length of an array.
        // Type     dataType:       A random Data Type.
        // string   collectionType  Type of the Collection.
        public Generators(byte Length, Type DataType, string CollectionType = "array" )
        {
            this.DataType = DataType;
            this.Length = Length;
            this.CollectionType = CollectionType;
        }  

        public G Generate()
        {
            Console.Clear();
            Console.WriteLine("Generation Process Starting...");
            Console.WriteLine("Thank You for Choosing Arrays.");
            return ArrayGen<G>.Selector(DataType, Length);


            //Console.WriteLine("Would collection would you like to Generate?");
            //switch ()
            //    typeof(IEnumerable<DataType>).IsAssignableFrom(propertyInfo.PropertyType)

        }

        static void collectionSelector()
        {

        }
    }
}
