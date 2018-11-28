namespace Animals.Library
{
    public interface IAnimal
    {
        // an interace is a contraxt hat a class has to follow
        //specfiying some methods it eeds to have, with their 
        // arguement types and return type.

        // no implementaion possible in interfaces
        // no data either ( but properties are ok)
        // just method names, arguements and return type.

        //(no backing field for auto implementaion)
        //this is just "any Ianimal  class must have a name property"

        string Name { get; set; }

        void MakeSound();

        void GoTo(string location);

        // there is no void type of class. it just means returns nothing

        // every interface member must ahve the same access modifer of the whole interfeace 

    }
}