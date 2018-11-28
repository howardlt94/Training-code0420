using System;

namespace Animals.Library
{
    public class Dog : IAnimal
    {
        //fields

        public string Name { get; set;}

        private string _breed;

        public string Breed 
        {
            get { return _breed; }
            set
            {
                if (value != null && value != "")
                {
                    _breed = value;
                }
            }
        }

        private int _age;
        public int Age 
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                //keyword "value in a setter 
            }
            
            

        }

        private int Weight;

        // classic gettesr and setters

        public int GetWeight()
        {
            return Weight;
        }

        public void SetWeight(int weight)
        {
            Weight = weight;
        }

        public void Bark()
        {
            Console.WriteLine("Woof");
        }

        public void MakeSound()
        {
            Bark();
        }

        public void GoTo(string location)
        {
            // string implementaion syntax
            // prefix with $
            //inside {} you should give an expression 
            // etiher string or any other objects that Tostring will be called on 
        
            string output = $"Walking to {location.ToLower()}.";
            // output = "walking to " + location .Tostring() + ".";
            // above is shortcut to this

            Console.WriteLine(output);
        }
        // snippets: prop, propfull
    }
}
