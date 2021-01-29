using System;
using System.Collections.Generic;
using Arrays.Tests.Generator.GeneratorTypes;

namespace Arrays.Tests
{

    /// <summary>
    /// The Generator Class is used for dynamically creating Collections filled with Dynamic Types.
    /// </summary>
    /// <typeparam name="G"> Generic Type for class, carries on to the *Gen Sub-Classes.</typeparam>
    
    class Generators<G>
    {
        /// <param name="DataType">Generic Field for the DataType of the Collection.</param>
        public G DataType { get; private set; }

        /// <param name="Length">Length of Collection.</param>
        public byte Length { get; private set; }
        
        /// <param name = "CollectionType" > GenericUriParser Field for the Type of Collection.</param>
        public string CollectionType { get; private set; }

        /// <summary>
        /// Generator Class Constructor, takes 
        /// in a generic and populates based
        /// on the Generics Type.
        /// </summary>
        /// <param name="DataType">A random Data Type.</param>
        /// <param name="Length">Length of Collection.</param>
        /// <param name="CollectionType">Type of the Collection.</param>
        public Generators(G DataType, byte Length, string CollectionType = "array" )
        {
            this.DataType = DataType;
            this.Length = Length;
            this.CollectionType = CollectionType;
        }

        /// <summary>
        /// This Generates the Arrays and supplies Data to the given *Gen Class Selector.
        /// </summary>
        /// <returns> Returns Generic Arrays<\T> Eventually will populate other collections.</returns>
        public G[] Generate()
        {
            string choice;
            Console.Clear();
            Console.WriteLine("Generation Process Starting...");
            Console.WriteLine("Thank You for Choosing Arrays.");
            Console.WriteLine("Please Type one of the following Data Types.");
            Console.WriteLine("1.) Int");
            Console.WriteLine("2.) String");
            Console.WriteLine("3.) Bool");

            choice = Console.ReadLine().ToLower();
            while (choice != "int" || choice != "string" || choice != "bool")
            {
                choice = Console.ReadLine().ToLower();
            }

            switch(choice){
                case "int":
                    return ArrayGen<int>.Selector(Length) as G[];
                case "string":
                    return ArrayGen<string>.Selector(Length) as G[];
                case "bool":
                    return ArrayGen<bool>.Selector(Length) as G[];
            }

            throw new InvalidOperationException("You must give a proper choice for the Collection Data Type.");
            //Console.WriteLine("Would collection would you like to Generate?");
            //switch ()
            //    typeof(IEnumerable<DataType>).IsAssignableFrom(propertyInfo.PropertyType)

        }

        //static void collectionSelector()
        //{

        //}
    }
}
