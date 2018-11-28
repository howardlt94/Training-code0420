using System;
using Animals.Library;


namespace Animals.UI
{
    class Program
    {
        // your entry point needs ta statc void main(string[args]) method
        // and that is where the execution starts

        // "prrogram.cs" and program class name are jsut convengtions.

        // naming conventions in c# - pascalcase aka TitleCase for
        // classes, methods, properties, namespace
        // camelCase (first letter lowercase) for local variables.

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Bark();

            dog.SetWeight(6);
            Console.WriteLine(dog.GetWeight());

            dog.Name = "Fido";
            Console.WriteLine(dog.Name);

            dog.Breed = "Golden Retreiver";

            dog.GoTo("the Park");


            Console.WriteLine("Hello World");

            //
             IAnimal animal = new Dog();
             animal = new Eagle();
             // this is okay beaucse both animals are under the Ianimal type.
             // but you are not allowed to d dog specfic or eagle specfic things 
             // via this varanle
             // error : animal.Fly();
             Eagle e = (Eagle) animal;
             // you can castr objects to more spefci types 
             //it will fail at runtime if objects is not actaully within/under that type

             //these terms are intercahngeable :
             // superclass,  base class, parent class
             // subclass, derived class, child class

             // good design (seperation of concerns)
             // means you shouldnt write code needlessly tied to one implementation
             DisplayData(new Dog());
             DisplayData(new Eagle());
        }
        public static void DisplayData(IAnimal animal)
        {
            Console.WriteLine(animal.Name); 
            // you can use the same code with multiple impleemtiations of classes your using 
        }
    }
}
