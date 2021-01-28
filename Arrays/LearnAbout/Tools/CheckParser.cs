using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.LearnAbout
{
    static class CheckParser
    {

        public static string TypeCheck(Type type) // Parameter is literally a "Type"
        {
            // This allows for Dynamic type checking
            // Point of this is to pair with 
            // the <T>[].GetType()
            Dictionary<Type, string> TypeAlias = new Dictionary<Type, string>
            {
                { typeof(bool), "bool" },
                { typeof(byte), "byte" },
                { typeof(char), "char" },
                { typeof(decimal), "decimal" },
                { typeof(double), "double" },
                { typeof(float), "float" },
                { typeof(int), "int" },
                { typeof(long), "long" },
                { typeof(object), "object" },
                { typeof(sbyte), "sbyte" },
                { typeof(short), "short" },
                { typeof(string), "string" },
                { typeof(uint), "uint" },
                { typeof(ulong), "ulong" },
                { typeof(void), "void" }
            };

            return setTypeCheck(type, TypeAlias);
        }

        // Checks from the Type Dictionary at Line 16
        private static string setTypeCheck(Type type, Dictionary<Type, string> TypeAlias)
        {
            // Debug -->
            //Console.WriteLine($"Get Type Is: {type}");

            // Lookup alias for type
            if (TypeAlias.TryGetValue(type, out string alias))
            {
                return alias;   // Prints out converted Type definition from Dictionary.
            }

            // Default to CLR type name if Type not found in the List
            return type.Name;
        }
           
        // TODO:
        //    1. CREATE METHOD HERE TO DETERMINE IF IS COLLECTION
        //       IF IS COLLECTION THEN PARSE COLLECTION TYPE
        // 
        //    2. Grab the first item in the collection and return that
        //       Items Type. ARRAY[0].GetType()
        //
        // Handle ->
        // 1. Arrays
        // 2. Lists
        // 3. Dict
    }
}
