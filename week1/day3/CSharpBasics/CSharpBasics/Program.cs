using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // local varibales and types
            int x = 0;
            double y = 4.58; // allows decial - 64 bit float)
            decimal z = 5.001m; // even more precise - for fiannical records etc

            string s = "string";
            bool b = true;
            b = false;

            // base class of *everthing * is object
            object o = true;

            //var (complier type inference) can take anytype string, object once delcated locked in that type

            var xyz = "Hello";
            var b1 = true;
           // xyz = false; // error! no dynamic typing

            // use var when the type is clear to the person reading 

            //control structures
            // loops
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            while (false)
            {
                //loop
            }

            do
            {
                //do while loop

            } while (false);

            // condtional
            if (true)
            {
                // if
            }
            else if (false)
            {

            }
            else
            {
                //else
            }
            List<string> List = new List<string>();
            List.Add("asdf");


            // snippet for each
            foreach(var item in List)
            {
                // snippet: cw
                Console.WriteLine(item);
            }

            //object-oreited
            //  have objects which asssocite data and relatead behavior 
            //to represent "entities"/nounss
            // we create those objects from templates called classes
            //which define a contract for those objects at runtime.

            //part of the .NET ecosystem/platforms

            // strongly typed (more precisely, statatically types)
            // statically typed means, variable are locked to
            // a certain type at compole time and cannot change

            //unified type system
            // "primitives" (types with value semantics instead of reference 
            // semantics) also inherit from object.

            // garbage collection
            // "managed" language (memory is managed for you)
            // the runtine is reapsoble for freeing unused objects  
            // from memory. saves developer time, fewer bugs, some performance
            // penalty.

            // functions are not quite first-class but in practie
            // more less, data + behaavior = object
            // Csharp is somehwat functional, espically with practice wtih 
            // LINQ (one of the best parts of c#)
            // (Langauge - Intergrated QUery Language)

            // asynchronous programming support with TPL (task processing library)
            // parallel programming support
            // information hiding 
        }
    }
}
