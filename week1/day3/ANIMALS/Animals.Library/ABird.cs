namespace Animals.Library
{
    public abstract class ABird : IAnimal
    {
        // abstract class cannot be instantiaed but can rpovide implemetnaion to be shard by sub classes
        public abstract string Name {get;set;}

        public void GoTo(string location)
        {
            System.Console.WriteLine($"Flying to {location}.");
        }
        public abstract void MakeSound();

        }
    
}