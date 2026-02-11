namespace PracticeOOP1;

class Program
{
    static void Main(string[] args)
    {
        Game myGame = new Game();
        //object
        /*An object is created from a class.
         We have already created the class named Game,
         so now we can use this to create objects.*/
        Console.WriteLine(myGame.game);
        Console.WriteLine(myGame.game );
        //prints inside the Game class
    }

//CLASS
namespace PracticeOOP1;

public class Game
{
    public string game = "Far Cry 2";
    //field or attribute
    //A Class is like an object constructor, or a "blueprint" for creating objects.
}
