namespace ClassMembers;

class Program
{
    static void Main(string[] args)
    {
        Members game = new Members(); //object

        game.sale = "Pesos";
        //modified the empty field here
        
        /*output*/
        Console.WriteLine($"The game {game.game} is awesome! I bought it for {game.cost} {game.sale}!");
        game.Comment();

        //multiple object in one class
        Members costNow = new Members();
        costNow.sale = "Pesos";
        Console.WriteLine($"Now the game costs 600 {costNow.sale}.");
    }
}

//CLASS
namespace ClassMembers;

public class Members
{
    //all of these are class Members
    public string game = "Far Cry 4"; //field or attribute
    public string sale; //field or attribute or a blank field and modify them in  main
    public int cost = 152; //field or attribute

    public void Comment() // method
    {
        Console.WriteLine("I played this game and It's really great game!");
    }
}
