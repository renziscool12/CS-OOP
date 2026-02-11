namespace Constructors;

class Program
{
    static void Main(string[] args)
    {
        /*constructor is a special method that is used to initialize objects.
        The advantage of a constructor, is that it is called when an object of a class is created.
        It can be used to set initial values for fields*/
        
        Constructor myConstructor = new Constructor(); //Create an object of the class Constructor (This will cal the constructor)
        
        Console.WriteLine(myConstructor.game); //Print the value
    }
}

//CLASS
namespace Constructors;

//Create a class
class Constructor
{
    public string game; //Create a field or attribute

    // Create a class constructor for the Constructor class
    public Constructor()
    {
        game = "Far Cry 4"; //Set the initial value for game
    }
}
