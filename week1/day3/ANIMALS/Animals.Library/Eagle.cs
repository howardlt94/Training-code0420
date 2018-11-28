namespace Animals.Library
{
    public class Eagle : ABird 
    {
        public override string Name { get;set;}
        public override void MakeSound()
        {
            System.Console.WriteLine(" CAAWWA");
        }
        public void Fly()
        {
            System.Console.WriteLine("flying .......");
        }
    }
}