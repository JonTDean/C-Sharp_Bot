using System;
using System.Collections;
using System.Collections.Generic;
using Arrays.LearnAbout;

namespace Arrays
{

    /* TODO:
     
     *  Goals:
        [ x ] 1. Get an inferred Generic Array going.
                This array should handle all cases of
                any Type and of any Array.
     
        [  ] 2. After getting the Integer Type, it should
                Target the Learn Class.

        [  ] 3. Display a list of actions with Examples
               along with the reasoning behind why
    */

    /*  TODO: 
       
     *  GENERAL:
            [  ] 1. Iterate through Arrays

            [  ] 2. Get index at an Array

            [  ] 3. Display all Indexes

            [  ] 4. Parsing Types

     *  TYPE:
            Int -
                [  ] 1. Sum Indexes

            Strings
                [  ] 1. Concatenate all strings

                [  ] 2. Create a string from Characters
    */

    // Annotation 1*
    public class LearnArrays<T> 
    {
        public T[] GenericArray { get; private set; }

        public LearnArrays(T[] GenericArray)
        {
            this.GenericArray = GenericArray;
        }

        // Type Check the Array.
        public string getType()
        { 
            // Debug -->
            //Console.WriteLine("Array Type is: {0}", CheckParser.TypeCheck(this.GenericArray[0].GetType()));

            return CheckParser.TypeCheck(this.GenericArray[0].GetType());
        }
    }
}


/* Annotations
* 1.   If you're interested in this, Think of this as a Var (it's not one tho).
    https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/

* 2.   Took this from Stack Overflow:
    https://stackoverflow.com/questions/56352299/gettype-return-int-instead-of-system-int32
*
  3.    GetType() with arrays (Works with Generics). 
    https://stackoverflow.com/questions/28624571/how-to-determine-the-type-of-an-generic-array-element-with-reflection
*
  4.    GetElementType of defined arrays.
    https://docs.microsoft.com/en-us/dotnet/api/system.type.getelementtype?redirectedfrom=MSDN&view=net-5.0#System_Type_GetElementType
*
*
*
*
*
*
*
* Reading
* 1. GetType: https://docs.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-5.0
*
*/